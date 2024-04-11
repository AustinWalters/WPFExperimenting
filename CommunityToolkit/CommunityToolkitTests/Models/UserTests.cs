using Xunit;

namespace CommunityToolkit.Models.Tests
{
    public class UserTests
    {
        private readonly User _user;
        [Fact]
        public void SetNameTest()
        {
            Assert.Equal(string.Empty, _user.FullName);
            _user.SetName("Austin");
            Assert.Equal("Austin", _user.FullName);
        }

        [Fact]
        public void SetIdTest()
        {
            Assert.Equal(string.Empty, _user.Id);
            _user.SetId("12345");
            Assert.Equal("12345", _user.Id);
        }

        [Fact]
        public void DoesHavePermission()
        {
            Assert.False(_user.HasPermission("1"));
            _user.GetPermissions();
            Assert.True(_user.HasPermission("1"));
        }

        [Fact]
        public void DoesNotHavePermission()
        {
            Assert.False(_user.HasPermission("1"));
            _user.GetPermissions();
            Assert.False(_user.HasPermission("4"));
        }
    }
}