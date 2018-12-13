using System;

namespace FTN.Common
{	    
    public enum CurveStyle : short
    {
        Unknown = 0x0,
        constantYValue = 0x1,
        formula = 0x2,
        rampYValue = 0x3,
        straightLineYValues = 0x4,
    }

    public enum UnitMultiplier : short
    {
        Unknown = 0x0,
        c = 0x1,
        d = 0x2,
        G = 0x3,
        k = 0x4,
        m = 0x5,
        M = 0x6,
        micro = 0x7,
        n = 0x8,
        none = 0x9,
        p = 0xA,
        T = 0xB,
    }

    public enum UnitSymbol : short
    {
        Unknown = 0x00,
        A = 0x01,
        deg = 0x02,
        degC = 0x03,
        F = 0x04,
        g = 0x05,
        h = 0x06,
        H = 0x07,
        Hz = 0x08,
        J = 0x09,
        m = 0x0A,
        m2 = 0x0B,
        m3 = 0x0C,
        min = 0x0D,
        N = 0x0E,
        none = 0x0F,
        ohm = 0x10,
        Pa = 0x20,
        rad = 0x30,
        s = 0x40,
        S = 0x50,
        V = 0x60,
        VA = 0x70,
        VAh = 0x80,
        VAr = 0x90,
        VArh = 0xA0,
        W = 0xB0,
        Wh = 0xC0,
    }

    public enum RegulatingControlModeKind : short
    {
        Unknown = 0x0,
        activePower = 0x1,
        admittance = 0x2,
        currentFlow = 0x3,
        @fixed = 0x4,
        powerFactor = 0x5,
        reactivePower = 0x6,
        temperature = 0x7,
        timeScheduled = 0x8,
        voltage = 0x9,
    }

    public enum PhaseCode : short
    {
        Unknown = 0x00,
        A = 0x01,
        AB = 0x02,
        ABC = 0x03,
        ABCN = 0x04,
        ABN = 0x05,
        AC = 0x06,
        ACN = 0x07,
        AN = 0x08,
        B = 0x09,
        BC = 0x0A,
        BCN = 0x0B,
        BN = 0x0C,
        C = 0x0D,
        CN = 0x0E,
        N = 0x0F,
        s1 = 0x10,
        s12 = 0x20,
        s12N = 0x30,
        s1N = 0x40,
        s2 = 0x50,
        s2N = 0x60,
    }
}
