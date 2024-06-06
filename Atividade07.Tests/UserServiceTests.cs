using Atividade07;
using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;
using Xunit.Sdk;

namespace Atividade07.Tests
{
    public class UserServiceTests
    {
    
        [Fact]
        public void Can_get_user_service(){
            
            
            var user = new User("Teste", "Test@gmail.com");
            var userService = new UserService(_db);
            userService.SaveUser(user);
            Assert.Equal(_db.users![0], user);

        }
    }
}


