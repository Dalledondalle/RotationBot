buffs = {}
debuffs = {}
DoAoe = false
StopCast = true

CF = function(r,g,b)  
    local f = _G["RBF"]
    local t = _G["RBFT"]    
    
    if f == nil then
        f = CreateFrame("Frame","RBF",UIParent)  
        t = f:CreateTexture("RBFT","BACKGROUND")      
    end    
    
    f:SetFrameStrata("BACKGROUND")
    f:SetWidth(32) -- Set these to whatever height/width is needed 
    f:SetHeight(32) -- for your Texture
    
    t:SetTexture("Interface\\AddOns\\WeakAuras\\Media\\Textures\\Square_FullWhite.tga", false)
    t:SetAllPoints(f)
    t:SetVertexColor(r,g,b);
    f.texture = t 
    
    f.texture:SetVertexColor(r,g,b)
    
    
    f:SetPoint("TOPLEFT",400,-250)
    f:Show()
end



GetBuffs = function()
    buffs = {}
    local i = 1
    local buff = UnitBuff("player", i);
    while buff do
        buffs[#buffs + 1] = buff;
        i = i + 1;
        buff = UnitBuff("player", i);
    end;
    if #buffs < 1 then
        return nil
    else
        return buffs
    end
end

GetDebuffsTarget = function()
    debuffs = {}
    local i = 1;
    local debuff, _, _, _, _, expirationTime, caster = UnitDebuff("target", i);
    while debuff do
        if caster == "player" then
            debuffs[#debuffs + 1] = debuff;
        end
        i = i + 1;
        debuff = UnitDebuff("target", i);       
    end
    if #debuffs < 1 then
        return nil
    else
        return debuffs
    end    
end

HasBuff = function(buff)
    if buffs == nil then
        return nil
    end
    for key, value in ipairs(buffs) do 
        if string.lower(value) == string.lower(buff) then            
            return true
        end
    end
    return nil
end

HasDebuff = function(debuff)
    local debuffs = GetDebuffsTarget()
    if debuffs == nil then
        return nil
    end
    for key, value in ipairs(debuffs) do 
        if string.lower(value) == string.lower(debuff) then            
            return true
        end
    end
    return nil
end

TimeLeftOnDebuff = function(debuffToFind)
    local i = 1;
    local debuff, _, _, _, _, expirationTime, caster = UnitDebuff("target", i);
    while debuff do
        if caster == "player" and string.lower(debuff) == string.lower(debuffToFind) then
            return expirationTime - GetTime()
        end
        i = i + 1;
        debuff, _, _, _, _, expirationTime, caster = UnitDebuff("target", i);       
    end
end

SwitchDoAoe = function(self, key)
    if key == "DELETE" then    
        DoAoe =  not DoAoe
    end
    if key == "CAPSLOCK" then    
        StopCast =  not StopCast
    end
end



IsEclipsed = function()
    if HasBuff("eclipse (solar)") == true or HasBuff("eclipse (lunar)") == true then
        return true
    end
    return false
end


IsConvoking = function()
    if HasBuff("Convoke the spirits") == true then 
        return true
    end
    return false
end


DoNothing = function()
    CF(0,0,0)
    return "Do Nothing"        
end

StarsurgeCost = function()
    return GetSpellPowerCost(78674)[1].cost
end


GotBalanceofAllThings = function()
    if HasBuff("Balance of All Things") == true then
        return true
    end
    return false
end


CurrentAstralPower = function()
    return UnitPower("player", 8)
end

CastStarsurge = function()
    CF(1,1,1)
    return "Cast Starsurge"
end


CastMoonfire = function()
    CF(0.5,1,1)
    return "Cast Moonfire"
end

CastSunfire = function()
    CF(1,1,0.5)
    return "Cast Sunfire"
end

CastStarfire = function()
    CF(0,1,1)
    return "Cast Starfire"
end

CastWrath = function()
    CF(1,1,0)
    return "Cast Wrath"
end


WrathStacks = function()
    return GetSpellCount(190984)
end

StarfireStacks = function()
    return GetSpellCount(194153)
end


CastingStarfire = function(spell)
    if spell == "Starfire" then 
        return true
    end
    return false
end

CastingWrath = function(spell)
    if spell == "Wrath" then 
        return true
    end
    return false
end

IsMoving = function()
    if GetUnitSpeed("player") == 0 then
        return false
    end
    return true
end

MoonfireDuration = function()
    return TimeLeftOnDebuff("moonfire")
end

SunfireDuration = function()
    return TimeLeftOnDebuff("sunfire")
end

HasMoonfire = function()
    if HasDebuff("moonfire") == true then
        return true
    end
    return false
end

HasSunfire = function()
    if HasDebuff("sunfire") == true then
        return true
    end
    return false
end




aura_env.NextSpell = function() 
    GetBuffs()
    GetDebuffsTarget()
    CF(0,0,0)
    local aoe = AOEF or CreateFrame("Frame", "AOEF", UIParent)
    local f = _G["RBF"]
    local spell, _, displayName, _, _, _, _, castID, interrupt = UnitCastingInfo("player")
    local power = UnitPower("player", 8);
    local hasMoonfire = HasDebuff("moonfire")
    local moonfireDuration = TimeLeftOnDebuff("moonfire")
    local hasSunfire = HasDebuff("sunfire")
    local sunfireDuration = TimeLeftOnDebuff("sunfire")
    local hasSolarEclipse = HasBuff("eclipse (solar)")
    local hasLunarEclipse = HasBuff("eclipse (lunar)")
    local costOfStarsurge = GetSpellPowerCost(78674)[1].cost
    local wrathStacks = GetSpellCount(190984)
    local starfireStacks = GetSpellCount(194153)
    --print("Moonfire:"..tostring(moonfireDuration))
    --print("Sunfire: "..tostring(sunfireDuration))
    
    aoe:SetScript("OnKeyDown", SwitchDoAoe)
    aoe:SetPropagateKeyboardInput(true)
    
    
    if StopCast == true or IsConvoking() == true then
        return DoNothing()
    end
    
    
    if GotBalanceofAllThings() == true and CurrentAstralPower() >= StarsurgeCost() then
        return CastStarsurge()
        
    elseif IsMoving() == true then        
        if HasMoonfire() == false or MoonfireDuration() < 5 then
            return CastMoonfire()
        elseif MoonfireDuration() > SunfireDuration() then
            return CastSunfire()
        elseif HasSunfire() == false or SunfireDuration() < 5 then   
            return CastSunfire()
        else
            return CastMoonfire()
        end        
        
        
    elseif (CurrentAstralPower() + 6 >= 95 and CastingWrath()) then
        return CastStarsurge()
        
        
    elseif (CurrentAstralPower() + 8 >= 95 and CastingStarfire()) then
        return CastStarsurge()
        
        
        
    elseif hasLunarEclipse == true then
        if HasMoonfire() == false or MoonfireDuration() < 5 then
            return CastMoonfire()
        elseif HasSunfire() == false or SunfireDuration() < 5 then   
            return CastSunfire()
        else
            return CastStarfire()
        end
        
        
    elseif hasSolarEclipse == true then
        if HasMoonfire() == false or MoonfireDuration() < 5 then
            return CastMoonfire()
        elseif HasSunfire() == false or MoonfireDuration() < 5 then
            return CastSunfire()
        else
            return CastWrath()
        end
        
        
    elseif WrathStacks() == 2 then
        return CastWrath()       
        
        
    elseif StarfireStacks() == 2 then
        return CastStarfire()
        
        
    elseif CastingStarfire(spell) == true and StarfireStacks() == 1 then
        if CurrentAstralPower() + 8 >= StarsurgeCost() then
            return CastStarsurge()
        else   
            return CastWrath()
        end
        
        
    elseif CastingWrath(spell) == true and WrathStacks() == 1 then
        if CurrentAstralPower() + 6 >= StarsurgeCost() then
            return CastStarsurge()
        else      
            return CastStarfire()
        end
        
    elseif StarfireStacks() > 0 then
        return CastStarfire()
        
    elseif WrathStacks() > 0 then
        return CastWrath()
        
    else
        return "Unknown"
    end
end

