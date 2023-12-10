using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommunityToolkit.Models.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void SetNameTest()
        {
            User user = new User();
            Assert.AreEqual(string.Empty, user.FullName);
            user.SetName("Austin");
            Assert.AreEqual("Austin", user.FullName);
        }

        [TestMethod()]
        public void SetIdTest()
        {
            User user = new User();
            Assert.AreEqual(string.Empty, user.Id);
            user.SetId("12345");
            Assert.AreEqual("12345", user.Id);
        }

        [TestMethod()]
        public void DoesHavePermission()
        {
            User user = new User();
            Assert.IsFalse(user.HasPermission("1"));
            user.GetPermissions();
            Assert.IsTrue(user.HasPermission("1"));
        }
        [TestMethod()]
        public void DoesNotHavePermission()
        {
            User user = new User();
            Assert.IsFalse(user.HasPermission("1"));
            user.GetPermissions();
            Assert.IsFalse(user.HasPermission("4"));
        }
    }
}