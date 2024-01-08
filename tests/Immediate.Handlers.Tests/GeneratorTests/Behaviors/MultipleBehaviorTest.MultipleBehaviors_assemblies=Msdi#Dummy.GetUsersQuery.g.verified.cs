//HintName: Dummy.GetUsersQuery.g.cs
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable CS1591

namespace Dummy;

public static partial class GetUsersQuery
{
    public sealed class Handler
    {
        private readonly global::Dummy.GetUsersQuery.HandleBehavior _behavior_0;
        private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _behavior_1;
        private readonly global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _behavior_2;
    
        public Handler(
            global::Dummy.GetUsersQuery.HandleBehavior behavior_0,
            global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> behavior_1,
            global::Dummy.SecondLoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> behavior_2
		)
        {
            _behavior_0 = behavior_0;
            _behavior_1 = behavior_1;
            _behavior_2 = behavior_2;
        }
    
        public async global::System.Threading.Tasks.Task<IEnumerable<global::Dummy.User>> HandleAsync(global::Dummy.GetUsersQuery.Query request, global::System.Threading.CancellationToken cancellationToken = default)
        {
            _behavior_2.InnerHandler = _behavior_1;
            _behavior_1.InnerHandler = _behavior_0;
			
            return await _behavior_2
				.HandleAsync(request, cancellationToken)
				.ConfigureAwait(false);
        }
    }

    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class HandleBehavior : global::Immediate.Handlers.Shared.Behavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>>
    {
        private readonly global::Dummy.UsersService _usersService;
    
        public HandleBehavior(
            global::Dummy.UsersService usersService
            )
        {
            _usersService = usersService;
        }
    
        public override async global::System.Threading.Tasks.Task<IEnumerable<global::Dummy.User>> HandleAsync(global::Dummy.GetUsersQuery.Query request, global::System.Threading.CancellationToken cancellationToken)
        {
            return await global::Dummy.GetUsersQuery
				.HandleAsync(
					request,                
					_usersService,
					cancellationToken
				)
				.ConfigureAwait(false);
        }
    }

    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddHandlers(global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
        services.AddScoped<global::Dummy.GetUsersQuery.Handler>();
        services.AddScoped<global::Dummy.GetUsersQuery.HandleBehavior>();
        return services;
    }
}
