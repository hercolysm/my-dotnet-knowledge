using AutoBogus;
using Microsoft.AspNetCore.Mvc.Testing;
using MyLibraryClass.NET6.Entities;
using MyXUnitTest.NET6.Configurations;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using Xunit.Abstractions;

namespace MyXUnitTest.NET6.MyWebAPI.NET6
{
    public class ContactControllerTest : IClassFixture<WebApplicationFactory<Program>>, IAsyncLifetime
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _httpClient;
        private readonly ITestOutputHelper _output;
        private Contact? _contact;

        public ContactControllerTest(WebApplicationFactory<Program> factory, ITestOutputHelper output)
        {
            _factory = factory;
            _httpClient = _factory.CreateClient();
            _output = output;
        }

        public async Task InitializeAsync()
        {
            await CreateContact_AutoFakerData_ReturnSuccess();
        }

        public async Task DisposeAsync()
        {
            _httpClient.Dispose();
        }

        [Fact]
        public async void GetWithFilter_AllContacts_ReturnSuccess()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, $"/contacts?nome={_contact.Nome}");

            // Act
            var response = await _httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();

            _output.WriteLine($"Retorno: {responseString}");
            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(responseString);

            // Assert
            Assert.Contains(_contact.Nome, responseString);
            Assert.NotEmpty(contacts);
        }

        [Fact]
        public async void GetWithoutFilter_AllContacts_ReturnSuccess()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, "/contacts");

            // Act
            var response = await _httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();

            _output.WriteLine($"Retorno: {responseString}");
            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(responseString);

            // Assert
            Assert.NotEmpty(contacts);
        }

        [Fact]
        public void GetById_ExistentContact_ReturnSuccess()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, $"/contact/{_contact.Id}");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();
            var responseContent = response.Content.ReadAsStringAsync().Result;

            _output.WriteLine($"Retorno: {responseContent}");
            Contact findContact = JsonConvert.DeserializeObject<Contact>(responseContent);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(findContact);
            Assert.Equal(_contact.Id, findContact.Id);
            Assert.Equal(_contact.Nome, findContact.Nome);
            Assert.Equal(_contact.Email, findContact.Email);
            Assert.Equal(_contact.Status, findContact.Status);
        }

        [Theory]
        [InlineData(-1)]
        public void GetById_InexistentContact_ReturnNotFound(int Id)
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, $"/contact/{Id}");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public void CreateContact_InvalidData_ReturnSuccess()
        {
            // Arrange
            var contact = new Contact
            {
                Nome = "Nome",
                Status = false
            };
            var json = JsonConvert.SerializeObject(contact);

            var request = new HttpRequestMessage(HttpMethod.Post, "/contact");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();
            _output.WriteLine($"Retorno: {response.Content.ReadAsStringAsync().Result}");

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task CreateContact_AutoFakerData_ReturnSuccess()
        {
            // Arrange
            Contact newContact = new AutoFaker<Contact>(AutoBogusConfiguration.LOCATE)
                .RuleFor(p => p.Id, faker => 0)
                .RuleFor(p => p.Nome, faker => faker.Person.FullName)
                .RuleFor(p => p.Email, faker => faker.Person.Email)
                .RuleFor(p => p.Status, true);

            var json = JsonConvert.SerializeObject(newContact);

            var request = new HttpRequestMessage(HttpMethod.Post, "/contact");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = await _httpClient.SendAsync(request);
            var responseContent = response.Content.ReadAsStringAsync().Result;

            _output.WriteLine($"Contato criado para o teste: {responseContent}");
            _contact = JsonConvert.DeserializeObject<Contact>(responseContent);

            // Assert
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.NotNull(_contact);
            Assert.True(_contact.Id > 0);
            Assert.Equal(newContact.Nome, _contact.Nome);
            Assert.Equal(newContact.Email, _contact.Email);
            Assert.Equal(newContact.Status, _contact.Status);
        }

        [Theory]
        [InlineData("Teste123", "Teste@123", true)]
        [InlineData("Teste456", "Teste@456", false)]
        public void UpdateContact_ValidData_ReturnSuccess(string Nome, string Email, bool Status)
        {
            // Arrange
            int contactId = _contact.Id;
            Contact updateContact = new Contact
            {
                Nome = Nome,
                Email = Email,
                Status = Status
            };
            var json = JsonConvert.SerializeObject(updateContact);

            var request = new HttpRequestMessage(HttpMethod.Put, $"/contact/{contactId}");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();
            var responseContent = response.Content.ReadAsStringAsync().Result;
            
            _output.WriteLine($"Retorno: {responseContent}");
            _contact = JsonConvert.DeserializeObject<Contact>(responseContent);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(_contact);
            Assert.Equal(contactId, _contact.Id);
            Assert.Equal(updateContact.Nome, _contact.Nome);
            Assert.Equal(updateContact.Email, _contact.Email);
            Assert.Equal(updateContact.Status, _contact.Status);
        }

        [Fact]
        public void Delete_ExistentContact_ReturnSuccess()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Delete, $"/contact/{_contact.Id}");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();

            // Assert
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);

            GetById_InexistentContact_ReturnNotFound(_contact.Id);
        }

        [Fact]
        public void Delete_InexistentContact_ReturnNotFound()
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Delete, "/contact/-1");

            // Act
            var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
