using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DualList
    {
        private Dictionary<String, String> goodTags;
        private Dictionary<String, String> badTags;
        private TimeList timeList;
        private Dictionary<string, int> masterIndices;
        private Dictionary<int, string> indicesMaster;
        private Dictionary<string, int> epcCountHolder;
        private string[] epcList;
        private string[] tidList;
        private string[] badEpcList;
        private string[] badTidList; 
        private int epcCount;
        private int epcLength;
        private int tidLength;
        private int badCount;
      

        /// <summary>S
        /// creates a new instance of a DualList object
        /// </summary>
        public DualList(String filePath, int numEpc, int newEpcLength, int newTidLength)
        {
            epcCount = numEpc;
            epcCountHolder = new Dictionary<string, int>();
            masterIndices = new Dictionary<string, int>();
            indicesMaster = new Dictionary<int, string>();
            FileBuilder.createSortingDictionaries(filePath, epcCountHolder, 
                                                  masterIndices,indicesMaster);

            goodTags = new Dictionary<String, String>();
            badTags = new Dictionary<String, String>();
            timeList = new TimeList();

            epcList = new string[masterIndices.Count];
            tidList = new string[masterIndices.Count];
            badEpcList = new string[masterIndices.Count];
            badTidList = new string[masterIndices.Count];
            epcLength = newEpcLength;
            tidLength = newTidLength;
        }

        /// <summary>
        /// Decides whether the tag being added to the dictionary is 
        /// valid or not
        /// </summary>
        /// <param name="epc"> String representation of the epc </param>
        /// <param name="tid"> String representation of the tid</param>
         /// <param name="theDate"> String representation of the date 
        /// </param>
        /// <param name="time"> String representation of the time </param>
        public void addTag(String epc, String tid, String theDate, 
            String time)
        {
            
            if(!checkValidity(epc,tid))
            {
                return;
            }

            if(epcCountHolder[epc] >= epcCount)
            {
                try
                {
                    epc = epc + "*";
                    badTags.Add(epc, tid);
                    badEpcList[masterIndices[epc]] = epc;
                    badTidList[masterIndices[epc]] = tid;

                }
                catch (Exception e)
                {
                    return;

                }
            }

            else
            {
                if (epc != "" && tid != "")
                {
                    try
                    {
                        goodTags.Add(epc, tid);
                        timeList.add(time, theDate);
                        epcCountHolder[epc]++;
                        epcList[masterIndices[epc]] = epc;
                        tidList[masterIndices[epc]] = tid;
                        badTidList[masterIndices[epc]] = "";
                        badEpcList[masterIndices[epc]] = "";
                        badTags.Remove(epc);
                        

                    }
                    catch (Exception e)
                    {
                        return;
                    }

                }
             
            }
                

        } 

        /// <summary>
        /// returns the sorted array of bad tids
        /// </summary>
        /// <returns></returns>
        public string[] getBadTidList()
        {
            return this.badTidList;
        }

        /// <summary>
        /// returns the sorted array of bad epcs
        /// </summary>
        /// <returns> A string array </returns>
        public string[] getBadEpcList()
        {
            return this.badEpcList;
        }

        /// <summary>
        /// Adds 
        /// </summary>
        /// <param name="epc"> String representation of epc 
        /// </param>
        /// <param name="tid"> String representation of tid
        /// </param>
        public void addToBadList(string epc, string tid)
        {
            badEpcList[masterIndices[epc]] = epc;
            badTidList[masterIndices[tid]] = tid;

        }

        /// <summary>
        /// Returns the good tags dictionary
        /// </summary>
        /// <returns> The good tags dictionary </returns>
        public Dictionary<String, String> getGoodTags()
        {
            return goodTags;

        }

        public int getNumBadTags()
        {
            return badTags.Keys.Count();


        }

        /// <summary>
        /// Returns the bad tags dictionary
        /// </summary>
        /// <returns> The Bad tags dictionary </returns>
        public Dictionary<String, String> getBadTags()
        {
            return badTags;  

        }


        public TimeList getTimeList()
        {
            return this.timeList;

        }

        
        public String getDateAt(int i)
        {
            return timeList.getDateAt(i);

        }

        public String getTimeAt(int i)
        {
            return getTimeAt(i);

        }

        /// <summary>
        /// returns the sorted array of Epc's
        /// </summary>
        /// <returns> List of Epcs </returns>
        public string[] getEpcArray()
        {
            return this.epcList;

        }

        /// <summary>
        /// returns the sorted array of Tid's
        /// </summary>
        /// <returns> List of Tids</returns>
        public string[] getTidArray()
        {
            return this.tidList;

        }


        public Boolean checkValidity(String epc, String tid)
        {
            if(epc.Contains("ERROR"))
            {
                return false;
            }

            if(epc == "")
            {
                return false;
            }

            if(tid.Contains("ERROR"))
            {
                return false;
            }

            if(tid == "")
            {
                return false;

            }

            if(!masterIndices.ContainsKey(epc))
            {
                return false;
            }

            return true;
        }


        public void checkMissing()
        {
            for(int i = 0; i < epcList.Length; i++)
            {
                try
                {
                    if (epcList[i] != indicesMaster[i])
                    {
                        badTags.Add(indicesMaster[i], "Missing");
                        badTidList[i] = "Missing";
                        badEpcList[i] = indicesMaster[i];
                        epcList[i] = "";

                    }
                    else
                    {


                    }
                }
                catch(Exception ex)
                {
                   
                }

            }


        }

    }
}
