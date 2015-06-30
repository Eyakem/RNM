using RNM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultLogging.Domain
{
    public class ReportCard
    {
        private List<Answer> answers;
        private List<IDescribedPhoto> describedPhotos;

        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public List<IDescribedPhoto> DescribedPhotos
        {
            get { return describedPhotos; }
            set { describedPhotos = value; }
        }
    }
}
