using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TextParser
    {
        private int maxEpc;
        private int maxTid;

        public TextParser(int maxEpc, int maxTid)
        {
            this.maxEpc = maxEpc;
            this.maxTid = maxTid;

        }

        /// <summary>
        /// This function is responsible for parsing information from a predator file
        /// </summary>
        /// <param name="txt"> The line of text to parse from </param>
        /// <param name="epc"> The epc reference to populate </param>
        /// <param name="tid"> The tid reference to populate</param>
        /// <param name="time"> the time reference to populate </param>
        /// <param name="theDate"> The date reference to populate </param>
        public  void ParsePredator(ref String txt, ref String epc, ref String tid,
           ref String time, ref String theDate)
        {
            if (txt.Contains("="))
            {
                //txt = txt.Replace(Chr(34), "");

                String[] strArr = txt.Split('=');
                tid = strArr[strArr.Length - 1];
                tid = tid.Trim();
                String[] strArr2 = strArr[1].Split();
                String[] strArr3 = strArr2[1].Split();
                epc = strArr3[0];
                time = "";
                theDate = "";
            }

            if(tid.Length > this.maxTid)
            {
                tid = tid.Substring(0,this.maxTid);

            }

            if(epc.Length > this.maxEpc)
            {
                epc = epc.Substring(0,this.maxEpc);

            }

        }


        public void parsePickUp(ref String txt, ref String epc, ref String tid,
           ref String time, ref String theDate)
        {
            if(txt.Contains(","))
            {
                String[] strArr = txt.Split(',');

                try
                {
                    epc = strArr[0];
                    tid = strArr[1];
                    theDate = strArr[2];
                    time = strArr[3];
                }
                catch (Exception e)
                {
                    tid = "ERROR";
                    theDate = "";
                    time = "";
                }
            }

            if(tid.Length > this.maxTid)
            {
                tid = tid.Substring(0,this.maxTid);

            }

            if(epc.Length > this.maxEpc)
            {
                epc = epc.Substring(0,this.maxEpc);

            }
        }

        public  void parseGoodFile(ref String txt, ref String epc, ref String tid,
           ref String time, ref String theDate)
        {
            if (txt.Contains(','))
            {
                String[] strArr = txt.Split(',');

                try
                {
                    epc = strArr[0];
                    tid = strArr[1];

                }
                catch (Exception e)
                {
                    tid = "ERROR";
                    theDate = "";
                    time = "";

                }
            }

                if (tid.Length > this.maxTid)
                {
                    tid = tid.Substring(0, this.maxTid);

                }

                if (epc.Length > this.maxEpc)
                {
                    epc = epc.Substring(0, this.maxEpc);

                }
        }

      }
 
  }

