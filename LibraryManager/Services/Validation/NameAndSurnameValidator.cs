﻿namespace LibraryManager.Services.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NameAndSurnameValidator
    {
        private string input;
        private string name;
        private StringBuilder result;

        public NameAndSurnameValidator(string input, string name)
        {
            this.input = input;
            this.name = name;
            this.result = new StringBuilder();
        }

        public string Validate()
        {
            result.AppendLine(InputShouldBeBetweenTwoAndThirtyCharacters());
            result.AppendLine(InputShouldContainOnlyLetters());
            result.AppendLine(InputShouldStartWithUpperLetter());

            return result.ToString();
        }

        private string InputShouldBeBetweenTwoAndThirtyCharacters()
        {
            if (this.input.Length < 2 || this.input.Length > 30)
            {
                return $"{this.name} should be between 2 and 30 characters";
            }

            return string.Empty;
        }

        private string InputShouldContainOnlyLetters()
        {
            var isLetter = true;

            foreach (var ch in this.input)
            {
                if (!Char.IsLetter(ch))
                {
                    isLetter = false;
                }
            }

            return isLetter ? string.Empty : $"{this.name} should contains only letters";
        }

        private string InputShouldStartWithUpperLetter()
        {
            var letter = Char.IsUpper(this.input[0]);

            return letter ? string.Empty : $"{this.name} should start with upper letter";
        }

    }
}
