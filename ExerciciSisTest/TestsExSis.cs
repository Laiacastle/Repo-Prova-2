using ExerciciSisLibrary;
using System;
namespace ExerciciSisTest
{
    [TestClass]
    public class TestsExSis
    {
        [TestMethod]
        public void Char5()
        {
            //Arrange
            char[] contra = { 'a', 'b', 'c', 'd', 'e' };
            //Act
            bool result = Utils.CharCompruve(contra);
            //Assert
            Assert.IsTrue(result );
        }
        [TestMethod]
        public void Char11()
        {
            //Arrange
            char[] contra = { 'A', '2', 'A', '2',  'A','A', '2', 'A', '2', 'A', 'A' };
            //Act
            bool result = Utils.CharCompruve(contra);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Char12()
        {
            //Arrange
            char[] contra = { 'a', 'b', 'c', 'd', 'e', 'a', 'b', 'c', 'd', 'e', 'y' };
            //Act
            bool result = Utils.CharCompruve(contra);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Char4()
        {
            //Arrange
            char[] contra = { 'a', 'b', 'c', 'd'};
            //Act
            bool result = Utils.CharCompruve(contra);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NumStart()
        {
            //Arrange
            char[] contra = { '2', 'b', 'c', 'd', 'e', 'a', 'b', 'c', 'd', 'e', 'y' };
            //Act
            bool result = Utils.NumsStartEnd(contra);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void NumFin()
        {
            //Arrange
            char[] contra = { 'a', 'b', 'c', 'd', 'e', 'a', 'b', 'c', 'd', 'e', '3' };
            //Act
            bool result = Utils.NumsStartEnd(contra);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AllNums()
        {
            //Arrange
            char[] contra = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '1' };
            //Act
            bool result = Utils.NumsStartEnd(contra);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
