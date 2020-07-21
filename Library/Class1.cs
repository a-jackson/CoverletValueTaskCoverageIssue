using System;
using System.Threading.Tasks;

namespace Library
{
    public class Class1
    {
        public async Task<int> TaskMethod()
        {
            return await this.GetValueTask();
        }

        private Task<int> GetValueTask()
        {
            return Task.FromResult(5);
        }

        public async ValueTask<int> ValueTaskMethod()
        {
            return await this.GetValueValueTask();
        }

        private ValueTask<int> GetValueValueTask()
        {
            return new ValueTask<int>(5);
        }
    }
}
