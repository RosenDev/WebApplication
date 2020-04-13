using System;

namespace WebApplication.Services
{
    public interface ITransientService:IDisposable
    {
         void DoWork();
    }
}