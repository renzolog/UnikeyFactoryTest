﻿using UnikeyFactoryTest.Domain.Enums;

namespace UnikeyFactoryTest.Domain
{
    public class AdministratedAnswerBusiness
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public AnswerState isCorrect { get; set; }
        public bool isSelected { get; set; }
        public int AdministratedQuestionId { get; set; }
        public int Score { get; set; }

        public virtual AdministratedQuestionBusiness AdministratedQuestion { get; set; }

    }
}
