namespace LibraryManager.Automapper
{
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
