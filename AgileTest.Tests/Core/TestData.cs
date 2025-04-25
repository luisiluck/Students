using System;
using System.Collections.Generic;
using System.IO;
using AgileTest.Common.Models;
using Newtonsoft.Json;
using Xunit;

namespace AgileTest.Tests.Core
{
    public static class TestData
    {
        public const int EXISTING_USER_ID = 1;

        public const int NOT_EXISTING_USER_ID = 99;

        public class StudentCreateDataOk : TheoryData<StudentCreateModel>
        {
            private const string _filePath = "Core/RawData/StudentCreate.json";
            public StudentCreateDataOk()
            {
                var fileData = File.ReadAllText(_filePath);
                var studentCreateList = JsonConvert.DeserializeObject<List<StudentCreateModel>>(fileData);
                studentCreateList.ForEach(Add);
            }
        }
        
        public class StudentCreateDataFail : TheoryData<StudentCreateModel, string>
        {
            private const string _filePath = "Core/RawData/StudentCreateFail.json";
            public StudentCreateDataFail()
            {
                var fileData = File.ReadAllText(_filePath);
                var list = JsonConvert.DeserializeObject<List<Tuple<StudentCreateModel, string>>>(fileData);
                list.ForEach(t => Add(t.Item1, t.Item2));
            }
        }
    }
}
