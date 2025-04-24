using System.Collections.Generic;
using System.IO;
using AgileTest.Common.Models;
using Newtonsoft.Json;
using Xunit;

namespace AgileTest.Tests.Core
{
    public static class TestData
    {
        private const string _filePath = "Core/RawData/StudentCreate.json";
        
        public const int EXISTING_USER_ID = 1;

        public const int NOT_EXISTING_USER_ID = 99;

        public class StudentCreateData : TheoryData<StudentCreateModel>
        {
            public StudentCreateData()
            {
                var fileData = File.ReadAllText(_filePath);
                var studentCreateList = JsonConvert.DeserializeObject<List<StudentCreateModel>>(fileData);
                studentCreateList.ForEach(Add);
            }
        }
    }
}
