using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System.Collections.Generic;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class RegulatingControl : PowerSystemResource
    {
        public RegulatingControl(long globalId) : base(globalId)
        {
        }

        #region Properties

        public bool Discrete { get; set; }
        public RegulatingControlModeKind Mode { get; set; }
        public PhaseCode MonitoredPhase { get; set; }
        public float TargetRange { get; set; }
        public float TargetValue { get; set; }
        public long Terminal { get; set; }

        #endregion Properties

        #region Overrides

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                RegulatingControl x = (RegulatingControl)obj;
                return (x.Discrete == this.Discrete && x.Mode == this.Mode && x.MonitoredPhase == this.MonitoredPhase
                    && x.TargetRange == this.TargetRange && x.TargetValue == this.TargetValue && x.Terminal == this.Terminal);
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
                case ModelCode.REGULATINGCONTROL_DISCRETE:
                case ModelCode.REGULATINGCONTROL_MODE:
                case ModelCode.REGULATINGCONTROL_MONITOREDPHASE:
                case ModelCode.REGULATINGCONTROL_TARGETRANGE:
                case ModelCode.REGULATINGCONTROL_TARGETVALUE:
                case ModelCode.REGULATINGCONTROL_TERMINAL:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.REGULATINGCONTROL_DISCRETE:
                    property.SetValue(Discrete);
                    break;

                case ModelCode.REGULATINGCONTROL_MODE:
                    property.SetValue((short)Mode);
                    break;

                case ModelCode.REGULATINGCONTROL_MONITOREDPHASE:
                    property.SetValue((short)MonitoredPhase);
                    break;

                case ModelCode.REGULATINGCONTROL_TARGETRANGE:
                    property.SetValue(TargetRange);
                    break;

                case ModelCode.REGULATINGCONTROL_TARGETVALUE:
                    property.SetValue(TargetValue);
                    break;

                case ModelCode.REGULATINGCONTROL_TERMINAL:
                    property.SetValue(Terminal);
                    break;

                //case ModelCode.REGULATINGCONTROL_REGULATINGCONDEQ:
                //    property.SetValue(RegulatingCondEq);
                //    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.REGULATINGCONTROL_DISCRETE:
                    Discrete = property.AsBool();
                    break;

                case ModelCode.REGULATINGCONTROL_MODE:
                    Mode = (RegulatingControlModeKind)property.AsEnum();
                    break;

                case ModelCode.REGULATINGCONTROL_MONITOREDPHASE:
                    MonitoredPhase = (PhaseCode)property.AsEnum();
                    break;

                case ModelCode.REGULATINGCONTROL_TARGETRANGE:
                    TargetRange = property.AsFloat();
                    break;

                case ModelCode.REGULATINGCONTROL_TARGETVALUE:
                    TargetValue = property.AsFloat();
                    break;

                case ModelCode.REGULATINGCONTROL_TERMINAL:
                    Terminal = property.AsReference();
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
            if (Terminal != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.REGULATINGCONTROL_TERMINAL] = new List<long>();
                references[ModelCode.REGULATINGCONTROL_TERMINAL].Add(Terminal);
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