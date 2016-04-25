using Is.Net.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Is.Net.UnitTest
{
    [TestClass]
    public class TextHelperTest
    {
        private TextHelper helper
        {
            get
            {
                return TextHelper.Instance.Value;
            }
        }

        [TestMethod]
        public void IsSpace()
        {
            Assert.IsTrue(helper.IsSpace(" "));
            Assert.IsTrue(helper.IsSpace(' '));
            Assert.IsFalse(helper.IsSpace(""));
            Assert.IsFalse(helper.IsSpace("a"));
            Assert.IsFalse(helper.IsSpace(null));
        }

        [TestMethod]
        public void IsURL()
        {
            Assert.IsTrue(helper.IsURL(@"http://www.buraktungut.com"));
            Assert.IsTrue(helper.IsURL(@"http://otomatikmuhendis.com/"));
            Assert.IsTrue(helper.IsURL(@"ftp://subdomain.domain.net.tr"));
            Assert.IsFalse(helper.IsURL("subdomain.domain.net.tr"));
            Assert.IsFalse(helper.IsURL("website address"));
            Assert.IsFalse(helper.IsURL(""));
            Assert.IsFalse(helper.IsURL("a"));
            Assert.IsFalse(helper.IsURL(null));
        }

        [TestMethod]
        public void IsEmail()
        {
            Assert.IsTrue(helper.IsEmail("emailaddress@domain.com"));
            Assert.IsTrue(helper.IsEmail("special.emailaddress+withcharacters@emaildomain.com"));
            Assert.IsFalse(helper.IsEmail(""));
            Assert.IsFalse(helper.IsEmail("a"));
            Assert.IsFalse(helper.IsEmail(null));
        }

        [TestMethod]
        public void IsName()
        {
            Assert.IsTrue(helper.IsName("Name Surname"));
            Assert.IsTrue(helper.IsName("abcdefghıijkl noprsstuuvyz'abcdefghijklm"));
            Assert.IsTrue(helper.IsName("a"));
            Assert.IsTrue(helper.IsName(" "));
            Assert.IsFalse(helper.IsName("1"));
            Assert.IsFalse(helper.IsName(""));
            Assert.IsFalse(helper.IsName(null));
        }

        [TestMethod]
        public void IsTurkishIdentity()
        {
            Assert.IsTrue(helper.IsTurkishIdentity("92279202834"));
            Assert.IsFalse(helper.IsTurkishIdentity("11122233344"));
            Assert.IsFalse(helper.IsTurkishIdentity(""));
            Assert.IsFalse(helper.IsTurkishIdentity("a"));
            Assert.IsFalse(helper.IsTurkishIdentity(null));
        }

        [TestMethod]
        public void IsSocialSecurityNumber()
        {
            Assert.IsTrue(helper.IsSocialSecurityNumber("333-22-4444"));
            Assert.IsFalse(helper.IsSocialSecurityNumber("11122233344"));
            Assert.IsFalse(helper.IsSocialSecurityNumber(""));
            Assert.IsFalse(helper.IsSocialSecurityNumber("a"));
            Assert.IsFalse(helper.IsSocialSecurityNumber(null));
        }

        [TestMethod]
        public void IsConfirmation()
        {
            Assert.IsTrue(helper.IsConfirmation("yes"));
            Assert.IsTrue(helper.IsConfirmation("evet"));
            Assert.IsTrue(helper.IsConfirmation("True"));
            Assert.IsFalse(helper.IsConfirmation("no"));
            Assert.IsFalse(helper.IsConfirmation("a"));
        }

        [TestMethod]
        public void IsIP()
        {
            Assert.IsTrue(helper.IsIP("192.168.0.1"));
            Assert.IsTrue(helper.IsIP("0.0.0.0"));
            Assert.IsTrue(helper.IsIP("::1"));
            Assert.IsFalse(helper.IsIP("a"));
            Assert.IsFalse(helper.IsIP(null));
        }

        [TestMethod]
        public void IsCreditCard()
        {
            Assert.IsTrue(helper.IsCreditCard("378282246310005"));
            Assert.IsFalse(helper.IsCreditCard("378282246310000"));
            Assert.IsFalse(helper.IsCreditCard("111"));
            Assert.IsFalse(helper.IsCreditCard("a"));
        }

        [TestMethod]
        public void IsAlphaNumeric()
        {
            Assert.IsTrue(helper.IsAlphaNumeric("harfler432SaY"));
            Assert.IsFalse(helper.IsAlphaNumeric("Qwert&!"));
        }
    }
}
