using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class FileBuilder
    {

        /// <summary>
        /// Creates a file that contains a list of the bad tags
        /// </summary>
        /// <param name="destination"> File path for bad file </param>
        /// <param name="dualList"> DualList object containing list of tags
        /// </param>
        public static void buildBadFile(string destination, DualList dualList)
        {
            StreamWriter writer = new StreamWriter(destination);
            string[] tids = dualList.getBadTidList();
            string[] epcs = dualList.getBadEpcList();

            for (int i = 0; i < tids.Length; i++)
            {
                if ((epcs[i] == "") || (epcs[i] == null))
                {
                    
                }
                else
                {
                    writer.WriteLine(epcs[i] + "," + tids[i]);
                }
            }

            writer.Close();
        }

        /// <summary>
        /// Creates a file containing the completed list of tags
        /// </summary>
        /// <param name="destination">File pathway for the list of tags 
        /// </param>
        /// <param name="dualList">DualList object cointaining the list of tags
        /// </param>
        public static void buildAssociationFile(string destination, DualList dualList)
        {
            StreamWriter writer = new StreamWriter(destination);
            string[] tids = dualList.getTidArray();
            string[] epcs = dualList.getEpcArray();

            for (int i = 0; i < tids.Length; i++)
            {
                writer.WriteLine(epcs[i] + "," + tids[i]);

            }
            writer.Close();
        }

        /// <summary>
        /// Creates a file containing all the good tags
        /// </summary>
        /// <param name="destination">File pathway</param>
        /// <param name="dualList">DualList object containing the lists of tags</param>
        public static void buildGoodFile(string destination, DualList dualList)
        {
            StreamWriter writer = new StreamWriter(destination);
            string[] tids = dualList.getTidArray();
            string[] epcs = dualList.getEpcArray();
            TimeList time = dualList.getTimeList();


            for (int i = 0; i < tids.Length; i++)
            {
                if (epcs[i] == null || epcs[i] == "")
                {

                }
                else
                {
                    writer.WriteLine(epcs[i] + "," + tids[i] + "," + time.getDateAt(i) + "," + time.getTimeAt(i));
                }
            }
            writer.Close();
        }

        public static void createSortingDictionaries(string filePath,
                                                     Dictionary<string, int>
                                                     epcCounter,
                                                     Dictionary<string, int>
                                                     masterDictionary, Dictionary<int, string> IndicesMaster)
        {

            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            int counter = 0;
            while (line != null)
            {
                string[] lineArray = line.Split(',');

                try
                {
                    epcCounter.Add(lineArray[1], 0);
                    masterDictionary.Add(lineArray[1], counter);
                    IndicesMaster.Add(counter, lineArray[1]);
                    counter++;
                }
                catch (Exception e)
                {
                }

                line = reader.ReadLine();
            }
            reader.Close();
        }
    }

}
