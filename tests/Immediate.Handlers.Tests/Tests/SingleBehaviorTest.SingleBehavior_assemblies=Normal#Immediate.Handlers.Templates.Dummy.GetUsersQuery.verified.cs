//HintName: Immediate.Handlers.Templates.Dummy.GetUsersQuery.cs


namespace Dummy;

public static partial class GetUsersQuery
{
    public sealed class Handler
    {
        private readonly global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> _behavior_1;
        private readonly global::Dummy.GetUsersQuery.HandleBehavior _behavior_0;
    
        public Handler(
            global::Dummy.LoggingBehavior<global::Dummy.GetUsersQuery.Query, IEnumerable<global::Dummy.User>> behavior_1,
            global::Dummy.GetUsersQuery.HandleBehavior handleBehavior)
        {
            _behavior_1 = behavior_1;
            _behavior_0 = handleBehavior;
        }
    
        public async global::System.Threading.Tasks.Task<IEnumerable<global::Dummy.User>> HandleAsync(global::Dummy.GetUsersQuery.Query request, global::System.Threading.CancellationToken cancellationToken = default)
        {
            _behavior_1.InnerHandler = _behavior_0;
            return await _behavior_1.HandleAsync(request, cancellationToken);
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
            return await global::Dummy.GetUsersQuery.HandleAsync(
                request,                
                _usersService,
                cancellationToken);
        }
    }

}
