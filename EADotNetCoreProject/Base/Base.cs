using System;

namespace EAAutoFramework.Base
{
    public class Base
    {
        public readonly ParallelConfig parallelConfig;

        public Base(ParallelConfig parellelConfig)
        {
            parallelConfig = parellelConfig;
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            return (TPage) Activator.CreateInstance(typeof(TPage));
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
