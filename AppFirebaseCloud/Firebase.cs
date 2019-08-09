using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppFirebaseCloud
{
    public class Firebase
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Qy24zLL1FGhjBtxvTTIWl2cwHjC8DbgNfW2COR4M",
            BasePath = "https://test-ea548.firebaseio.com/"
        };

        IFirebaseClient client;

        public Firebase()
        {
            isConnection();
        }

        internal bool isConnection()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                return true;
            return false;
        }

        Student result = null;

        internal async Task<bool> Insert(Student student)
        {
            var response = await client.SetTaskAsync("students/" + student.Id + "/", student);
            result = response.ResultAs<Student>();

            if (result.Id != null)
                return true;

            return false;
        }

        internal async Task<bool> Update(Student student)
        {
            var response = await client.UpdateTaskAsync("students/" +student.Id.ToString(), student);
            result = response.ResultAs<Student>();

            if (result.Id != null)
                return true;

            return false;
        }

        internal async Task<bool> Delete(Student student)
        {
            var response = await client.DeleteTaskAsync("students/"+student.Id.ToString());

            if (response.Success)
                return true;

            return false;
        }

        List<Student> listStudent;
        internal async Task<List<Student>> List()
        {
            listStudent = new List<Student>();
            var response = await client.GetTaskAsync("students");
            var result = response.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string, Student>>(result);

            foreach (var item in data)
            {
                Student student = item.Value;
                listStudent.Add(student);
            }

            return listStudent;
        }
    }
}