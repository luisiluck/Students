using AgileTest.Common.Models;
using System.Collections.Generic;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace AgileTest.Tests.Core
{
    public class StudentTests : IntegrationTestsCore
    {
        public StudentTests(ITestOutputHelper output) : base(output) {}
        
        [Fact]
        public async void ITStudentGetAllSuccess()
        {
            var response = await Get(ApiEndpoints.STUDENT_GET_ALL);

            Assert.NotNull(response);

            Assert.True(response.IsSuccessStatusCode,"Incorrect response, expected sucess");

            var models = await DeserializeJSON<List<StudentModel>>(response);

            Assert.NotNull(models);
            Assert.Equal(7,models.Count);
        }

        [Fact]
        public async void ITStudentGetSuccess()
        {
            var response = await Get(string.Format(ApiEndpoints.STUDENT_GET_BY_ID, TestData.EXISTING_USER_ID));

            Assert.NotNull(response);

            Assert.True(response.IsSuccessStatusCode, "Incorrect response, expected sucess");

            var model = await DeserializeJSON<StudentModel>(response);

            Assert.NotNull(model);
            Assert.Equal(TestData.EXISTING_USER_ID,model.Id);
        }

        [Fact]
        public async void ITStudentGetFail()
        {
            var response = await Get(string.Format(ApiEndpoints.STUDENT_GET_BY_ID,TestData.NOT_EXISTING_USER_ID));

            Assert.NotNull(response);

            Assert.Equal(System.Net.HttpStatusCode.NoContent, response.StatusCode);
        }

        [Theory]
        [ClassData(typeof(TestData.StudentCreateDataOk))]
        public async void ITStudentPostSuccess(StudentCreateModel student)
        {
            var response = await Post(ApiEndpoints.STUDENT_GET_ALL, student);
            Assert.NotNull(response);
            Assert.True(response.IsSuccessStatusCode, "Incorrect response, expected success");
            
            var model = await DeserializeJSON<StudentModel>(response);

            Assert.NotNull(model);
            Assert.Equal(student.DNI,model.DNI);
            Assert.Equal(student.Name, model.Name);
            Assert.Equal(student.Surname, model.Surname);
        }
        
        [Theory]
        [ClassData(typeof(TestData.StudentCreateDataFail))]
        public async void ITStudentPostFail(StudentCreateModel student, string message)
        {
            var response = await Post(ApiEndpoints.STUDENT_GET_ALL, student);
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var resMessage = await response.Content.ReadAsStringAsync();
            Assert.Contains(message, resMessage);
        }
    }
}
