namespace nunit_buisness
{
    [TestFixture]
    public class Tests
    {
        



        [Test]
        public void OneThousand_G_E()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreEqual(950, obj.calculateDiscount(1000));
        }
    }
}