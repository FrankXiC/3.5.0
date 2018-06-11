using System;
using System.Threading.Tasks;
using Abp.TestBase;
using TESTABP.EntityFrameworkCore;
using TESTABP.Tests.TestDatas;

namespace TESTABP.Tests {
    public class TESTABPTestBase : AbpIntegratedTestBase<TESTABPTestModule> {
        public TESTABPTestBase() {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<TESTABPDbContext> action) {
            using (var context = LocalIocManager.Resolve<TESTABPDbContext>()) {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<TESTABPDbContext, T> func) {
            T result;

            using (var context = LocalIocManager.Resolve<TESTABPDbContext>()) {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<TESTABPDbContext, Task> action) {
            using (var context = LocalIocManager.Resolve<TESTABPDbContext>()) {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<TESTABPDbContext, Task<T>> func) {
            T result;

            using (var context = LocalIocManager.Resolve<TESTABPDbContext>()) {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
