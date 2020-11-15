using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class ResearchTeam
    {
        private string researchObject;
        private string organization;
        private readonly int id;
        private TimeFrame researchPeriod;
        private Paper[] papers;

        public int ResearchTeamCounter = 1;
        public ResearchTeam(string researchObj, string organiz, int Id, TimeFrame period) {

            researchObject = researchObj;
            organization = organiz;
            id = Id;
            researchPeriod = period;
            papers = new Paper[0];

        }

        public ResearchTeam() : this("", "", 0, 0 ) { papers = new Paper[0]; } 


        public string ResearchObject {
            get => researchObject;
            set => researchObject = value;
        }
        public string Organization {
            get => organization;
            set => organization = value;
        }

        public TimeFrame ResearchPeriod {
            get => researchPeriod;
            set => researchPeriod = value;
        }

        public int Id {
            get => id;
        }
        public Paper[] Papers {
            get => papers;
            set => papers = value;
        }

        public Paper Paper
        {
            get { 
                if (Papers.Length > 0) {
                    DateTime max = Papers[0].date;
                    int idx = 0;
                    for (int i=1;i<Papers.Length;i++) {
                        if (Papers[i].date > max) {
                            max = Papers[i].date;
                            idx = i;
                        } 
                    }
                    return Papers[idx];
                }
                else
                    return null; 
            }
        }

        public bool this[TimeFrame index]
        {
            get => ResearchPeriod == index;
        }

        public void AddPapers(params Paper[] p) {
            Paper[] temp = new Paper[Papers.Length + p.Length];
            Papers.CopyTo(temp, 0);
            int j = 0;
            for (int i = Papers.Length; i < temp.Length; i++, j++)
                temp[i] = p[j];
            Papers = temp;
        }

        public override string ToString()
        {
            string temp = $" research object {ResearchObject}\nOrganization: {Organization} \nResearch Period: {ResearchPeriod} \nPapers:\n";
            foreach (Paper n in Papers) temp += n.ToString();
            return temp;
        }

        public string ToShortString()=> $"research object: {ResearchObject}\nOrganization: {Organization} \nResearch Period: {ResearchPeriod} \n\n";



    }
}
