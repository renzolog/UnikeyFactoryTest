﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnikeyFactoryTest.Context;
using UnikeyFactoryTest.Repository;

namespace UnikeyFactoryTestDAL.Test
{
    [TestClass]
    public class UnitTestCreateFeaturesRepository
    {
        [TestMethod]
        public void TestMethodSaveChangesDB_OK()
        {
            UnikeyFactoryTest.Context.Test test = new UnikeyFactoryTest.Context.Test()
            {
                Date = DateTime.Now,
                URL = "Test URL",
                UserId = 1
            };

            Question question = new Question()
            {
                TestId = 1,
                Text = "Question Test"

            };
            Answer answer = new Answer()
            {
                IsCorrect = true,
                QuestionId = 1,
                Score = 10,
                Text = "Answer Test"
            };

            TestRepository testRepository = new TestRepository();

            try
            {
                question.Answers.Add(answer);
                test.Questions.Add(question);
                testRepository.SaveTest(test);
            }
            catch (Exception ex)
            {
                int gg = 0;
            }

            TestPlatformDBEntities _ctx = new TestPlatformDBEntities();
            Assert.AreEqual(1, _ctx.Tests.Count());

            int g = 0;
        }
    }
}
