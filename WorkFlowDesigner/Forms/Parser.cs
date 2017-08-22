using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner.Forms
{
    class Parser
    {
        public Parser()
        {
        }
        public List<string[]> Condition (string condition)
        {
            List<string[]> a = new List<string[]>();
            int i = 0;
            while (i < condition.Length)
            {
                a.Add(new string[] { condition[i]=='('? "(":(condition[i]==')' ?")":""), "" });
                if (condition[i] == '('||condition[i]==')') i++;
                while((condition[i]>='a'&& condition[i] <= 'z')||(condition[i] >= 'A' && condition[i] <= 'Z')||condition[i]==' ')
                {
                    a.Last()[1] += condition[i];
                    i++;
                }
                a.Add(new string[] { "", "" });
                while(condition[i]=='='|| condition[i] == '!' || condition[i] == '>' || condition[i] == '<')
                {
                    a.Last()[0] += condition[i];
                    i++;
                }
                while(condition[i]!='&'&& condition[i]!='|')
                {
                    a.Last()[1] += condition[i];
                    i++;
                    if (i == condition.Length) return a;
                }
                if(i<condition.Length)
                {
                    a.Add(new string[] { condition[i].ToString(), "" });
                    i++;
                }
               
            } 
            return a;
        }

    }
}
