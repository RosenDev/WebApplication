using System;

namespace WebApplication.Services
{
    public interface IScopedService:IDisposable
    {
        void DoWork();
    }
}