[TestMethod()]
public void ReplaceUnderScoreWithSpaceTest(){
	string testparam1 = "foobar";
	CheesyUnderscore cheesy = new CheesyUnderscore();
	string expected = "foobar";
	string actual = cheesy.ReplaceUnderScoreWithSpace(testparam1);
	Assert.AreEqual(expected, actual);
}
