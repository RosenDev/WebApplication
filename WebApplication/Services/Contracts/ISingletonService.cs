using System;

namespace WebApplication.Services
{
    public interface ISingletonService:IDisposable
    {
        void DoWork();
    }
}