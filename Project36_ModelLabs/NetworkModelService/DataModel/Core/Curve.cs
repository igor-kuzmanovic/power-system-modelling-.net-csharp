using FTN.Common;
using System.Collections.Generic;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class Curve : IdentifiedObject
    {
        public Curve(long globalId) : base(globalId)
        {
        }

        #region Properties

        public CurveStyle CurveStyle { get; set; }
        public UnitMultiplier XMultiplier { get; set; }
        public UnitSymbol XUnit { get; set; }
        public UnitMultiplier Y1Multiplier { get; set; }
        public UnitSymbol Y1Unit { get; set; }
        public UnitMultiplier Y2Multiplier { get; set; }
        public UnitSymbol Y2Unit { get; set; }
        public UnitMultiplier Y3Multiplier { get; set; }
        public UnitSymbol Y3Unit { get; set; }
        public List<long> CurveDatas { get; set; } = new List<long>();

        #endregion Properties

        #region Overrides

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Curve x = (Curve)obj;
                return (x.CurveStyle == this.CurveStyle && x.XMultiplier == this.XMultiplier && x.XUnit == this.XUnit
                    && x.Y1Multiplier == this.Y1Multiplier && x.Y1Unit == this.Y1Unit && x.Y2Multiplier == this.Y2Multiplier
                    && x.Y2Unit == this.Y2Unit && x.Y3Multiplier == this.Y3Multiplier && x.Y3Unit == this.Y3Unit
                    && CompareHelper.CompareLists(x.CurveDatas, this.CurveDatas, true));
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Overrides

        #region IAccess implementation

        public override bool HasProperty(ModelCode property)
        {
            switch (property)
            {
                case ModelCode.CURVE_CURVESTLYE:
                case ModelCode.CURVE_XMULTIPLIER:
                case ModelCode.CURVE_XUNIT:
                case ModelCode.CURVE_Y1MULTIPLIER:
                case ModelCode.CURVE_Y1UNIT:
                case ModelCode.CURVE_Y2MULTIPLIER:
                case ModelCode.CURVE_Y2UNIT:
                case ModelCode.CURVE_Y3MULTIPLIER:
                case ModelCode.CURVE_Y3UNIT:
                case ModelCode.CURVE_CURVEDATAS:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.CURVE_CURVESTLYE:
                    property.SetValue((short)CurveStyle);
                    break;

                case ModelCode.CURVE_XMULTIPLIER:
                    property.SetValue((short)XMultiplier);
                    break;

                case ModelCode.CURVE_XUNIT:
                    property.SetValue((short)XUnit);
                    break;

                case ModelCode.CURVE_Y1MULTIPLIER:
                    property.SetValue((short)Y1Multiplier);
                    break;

                case ModelCode.CURVE_Y1UNIT:
                    property.SetValue((short)Y1Unit);
                    break;

                case ModelCode.CURVE_Y2MULTIPLIER:
                    property.SetValue((short)Y2Multiplier);
                    break;

                case ModelCode.CURVE_Y2UNIT:
                    property.SetValue((short)Y2Unit);
                    break;

                case ModelCode.CURVE_Y3MULTIPLIER:
                    property.SetValue((short)Y3Multiplier);
                    break;

                case ModelCode.CURVE_Y3UNIT:
                    property.SetValue((short)Y3Unit);
                    break;

                case ModelCode.CURVE_CURVEDATAS:
                    property.SetValue(CurveDatas);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.CURVE_CURVESTLYE:
                    CurveStyle = (CurveStyle)property.AsEnum();
                    break;

                case ModelCode.CURVE_XMULTIPLIER:
                    XMultiplier = (UnitMultiplier)property.AsEnum();
                    break;

                case ModelCode.CURVE_XUNIT:
                    XUnit = (UnitSymbol)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y1MULTIPLIER:
                    Y1Multiplier = (UnitMultiplier)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y1UNIT:
                    Y1Unit = (UnitSymbol)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y2MULTIPLIER:
                    Y2Multiplier = (UnitMultiplier)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y2UNIT:
                    Y2Unit = (UnitSymbol)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y3MULTIPLIER:
                    Y3Multiplier = (UnitMultiplier)property.AsEnum();
                    break;

                case ModelCode.CURVE_Y3UNIT:
                    Y3Unit = (UnitSymbol)property.AsEnum();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation

        public override bool IsReferenced
        {
            get
            {
                return CurveDatas.Count > 0 || base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (CurveDatas != null && CurveDatas.Count > 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.CURVE_CURVEDATAS] = CurveDatas.GetRange(0, CurveDatas.Count);
            }

            base.GetReferences(references, refType);
        }

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.CURVEDATA_CURVE:
                    CurveDatas.Add(globalId);
                    break;

                default:
                    base.AddReference(referenceId, globalId);
                    break;
            }
        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.CURVEDATA_CURVE:

                    if (CurveDatas.Contains(globalId))
                    {
                        CurveDatas.Remove(globalId);
                    }
                    else
                    {
                        CommonTrace.WriteTrace(CommonTrace.TraceWarning, "Entity (GID = 0x{0:x16}) doesn't contain reference 0x{1:x16}.", this.GlobalId, globalId);
                    }

                    break;

                default:
                    base.RemoveReference(referenceId, globalId);
                    break;
            }
        }

        #endregion IReference implementation
    }
}