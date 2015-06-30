
namespace RNM.FaultLogging.Domain
{
    #region [Namespaces]

    using RNM.Common;
    using RNM.FaultLogging.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Drawing;
    using RNM.Common.Interfaces;
    using RNM.Common.ReferenceNumber;

    #endregion

    /// <summary>
    /// Fault
    /// </summary>
    public class Fault:IFault 
    {
        #region [Fields]

        private int id;
        private string faultReference;
        private List<Call> calls;
        private ReportCard reportCard;
        private FaultType type;
        private GeocodeLocation geocodeLocation;
        private PhysicalLocation physicalLocation   ;
        private FaultStatus status ;
        private FaultPriority priority;

        #endregion

        #region [Constructors]

        public Fault()
        {
            //this.faultReference =(new ReferenceGenerator()).Issue();
            this.calls = new List<Call>();
        }

        public Fault(FaultType type)
            :this()
        {
            this.type = FaultType.Unknown;
        }

        #endregion

        #region [Properties]

        public virtual int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<Call> Calls
        {
            get { return calls; }
        }

        public virtual  FaultType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public virtual FaultStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public virtual FaultPriority Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public virtual ReportCard ReportCard
        {
            get { return reportCard; }
            set { reportCard = value; }
        }

        public virtual string FaultReference
        {
            get { return this.faultReference; }
            private set { this.faultReference = value; }
        }


        public virtual GeocodeLocation Geocode
        {
            get { return this.geocodeLocation; }
            set { this.geocodeLocation = value; }
        }

        public virtual PhysicalLocation Address
        {
            get { return this.physicalLocation; }
            set { this.physicalLocation = value; }
        }
        #endregion
    }
}
