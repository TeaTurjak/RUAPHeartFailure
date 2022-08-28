// This code requires the Nuget package Microsoft.AspNet.WebApi.Client to be installed.
// Instructions for doing this in Visual Studio:
// Tools -> Nuget Package Manager -> Package Manager Console
// Install-Package Microsoft.AspNet.WebApi.Client

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace HeartFailureApp
{
    class RequestResponse
    {
        /*
        static void Main(string[] args)
        {
            InvokeRequestResponseService().Wait();
        }
        */

        private static string[] patientDetails=new string[8];

        
        public static void SetGivenDetails (string[] givenDetails)
        {
            patientDetails = givenDetails;
        }
        

        public static string diagnosisResponse;
        public static string finalDiagnosis;

        public static async Task InvokeRequestResponseService()
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "patient_details",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "age", patientDetails[0]
                                            },
                                            {
                                                "anaemia", patientDetails[1]
                                            },
                                            {
                                                "creatinine_phosphokinase", patientDetails[2]
                                            },
                                            {
                                                "diabetes", patientDetails[3]
                                            },
                                            {
                                                "ejection_fraction", patientDetails[4]
                                            },
                                            {
                                                "platelets", patientDetails[5]
                                            },
                                            {
                                                "serum_creatinine", patientDetails[6]
                                            },
                                            {
                                                "time", patientDetails[7]
                                            },


                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "OxfM3owPqmbO4zSoIFgPGF5V78flKTj1AjBFF1/XewxFkbq+x26qBhCGRwj9K5iTyQ6Y66cXH91b8Z5+D726bg==";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/35ebc03fd88d46c095c48ad99a7105e5/services/8a3eaf9e20e84bd9ab2259cbe00efea4/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)
                
                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);
                
                if (response.IsSuccessStatusCode)
                {
                    string result1 = await response.Content.ReadAsStringAsync();
                    diagnosisResponse =result1;
                    Console.WriteLine("Result: {0}", result1);

                    JObject obj = JObject.Parse(diagnosisResponse);
                    JToken jToken = obj["Results"];
                    string death_event_data = jToken["death_event"].ToString();

                    string tempbefore=death_event_data.Remove(0,38);
                    string tempafter = tempbefore.Remove(1);
                    Console.WriteLine("Death event is:" + tempafter);

                    finalDiagnosis = tempafter;

                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp,
                    // which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);

                }
            }
        }
    }
}
