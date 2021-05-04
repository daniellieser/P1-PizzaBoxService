using System;
using Xunit;
using PizzaBoxDomain;
using PizzaBoxDomain.Models;

namespace PizzaBoxTest
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            //arange
            var sut = new VeganPizza();
            //act
            var actual = sut.Crust.Name;
            //assert
            Assert.True(actual == "Deep Dish");
        }
        [Fact]
        public void Test2()
        {
            var sut = new Bacon();

            // act
            var actual = sut.Name;

            // assert
            Assert.True(actual == "Bacon");
        }
        [Fact]
        public void Test3()
        {
            // arrange
            var sut = new Jalapenos();

            // act
            var actual = sut.Name;

            // assert
            Assert.True(actual == "Jalapenos");
        }
        [Fact]
        public void Test4()
        {
            var sut = new Jalapenos();

            // act
            var actual = sut.Price;

            // assert
            Assert.True(actual == 0.85m);
        }
        [Fact]
        public void Test_MushroomsPrice()
        {
            // arrange
            var sut = new Mushrooms();

            // act
            var actual = sut.Price;

            // assert
            Assert.True(actual == 1.05m);
        }

        [Fact]
        public void Test_BaconPrice()
        {
            // arrange
            var sut = new Bacon();

            // act
            var actual = sut.Price;

            // assert
            Assert.True(actual == 1.10m);
        }
        [Fact]
        public void Test_SausagePrice()
        {
            // arrange
            var sut = new Sausage();

            // act
            var actual = sut.Price;

            // assert
            Assert.True(actual == 1.10m);
        }

        [Fact]
        public void Test_PizzaCrustCustom()
        {
            // arrange
            var sut = new CustomPizza();

            // act
            var actual = sut.Crust.Name;

            // assert
            Assert.True(actual == "NY Style");
        }
        [Fact]
        public void Test_PizzaCrustMeat()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual = sut.Crust.Name;

            // assert
            Assert.True(actual == "NY Style");
        }

        [Fact]
        public void Test_PizzaSize_Cost()
        {
            // arrange
            var sut = new VeganPizza();

            // act
            var actual = sut.Size.Price;

            // assert
            Assert.True(actual == 8m);
        }
        [Fact]
        public void Test_PizzaMeat()
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual = sut.Size.Price;

            // assert
            Assert.True(actual == 8m);
        }
        [Fact]
        public void Test_PizzaCustom()
        {
            // arrange
            var sut = new CustomPizza();

            // act
            var actual = sut.Size.Price;

            // assert
            Assert.True(actual == 8m);
        }
    }

}
