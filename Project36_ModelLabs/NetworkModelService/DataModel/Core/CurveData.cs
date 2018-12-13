using FTN.Common;
using System.Collections.Generic;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class CurveData : IdentifiedObject
    {
        public CurveData(long globalId) : base(globalId)
        {
        }

        #region Properties

        public float Xvalue { get; set; }
        public float Y1value { get; set; }
        public float Y2value { get; set; }
        public float Y3value { get; set; }
        public long Curve { get; set; }


        #endregion Properties

        #region Overrides

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                CurveData x = (CurveData)obj;
                return (x.Xvalue == this.Xvalue && x.Y1value == this.Y1value && x.Y2value == this.Y2value
                    && x.Y3value == this.Y3value && x.Curve == this.Curve);
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
                case ModelCode.CURVEDATA_XVALUE:
                case ModelCode.CURVEDATA_Y1VALUE:
                case ModelCode.CURVEDATA_Y2VALUE:
                case ModelCode.CURVEDATA_Y3VALUE:
                case ModelCode.CURVEDATA_CURVE:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.CURVEDATA_XVALUE:
                    property.SetValue(Xvalue);
                    break;

                case ModelCode.CURVEDATA_Y1VALUE:
                    property.SetValue(Y1value);
                    break;

                case ModelCode.CURVEDATA_Y2VALUE:
                    property.SetValue(Y2value);
                    break;

                case ModelCode.CURVEDATA_Y3VALUE:
                    property.SetValue(Y3value);
                    break;

                case ModelCode.CURVEDATA_CURVE:
                    property.SetValue(Curve);
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
                case ModelCode.CURVEDATA_XVALUE:
                    Xvalue = property.AsFloat();
                    break;

                case ModelCode.CURVEDATA_Y1VALUE:
                    Y1value = property.AsFloat();
                    break;

                case ModelCode.CURVEDATA_Y2VALUE:
                    Y2value = property.AsFloat();
                    break;

                case ModelCode.CURVEDATA_Y3VALUE:
                    Y3value = property.AsFloat();
                    break;

                case ModelCode.CURVEDATA_CURVE:
                    Curve = property.AsReference();
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
                return base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (Curve != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.CURVEDATA_CURVE] = new List<long>();
                references[ModelCode.CURVEDATA_CURVE].Add(Curve);
            }

            base.GetReferences(references, refType);
        }

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                default:
                    base.AddReference(referenceId, globalId);
                    break;
            }
        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                default:
                    base.RemoveReference(referenceId, globalId);
                    break;
            }
        }

        #endregion IReference implementation
    }
}