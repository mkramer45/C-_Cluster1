using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connance.SharedObjects;

namespace Connance.ClientSpecificMessageConverter
{
    class ChristusMessageConverter : BaseScoringMessageConverte
    {
        protected const int RecInsurance = 251; /// protected integer variable of 251 ... arrives in this messagetypeID 

        public const string FieldInsMnemonic = "InsMnemonic"; /// public  string variable of FieldInsMnemonic, set to InsMnemonic ... arrives in this field of the 251 record
        public const string FieldClientDefined1 = "ClientDefined1"; /// public  string variable of FieldClientDefined1, set to ClientDefined1 ... derived field in alegis,cardonelig visitrecords, imports value from InsMnemonic

        static public void ConvertFrom_54(Dictionary<int, ParameterSet[]> inputMessage, Dictionary<int, ParameterSet[]> outputMessage) /// here is our one and only method
        {
            if (inputMessage.ContainsKey(RecInsurance)) /// if we are dealing with a record that is distinguished by 251, aka where the InsMnemonic field is found 
            {
                string InsMnemonic; /// string variable InsMnemonic

                if (inputMessage[RecInsurance][0].ContainsNotNullParameter(FieldInsMnemonic)) /// if the InsMnemonic field is NOT null
                {
                    InsMnemonic = inputMessage[RecInsurance][0].GetStringParameterValue(FieldInsMnemonic); /// set our variable InsMnemonic = the value of this InsMnemonic Field from the file
                    if (outputMessage[RecordVisit][0].ContainsParameter(FieldClientDefined1)) /// if OutPutMessage for RecordVisit contains parameter FieldClientDefined1 (which it does, after updating configs for visit record to contain this field)
                        outputMessage[RecordVisit][0].UpdateParameterValue(FieldClientDefined1, InsMnemonic); /// Update the ClientDefined1 field of the visit record with the value from the InsMnemonic field
                    else
                        outputMessage[RecordVisit][0].AddParameter(FieldClientDefined1, typeof(String), InsMnemonic); 
                }
            }
        }
    }
}
