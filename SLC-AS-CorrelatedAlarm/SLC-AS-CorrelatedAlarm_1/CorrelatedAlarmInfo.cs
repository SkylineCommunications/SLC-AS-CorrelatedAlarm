namespace SLCASCorrelatedAlarm
{
    using System;

    internal partial class CorrelatedAlarmInfo
    {
        #region Constructors
        private CorrelatedAlarmInfo()
        {
        }
        #endregion

        #region Public properties
        public int AlarmId { get; set; }

        public AlarmProperty[] AlarmProperties { get; set; }

        public DateTime AlarmTime { get; set; }

        public int AlarmType { get; set; }

        public string AlarmValue { get; set; }

        public int AmountProperties { get; set; }

        public int DmaID { get; set; }

        public int ElementID { get; set; }

        public int ElementRCA { get; set; }

        public string ImpactedServices { get; set; }

        public string Owner { get; set; }

        public int ParameterID { get; set; }

        public string ParameterIndex { get; set; }

        public int ParameterRCA { get; set; }

        public int PrevAlarmID { get; set; }

        public int RootAlarmID { get; set; }

        public int ServiceRCA { get; set; }

        public int Severity { get; set; }

        public int SeverityRange { get; set; }

        public int SourceID { get; set; }

        public int Status { get; set; }

        public int UserStatus { get; set; }
        #endregion

        #region Nested Classes
        internal class AlarmProperty
        {
            #region Public properties
            public string PropertyName { get; set; }

            public string PropertyValue { get; set; }
            #endregion
        }
        #endregion
    }
}
