using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Main
    {
        private String masterFilePath;
        private String fileDest;
        private String fileToRead;
        public DualList dualList;
        private String orderNumber;

        public Main(String master, String dest, String toRead, 
                    DualList dl, String orderNum)
        {
            this.masterFilePath = master;
            this.fileDest = dest;
            this.fileToRead = toRead;
            this.dualList = dl;
            this.orderNumber = orderNum;
           
               
        } 

        /// <summary>
        /// Creates a new master list based on the file path. THe file must
        /// be comma delimited
        /// </summary>
        /// <param name="filePath"> The pathway for the file </param>
        /// <returns> The new populated master list </returns>
        public Dictionary<String,String> createMasterList()
        {
            Dictionary<String, String> masterList = new Dictionary<String, String>();

            using (StreamReader reader = new StreamReader(this.masterFilePath))
            {
                String line;
                while((line = reader.ReadLine()) != null)
                {
                    String[] field = line.Split(',');
                    masterList.Add(field[1], field[0]);
                            
                }

            }
            return masterList;
        }

        public void main(Boolean isPred)
        {
            TextParser parser = new TextParser(24, 24);
            

            if(isPred)
            {
                String epc = "";
                String tid = "";
                String time = "";
                String theDate = "";
                String line = "";

                using (StreamReader reader = new StreamReader(this.fileToRead))
                {
                    while((line = reader.ReadLine()) != null)
                    {
                        parser.ParsePredator(ref line, ref epc, ref tid, ref time, ref theDate);
                        dualList.addTag(epc, tid, theDate, time);
                   
                    }
                }
            }

            else
            {
                String line;
                String epc = "";
                String tid = "";
                String time = "";
                String theDate = "";

                using (StreamReader reader = new StreamReader(this.fileToRead))
                {
                    while((line = reader.ReadLine()) != null)
                    {
                         parser.parsePickUp(ref line, ref epc, ref tid, ref time, ref theDate);
                        dualList.addTag(epc, tid, theDate, time);

                    }
                }

            }
            dualList.checkMissing();

            try
            {
                FileBuilder.buildBadFile("W://Public/RFID/" + orderNumber + "/" + orderNumber + "BAD_TAGS", dualList);
                FileBuilder.buildBadFile("W://Public/RFID/" + orderNumber + "/" + orderNumber + "GOOD_TAGS", dualList);

                if (dualList.getNumBadTags() == 0)
                {

                    FileBuilder.buildAssociationFile("W://Public/RFID/" + orderNumber + "/" + orderNumber + "ASSOCIATION_FILE", dualList);
                }

            } 
            catch(Exception e)
            {
                FileBuilder.buildBadFile("C://Users/Public/BAD_TAGS",dualList);
                FileBuilder.buildGoodFile("C://Users/Public/Good_TAGS", dualList);
            
                 if(dualList.getBadEpcList().Length == 0)
                {
                    FileBuilder.buildAssociationFile("C://Users/Public/ASSOCIATION_FILE", dualList);

                }
            }

            MessageBox.Show("Number of badtags " + dualList.getNumBadTags().ToString());


            }

        }

    }

