using Immediate.Handlers.Shared;

#pragma warning disable CA1822
#pragma warning disable IDE0060
#pragma warning disable MA0022

namespace Immediate.Handlers.Benchmarks;

public sealed record Request0(long Id) : Mediator.IRequest<Response0>, MediatR.IRequest<Response0>;

public sealed record Response0(long Id);

public sealed partial class Request0TraditionalHandler
	: Mediator.IRequestHandler<Request0, Response0>,
	MediatR.IRequestHandler<Request0, Response0>
{
	ValueTask<Response0> Mediator.IRequestHandler<Request0, Response0>.Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response0> MediatR.IRequestHandler<Request0, Response0>.Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request0StaticHandler
{
	private static ValueTask<Response0> Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request0SealedHandler
{
	private ValueTask<Response0> Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request1(long Id) : Mediator.IRequest<Response1>, MediatR.IRequest<Response1>;

public sealed record Response1(long Id);

public sealed partial class Request1TraditionalHandler
	: Mediator.IRequestHandler<Request1, Response1>,
	MediatR.IRequestHandler<Request1, Response1>
{
	ValueTask<Response1> Mediator.IRequestHandler<Request1, Response1>.Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response1> MediatR.IRequestHandler<Request1, Response1>.Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request1StaticHandler
{
	private static ValueTask<Response1> Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request1SealedHandler
{
	private ValueTask<Response1> Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request2(long Id) : Mediator.IRequest<Response2>, MediatR.IRequest<Response2>;

public sealed record Response2(long Id);

public sealed partial class Request2TraditionalHandler
	: Mediator.IRequestHandler<Request2, Response2>,
	MediatR.IRequestHandler<Request2, Response2>
{
	ValueTask<Response2> Mediator.IRequestHandler<Request2, Response2>.Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response2> MediatR.IRequestHandler<Request2, Response2>.Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request2StaticHandler
{
	private static ValueTask<Response2> Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request2SealedHandler
{
	private ValueTask<Response2> Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request3(long Id) : Mediator.IRequest<Response3>, MediatR.IRequest<Response3>;

public sealed record Response3(long Id);

public sealed partial class Request3TraditionalHandler
	: Mediator.IRequestHandler<Request3, Response3>,
	MediatR.IRequestHandler<Request3, Response3>
{
	ValueTask<Response3> Mediator.IRequestHandler<Request3, Response3>.Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response3> MediatR.IRequestHandler<Request3, Response3>.Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request3StaticHandler
{
	private static ValueTask<Response3> Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request3SealedHandler
{
	private ValueTask<Response3> Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request4(long Id) : Mediator.IRequest<Response4>, MediatR.IRequest<Response4>;

public sealed record Response4(long Id);

public sealed partial class Request4TraditionalHandler
	: Mediator.IRequestHandler<Request4, Response4>,
	MediatR.IRequestHandler<Request4, Response4>
{
	ValueTask<Response4> Mediator.IRequestHandler<Request4, Response4>.Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response4> MediatR.IRequestHandler<Request4, Response4>.Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request4StaticHandler
{
	private static ValueTask<Response4> Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request4SealedHandler
{
	private ValueTask<Response4> Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request5(long Id) : Mediator.IRequest<Response5>, MediatR.IRequest<Response5>;

public sealed record Response5(long Id);

public sealed partial class Request5TraditionalHandler
	: Mediator.IRequestHandler<Request5, Response5>,
	MediatR.IRequestHandler<Request5, Response5>
{
	ValueTask<Response5> Mediator.IRequestHandler<Request5, Response5>.Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response5> MediatR.IRequestHandler<Request5, Response5>.Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request5StaticHandler
{
	private static ValueTask<Response5> Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request5SealedHandler
{
	private ValueTask<Response5> Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request6(long Id) : Mediator.IRequest<Response6>, MediatR.IRequest<Response6>;

public sealed record Response6(long Id);

public sealed partial class Request6TraditionalHandler
	: Mediator.IRequestHandler<Request6, Response6>,
	MediatR.IRequestHandler<Request6, Response6>
{
	ValueTask<Response6> Mediator.IRequestHandler<Request6, Response6>.Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response6> MediatR.IRequestHandler<Request6, Response6>.Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request6StaticHandler
{
	private static ValueTask<Response6> Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request6SealedHandler
{
	private ValueTask<Response6> Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request7(long Id) : Mediator.IRequest<Response7>, MediatR.IRequest<Response7>;

public sealed record Response7(long Id);

public sealed partial class Request7TraditionalHandler
	: Mediator.IRequestHandler<Request7, Response7>,
	MediatR.IRequestHandler<Request7, Response7>
{
	ValueTask<Response7> Mediator.IRequestHandler<Request7, Response7>.Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response7> MediatR.IRequestHandler<Request7, Response7>.Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request7StaticHandler
{
	private static ValueTask<Response7> Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request7SealedHandler
{
	private ValueTask<Response7> Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request8(long Id) : Mediator.IRequest<Response8>, MediatR.IRequest<Response8>;

public sealed record Response8(long Id);

public sealed partial class Request8TraditionalHandler
	: Mediator.IRequestHandler<Request8, Response8>,
	MediatR.IRequestHandler<Request8, Response8>
{
	ValueTask<Response8> Mediator.IRequestHandler<Request8, Response8>.Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response8> MediatR.IRequestHandler<Request8, Response8>.Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request8StaticHandler
{
	private static ValueTask<Response8> Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request8SealedHandler
{
	private ValueTask<Response8> Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request9(long Id) : Mediator.IRequest<Response9>, MediatR.IRequest<Response9>;

public sealed record Response9(long Id);

public sealed partial class Request9TraditionalHandler
	: Mediator.IRequestHandler<Request9, Response9>,
	MediatR.IRequestHandler<Request9, Response9>
{
	ValueTask<Response9> Mediator.IRequestHandler<Request9, Response9>.Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response9> MediatR.IRequestHandler<Request9, Response9>.Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request9StaticHandler
{
	private static ValueTask<Response9> Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request9SealedHandler
{
	private ValueTask<Response9> Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request10(long Id) : Mediator.IRequest<Response10>, MediatR.IRequest<Response10>;

public sealed record Response10(long Id);

public sealed partial class Request10TraditionalHandler
	: Mediator.IRequestHandler<Request10, Response10>,
	MediatR.IRequestHandler<Request10, Response10>
{
	ValueTask<Response10> Mediator.IRequestHandler<Request10, Response10>.Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response10> MediatR.IRequestHandler<Request10, Response10>.Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request10StaticHandler
{
	private static ValueTask<Response10> Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request10SealedHandler
{
	private ValueTask<Response10> Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request11(long Id) : Mediator.IRequest<Response11>, MediatR.IRequest<Response11>;

public sealed record Response11(long Id);

public sealed partial class Request11TraditionalHandler
	: Mediator.IRequestHandler<Request11, Response11>,
	MediatR.IRequestHandler<Request11, Response11>
{
	ValueTask<Response11> Mediator.IRequestHandler<Request11, Response11>.Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response11> MediatR.IRequestHandler<Request11, Response11>.Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request11StaticHandler
{
	private static ValueTask<Response11> Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request11SealedHandler
{
	private ValueTask<Response11> Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request12(long Id) : Mediator.IRequest<Response12>, MediatR.IRequest<Response12>;

public sealed record Response12(long Id);

public sealed partial class Request12TraditionalHandler
	: Mediator.IRequestHandler<Request12, Response12>,
	MediatR.IRequestHandler<Request12, Response12>
{
	ValueTask<Response12> Mediator.IRequestHandler<Request12, Response12>.Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response12> MediatR.IRequestHandler<Request12, Response12>.Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request12StaticHandler
{
	private static ValueTask<Response12> Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request12SealedHandler
{
	private ValueTask<Response12> Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request13(long Id) : Mediator.IRequest<Response13>, MediatR.IRequest<Response13>;

public sealed record Response13(long Id);

public sealed partial class Request13TraditionalHandler
	: Mediator.IRequestHandler<Request13, Response13>,
	MediatR.IRequestHandler<Request13, Response13>
{
	ValueTask<Response13> Mediator.IRequestHandler<Request13, Response13>.Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response13> MediatR.IRequestHandler<Request13, Response13>.Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request13StaticHandler
{
	private static ValueTask<Response13> Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request13SealedHandler
{
	private ValueTask<Response13> Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request14(long Id) : Mediator.IRequest<Response14>, MediatR.IRequest<Response14>;

public sealed record Response14(long Id);

public sealed partial class Request14TraditionalHandler
	: Mediator.IRequestHandler<Request14, Response14>,
	MediatR.IRequestHandler<Request14, Response14>
{
	ValueTask<Response14> Mediator.IRequestHandler<Request14, Response14>.Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response14> MediatR.IRequestHandler<Request14, Response14>.Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request14StaticHandler
{
	private static ValueTask<Response14> Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request14SealedHandler
{
	private ValueTask<Response14> Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request15(long Id) : Mediator.IRequest<Response15>, MediatR.IRequest<Response15>;

public sealed record Response15(long Id);

public sealed partial class Request15TraditionalHandler
	: Mediator.IRequestHandler<Request15, Response15>,
	MediatR.IRequestHandler<Request15, Response15>
{
	ValueTask<Response15> Mediator.IRequestHandler<Request15, Response15>.Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response15> MediatR.IRequestHandler<Request15, Response15>.Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request15StaticHandler
{
	private static ValueTask<Response15> Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request15SealedHandler
{
	private ValueTask<Response15> Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request16(long Id) : Mediator.IRequest<Response16>, MediatR.IRequest<Response16>;

public sealed record Response16(long Id);

public sealed partial class Request16TraditionalHandler
	: Mediator.IRequestHandler<Request16, Response16>,
	MediatR.IRequestHandler<Request16, Response16>
{
	ValueTask<Response16> Mediator.IRequestHandler<Request16, Response16>.Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response16> MediatR.IRequestHandler<Request16, Response16>.Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request16StaticHandler
{
	private static ValueTask<Response16> Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request16SealedHandler
{
	private ValueTask<Response16> Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request17(long Id) : Mediator.IRequest<Response17>, MediatR.IRequest<Response17>;

public sealed record Response17(long Id);

public sealed partial class Request17TraditionalHandler
	: Mediator.IRequestHandler<Request17, Response17>,
	MediatR.IRequestHandler<Request17, Response17>
{
	ValueTask<Response17> Mediator.IRequestHandler<Request17, Response17>.Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response17> MediatR.IRequestHandler<Request17, Response17>.Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request17StaticHandler
{
	private static ValueTask<Response17> Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request17SealedHandler
{
	private ValueTask<Response17> Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request18(long Id) : Mediator.IRequest<Response18>, MediatR.IRequest<Response18>;

public sealed record Response18(long Id);

public sealed partial class Request18TraditionalHandler
	: Mediator.IRequestHandler<Request18, Response18>,
	MediatR.IRequestHandler<Request18, Response18>
{
	ValueTask<Response18> Mediator.IRequestHandler<Request18, Response18>.Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response18> MediatR.IRequestHandler<Request18, Response18>.Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request18StaticHandler
{
	private static ValueTask<Response18> Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request18SealedHandler
{
	private ValueTask<Response18> Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request19(long Id) : Mediator.IRequest<Response19>, MediatR.IRequest<Response19>;

public sealed record Response19(long Id);

public sealed partial class Request19TraditionalHandler
	: Mediator.IRequestHandler<Request19, Response19>,
	MediatR.IRequestHandler<Request19, Response19>
{
	ValueTask<Response19> Mediator.IRequestHandler<Request19, Response19>.Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response19> MediatR.IRequestHandler<Request19, Response19>.Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request19StaticHandler
{
	private static ValueTask<Response19> Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request19SealedHandler
{
	private ValueTask<Response19> Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request20(long Id) : Mediator.IRequest<Response20>, MediatR.IRequest<Response20>;

public sealed record Response20(long Id);

public sealed partial class Request20TraditionalHandler
	: Mediator.IRequestHandler<Request20, Response20>,
	MediatR.IRequestHandler<Request20, Response20>
{
	ValueTask<Response20> Mediator.IRequestHandler<Request20, Response20>.Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response20> MediatR.IRequestHandler<Request20, Response20>.Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request20StaticHandler
{
	private static ValueTask<Response20> Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request20SealedHandler
{
	private ValueTask<Response20> Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request21(long Id) : Mediator.IRequest<Response21>, MediatR.IRequest<Response21>;

public sealed record Response21(long Id);

public sealed partial class Request21TraditionalHandler
	: Mediator.IRequestHandler<Request21, Response21>,
	MediatR.IRequestHandler<Request21, Response21>
{
	ValueTask<Response21> Mediator.IRequestHandler<Request21, Response21>.Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response21> MediatR.IRequestHandler<Request21, Response21>.Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request21StaticHandler
{
	private static ValueTask<Response21> Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request21SealedHandler
{
	private ValueTask<Response21> Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request22(long Id) : Mediator.IRequest<Response22>, MediatR.IRequest<Response22>;

public sealed record Response22(long Id);

public sealed partial class Request22TraditionalHandler
	: Mediator.IRequestHandler<Request22, Response22>,
	MediatR.IRequestHandler<Request22, Response22>
{
	ValueTask<Response22> Mediator.IRequestHandler<Request22, Response22>.Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response22> MediatR.IRequestHandler<Request22, Response22>.Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request22StaticHandler
{
	private static ValueTask<Response22> Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request22SealedHandler
{
	private ValueTask<Response22> Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request23(long Id) : Mediator.IRequest<Response23>, MediatR.IRequest<Response23>;

public sealed record Response23(long Id);

public sealed partial class Request23TraditionalHandler
	: Mediator.IRequestHandler<Request23, Response23>,
	MediatR.IRequestHandler<Request23, Response23>
{
	ValueTask<Response23> Mediator.IRequestHandler<Request23, Response23>.Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response23> MediatR.IRequestHandler<Request23, Response23>.Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request23StaticHandler
{
	private static ValueTask<Response23> Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request23SealedHandler
{
	private ValueTask<Response23> Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request24(long Id) : Mediator.IRequest<Response24>, MediatR.IRequest<Response24>;

public sealed record Response24(long Id);

public sealed partial class Request24TraditionalHandler
	: Mediator.IRequestHandler<Request24, Response24>,
	MediatR.IRequestHandler<Request24, Response24>
{
	ValueTask<Response24> Mediator.IRequestHandler<Request24, Response24>.Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response24> MediatR.IRequestHandler<Request24, Response24>.Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request24StaticHandler
{
	private static ValueTask<Response24> Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request24SealedHandler
{
	private ValueTask<Response24> Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request25(long Id) : Mediator.IRequest<Response25>, MediatR.IRequest<Response25>;

public sealed record Response25(long Id);

public sealed partial class Request25TraditionalHandler
	: Mediator.IRequestHandler<Request25, Response25>,
	MediatR.IRequestHandler<Request25, Response25>
{
	ValueTask<Response25> Mediator.IRequestHandler<Request25, Response25>.Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response25> MediatR.IRequestHandler<Request25, Response25>.Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request25StaticHandler
{
	private static ValueTask<Response25> Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request25SealedHandler
{
	private ValueTask<Response25> Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request26(long Id) : Mediator.IRequest<Response26>, MediatR.IRequest<Response26>;

public sealed record Response26(long Id);

public sealed partial class Request26TraditionalHandler
	: Mediator.IRequestHandler<Request26, Response26>,
	MediatR.IRequestHandler<Request26, Response26>
{
	ValueTask<Response26> Mediator.IRequestHandler<Request26, Response26>.Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response26> MediatR.IRequestHandler<Request26, Response26>.Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request26StaticHandler
{
	private static ValueTask<Response26> Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request26SealedHandler
{
	private ValueTask<Response26> Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request27(long Id) : Mediator.IRequest<Response27>, MediatR.IRequest<Response27>;

public sealed record Response27(long Id);

public sealed partial class Request27TraditionalHandler
	: Mediator.IRequestHandler<Request27, Response27>,
	MediatR.IRequestHandler<Request27, Response27>
{
	ValueTask<Response27> Mediator.IRequestHandler<Request27, Response27>.Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response27> MediatR.IRequestHandler<Request27, Response27>.Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request27StaticHandler
{
	private static ValueTask<Response27> Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request27SealedHandler
{
	private ValueTask<Response27> Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request28(long Id) : Mediator.IRequest<Response28>, MediatR.IRequest<Response28>;

public sealed record Response28(long Id);

public sealed partial class Request28TraditionalHandler
	: Mediator.IRequestHandler<Request28, Response28>,
	MediatR.IRequestHandler<Request28, Response28>
{
	ValueTask<Response28> Mediator.IRequestHandler<Request28, Response28>.Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response28> MediatR.IRequestHandler<Request28, Response28>.Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request28StaticHandler
{
	private static ValueTask<Response28> Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request28SealedHandler
{
	private ValueTask<Response28> Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request29(long Id) : Mediator.IRequest<Response29>, MediatR.IRequest<Response29>;

public sealed record Response29(long Id);

public sealed partial class Request29TraditionalHandler
	: Mediator.IRequestHandler<Request29, Response29>,
	MediatR.IRequestHandler<Request29, Response29>
{
	ValueTask<Response29> Mediator.IRequestHandler<Request29, Response29>.Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response29> MediatR.IRequestHandler<Request29, Response29>.Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request29StaticHandler
{
	private static ValueTask<Response29> Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request29SealedHandler
{
	private ValueTask<Response29> Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request30(long Id) : Mediator.IRequest<Response30>, MediatR.IRequest<Response30>;

public sealed record Response30(long Id);

public sealed partial class Request30TraditionalHandler
	: Mediator.IRequestHandler<Request30, Response30>,
	MediatR.IRequestHandler<Request30, Response30>
{
	ValueTask<Response30> Mediator.IRequestHandler<Request30, Response30>.Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response30> MediatR.IRequestHandler<Request30, Response30>.Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request30StaticHandler
{
	private static ValueTask<Response30> Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request30SealedHandler
{
	private ValueTask<Response30> Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request31(long Id) : Mediator.IRequest<Response31>, MediatR.IRequest<Response31>;

public sealed record Response31(long Id);

public sealed partial class Request31TraditionalHandler
	: Mediator.IRequestHandler<Request31, Response31>,
	MediatR.IRequestHandler<Request31, Response31>
{
	ValueTask<Response31> Mediator.IRequestHandler<Request31, Response31>.Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response31> MediatR.IRequestHandler<Request31, Response31>.Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request31StaticHandler
{
	private static ValueTask<Response31> Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request31SealedHandler
{
	private ValueTask<Response31> Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request32(long Id) : Mediator.IRequest<Response32>, MediatR.IRequest<Response32>;

public sealed record Response32(long Id);

public sealed partial class Request32TraditionalHandler
	: Mediator.IRequestHandler<Request32, Response32>,
	MediatR.IRequestHandler<Request32, Response32>
{
	ValueTask<Response32> Mediator.IRequestHandler<Request32, Response32>.Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response32> MediatR.IRequestHandler<Request32, Response32>.Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request32StaticHandler
{
	private static ValueTask<Response32> Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request32SealedHandler
{
	private ValueTask<Response32> Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request33(long Id) : Mediator.IRequest<Response33>, MediatR.IRequest<Response33>;

public sealed record Response33(long Id);

public sealed partial class Request33TraditionalHandler
	: Mediator.IRequestHandler<Request33, Response33>,
	MediatR.IRequestHandler<Request33, Response33>
{
	ValueTask<Response33> Mediator.IRequestHandler<Request33, Response33>.Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response33> MediatR.IRequestHandler<Request33, Response33>.Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request33StaticHandler
{
	private static ValueTask<Response33> Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request33SealedHandler
{
	private ValueTask<Response33> Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request34(long Id) : Mediator.IRequest<Response34>, MediatR.IRequest<Response34>;

public sealed record Response34(long Id);

public sealed partial class Request34TraditionalHandler
	: Mediator.IRequestHandler<Request34, Response34>,
	MediatR.IRequestHandler<Request34, Response34>
{
	ValueTask<Response34> Mediator.IRequestHandler<Request34, Response34>.Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response34> MediatR.IRequestHandler<Request34, Response34>.Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request34StaticHandler
{
	private static ValueTask<Response34> Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request34SealedHandler
{
	private ValueTask<Response34> Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request35(long Id) : Mediator.IRequest<Response35>, MediatR.IRequest<Response35>;

public sealed record Response35(long Id);

public sealed partial class Request35TraditionalHandler
	: Mediator.IRequestHandler<Request35, Response35>,
	MediatR.IRequestHandler<Request35, Response35>
{
	ValueTask<Response35> Mediator.IRequestHandler<Request35, Response35>.Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response35> MediatR.IRequestHandler<Request35, Response35>.Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request35StaticHandler
{
	private static ValueTask<Response35> Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request35SealedHandler
{
	private ValueTask<Response35> Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request36(long Id) : Mediator.IRequest<Response36>, MediatR.IRequest<Response36>;

public sealed record Response36(long Id);

public sealed partial class Request36TraditionalHandler
	: Mediator.IRequestHandler<Request36, Response36>,
	MediatR.IRequestHandler<Request36, Response36>
{
	ValueTask<Response36> Mediator.IRequestHandler<Request36, Response36>.Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response36> MediatR.IRequestHandler<Request36, Response36>.Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request36StaticHandler
{
	private static ValueTask<Response36> Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request36SealedHandler
{
	private ValueTask<Response36> Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request37(long Id) : Mediator.IRequest<Response37>, MediatR.IRequest<Response37>;

public sealed record Response37(long Id);

public sealed partial class Request37TraditionalHandler
	: Mediator.IRequestHandler<Request37, Response37>,
	MediatR.IRequestHandler<Request37, Response37>
{
	ValueTask<Response37> Mediator.IRequestHandler<Request37, Response37>.Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response37> MediatR.IRequestHandler<Request37, Response37>.Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request37StaticHandler
{
	private static ValueTask<Response37> Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request37SealedHandler
{
	private ValueTask<Response37> Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request38(long Id) : Mediator.IRequest<Response38>, MediatR.IRequest<Response38>;

public sealed record Response38(long Id);

public sealed partial class Request38TraditionalHandler
	: Mediator.IRequestHandler<Request38, Response38>,
	MediatR.IRequestHandler<Request38, Response38>
{
	ValueTask<Response38> Mediator.IRequestHandler<Request38, Response38>.Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response38> MediatR.IRequestHandler<Request38, Response38>.Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request38StaticHandler
{
	private static ValueTask<Response38> Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request38SealedHandler
{
	private ValueTask<Response38> Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request39(long Id) : Mediator.IRequest<Response39>, MediatR.IRequest<Response39>;

public sealed record Response39(long Id);

public sealed partial class Request39TraditionalHandler
	: Mediator.IRequestHandler<Request39, Response39>,
	MediatR.IRequestHandler<Request39, Response39>
{
	ValueTask<Response39> Mediator.IRequestHandler<Request39, Response39>.Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response39> MediatR.IRequestHandler<Request39, Response39>.Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request39StaticHandler
{
	private static ValueTask<Response39> Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request39SealedHandler
{
	private ValueTask<Response39> Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request40(long Id) : Mediator.IRequest<Response40>, MediatR.IRequest<Response40>;

public sealed record Response40(long Id);

public sealed partial class Request40TraditionalHandler
	: Mediator.IRequestHandler<Request40, Response40>,
	MediatR.IRequestHandler<Request40, Response40>
{
	ValueTask<Response40> Mediator.IRequestHandler<Request40, Response40>.Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response40> MediatR.IRequestHandler<Request40, Response40>.Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request40StaticHandler
{
	private static ValueTask<Response40> Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request40SealedHandler
{
	private ValueTask<Response40> Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request41(long Id) : Mediator.IRequest<Response41>, MediatR.IRequest<Response41>;

public sealed record Response41(long Id);

public sealed partial class Request41TraditionalHandler
	: Mediator.IRequestHandler<Request41, Response41>,
	MediatR.IRequestHandler<Request41, Response41>
{
	ValueTask<Response41> Mediator.IRequestHandler<Request41, Response41>.Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response41> MediatR.IRequestHandler<Request41, Response41>.Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request41StaticHandler
{
	private static ValueTask<Response41> Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request41SealedHandler
{
	private ValueTask<Response41> Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request42(long Id) : Mediator.IRequest<Response42>, MediatR.IRequest<Response42>;

public sealed record Response42(long Id);

public sealed partial class Request42TraditionalHandler
	: Mediator.IRequestHandler<Request42, Response42>,
	MediatR.IRequestHandler<Request42, Response42>
{
	ValueTask<Response42> Mediator.IRequestHandler<Request42, Response42>.Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response42> MediatR.IRequestHandler<Request42, Response42>.Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request42StaticHandler
{
	private static ValueTask<Response42> Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request42SealedHandler
{
	private ValueTask<Response42> Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request43(long Id) : Mediator.IRequest<Response43>, MediatR.IRequest<Response43>;

public sealed record Response43(long Id);

public sealed partial class Request43TraditionalHandler
	: Mediator.IRequestHandler<Request43, Response43>,
	MediatR.IRequestHandler<Request43, Response43>
{
	ValueTask<Response43> Mediator.IRequestHandler<Request43, Response43>.Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response43> MediatR.IRequestHandler<Request43, Response43>.Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request43StaticHandler
{
	private static ValueTask<Response43> Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request43SealedHandler
{
	private ValueTask<Response43> Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request44(long Id) : Mediator.IRequest<Response44>, MediatR.IRequest<Response44>;

public sealed record Response44(long Id);

public sealed partial class Request44TraditionalHandler
	: Mediator.IRequestHandler<Request44, Response44>,
	MediatR.IRequestHandler<Request44, Response44>
{
	ValueTask<Response44> Mediator.IRequestHandler<Request44, Response44>.Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response44> MediatR.IRequestHandler<Request44, Response44>.Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request44StaticHandler
{
	private static ValueTask<Response44> Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request44SealedHandler
{
	private ValueTask<Response44> Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request45(long Id) : Mediator.IRequest<Response45>, MediatR.IRequest<Response45>;

public sealed record Response45(long Id);

public sealed partial class Request45TraditionalHandler
	: Mediator.IRequestHandler<Request45, Response45>,
	MediatR.IRequestHandler<Request45, Response45>
{
	ValueTask<Response45> Mediator.IRequestHandler<Request45, Response45>.Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response45> MediatR.IRequestHandler<Request45, Response45>.Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request45StaticHandler
{
	private static ValueTask<Response45> Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request45SealedHandler
{
	private ValueTask<Response45> Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request46(long Id) : Mediator.IRequest<Response46>, MediatR.IRequest<Response46>;

public sealed record Response46(long Id);

public sealed partial class Request46TraditionalHandler
	: Mediator.IRequestHandler<Request46, Response46>,
	MediatR.IRequestHandler<Request46, Response46>
{
	ValueTask<Response46> Mediator.IRequestHandler<Request46, Response46>.Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response46> MediatR.IRequestHandler<Request46, Response46>.Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request46StaticHandler
{
	private static ValueTask<Response46> Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request46SealedHandler
{
	private ValueTask<Response46> Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request47(long Id) : Mediator.IRequest<Response47>, MediatR.IRequest<Response47>;

public sealed record Response47(long Id);

public sealed partial class Request47TraditionalHandler
	: Mediator.IRequestHandler<Request47, Response47>,
	MediatR.IRequestHandler<Request47, Response47>
{
	ValueTask<Response47> Mediator.IRequestHandler<Request47, Response47>.Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response47> MediatR.IRequestHandler<Request47, Response47>.Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request47StaticHandler
{
	private static ValueTask<Response47> Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request47SealedHandler
{
	private ValueTask<Response47> Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request48(long Id) : Mediator.IRequest<Response48>, MediatR.IRequest<Response48>;

public sealed record Response48(long Id);

public sealed partial class Request48TraditionalHandler
	: Mediator.IRequestHandler<Request48, Response48>,
	MediatR.IRequestHandler<Request48, Response48>
{
	ValueTask<Response48> Mediator.IRequestHandler<Request48, Response48>.Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response48> MediatR.IRequestHandler<Request48, Response48>.Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request48StaticHandler
{
	private static ValueTask<Response48> Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request48SealedHandler
{
	private ValueTask<Response48> Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request49(long Id) : Mediator.IRequest<Response49>, MediatR.IRequest<Response49>;

public sealed record Response49(long Id);

public sealed partial class Request49TraditionalHandler
	: Mediator.IRequestHandler<Request49, Response49>,
	MediatR.IRequestHandler<Request49, Response49>
{
	ValueTask<Response49> Mediator.IRequestHandler<Request49, Response49>.Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response49> MediatR.IRequestHandler<Request49, Response49>.Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request49StaticHandler
{
	private static ValueTask<Response49> Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request49SealedHandler
{
	private ValueTask<Response49> Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request50(long Id) : Mediator.IRequest<Response50>, MediatR.IRequest<Response50>;

public sealed record Response50(long Id);

public sealed partial class Request50TraditionalHandler
	: Mediator.IRequestHandler<Request50, Response50>,
	MediatR.IRequestHandler<Request50, Response50>
{
	ValueTask<Response50> Mediator.IRequestHandler<Request50, Response50>.Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response50> MediatR.IRequestHandler<Request50, Response50>.Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request50StaticHandler
{
	private static ValueTask<Response50> Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request50SealedHandler
{
	private ValueTask<Response50> Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request51(long Id) : Mediator.IRequest<Response51>, MediatR.IRequest<Response51>;

public sealed record Response51(long Id);

public sealed partial class Request51TraditionalHandler
	: Mediator.IRequestHandler<Request51, Response51>,
	MediatR.IRequestHandler<Request51, Response51>
{
	ValueTask<Response51> Mediator.IRequestHandler<Request51, Response51>.Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response51> MediatR.IRequestHandler<Request51, Response51>.Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request51StaticHandler
{
	private static ValueTask<Response51> Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request51SealedHandler
{
	private ValueTask<Response51> Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request52(long Id) : Mediator.IRequest<Response52>, MediatR.IRequest<Response52>;

public sealed record Response52(long Id);

public sealed partial class Request52TraditionalHandler
	: Mediator.IRequestHandler<Request52, Response52>,
	MediatR.IRequestHandler<Request52, Response52>
{
	ValueTask<Response52> Mediator.IRequestHandler<Request52, Response52>.Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response52> MediatR.IRequestHandler<Request52, Response52>.Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request52StaticHandler
{
	private static ValueTask<Response52> Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request52SealedHandler
{
	private ValueTask<Response52> Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request53(long Id) : Mediator.IRequest<Response53>, MediatR.IRequest<Response53>;

public sealed record Response53(long Id);

public sealed partial class Request53TraditionalHandler
	: Mediator.IRequestHandler<Request53, Response53>,
	MediatR.IRequestHandler<Request53, Response53>
{
	ValueTask<Response53> Mediator.IRequestHandler<Request53, Response53>.Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response53> MediatR.IRequestHandler<Request53, Response53>.Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request53StaticHandler
{
	private static ValueTask<Response53> Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request53SealedHandler
{
	private ValueTask<Response53> Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request54(long Id) : Mediator.IRequest<Response54>, MediatR.IRequest<Response54>;

public sealed record Response54(long Id);

public sealed partial class Request54TraditionalHandler
	: Mediator.IRequestHandler<Request54, Response54>,
	MediatR.IRequestHandler<Request54, Response54>
{
	ValueTask<Response54> Mediator.IRequestHandler<Request54, Response54>.Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response54> MediatR.IRequestHandler<Request54, Response54>.Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request54StaticHandler
{
	private static ValueTask<Response54> Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request54SealedHandler
{
	private ValueTask<Response54> Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request55(long Id) : Mediator.IRequest<Response55>, MediatR.IRequest<Response55>;

public sealed record Response55(long Id);

public sealed partial class Request55TraditionalHandler
	: Mediator.IRequestHandler<Request55, Response55>,
	MediatR.IRequestHandler<Request55, Response55>
{
	ValueTask<Response55> Mediator.IRequestHandler<Request55, Response55>.Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response55> MediatR.IRequestHandler<Request55, Response55>.Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request55StaticHandler
{
	private static ValueTask<Response55> Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request55SealedHandler
{
	private ValueTask<Response55> Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request56(long Id) : Mediator.IRequest<Response56>, MediatR.IRequest<Response56>;

public sealed record Response56(long Id);

public sealed partial class Request56TraditionalHandler
	: Mediator.IRequestHandler<Request56, Response56>,
	MediatR.IRequestHandler<Request56, Response56>
{
	ValueTask<Response56> Mediator.IRequestHandler<Request56, Response56>.Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response56> MediatR.IRequestHandler<Request56, Response56>.Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request56StaticHandler
{
	private static ValueTask<Response56> Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request56SealedHandler
{
	private ValueTask<Response56> Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request57(long Id) : Mediator.IRequest<Response57>, MediatR.IRequest<Response57>;

public sealed record Response57(long Id);

public sealed partial class Request57TraditionalHandler
	: Mediator.IRequestHandler<Request57, Response57>,
	MediatR.IRequestHandler<Request57, Response57>
{
	ValueTask<Response57> Mediator.IRequestHandler<Request57, Response57>.Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response57> MediatR.IRequestHandler<Request57, Response57>.Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request57StaticHandler
{
	private static ValueTask<Response57> Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request57SealedHandler
{
	private ValueTask<Response57> Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request58(long Id) : Mediator.IRequest<Response58>, MediatR.IRequest<Response58>;

public sealed record Response58(long Id);

public sealed partial class Request58TraditionalHandler
	: Mediator.IRequestHandler<Request58, Response58>,
	MediatR.IRequestHandler<Request58, Response58>
{
	ValueTask<Response58> Mediator.IRequestHandler<Request58, Response58>.Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response58> MediatR.IRequestHandler<Request58, Response58>.Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request58StaticHandler
{
	private static ValueTask<Response58> Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request58SealedHandler
{
	private ValueTask<Response58> Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request59(long Id) : Mediator.IRequest<Response59>, MediatR.IRequest<Response59>;

public sealed record Response59(long Id);

public sealed partial class Request59TraditionalHandler
	: Mediator.IRequestHandler<Request59, Response59>,
	MediatR.IRequestHandler<Request59, Response59>
{
	ValueTask<Response59> Mediator.IRequestHandler<Request59, Response59>.Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response59> MediatR.IRequestHandler<Request59, Response59>.Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request59StaticHandler
{
	private static ValueTask<Response59> Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request59SealedHandler
{
	private ValueTask<Response59> Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request60(long Id) : Mediator.IRequest<Response60>, MediatR.IRequest<Response60>;

public sealed record Response60(long Id);

public sealed partial class Request60TraditionalHandler
	: Mediator.IRequestHandler<Request60, Response60>,
	MediatR.IRequestHandler<Request60, Response60>
{
	ValueTask<Response60> Mediator.IRequestHandler<Request60, Response60>.Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response60> MediatR.IRequestHandler<Request60, Response60>.Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request60StaticHandler
{
	private static ValueTask<Response60> Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request60SealedHandler
{
	private ValueTask<Response60> Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request61(long Id) : Mediator.IRequest<Response61>, MediatR.IRequest<Response61>;

public sealed record Response61(long Id);

public sealed partial class Request61TraditionalHandler
	: Mediator.IRequestHandler<Request61, Response61>,
	MediatR.IRequestHandler<Request61, Response61>
{
	ValueTask<Response61> Mediator.IRequestHandler<Request61, Response61>.Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response61> MediatR.IRequestHandler<Request61, Response61>.Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request61StaticHandler
{
	private static ValueTask<Response61> Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request61SealedHandler
{
	private ValueTask<Response61> Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request62(long Id) : Mediator.IRequest<Response62>, MediatR.IRequest<Response62>;

public sealed record Response62(long Id);

public sealed partial class Request62TraditionalHandler
	: Mediator.IRequestHandler<Request62, Response62>,
	MediatR.IRequestHandler<Request62, Response62>
{
	ValueTask<Response62> Mediator.IRequestHandler<Request62, Response62>.Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response62> MediatR.IRequestHandler<Request62, Response62>.Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request62StaticHandler
{
	private static ValueTask<Response62> Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request62SealedHandler
{
	private ValueTask<Response62> Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request63(long Id) : Mediator.IRequest<Response63>, MediatR.IRequest<Response63>;

public sealed record Response63(long Id);

public sealed partial class Request63TraditionalHandler
	: Mediator.IRequestHandler<Request63, Response63>,
	MediatR.IRequestHandler<Request63, Response63>
{
	ValueTask<Response63> Mediator.IRequestHandler<Request63, Response63>.Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response63> MediatR.IRequestHandler<Request63, Response63>.Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request63StaticHandler
{
	private static ValueTask<Response63> Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request63SealedHandler
{
	private ValueTask<Response63> Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request64(long Id) : Mediator.IRequest<Response64>, MediatR.IRequest<Response64>;

public sealed record Response64(long Id);

public sealed partial class Request64TraditionalHandler
	: Mediator.IRequestHandler<Request64, Response64>,
	MediatR.IRequestHandler<Request64, Response64>
{
	ValueTask<Response64> Mediator.IRequestHandler<Request64, Response64>.Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response64> MediatR.IRequestHandler<Request64, Response64>.Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request64StaticHandler
{
	private static ValueTask<Response64> Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request64SealedHandler
{
	private ValueTask<Response64> Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request65(long Id) : Mediator.IRequest<Response65>, MediatR.IRequest<Response65>;

public sealed record Response65(long Id);

public sealed partial class Request65TraditionalHandler
	: Mediator.IRequestHandler<Request65, Response65>,
	MediatR.IRequestHandler<Request65, Response65>
{
	ValueTask<Response65> Mediator.IRequestHandler<Request65, Response65>.Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response65> MediatR.IRequestHandler<Request65, Response65>.Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request65StaticHandler
{
	private static ValueTask<Response65> Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request65SealedHandler
{
	private ValueTask<Response65> Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request66(long Id) : Mediator.IRequest<Response66>, MediatR.IRequest<Response66>;

public sealed record Response66(long Id);

public sealed partial class Request66TraditionalHandler
	: Mediator.IRequestHandler<Request66, Response66>,
	MediatR.IRequestHandler<Request66, Response66>
{
	ValueTask<Response66> Mediator.IRequestHandler<Request66, Response66>.Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response66> MediatR.IRequestHandler<Request66, Response66>.Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request66StaticHandler
{
	private static ValueTask<Response66> Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request66SealedHandler
{
	private ValueTask<Response66> Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request67(long Id) : Mediator.IRequest<Response67>, MediatR.IRequest<Response67>;

public sealed record Response67(long Id);

public sealed partial class Request67TraditionalHandler
	: Mediator.IRequestHandler<Request67, Response67>,
	MediatR.IRequestHandler<Request67, Response67>
{
	ValueTask<Response67> Mediator.IRequestHandler<Request67, Response67>.Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response67> MediatR.IRequestHandler<Request67, Response67>.Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request67StaticHandler
{
	private static ValueTask<Response67> Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request67SealedHandler
{
	private ValueTask<Response67> Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request68(long Id) : Mediator.IRequest<Response68>, MediatR.IRequest<Response68>;

public sealed record Response68(long Id);

public sealed partial class Request68TraditionalHandler
	: Mediator.IRequestHandler<Request68, Response68>,
	MediatR.IRequestHandler<Request68, Response68>
{
	ValueTask<Response68> Mediator.IRequestHandler<Request68, Response68>.Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response68> MediatR.IRequestHandler<Request68, Response68>.Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request68StaticHandler
{
	private static ValueTask<Response68> Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request68SealedHandler
{
	private ValueTask<Response68> Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request69(long Id) : Mediator.IRequest<Response69>, MediatR.IRequest<Response69>;

public sealed record Response69(long Id);

public sealed partial class Request69TraditionalHandler
	: Mediator.IRequestHandler<Request69, Response69>,
	MediatR.IRequestHandler<Request69, Response69>
{
	ValueTask<Response69> Mediator.IRequestHandler<Request69, Response69>.Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response69> MediatR.IRequestHandler<Request69, Response69>.Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request69StaticHandler
{
	private static ValueTask<Response69> Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request69SealedHandler
{
	private ValueTask<Response69> Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request70(long Id) : Mediator.IRequest<Response70>, MediatR.IRequest<Response70>;

public sealed record Response70(long Id);

public sealed partial class Request70TraditionalHandler
	: Mediator.IRequestHandler<Request70, Response70>,
	MediatR.IRequestHandler<Request70, Response70>
{
	ValueTask<Response70> Mediator.IRequestHandler<Request70, Response70>.Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response70> MediatR.IRequestHandler<Request70, Response70>.Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request70StaticHandler
{
	private static ValueTask<Response70> Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request70SealedHandler
{
	private ValueTask<Response70> Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request71(long Id) : Mediator.IRequest<Response71>, MediatR.IRequest<Response71>;

public sealed record Response71(long Id);

public sealed partial class Request71TraditionalHandler
	: Mediator.IRequestHandler<Request71, Response71>,
	MediatR.IRequestHandler<Request71, Response71>
{
	ValueTask<Response71> Mediator.IRequestHandler<Request71, Response71>.Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response71> MediatR.IRequestHandler<Request71, Response71>.Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request71StaticHandler
{
	private static ValueTask<Response71> Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request71SealedHandler
{
	private ValueTask<Response71> Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request72(long Id) : Mediator.IRequest<Response72>, MediatR.IRequest<Response72>;

public sealed record Response72(long Id);

public sealed partial class Request72TraditionalHandler
	: Mediator.IRequestHandler<Request72, Response72>,
	MediatR.IRequestHandler<Request72, Response72>
{
	ValueTask<Response72> Mediator.IRequestHandler<Request72, Response72>.Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response72> MediatR.IRequestHandler<Request72, Response72>.Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request72StaticHandler
{
	private static ValueTask<Response72> Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request72SealedHandler
{
	private ValueTask<Response72> Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request73(long Id) : Mediator.IRequest<Response73>, MediatR.IRequest<Response73>;

public sealed record Response73(long Id);

public sealed partial class Request73TraditionalHandler
	: Mediator.IRequestHandler<Request73, Response73>,
	MediatR.IRequestHandler<Request73, Response73>
{
	ValueTask<Response73> Mediator.IRequestHandler<Request73, Response73>.Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response73> MediatR.IRequestHandler<Request73, Response73>.Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request73StaticHandler
{
	private static ValueTask<Response73> Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request73SealedHandler
{
	private ValueTask<Response73> Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request74(long Id) : Mediator.IRequest<Response74>, MediatR.IRequest<Response74>;

public sealed record Response74(long Id);

public sealed partial class Request74TraditionalHandler
	: Mediator.IRequestHandler<Request74, Response74>,
	MediatR.IRequestHandler<Request74, Response74>
{
	ValueTask<Response74> Mediator.IRequestHandler<Request74, Response74>.Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response74> MediatR.IRequestHandler<Request74, Response74>.Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request74StaticHandler
{
	private static ValueTask<Response74> Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request74SealedHandler
{
	private ValueTask<Response74> Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request75(long Id) : Mediator.IRequest<Response75>, MediatR.IRequest<Response75>;

public sealed record Response75(long Id);

public sealed partial class Request75TraditionalHandler
	: Mediator.IRequestHandler<Request75, Response75>,
	MediatR.IRequestHandler<Request75, Response75>
{
	ValueTask<Response75> Mediator.IRequestHandler<Request75, Response75>.Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response75> MediatR.IRequestHandler<Request75, Response75>.Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request75StaticHandler
{
	private static ValueTask<Response75> Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request75SealedHandler
{
	private ValueTask<Response75> Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request76(long Id) : Mediator.IRequest<Response76>, MediatR.IRequest<Response76>;

public sealed record Response76(long Id);

public sealed partial class Request76TraditionalHandler
	: Mediator.IRequestHandler<Request76, Response76>,
	MediatR.IRequestHandler<Request76, Response76>
{
	ValueTask<Response76> Mediator.IRequestHandler<Request76, Response76>.Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response76> MediatR.IRequestHandler<Request76, Response76>.Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request76StaticHandler
{
	private static ValueTask<Response76> Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request76SealedHandler
{
	private ValueTask<Response76> Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request77(long Id) : Mediator.IRequest<Response77>, MediatR.IRequest<Response77>;

public sealed record Response77(long Id);

public sealed partial class Request77TraditionalHandler
	: Mediator.IRequestHandler<Request77, Response77>,
	MediatR.IRequestHandler<Request77, Response77>
{
	ValueTask<Response77> Mediator.IRequestHandler<Request77, Response77>.Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response77> MediatR.IRequestHandler<Request77, Response77>.Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request77StaticHandler
{
	private static ValueTask<Response77> Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request77SealedHandler
{
	private ValueTask<Response77> Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request78(long Id) : Mediator.IRequest<Response78>, MediatR.IRequest<Response78>;

public sealed record Response78(long Id);

public sealed partial class Request78TraditionalHandler
	: Mediator.IRequestHandler<Request78, Response78>,
	MediatR.IRequestHandler<Request78, Response78>
{
	ValueTask<Response78> Mediator.IRequestHandler<Request78, Response78>.Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response78> MediatR.IRequestHandler<Request78, Response78>.Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request78StaticHandler
{
	private static ValueTask<Response78> Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request78SealedHandler
{
	private ValueTask<Response78> Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request79(long Id) : Mediator.IRequest<Response79>, MediatR.IRequest<Response79>;

public sealed record Response79(long Id);

public sealed partial class Request79TraditionalHandler
	: Mediator.IRequestHandler<Request79, Response79>,
	MediatR.IRequestHandler<Request79, Response79>
{
	ValueTask<Response79> Mediator.IRequestHandler<Request79, Response79>.Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response79> MediatR.IRequestHandler<Request79, Response79>.Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request79StaticHandler
{
	private static ValueTask<Response79> Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request79SealedHandler
{
	private ValueTask<Response79> Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request80(long Id) : Mediator.IRequest<Response80>, MediatR.IRequest<Response80>;

public sealed record Response80(long Id);

public sealed partial class Request80TraditionalHandler
	: Mediator.IRequestHandler<Request80, Response80>,
	MediatR.IRequestHandler<Request80, Response80>
{
	ValueTask<Response80> Mediator.IRequestHandler<Request80, Response80>.Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response80> MediatR.IRequestHandler<Request80, Response80>.Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request80StaticHandler
{
	private static ValueTask<Response80> Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request80SealedHandler
{
	private ValueTask<Response80> Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request81(long Id) : Mediator.IRequest<Response81>, MediatR.IRequest<Response81>;

public sealed record Response81(long Id);

public sealed partial class Request81TraditionalHandler
	: Mediator.IRequestHandler<Request81, Response81>,
	MediatR.IRequestHandler<Request81, Response81>
{
	ValueTask<Response81> Mediator.IRequestHandler<Request81, Response81>.Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response81> MediatR.IRequestHandler<Request81, Response81>.Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request81StaticHandler
{
	private static ValueTask<Response81> Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request81SealedHandler
{
	private ValueTask<Response81> Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request82(long Id) : Mediator.IRequest<Response82>, MediatR.IRequest<Response82>;

public sealed record Response82(long Id);

public sealed partial class Request82TraditionalHandler
	: Mediator.IRequestHandler<Request82, Response82>,
	MediatR.IRequestHandler<Request82, Response82>
{
	ValueTask<Response82> Mediator.IRequestHandler<Request82, Response82>.Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response82> MediatR.IRequestHandler<Request82, Response82>.Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request82StaticHandler
{
	private static ValueTask<Response82> Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request82SealedHandler
{
	private ValueTask<Response82> Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request83(long Id) : Mediator.IRequest<Response83>, MediatR.IRequest<Response83>;

public sealed record Response83(long Id);

public sealed partial class Request83TraditionalHandler
	: Mediator.IRequestHandler<Request83, Response83>,
	MediatR.IRequestHandler<Request83, Response83>
{
	ValueTask<Response83> Mediator.IRequestHandler<Request83, Response83>.Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response83> MediatR.IRequestHandler<Request83, Response83>.Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request83StaticHandler
{
	private static ValueTask<Response83> Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request83SealedHandler
{
	private ValueTask<Response83> Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request84(long Id) : Mediator.IRequest<Response84>, MediatR.IRequest<Response84>;

public sealed record Response84(long Id);

public sealed partial class Request84TraditionalHandler
	: Mediator.IRequestHandler<Request84, Response84>,
	MediatR.IRequestHandler<Request84, Response84>
{
	ValueTask<Response84> Mediator.IRequestHandler<Request84, Response84>.Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response84> MediatR.IRequestHandler<Request84, Response84>.Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request84StaticHandler
{
	private static ValueTask<Response84> Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request84SealedHandler
{
	private ValueTask<Response84> Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request85(long Id) : Mediator.IRequest<Response85>, MediatR.IRequest<Response85>;

public sealed record Response85(long Id);

public sealed partial class Request85TraditionalHandler
	: Mediator.IRequestHandler<Request85, Response85>,
	MediatR.IRequestHandler<Request85, Response85>
{
	ValueTask<Response85> Mediator.IRequestHandler<Request85, Response85>.Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response85> MediatR.IRequestHandler<Request85, Response85>.Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request85StaticHandler
{
	private static ValueTask<Response85> Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request85SealedHandler
{
	private ValueTask<Response85> Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request86(long Id) : Mediator.IRequest<Response86>, MediatR.IRequest<Response86>;

public sealed record Response86(long Id);

public sealed partial class Request86TraditionalHandler
	: Mediator.IRequestHandler<Request86, Response86>,
	MediatR.IRequestHandler<Request86, Response86>
{
	ValueTask<Response86> Mediator.IRequestHandler<Request86, Response86>.Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response86> MediatR.IRequestHandler<Request86, Response86>.Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request86StaticHandler
{
	private static ValueTask<Response86> Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request86SealedHandler
{
	private ValueTask<Response86> Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request87(long Id) : Mediator.IRequest<Response87>, MediatR.IRequest<Response87>;

public sealed record Response87(long Id);

public sealed partial class Request87TraditionalHandler
	: Mediator.IRequestHandler<Request87, Response87>,
	MediatR.IRequestHandler<Request87, Response87>
{
	ValueTask<Response87> Mediator.IRequestHandler<Request87, Response87>.Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response87> MediatR.IRequestHandler<Request87, Response87>.Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request87StaticHandler
{
	private static ValueTask<Response87> Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request87SealedHandler
{
	private ValueTask<Response87> Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request88(long Id) : Mediator.IRequest<Response88>, MediatR.IRequest<Response88>;

public sealed record Response88(long Id);

public sealed partial class Request88TraditionalHandler
	: Mediator.IRequestHandler<Request88, Response88>,
	MediatR.IRequestHandler<Request88, Response88>
{
	ValueTask<Response88> Mediator.IRequestHandler<Request88, Response88>.Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response88> MediatR.IRequestHandler<Request88, Response88>.Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request88StaticHandler
{
	private static ValueTask<Response88> Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request88SealedHandler
{
	private ValueTask<Response88> Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request89(long Id) : Mediator.IRequest<Response89>, MediatR.IRequest<Response89>;

public sealed record Response89(long Id);

public sealed partial class Request89TraditionalHandler
	: Mediator.IRequestHandler<Request89, Response89>,
	MediatR.IRequestHandler<Request89, Response89>
{
	ValueTask<Response89> Mediator.IRequestHandler<Request89, Response89>.Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response89> MediatR.IRequestHandler<Request89, Response89>.Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request89StaticHandler
{
	private static ValueTask<Response89> Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request89SealedHandler
{
	private ValueTask<Response89> Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request90(long Id) : Mediator.IRequest<Response90>, MediatR.IRequest<Response90>;

public sealed record Response90(long Id);

public sealed partial class Request90TraditionalHandler
	: Mediator.IRequestHandler<Request90, Response90>,
	MediatR.IRequestHandler<Request90, Response90>
{
	ValueTask<Response90> Mediator.IRequestHandler<Request90, Response90>.Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response90> MediatR.IRequestHandler<Request90, Response90>.Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request90StaticHandler
{
	private static ValueTask<Response90> Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request90SealedHandler
{
	private ValueTask<Response90> Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request91(long Id) : Mediator.IRequest<Response91>, MediatR.IRequest<Response91>;

public sealed record Response91(long Id);

public sealed partial class Request91TraditionalHandler
	: Mediator.IRequestHandler<Request91, Response91>,
	MediatR.IRequestHandler<Request91, Response91>
{
	ValueTask<Response91> Mediator.IRequestHandler<Request91, Response91>.Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response91> MediatR.IRequestHandler<Request91, Response91>.Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request91StaticHandler
{
	private static ValueTask<Response91> Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request91SealedHandler
{
	private ValueTask<Response91> Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request92(long Id) : Mediator.IRequest<Response92>, MediatR.IRequest<Response92>;

public sealed record Response92(long Id);

public sealed partial class Request92TraditionalHandler
	: Mediator.IRequestHandler<Request92, Response92>,
	MediatR.IRequestHandler<Request92, Response92>
{
	ValueTask<Response92> Mediator.IRequestHandler<Request92, Response92>.Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response92> MediatR.IRequestHandler<Request92, Response92>.Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request92StaticHandler
{
	private static ValueTask<Response92> Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request92SealedHandler
{
	private ValueTask<Response92> Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request93(long Id) : Mediator.IRequest<Response93>, MediatR.IRequest<Response93>;

public sealed record Response93(long Id);

public sealed partial class Request93TraditionalHandler
	: Mediator.IRequestHandler<Request93, Response93>,
	MediatR.IRequestHandler<Request93, Response93>
{
	ValueTask<Response93> Mediator.IRequestHandler<Request93, Response93>.Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response93> MediatR.IRequestHandler<Request93, Response93>.Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request93StaticHandler
{
	private static ValueTask<Response93> Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request93SealedHandler
{
	private ValueTask<Response93> Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request94(long Id) : Mediator.IRequest<Response94>, MediatR.IRequest<Response94>;

public sealed record Response94(long Id);

public sealed partial class Request94TraditionalHandler
	: Mediator.IRequestHandler<Request94, Response94>,
	MediatR.IRequestHandler<Request94, Response94>
{
	ValueTask<Response94> Mediator.IRequestHandler<Request94, Response94>.Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response94> MediatR.IRequestHandler<Request94, Response94>.Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request94StaticHandler
{
	private static ValueTask<Response94> Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request94SealedHandler
{
	private ValueTask<Response94> Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request95(long Id) : Mediator.IRequest<Response95>, MediatR.IRequest<Response95>;

public sealed record Response95(long Id);

public sealed partial class Request95TraditionalHandler
	: Mediator.IRequestHandler<Request95, Response95>,
	MediatR.IRequestHandler<Request95, Response95>
{
	ValueTask<Response95> Mediator.IRequestHandler<Request95, Response95>.Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response95> MediatR.IRequestHandler<Request95, Response95>.Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request95StaticHandler
{
	private static ValueTask<Response95> Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request95SealedHandler
{
	private ValueTask<Response95> Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request96(long Id) : Mediator.IRequest<Response96>, MediatR.IRequest<Response96>;

public sealed record Response96(long Id);

public sealed partial class Request96TraditionalHandler
	: Mediator.IRequestHandler<Request96, Response96>,
	MediatR.IRequestHandler<Request96, Response96>
{
	ValueTask<Response96> Mediator.IRequestHandler<Request96, Response96>.Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response96> MediatR.IRequestHandler<Request96, Response96>.Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request96StaticHandler
{
	private static ValueTask<Response96> Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request96SealedHandler
{
	private ValueTask<Response96> Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request97(long Id) : Mediator.IRequest<Response97>, MediatR.IRequest<Response97>;

public sealed record Response97(long Id);

public sealed partial class Request97TraditionalHandler
	: Mediator.IRequestHandler<Request97, Response97>,
	MediatR.IRequestHandler<Request97, Response97>
{
	ValueTask<Response97> Mediator.IRequestHandler<Request97, Response97>.Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response97> MediatR.IRequestHandler<Request97, Response97>.Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request97StaticHandler
{
	private static ValueTask<Response97> Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request97SealedHandler
{
	private ValueTask<Response97> Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request98(long Id) : Mediator.IRequest<Response98>, MediatR.IRequest<Response98>;

public sealed record Response98(long Id);

public sealed partial class Request98TraditionalHandler
	: Mediator.IRequestHandler<Request98, Response98>,
	MediatR.IRequestHandler<Request98, Response98>
{
	ValueTask<Response98> Mediator.IRequestHandler<Request98, Response98>.Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response98> MediatR.IRequestHandler<Request98, Response98>.Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request98StaticHandler
{
	private static ValueTask<Response98> Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request98SealedHandler
{
	private ValueTask<Response98> Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request99(long Id) : Mediator.IRequest<Response99>, MediatR.IRequest<Response99>;

public sealed record Response99(long Id);

public sealed partial class Request99TraditionalHandler
	: Mediator.IRequestHandler<Request99, Response99>,
	MediatR.IRequestHandler<Request99, Response99>
{
	ValueTask<Response99> Mediator.IRequestHandler<Request99, Response99>.Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response99> MediatR.IRequestHandler<Request99, Response99>.Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request99StaticHandler
{
	private static ValueTask<Response99> Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request99SealedHandler
{
	private ValueTask<Response99> Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request100(long Id) : Mediator.IRequest<Response100>, MediatR.IRequest<Response100>;

public sealed record Response100(long Id);

public sealed partial class Request100TraditionalHandler
	: Mediator.IRequestHandler<Request100, Response100>,
	MediatR.IRequestHandler<Request100, Response100>
{
	ValueTask<Response100> Mediator.IRequestHandler<Request100, Response100>.Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response100> MediatR.IRequestHandler<Request100, Response100>.Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request100StaticHandler
{
	private static ValueTask<Response100> Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request100SealedHandler
{
	private ValueTask<Response100> Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request101(long Id) : Mediator.IRequest<Response101>, MediatR.IRequest<Response101>;

public sealed record Response101(long Id);

public sealed partial class Request101TraditionalHandler
	: Mediator.IRequestHandler<Request101, Response101>,
	MediatR.IRequestHandler<Request101, Response101>
{
	ValueTask<Response101> Mediator.IRequestHandler<Request101, Response101>.Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response101> MediatR.IRequestHandler<Request101, Response101>.Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request101StaticHandler
{
	private static ValueTask<Response101> Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request101SealedHandler
{
	private ValueTask<Response101> Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request102(long Id) : Mediator.IRequest<Response102>, MediatR.IRequest<Response102>;

public sealed record Response102(long Id);

public sealed partial class Request102TraditionalHandler
	: Mediator.IRequestHandler<Request102, Response102>,
	MediatR.IRequestHandler<Request102, Response102>
{
	ValueTask<Response102> Mediator.IRequestHandler<Request102, Response102>.Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response102> MediatR.IRequestHandler<Request102, Response102>.Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request102StaticHandler
{
	private static ValueTask<Response102> Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request102SealedHandler
{
	private ValueTask<Response102> Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request103(long Id) : Mediator.IRequest<Response103>, MediatR.IRequest<Response103>;

public sealed record Response103(long Id);

public sealed partial class Request103TraditionalHandler
	: Mediator.IRequestHandler<Request103, Response103>,
	MediatR.IRequestHandler<Request103, Response103>
{
	ValueTask<Response103> Mediator.IRequestHandler<Request103, Response103>.Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response103> MediatR.IRequestHandler<Request103, Response103>.Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request103StaticHandler
{
	private static ValueTask<Response103> Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request103SealedHandler
{
	private ValueTask<Response103> Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request104(long Id) : Mediator.IRequest<Response104>, MediatR.IRequest<Response104>;

public sealed record Response104(long Id);

public sealed partial class Request104TraditionalHandler
	: Mediator.IRequestHandler<Request104, Response104>,
	MediatR.IRequestHandler<Request104, Response104>
{
	ValueTask<Response104> Mediator.IRequestHandler<Request104, Response104>.Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response104> MediatR.IRequestHandler<Request104, Response104>.Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request104StaticHandler
{
	private static ValueTask<Response104> Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request104SealedHandler
{
	private ValueTask<Response104> Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request105(long Id) : Mediator.IRequest<Response105>, MediatR.IRequest<Response105>;

public sealed record Response105(long Id);

public sealed partial class Request105TraditionalHandler
	: Mediator.IRequestHandler<Request105, Response105>,
	MediatR.IRequestHandler<Request105, Response105>
{
	ValueTask<Response105> Mediator.IRequestHandler<Request105, Response105>.Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response105> MediatR.IRequestHandler<Request105, Response105>.Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request105StaticHandler
{
	private static ValueTask<Response105> Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request105SealedHandler
{
	private ValueTask<Response105> Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request106(long Id) : Mediator.IRequest<Response106>, MediatR.IRequest<Response106>;

public sealed record Response106(long Id);

public sealed partial class Request106TraditionalHandler
	: Mediator.IRequestHandler<Request106, Response106>,
	MediatR.IRequestHandler<Request106, Response106>
{
	ValueTask<Response106> Mediator.IRequestHandler<Request106, Response106>.Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response106> MediatR.IRequestHandler<Request106, Response106>.Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request106StaticHandler
{
	private static ValueTask<Response106> Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request106SealedHandler
{
	private ValueTask<Response106> Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request107(long Id) : Mediator.IRequest<Response107>, MediatR.IRequest<Response107>;

public sealed record Response107(long Id);

public sealed partial class Request107TraditionalHandler
	: Mediator.IRequestHandler<Request107, Response107>,
	MediatR.IRequestHandler<Request107, Response107>
{
	ValueTask<Response107> Mediator.IRequestHandler<Request107, Response107>.Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response107> MediatR.IRequestHandler<Request107, Response107>.Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request107StaticHandler
{
	private static ValueTask<Response107> Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request107SealedHandler
{
	private ValueTask<Response107> Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request108(long Id) : Mediator.IRequest<Response108>, MediatR.IRequest<Response108>;

public sealed record Response108(long Id);

public sealed partial class Request108TraditionalHandler
	: Mediator.IRequestHandler<Request108, Response108>,
	MediatR.IRequestHandler<Request108, Response108>
{
	ValueTask<Response108> Mediator.IRequestHandler<Request108, Response108>.Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response108> MediatR.IRequestHandler<Request108, Response108>.Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request108StaticHandler
{
	private static ValueTask<Response108> Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request108SealedHandler
{
	private ValueTask<Response108> Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request109(long Id) : Mediator.IRequest<Response109>, MediatR.IRequest<Response109>;

public sealed record Response109(long Id);

public sealed partial class Request109TraditionalHandler
	: Mediator.IRequestHandler<Request109, Response109>,
	MediatR.IRequestHandler<Request109, Response109>
{
	ValueTask<Response109> Mediator.IRequestHandler<Request109, Response109>.Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response109> MediatR.IRequestHandler<Request109, Response109>.Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request109StaticHandler
{
	private static ValueTask<Response109> Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request109SealedHandler
{
	private ValueTask<Response109> Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request110(long Id) : Mediator.IRequest<Response110>, MediatR.IRequest<Response110>;

public sealed record Response110(long Id);

public sealed partial class Request110TraditionalHandler
	: Mediator.IRequestHandler<Request110, Response110>,
	MediatR.IRequestHandler<Request110, Response110>
{
	ValueTask<Response110> Mediator.IRequestHandler<Request110, Response110>.Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response110> MediatR.IRequestHandler<Request110, Response110>.Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request110StaticHandler
{
	private static ValueTask<Response110> Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request110SealedHandler
{
	private ValueTask<Response110> Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request111(long Id) : Mediator.IRequest<Response111>, MediatR.IRequest<Response111>;

public sealed record Response111(long Id);

public sealed partial class Request111TraditionalHandler
	: Mediator.IRequestHandler<Request111, Response111>,
	MediatR.IRequestHandler<Request111, Response111>
{
	ValueTask<Response111> Mediator.IRequestHandler<Request111, Response111>.Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response111> MediatR.IRequestHandler<Request111, Response111>.Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request111StaticHandler
{
	private static ValueTask<Response111> Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request111SealedHandler
{
	private ValueTask<Response111> Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request112(long Id) : Mediator.IRequest<Response112>, MediatR.IRequest<Response112>;

public sealed record Response112(long Id);

public sealed partial class Request112TraditionalHandler
	: Mediator.IRequestHandler<Request112, Response112>,
	MediatR.IRequestHandler<Request112, Response112>
{
	ValueTask<Response112> Mediator.IRequestHandler<Request112, Response112>.Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response112> MediatR.IRequestHandler<Request112, Response112>.Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request112StaticHandler
{
	private static ValueTask<Response112> Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request112SealedHandler
{
	private ValueTask<Response112> Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request113(long Id) : Mediator.IRequest<Response113>, MediatR.IRequest<Response113>;

public sealed record Response113(long Id);

public sealed partial class Request113TraditionalHandler
	: Mediator.IRequestHandler<Request113, Response113>,
	MediatR.IRequestHandler<Request113, Response113>
{
	ValueTask<Response113> Mediator.IRequestHandler<Request113, Response113>.Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response113> MediatR.IRequestHandler<Request113, Response113>.Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request113StaticHandler
{
	private static ValueTask<Response113> Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request113SealedHandler
{
	private ValueTask<Response113> Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request114(long Id) : Mediator.IRequest<Response114>, MediatR.IRequest<Response114>;

public sealed record Response114(long Id);

public sealed partial class Request114TraditionalHandler
	: Mediator.IRequestHandler<Request114, Response114>,
	MediatR.IRequestHandler<Request114, Response114>
{
	ValueTask<Response114> Mediator.IRequestHandler<Request114, Response114>.Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response114> MediatR.IRequestHandler<Request114, Response114>.Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request114StaticHandler
{
	private static ValueTask<Response114> Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request114SealedHandler
{
	private ValueTask<Response114> Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request115(long Id) : Mediator.IRequest<Response115>, MediatR.IRequest<Response115>;

public sealed record Response115(long Id);

public sealed partial class Request115TraditionalHandler
	: Mediator.IRequestHandler<Request115, Response115>,
	MediatR.IRequestHandler<Request115, Response115>
{
	ValueTask<Response115> Mediator.IRequestHandler<Request115, Response115>.Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response115> MediatR.IRequestHandler<Request115, Response115>.Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request115StaticHandler
{
	private static ValueTask<Response115> Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request115SealedHandler
{
	private ValueTask<Response115> Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request116(long Id) : Mediator.IRequest<Response116>, MediatR.IRequest<Response116>;

public sealed record Response116(long Id);

public sealed partial class Request116TraditionalHandler
	: Mediator.IRequestHandler<Request116, Response116>,
	MediatR.IRequestHandler<Request116, Response116>
{
	ValueTask<Response116> Mediator.IRequestHandler<Request116, Response116>.Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response116> MediatR.IRequestHandler<Request116, Response116>.Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request116StaticHandler
{
	private static ValueTask<Response116> Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request116SealedHandler
{
	private ValueTask<Response116> Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request117(long Id) : Mediator.IRequest<Response117>, MediatR.IRequest<Response117>;

public sealed record Response117(long Id);

public sealed partial class Request117TraditionalHandler
	: Mediator.IRequestHandler<Request117, Response117>,
	MediatR.IRequestHandler<Request117, Response117>
{
	ValueTask<Response117> Mediator.IRequestHandler<Request117, Response117>.Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response117> MediatR.IRequestHandler<Request117, Response117>.Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request117StaticHandler
{
	private static ValueTask<Response117> Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request117SealedHandler
{
	private ValueTask<Response117> Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request118(long Id) : Mediator.IRequest<Response118>, MediatR.IRequest<Response118>;

public sealed record Response118(long Id);

public sealed partial class Request118TraditionalHandler
	: Mediator.IRequestHandler<Request118, Response118>,
	MediatR.IRequestHandler<Request118, Response118>
{
	ValueTask<Response118> Mediator.IRequestHandler<Request118, Response118>.Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response118> MediatR.IRequestHandler<Request118, Response118>.Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request118StaticHandler
{
	private static ValueTask<Response118> Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request118SealedHandler
{
	private ValueTask<Response118> Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request119(long Id) : Mediator.IRequest<Response119>, MediatR.IRequest<Response119>;

public sealed record Response119(long Id);

public sealed partial class Request119TraditionalHandler
	: Mediator.IRequestHandler<Request119, Response119>,
	MediatR.IRequestHandler<Request119, Response119>
{
	ValueTask<Response119> Mediator.IRequestHandler<Request119, Response119>.Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response119> MediatR.IRequestHandler<Request119, Response119>.Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request119StaticHandler
{
	private static ValueTask<Response119> Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request119SealedHandler
{
	private ValueTask<Response119> Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request120(long Id) : Mediator.IRequest<Response120>, MediatR.IRequest<Response120>;

public sealed record Response120(long Id);

public sealed partial class Request120TraditionalHandler
	: Mediator.IRequestHandler<Request120, Response120>,
	MediatR.IRequestHandler<Request120, Response120>
{
	ValueTask<Response120> Mediator.IRequestHandler<Request120, Response120>.Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response120> MediatR.IRequestHandler<Request120, Response120>.Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request120StaticHandler
{
	private static ValueTask<Response120> Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request120SealedHandler
{
	private ValueTask<Response120> Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request121(long Id) : Mediator.IRequest<Response121>, MediatR.IRequest<Response121>;

public sealed record Response121(long Id);

public sealed partial class Request121TraditionalHandler
	: Mediator.IRequestHandler<Request121, Response121>,
	MediatR.IRequestHandler<Request121, Response121>
{
	ValueTask<Response121> Mediator.IRequestHandler<Request121, Response121>.Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response121> MediatR.IRequestHandler<Request121, Response121>.Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request121StaticHandler
{
	private static ValueTask<Response121> Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request121SealedHandler
{
	private ValueTask<Response121> Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request122(long Id) : Mediator.IRequest<Response122>, MediatR.IRequest<Response122>;

public sealed record Response122(long Id);

public sealed partial class Request122TraditionalHandler
	: Mediator.IRequestHandler<Request122, Response122>,
	MediatR.IRequestHandler<Request122, Response122>
{
	ValueTask<Response122> Mediator.IRequestHandler<Request122, Response122>.Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response122> MediatR.IRequestHandler<Request122, Response122>.Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request122StaticHandler
{
	private static ValueTask<Response122> Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request122SealedHandler
{
	private ValueTask<Response122> Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request123(long Id) : Mediator.IRequest<Response123>, MediatR.IRequest<Response123>;

public sealed record Response123(long Id);

public sealed partial class Request123TraditionalHandler
	: Mediator.IRequestHandler<Request123, Response123>,
	MediatR.IRequestHandler<Request123, Response123>
{
	ValueTask<Response123> Mediator.IRequestHandler<Request123, Response123>.Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response123> MediatR.IRequestHandler<Request123, Response123>.Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request123StaticHandler
{
	private static ValueTask<Response123> Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request123SealedHandler
{
	private ValueTask<Response123> Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request124(long Id) : Mediator.IRequest<Response124>, MediatR.IRequest<Response124>;

public sealed record Response124(long Id);

public sealed partial class Request124TraditionalHandler
	: Mediator.IRequestHandler<Request124, Response124>,
	MediatR.IRequestHandler<Request124, Response124>
{
	ValueTask<Response124> Mediator.IRequestHandler<Request124, Response124>.Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response124> MediatR.IRequestHandler<Request124, Response124>.Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request124StaticHandler
{
	private static ValueTask<Response124> Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request124SealedHandler
{
	private ValueTask<Response124> Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request125(long Id) : Mediator.IRequest<Response125>, MediatR.IRequest<Response125>;

public sealed record Response125(long Id);

public sealed partial class Request125TraditionalHandler
	: Mediator.IRequestHandler<Request125, Response125>,
	MediatR.IRequestHandler<Request125, Response125>
{
	ValueTask<Response125> Mediator.IRequestHandler<Request125, Response125>.Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response125> MediatR.IRequestHandler<Request125, Response125>.Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request125StaticHandler
{
	private static ValueTask<Response125> Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request125SealedHandler
{
	private ValueTask<Response125> Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request126(long Id) : Mediator.IRequest<Response126>, MediatR.IRequest<Response126>;

public sealed record Response126(long Id);

public sealed partial class Request126TraditionalHandler
	: Mediator.IRequestHandler<Request126, Response126>,
	MediatR.IRequestHandler<Request126, Response126>
{
	ValueTask<Response126> Mediator.IRequestHandler<Request126, Response126>.Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response126> MediatR.IRequestHandler<Request126, Response126>.Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request126StaticHandler
{
	private static ValueTask<Response126> Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request126SealedHandler
{
	private ValueTask<Response126> Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request127(long Id) : Mediator.IRequest<Response127>, MediatR.IRequest<Response127>;

public sealed record Response127(long Id);

public sealed partial class Request127TraditionalHandler
	: Mediator.IRequestHandler<Request127, Response127>,
	MediatR.IRequestHandler<Request127, Response127>
{
	ValueTask<Response127> Mediator.IRequestHandler<Request127, Response127>.Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response127> MediatR.IRequestHandler<Request127, Response127>.Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request127StaticHandler
{
	private static ValueTask<Response127> Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request127SealedHandler
{
	private ValueTask<Response127> Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request128(long Id) : Mediator.IRequest<Response128>, MediatR.IRequest<Response128>;

public sealed record Response128(long Id);

public sealed partial class Request128TraditionalHandler
	: Mediator.IRequestHandler<Request128, Response128>,
	MediatR.IRequestHandler<Request128, Response128>
{
	ValueTask<Response128> Mediator.IRequestHandler<Request128, Response128>.Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response128> MediatR.IRequestHandler<Request128, Response128>.Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request128StaticHandler
{
	private static ValueTask<Response128> Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request128SealedHandler
{
	private ValueTask<Response128> Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request129(long Id) : Mediator.IRequest<Response129>, MediatR.IRequest<Response129>;

public sealed record Response129(long Id);

public sealed partial class Request129TraditionalHandler
	: Mediator.IRequestHandler<Request129, Response129>,
	MediatR.IRequestHandler<Request129, Response129>
{
	ValueTask<Response129> Mediator.IRequestHandler<Request129, Response129>.Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response129> MediatR.IRequestHandler<Request129, Response129>.Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request129StaticHandler
{
	private static ValueTask<Response129> Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request129SealedHandler
{
	private ValueTask<Response129> Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request130(long Id) : Mediator.IRequest<Response130>, MediatR.IRequest<Response130>;

public sealed record Response130(long Id);

public sealed partial class Request130TraditionalHandler
	: Mediator.IRequestHandler<Request130, Response130>,
	MediatR.IRequestHandler<Request130, Response130>
{
	ValueTask<Response130> Mediator.IRequestHandler<Request130, Response130>.Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response130> MediatR.IRequestHandler<Request130, Response130>.Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request130StaticHandler
{
	private static ValueTask<Response130> Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request130SealedHandler
{
	private ValueTask<Response130> Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request131(long Id) : Mediator.IRequest<Response131>, MediatR.IRequest<Response131>;

public sealed record Response131(long Id);

public sealed partial class Request131TraditionalHandler
	: Mediator.IRequestHandler<Request131, Response131>,
	MediatR.IRequestHandler<Request131, Response131>
{
	ValueTask<Response131> Mediator.IRequestHandler<Request131, Response131>.Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response131> MediatR.IRequestHandler<Request131, Response131>.Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request131StaticHandler
{
	private static ValueTask<Response131> Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request131SealedHandler
{
	private ValueTask<Response131> Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request132(long Id) : Mediator.IRequest<Response132>, MediatR.IRequest<Response132>;

public sealed record Response132(long Id);

public sealed partial class Request132TraditionalHandler
	: Mediator.IRequestHandler<Request132, Response132>,
	MediatR.IRequestHandler<Request132, Response132>
{
	ValueTask<Response132> Mediator.IRequestHandler<Request132, Response132>.Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response132> MediatR.IRequestHandler<Request132, Response132>.Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request132StaticHandler
{
	private static ValueTask<Response132> Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request132SealedHandler
{
	private ValueTask<Response132> Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request133(long Id) : Mediator.IRequest<Response133>, MediatR.IRequest<Response133>;

public sealed record Response133(long Id);

public sealed partial class Request133TraditionalHandler
	: Mediator.IRequestHandler<Request133, Response133>,
	MediatR.IRequestHandler<Request133, Response133>
{
	ValueTask<Response133> Mediator.IRequestHandler<Request133, Response133>.Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response133> MediatR.IRequestHandler<Request133, Response133>.Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request133StaticHandler
{
	private static ValueTask<Response133> Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request133SealedHandler
{
	private ValueTask<Response133> Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request134(long Id) : Mediator.IRequest<Response134>, MediatR.IRequest<Response134>;

public sealed record Response134(long Id);

public sealed partial class Request134TraditionalHandler
	: Mediator.IRequestHandler<Request134, Response134>,
	MediatR.IRequestHandler<Request134, Response134>
{
	ValueTask<Response134> Mediator.IRequestHandler<Request134, Response134>.Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response134> MediatR.IRequestHandler<Request134, Response134>.Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request134StaticHandler
{
	private static ValueTask<Response134> Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request134SealedHandler
{
	private ValueTask<Response134> Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request135(long Id) : Mediator.IRequest<Response135>, MediatR.IRequest<Response135>;

public sealed record Response135(long Id);

public sealed partial class Request135TraditionalHandler
	: Mediator.IRequestHandler<Request135, Response135>,
	MediatR.IRequestHandler<Request135, Response135>
{
	ValueTask<Response135> Mediator.IRequestHandler<Request135, Response135>.Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response135> MediatR.IRequestHandler<Request135, Response135>.Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request135StaticHandler
{
	private static ValueTask<Response135> Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request135SealedHandler
{
	private ValueTask<Response135> Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request136(long Id) : Mediator.IRequest<Response136>, MediatR.IRequest<Response136>;

public sealed record Response136(long Id);

public sealed partial class Request136TraditionalHandler
	: Mediator.IRequestHandler<Request136, Response136>,
	MediatR.IRequestHandler<Request136, Response136>
{
	ValueTask<Response136> Mediator.IRequestHandler<Request136, Response136>.Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response136> MediatR.IRequestHandler<Request136, Response136>.Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request136StaticHandler
{
	private static ValueTask<Response136> Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request136SealedHandler
{
	private ValueTask<Response136> Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request137(long Id) : Mediator.IRequest<Response137>, MediatR.IRequest<Response137>;

public sealed record Response137(long Id);

public sealed partial class Request137TraditionalHandler
	: Mediator.IRequestHandler<Request137, Response137>,
	MediatR.IRequestHandler<Request137, Response137>
{
	ValueTask<Response137> Mediator.IRequestHandler<Request137, Response137>.Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response137> MediatR.IRequestHandler<Request137, Response137>.Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request137StaticHandler
{
	private static ValueTask<Response137> Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request137SealedHandler
{
	private ValueTask<Response137> Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request138(long Id) : Mediator.IRequest<Response138>, MediatR.IRequest<Response138>;

public sealed record Response138(long Id);

public sealed partial class Request138TraditionalHandler
	: Mediator.IRequestHandler<Request138, Response138>,
	MediatR.IRequestHandler<Request138, Response138>
{
	ValueTask<Response138> Mediator.IRequestHandler<Request138, Response138>.Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response138> MediatR.IRequestHandler<Request138, Response138>.Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request138StaticHandler
{
	private static ValueTask<Response138> Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request138SealedHandler
{
	private ValueTask<Response138> Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request139(long Id) : Mediator.IRequest<Response139>, MediatR.IRequest<Response139>;

public sealed record Response139(long Id);

public sealed partial class Request139TraditionalHandler
	: Mediator.IRequestHandler<Request139, Response139>,
	MediatR.IRequestHandler<Request139, Response139>
{
	ValueTask<Response139> Mediator.IRequestHandler<Request139, Response139>.Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response139> MediatR.IRequestHandler<Request139, Response139>.Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request139StaticHandler
{
	private static ValueTask<Response139> Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request139SealedHandler
{
	private ValueTask<Response139> Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request140(long Id) : Mediator.IRequest<Response140>, MediatR.IRequest<Response140>;

public sealed record Response140(long Id);

public sealed partial class Request140TraditionalHandler
	: Mediator.IRequestHandler<Request140, Response140>,
	MediatR.IRequestHandler<Request140, Response140>
{
	ValueTask<Response140> Mediator.IRequestHandler<Request140, Response140>.Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response140> MediatR.IRequestHandler<Request140, Response140>.Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request140StaticHandler
{
	private static ValueTask<Response140> Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request140SealedHandler
{
	private ValueTask<Response140> Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request141(long Id) : Mediator.IRequest<Response141>, MediatR.IRequest<Response141>;

public sealed record Response141(long Id);

public sealed partial class Request141TraditionalHandler
	: Mediator.IRequestHandler<Request141, Response141>,
	MediatR.IRequestHandler<Request141, Response141>
{
	ValueTask<Response141> Mediator.IRequestHandler<Request141, Response141>.Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response141> MediatR.IRequestHandler<Request141, Response141>.Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request141StaticHandler
{
	private static ValueTask<Response141> Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request141SealedHandler
{
	private ValueTask<Response141> Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request142(long Id) : Mediator.IRequest<Response142>, MediatR.IRequest<Response142>;

public sealed record Response142(long Id);

public sealed partial class Request142TraditionalHandler
	: Mediator.IRequestHandler<Request142, Response142>,
	MediatR.IRequestHandler<Request142, Response142>
{
	ValueTask<Response142> Mediator.IRequestHandler<Request142, Response142>.Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response142> MediatR.IRequestHandler<Request142, Response142>.Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request142StaticHandler
{
	private static ValueTask<Response142> Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request142SealedHandler
{
	private ValueTask<Response142> Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request143(long Id) : Mediator.IRequest<Response143>, MediatR.IRequest<Response143>;

public sealed record Response143(long Id);

public sealed partial class Request143TraditionalHandler
	: Mediator.IRequestHandler<Request143, Response143>,
	MediatR.IRequestHandler<Request143, Response143>
{
	ValueTask<Response143> Mediator.IRequestHandler<Request143, Response143>.Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response143> MediatR.IRequestHandler<Request143, Response143>.Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request143StaticHandler
{
	private static ValueTask<Response143> Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request143SealedHandler
{
	private ValueTask<Response143> Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request144(long Id) : Mediator.IRequest<Response144>, MediatR.IRequest<Response144>;

public sealed record Response144(long Id);

public sealed partial class Request144TraditionalHandler
	: Mediator.IRequestHandler<Request144, Response144>,
	MediatR.IRequestHandler<Request144, Response144>
{
	ValueTask<Response144> Mediator.IRequestHandler<Request144, Response144>.Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response144> MediatR.IRequestHandler<Request144, Response144>.Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request144StaticHandler
{
	private static ValueTask<Response144> Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request144SealedHandler
{
	private ValueTask<Response144> Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request145(long Id) : Mediator.IRequest<Response145>, MediatR.IRequest<Response145>;

public sealed record Response145(long Id);

public sealed partial class Request145TraditionalHandler
	: Mediator.IRequestHandler<Request145, Response145>,
	MediatR.IRequestHandler<Request145, Response145>
{
	ValueTask<Response145> Mediator.IRequestHandler<Request145, Response145>.Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response145> MediatR.IRequestHandler<Request145, Response145>.Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request145StaticHandler
{
	private static ValueTask<Response145> Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request145SealedHandler
{
	private ValueTask<Response145> Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request146(long Id) : Mediator.IRequest<Response146>, MediatR.IRequest<Response146>;

public sealed record Response146(long Id);

public sealed partial class Request146TraditionalHandler
	: Mediator.IRequestHandler<Request146, Response146>,
	MediatR.IRequestHandler<Request146, Response146>
{
	ValueTask<Response146> Mediator.IRequestHandler<Request146, Response146>.Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response146> MediatR.IRequestHandler<Request146, Response146>.Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request146StaticHandler
{
	private static ValueTask<Response146> Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request146SealedHandler
{
	private ValueTask<Response146> Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request147(long Id) : Mediator.IRequest<Response147>, MediatR.IRequest<Response147>;

public sealed record Response147(long Id);

public sealed partial class Request147TraditionalHandler
	: Mediator.IRequestHandler<Request147, Response147>,
	MediatR.IRequestHandler<Request147, Response147>
{
	ValueTask<Response147> Mediator.IRequestHandler<Request147, Response147>.Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response147> MediatR.IRequestHandler<Request147, Response147>.Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request147StaticHandler
{
	private static ValueTask<Response147> Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request147SealedHandler
{
	private ValueTask<Response147> Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request148(long Id) : Mediator.IRequest<Response148>, MediatR.IRequest<Response148>;

public sealed record Response148(long Id);

public sealed partial class Request148TraditionalHandler
	: Mediator.IRequestHandler<Request148, Response148>,
	MediatR.IRequestHandler<Request148, Response148>
{
	ValueTask<Response148> Mediator.IRequestHandler<Request148, Response148>.Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response148> MediatR.IRequestHandler<Request148, Response148>.Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request148StaticHandler
{
	private static ValueTask<Response148> Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request148SealedHandler
{
	private ValueTask<Response148> Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request149(long Id) : Mediator.IRequest<Response149>, MediatR.IRequest<Response149>;

public sealed record Response149(long Id);

public sealed partial class Request149TraditionalHandler
	: Mediator.IRequestHandler<Request149, Response149>,
	MediatR.IRequestHandler<Request149, Response149>
{
	ValueTask<Response149> Mediator.IRequestHandler<Request149, Response149>.Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response149> MediatR.IRequestHandler<Request149, Response149>.Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request149StaticHandler
{
	private static ValueTask<Response149> Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request149SealedHandler
{
	private ValueTask<Response149> Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request150(long Id) : Mediator.IRequest<Response150>, MediatR.IRequest<Response150>;

public sealed record Response150(long Id);

public sealed partial class Request150TraditionalHandler
	: Mediator.IRequestHandler<Request150, Response150>,
	MediatR.IRequestHandler<Request150, Response150>
{
	ValueTask<Response150> Mediator.IRequestHandler<Request150, Response150>.Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response150> MediatR.IRequestHandler<Request150, Response150>.Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request150StaticHandler
{
	private static ValueTask<Response150> Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request150SealedHandler
{
	private ValueTask<Response150> Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request151(long Id) : Mediator.IRequest<Response151>, MediatR.IRequest<Response151>;

public sealed record Response151(long Id);

public sealed partial class Request151TraditionalHandler
	: Mediator.IRequestHandler<Request151, Response151>,
	MediatR.IRequestHandler<Request151, Response151>
{
	ValueTask<Response151> Mediator.IRequestHandler<Request151, Response151>.Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response151> MediatR.IRequestHandler<Request151, Response151>.Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request151StaticHandler
{
	private static ValueTask<Response151> Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request151SealedHandler
{
	private ValueTask<Response151> Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request152(long Id) : Mediator.IRequest<Response152>, MediatR.IRequest<Response152>;

public sealed record Response152(long Id);

public sealed partial class Request152TraditionalHandler
	: Mediator.IRequestHandler<Request152, Response152>,
	MediatR.IRequestHandler<Request152, Response152>
{
	ValueTask<Response152> Mediator.IRequestHandler<Request152, Response152>.Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response152> MediatR.IRequestHandler<Request152, Response152>.Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request152StaticHandler
{
	private static ValueTask<Response152> Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request152SealedHandler
{
	private ValueTask<Response152> Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request153(long Id) : Mediator.IRequest<Response153>, MediatR.IRequest<Response153>;

public sealed record Response153(long Id);

public sealed partial class Request153TraditionalHandler
	: Mediator.IRequestHandler<Request153, Response153>,
	MediatR.IRequestHandler<Request153, Response153>
{
	ValueTask<Response153> Mediator.IRequestHandler<Request153, Response153>.Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response153> MediatR.IRequestHandler<Request153, Response153>.Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request153StaticHandler
{
	private static ValueTask<Response153> Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request153SealedHandler
{
	private ValueTask<Response153> Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request154(long Id) : Mediator.IRequest<Response154>, MediatR.IRequest<Response154>;

public sealed record Response154(long Id);

public sealed partial class Request154TraditionalHandler
	: Mediator.IRequestHandler<Request154, Response154>,
	MediatR.IRequestHandler<Request154, Response154>
{
	ValueTask<Response154> Mediator.IRequestHandler<Request154, Response154>.Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response154> MediatR.IRequestHandler<Request154, Response154>.Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request154StaticHandler
{
	private static ValueTask<Response154> Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request154SealedHandler
{
	private ValueTask<Response154> Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request155(long Id) : Mediator.IRequest<Response155>, MediatR.IRequest<Response155>;

public sealed record Response155(long Id);

public sealed partial class Request155TraditionalHandler
	: Mediator.IRequestHandler<Request155, Response155>,
	MediatR.IRequestHandler<Request155, Response155>
{
	ValueTask<Response155> Mediator.IRequestHandler<Request155, Response155>.Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response155> MediatR.IRequestHandler<Request155, Response155>.Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request155StaticHandler
{
	private static ValueTask<Response155> Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request155SealedHandler
{
	private ValueTask<Response155> Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request156(long Id) : Mediator.IRequest<Response156>, MediatR.IRequest<Response156>;

public sealed record Response156(long Id);

public sealed partial class Request156TraditionalHandler
	: Mediator.IRequestHandler<Request156, Response156>,
	MediatR.IRequestHandler<Request156, Response156>
{
	ValueTask<Response156> Mediator.IRequestHandler<Request156, Response156>.Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response156> MediatR.IRequestHandler<Request156, Response156>.Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request156StaticHandler
{
	private static ValueTask<Response156> Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request156SealedHandler
{
	private ValueTask<Response156> Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request157(long Id) : Mediator.IRequest<Response157>, MediatR.IRequest<Response157>;

public sealed record Response157(long Id);

public sealed partial class Request157TraditionalHandler
	: Mediator.IRequestHandler<Request157, Response157>,
	MediatR.IRequestHandler<Request157, Response157>
{
	ValueTask<Response157> Mediator.IRequestHandler<Request157, Response157>.Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response157> MediatR.IRequestHandler<Request157, Response157>.Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request157StaticHandler
{
	private static ValueTask<Response157> Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request157SealedHandler
{
	private ValueTask<Response157> Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request158(long Id) : Mediator.IRequest<Response158>, MediatR.IRequest<Response158>;

public sealed record Response158(long Id);

public sealed partial class Request158TraditionalHandler
	: Mediator.IRequestHandler<Request158, Response158>,
	MediatR.IRequestHandler<Request158, Response158>
{
	ValueTask<Response158> Mediator.IRequestHandler<Request158, Response158>.Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response158> MediatR.IRequestHandler<Request158, Response158>.Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request158StaticHandler
{
	private static ValueTask<Response158> Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request158SealedHandler
{
	private ValueTask<Response158> Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request159(long Id) : Mediator.IRequest<Response159>, MediatR.IRequest<Response159>;

public sealed record Response159(long Id);

public sealed partial class Request159TraditionalHandler
	: Mediator.IRequestHandler<Request159, Response159>,
	MediatR.IRequestHandler<Request159, Response159>
{
	ValueTask<Response159> Mediator.IRequestHandler<Request159, Response159>.Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response159> MediatR.IRequestHandler<Request159, Response159>.Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request159StaticHandler
{
	private static ValueTask<Response159> Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request159SealedHandler
{
	private ValueTask<Response159> Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request160(long Id) : Mediator.IRequest<Response160>, MediatR.IRequest<Response160>;

public sealed record Response160(long Id);

public sealed partial class Request160TraditionalHandler
	: Mediator.IRequestHandler<Request160, Response160>,
	MediatR.IRequestHandler<Request160, Response160>
{
	ValueTask<Response160> Mediator.IRequestHandler<Request160, Response160>.Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response160> MediatR.IRequestHandler<Request160, Response160>.Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request160StaticHandler
{
	private static ValueTask<Response160> Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request160SealedHandler
{
	private ValueTask<Response160> Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request161(long Id) : Mediator.IRequest<Response161>, MediatR.IRequest<Response161>;

public sealed record Response161(long Id);

public sealed partial class Request161TraditionalHandler
	: Mediator.IRequestHandler<Request161, Response161>,
	MediatR.IRequestHandler<Request161, Response161>
{
	ValueTask<Response161> Mediator.IRequestHandler<Request161, Response161>.Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response161> MediatR.IRequestHandler<Request161, Response161>.Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request161StaticHandler
{
	private static ValueTask<Response161> Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request161SealedHandler
{
	private ValueTask<Response161> Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request162(long Id) : Mediator.IRequest<Response162>, MediatR.IRequest<Response162>;

public sealed record Response162(long Id);

public sealed partial class Request162TraditionalHandler
	: Mediator.IRequestHandler<Request162, Response162>,
	MediatR.IRequestHandler<Request162, Response162>
{
	ValueTask<Response162> Mediator.IRequestHandler<Request162, Response162>.Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response162> MediatR.IRequestHandler<Request162, Response162>.Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request162StaticHandler
{
	private static ValueTask<Response162> Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request162SealedHandler
{
	private ValueTask<Response162> Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request163(long Id) : Mediator.IRequest<Response163>, MediatR.IRequest<Response163>;

public sealed record Response163(long Id);

public sealed partial class Request163TraditionalHandler
	: Mediator.IRequestHandler<Request163, Response163>,
	MediatR.IRequestHandler<Request163, Response163>
{
	ValueTask<Response163> Mediator.IRequestHandler<Request163, Response163>.Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response163> MediatR.IRequestHandler<Request163, Response163>.Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request163StaticHandler
{
	private static ValueTask<Response163> Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request163SealedHandler
{
	private ValueTask<Response163> Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request164(long Id) : Mediator.IRequest<Response164>, MediatR.IRequest<Response164>;

public sealed record Response164(long Id);

public sealed partial class Request164TraditionalHandler
	: Mediator.IRequestHandler<Request164, Response164>,
	MediatR.IRequestHandler<Request164, Response164>
{
	ValueTask<Response164> Mediator.IRequestHandler<Request164, Response164>.Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response164> MediatR.IRequestHandler<Request164, Response164>.Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request164StaticHandler
{
	private static ValueTask<Response164> Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request164SealedHandler
{
	private ValueTask<Response164> Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request165(long Id) : Mediator.IRequest<Response165>, MediatR.IRequest<Response165>;

public sealed record Response165(long Id);

public sealed partial class Request165TraditionalHandler
	: Mediator.IRequestHandler<Request165, Response165>,
	MediatR.IRequestHandler<Request165, Response165>
{
	ValueTask<Response165> Mediator.IRequestHandler<Request165, Response165>.Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response165> MediatR.IRequestHandler<Request165, Response165>.Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request165StaticHandler
{
	private static ValueTask<Response165> Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request165SealedHandler
{
	private ValueTask<Response165> Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request166(long Id) : Mediator.IRequest<Response166>, MediatR.IRequest<Response166>;

public sealed record Response166(long Id);

public sealed partial class Request166TraditionalHandler
	: Mediator.IRequestHandler<Request166, Response166>,
	MediatR.IRequestHandler<Request166, Response166>
{
	ValueTask<Response166> Mediator.IRequestHandler<Request166, Response166>.Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response166> MediatR.IRequestHandler<Request166, Response166>.Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request166StaticHandler
{
	private static ValueTask<Response166> Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request166SealedHandler
{
	private ValueTask<Response166> Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request167(long Id) : Mediator.IRequest<Response167>, MediatR.IRequest<Response167>;

public sealed record Response167(long Id);

public sealed partial class Request167TraditionalHandler
	: Mediator.IRequestHandler<Request167, Response167>,
	MediatR.IRequestHandler<Request167, Response167>
{
	ValueTask<Response167> Mediator.IRequestHandler<Request167, Response167>.Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response167> MediatR.IRequestHandler<Request167, Response167>.Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request167StaticHandler
{
	private static ValueTask<Response167> Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request167SealedHandler
{
	private ValueTask<Response167> Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request168(long Id) : Mediator.IRequest<Response168>, MediatR.IRequest<Response168>;

public sealed record Response168(long Id);

public sealed partial class Request168TraditionalHandler
	: Mediator.IRequestHandler<Request168, Response168>,
	MediatR.IRequestHandler<Request168, Response168>
{
	ValueTask<Response168> Mediator.IRequestHandler<Request168, Response168>.Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response168> MediatR.IRequestHandler<Request168, Response168>.Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request168StaticHandler
{
	private static ValueTask<Response168> Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request168SealedHandler
{
	private ValueTask<Response168> Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request169(long Id) : Mediator.IRequest<Response169>, MediatR.IRequest<Response169>;

public sealed record Response169(long Id);

public sealed partial class Request169TraditionalHandler
	: Mediator.IRequestHandler<Request169, Response169>,
	MediatR.IRequestHandler<Request169, Response169>
{
	ValueTask<Response169> Mediator.IRequestHandler<Request169, Response169>.Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response169> MediatR.IRequestHandler<Request169, Response169>.Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request169StaticHandler
{
	private static ValueTask<Response169> Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request169SealedHandler
{
	private ValueTask<Response169> Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request170(long Id) : Mediator.IRequest<Response170>, MediatR.IRequest<Response170>;

public sealed record Response170(long Id);

public sealed partial class Request170TraditionalHandler
	: Mediator.IRequestHandler<Request170, Response170>,
	MediatR.IRequestHandler<Request170, Response170>
{
	ValueTask<Response170> Mediator.IRequestHandler<Request170, Response170>.Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response170> MediatR.IRequestHandler<Request170, Response170>.Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request170StaticHandler
{
	private static ValueTask<Response170> Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request170SealedHandler
{
	private ValueTask<Response170> Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request171(long Id) : Mediator.IRequest<Response171>, MediatR.IRequest<Response171>;

public sealed record Response171(long Id);

public sealed partial class Request171TraditionalHandler
	: Mediator.IRequestHandler<Request171, Response171>,
	MediatR.IRequestHandler<Request171, Response171>
{
	ValueTask<Response171> Mediator.IRequestHandler<Request171, Response171>.Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response171> MediatR.IRequestHandler<Request171, Response171>.Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request171StaticHandler
{
	private static ValueTask<Response171> Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request171SealedHandler
{
	private ValueTask<Response171> Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request172(long Id) : Mediator.IRequest<Response172>, MediatR.IRequest<Response172>;

public sealed record Response172(long Id);

public sealed partial class Request172TraditionalHandler
	: Mediator.IRequestHandler<Request172, Response172>,
	MediatR.IRequestHandler<Request172, Response172>
{
	ValueTask<Response172> Mediator.IRequestHandler<Request172, Response172>.Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response172> MediatR.IRequestHandler<Request172, Response172>.Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request172StaticHandler
{
	private static ValueTask<Response172> Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request172SealedHandler
{
	private ValueTask<Response172> Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request173(long Id) : Mediator.IRequest<Response173>, MediatR.IRequest<Response173>;

public sealed record Response173(long Id);

public sealed partial class Request173TraditionalHandler
	: Mediator.IRequestHandler<Request173, Response173>,
	MediatR.IRequestHandler<Request173, Response173>
{
	ValueTask<Response173> Mediator.IRequestHandler<Request173, Response173>.Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response173> MediatR.IRequestHandler<Request173, Response173>.Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request173StaticHandler
{
	private static ValueTask<Response173> Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request173SealedHandler
{
	private ValueTask<Response173> Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request174(long Id) : Mediator.IRequest<Response174>, MediatR.IRequest<Response174>;

public sealed record Response174(long Id);

public sealed partial class Request174TraditionalHandler
	: Mediator.IRequestHandler<Request174, Response174>,
	MediatR.IRequestHandler<Request174, Response174>
{
	ValueTask<Response174> Mediator.IRequestHandler<Request174, Response174>.Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response174> MediatR.IRequestHandler<Request174, Response174>.Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request174StaticHandler
{
	private static ValueTask<Response174> Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request174SealedHandler
{
	private ValueTask<Response174> Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request175(long Id) : Mediator.IRequest<Response175>, MediatR.IRequest<Response175>;

public sealed record Response175(long Id);

public sealed partial class Request175TraditionalHandler
	: Mediator.IRequestHandler<Request175, Response175>,
	MediatR.IRequestHandler<Request175, Response175>
{
	ValueTask<Response175> Mediator.IRequestHandler<Request175, Response175>.Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response175> MediatR.IRequestHandler<Request175, Response175>.Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request175StaticHandler
{
	private static ValueTask<Response175> Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request175SealedHandler
{
	private ValueTask<Response175> Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request176(long Id) : Mediator.IRequest<Response176>, MediatR.IRequest<Response176>;

public sealed record Response176(long Id);

public sealed partial class Request176TraditionalHandler
	: Mediator.IRequestHandler<Request176, Response176>,
	MediatR.IRequestHandler<Request176, Response176>
{
	ValueTask<Response176> Mediator.IRequestHandler<Request176, Response176>.Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response176> MediatR.IRequestHandler<Request176, Response176>.Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request176StaticHandler
{
	private static ValueTask<Response176> Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request176SealedHandler
{
	private ValueTask<Response176> Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request177(long Id) : Mediator.IRequest<Response177>, MediatR.IRequest<Response177>;

public sealed record Response177(long Id);

public sealed partial class Request177TraditionalHandler
	: Mediator.IRequestHandler<Request177, Response177>,
	MediatR.IRequestHandler<Request177, Response177>
{
	ValueTask<Response177> Mediator.IRequestHandler<Request177, Response177>.Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response177> MediatR.IRequestHandler<Request177, Response177>.Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request177StaticHandler
{
	private static ValueTask<Response177> Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request177SealedHandler
{
	private ValueTask<Response177> Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request178(long Id) : Mediator.IRequest<Response178>, MediatR.IRequest<Response178>;

public sealed record Response178(long Id);

public sealed partial class Request178TraditionalHandler
	: Mediator.IRequestHandler<Request178, Response178>,
	MediatR.IRequestHandler<Request178, Response178>
{
	ValueTask<Response178> Mediator.IRequestHandler<Request178, Response178>.Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response178> MediatR.IRequestHandler<Request178, Response178>.Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request178StaticHandler
{
	private static ValueTask<Response178> Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request178SealedHandler
{
	private ValueTask<Response178> Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request179(long Id) : Mediator.IRequest<Response179>, MediatR.IRequest<Response179>;

public sealed record Response179(long Id);

public sealed partial class Request179TraditionalHandler
	: Mediator.IRequestHandler<Request179, Response179>,
	MediatR.IRequestHandler<Request179, Response179>
{
	ValueTask<Response179> Mediator.IRequestHandler<Request179, Response179>.Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response179> MediatR.IRequestHandler<Request179, Response179>.Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request179StaticHandler
{
	private static ValueTask<Response179> Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request179SealedHandler
{
	private ValueTask<Response179> Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request180(long Id) : Mediator.IRequest<Response180>, MediatR.IRequest<Response180>;

public sealed record Response180(long Id);

public sealed partial class Request180TraditionalHandler
	: Mediator.IRequestHandler<Request180, Response180>,
	MediatR.IRequestHandler<Request180, Response180>
{
	ValueTask<Response180> Mediator.IRequestHandler<Request180, Response180>.Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response180> MediatR.IRequestHandler<Request180, Response180>.Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request180StaticHandler
{
	private static ValueTask<Response180> Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request180SealedHandler
{
	private ValueTask<Response180> Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request181(long Id) : Mediator.IRequest<Response181>, MediatR.IRequest<Response181>;

public sealed record Response181(long Id);

public sealed partial class Request181TraditionalHandler
	: Mediator.IRequestHandler<Request181, Response181>,
	MediatR.IRequestHandler<Request181, Response181>
{
	ValueTask<Response181> Mediator.IRequestHandler<Request181, Response181>.Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response181> MediatR.IRequestHandler<Request181, Response181>.Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request181StaticHandler
{
	private static ValueTask<Response181> Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request181SealedHandler
{
	private ValueTask<Response181> Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request182(long Id) : Mediator.IRequest<Response182>, MediatR.IRequest<Response182>;

public sealed record Response182(long Id);

public sealed partial class Request182TraditionalHandler
	: Mediator.IRequestHandler<Request182, Response182>,
	MediatR.IRequestHandler<Request182, Response182>
{
	ValueTask<Response182> Mediator.IRequestHandler<Request182, Response182>.Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response182> MediatR.IRequestHandler<Request182, Response182>.Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request182StaticHandler
{
	private static ValueTask<Response182> Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request182SealedHandler
{
	private ValueTask<Response182> Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request183(long Id) : Mediator.IRequest<Response183>, MediatR.IRequest<Response183>;

public sealed record Response183(long Id);

public sealed partial class Request183TraditionalHandler
	: Mediator.IRequestHandler<Request183, Response183>,
	MediatR.IRequestHandler<Request183, Response183>
{
	ValueTask<Response183> Mediator.IRequestHandler<Request183, Response183>.Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response183> MediatR.IRequestHandler<Request183, Response183>.Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request183StaticHandler
{
	private static ValueTask<Response183> Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request183SealedHandler
{
	private ValueTask<Response183> Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request184(long Id) : Mediator.IRequest<Response184>, MediatR.IRequest<Response184>;

public sealed record Response184(long Id);

public sealed partial class Request184TraditionalHandler
	: Mediator.IRequestHandler<Request184, Response184>,
	MediatR.IRequestHandler<Request184, Response184>
{
	ValueTask<Response184> Mediator.IRequestHandler<Request184, Response184>.Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response184> MediatR.IRequestHandler<Request184, Response184>.Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request184StaticHandler
{
	private static ValueTask<Response184> Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request184SealedHandler
{
	private ValueTask<Response184> Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request185(long Id) : Mediator.IRequest<Response185>, MediatR.IRequest<Response185>;

public sealed record Response185(long Id);

public sealed partial class Request185TraditionalHandler
	: Mediator.IRequestHandler<Request185, Response185>,
	MediatR.IRequestHandler<Request185, Response185>
{
	ValueTask<Response185> Mediator.IRequestHandler<Request185, Response185>.Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response185> MediatR.IRequestHandler<Request185, Response185>.Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request185StaticHandler
{
	private static ValueTask<Response185> Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request185SealedHandler
{
	private ValueTask<Response185> Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request186(long Id) : Mediator.IRequest<Response186>, MediatR.IRequest<Response186>;

public sealed record Response186(long Id);

public sealed partial class Request186TraditionalHandler
	: Mediator.IRequestHandler<Request186, Response186>,
	MediatR.IRequestHandler<Request186, Response186>
{
	ValueTask<Response186> Mediator.IRequestHandler<Request186, Response186>.Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response186> MediatR.IRequestHandler<Request186, Response186>.Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request186StaticHandler
{
	private static ValueTask<Response186> Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request186SealedHandler
{
	private ValueTask<Response186> Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request187(long Id) : Mediator.IRequest<Response187>, MediatR.IRequest<Response187>;

public sealed record Response187(long Id);

public sealed partial class Request187TraditionalHandler
	: Mediator.IRequestHandler<Request187, Response187>,
	MediatR.IRequestHandler<Request187, Response187>
{
	ValueTask<Response187> Mediator.IRequestHandler<Request187, Response187>.Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response187> MediatR.IRequestHandler<Request187, Response187>.Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request187StaticHandler
{
	private static ValueTask<Response187> Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request187SealedHandler
{
	private ValueTask<Response187> Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request188(long Id) : Mediator.IRequest<Response188>, MediatR.IRequest<Response188>;

public sealed record Response188(long Id);

public sealed partial class Request188TraditionalHandler
	: Mediator.IRequestHandler<Request188, Response188>,
	MediatR.IRequestHandler<Request188, Response188>
{
	ValueTask<Response188> Mediator.IRequestHandler<Request188, Response188>.Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response188> MediatR.IRequestHandler<Request188, Response188>.Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request188StaticHandler
{
	private static ValueTask<Response188> Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request188SealedHandler
{
	private ValueTask<Response188> Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request189(long Id) : Mediator.IRequest<Response189>, MediatR.IRequest<Response189>;

public sealed record Response189(long Id);

public sealed partial class Request189TraditionalHandler
	: Mediator.IRequestHandler<Request189, Response189>,
	MediatR.IRequestHandler<Request189, Response189>
{
	ValueTask<Response189> Mediator.IRequestHandler<Request189, Response189>.Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response189> MediatR.IRequestHandler<Request189, Response189>.Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request189StaticHandler
{
	private static ValueTask<Response189> Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request189SealedHandler
{
	private ValueTask<Response189> Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request190(long Id) : Mediator.IRequest<Response190>, MediatR.IRequest<Response190>;

public sealed record Response190(long Id);

public sealed partial class Request190TraditionalHandler
	: Mediator.IRequestHandler<Request190, Response190>,
	MediatR.IRequestHandler<Request190, Response190>
{
	ValueTask<Response190> Mediator.IRequestHandler<Request190, Response190>.Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response190> MediatR.IRequestHandler<Request190, Response190>.Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request190StaticHandler
{
	private static ValueTask<Response190> Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request190SealedHandler
{
	private ValueTask<Response190> Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request191(long Id) : Mediator.IRequest<Response191>, MediatR.IRequest<Response191>;

public sealed record Response191(long Id);

public sealed partial class Request191TraditionalHandler
	: Mediator.IRequestHandler<Request191, Response191>,
	MediatR.IRequestHandler<Request191, Response191>
{
	ValueTask<Response191> Mediator.IRequestHandler<Request191, Response191>.Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response191> MediatR.IRequestHandler<Request191, Response191>.Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request191StaticHandler
{
	private static ValueTask<Response191> Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request191SealedHandler
{
	private ValueTask<Response191> Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request192(long Id) : Mediator.IRequest<Response192>, MediatR.IRequest<Response192>;

public sealed record Response192(long Id);

public sealed partial class Request192TraditionalHandler
	: Mediator.IRequestHandler<Request192, Response192>,
	MediatR.IRequestHandler<Request192, Response192>
{
	ValueTask<Response192> Mediator.IRequestHandler<Request192, Response192>.Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response192> MediatR.IRequestHandler<Request192, Response192>.Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request192StaticHandler
{
	private static ValueTask<Response192> Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request192SealedHandler
{
	private ValueTask<Response192> Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request193(long Id) : Mediator.IRequest<Response193>, MediatR.IRequest<Response193>;

public sealed record Response193(long Id);

public sealed partial class Request193TraditionalHandler
	: Mediator.IRequestHandler<Request193, Response193>,
	MediatR.IRequestHandler<Request193, Response193>
{
	ValueTask<Response193> Mediator.IRequestHandler<Request193, Response193>.Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response193> MediatR.IRequestHandler<Request193, Response193>.Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request193StaticHandler
{
	private static ValueTask<Response193> Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request193SealedHandler
{
	private ValueTask<Response193> Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request194(long Id) : Mediator.IRequest<Response194>, MediatR.IRequest<Response194>;

public sealed record Response194(long Id);

public sealed partial class Request194TraditionalHandler
	: Mediator.IRequestHandler<Request194, Response194>,
	MediatR.IRequestHandler<Request194, Response194>
{
	ValueTask<Response194> Mediator.IRequestHandler<Request194, Response194>.Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response194> MediatR.IRequestHandler<Request194, Response194>.Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request194StaticHandler
{
	private static ValueTask<Response194> Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request194SealedHandler
{
	private ValueTask<Response194> Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request195(long Id) : Mediator.IRequest<Response195>, MediatR.IRequest<Response195>;

public sealed record Response195(long Id);

public sealed partial class Request195TraditionalHandler
	: Mediator.IRequestHandler<Request195, Response195>,
	MediatR.IRequestHandler<Request195, Response195>
{
	ValueTask<Response195> Mediator.IRequestHandler<Request195, Response195>.Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response195> MediatR.IRequestHandler<Request195, Response195>.Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request195StaticHandler
{
	private static ValueTask<Response195> Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request195SealedHandler
{
	private ValueTask<Response195> Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request196(long Id) : Mediator.IRequest<Response196>, MediatR.IRequest<Response196>;

public sealed record Response196(long Id);

public sealed partial class Request196TraditionalHandler
	: Mediator.IRequestHandler<Request196, Response196>,
	MediatR.IRequestHandler<Request196, Response196>
{
	ValueTask<Response196> Mediator.IRequestHandler<Request196, Response196>.Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response196> MediatR.IRequestHandler<Request196, Response196>.Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request196StaticHandler
{
	private static ValueTask<Response196> Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request196SealedHandler
{
	private ValueTask<Response196> Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request197(long Id) : Mediator.IRequest<Response197>, MediatR.IRequest<Response197>;

public sealed record Response197(long Id);

public sealed partial class Request197TraditionalHandler
	: Mediator.IRequestHandler<Request197, Response197>,
	MediatR.IRequestHandler<Request197, Response197>
{
	ValueTask<Response197> Mediator.IRequestHandler<Request197, Response197>.Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response197> MediatR.IRequestHandler<Request197, Response197>.Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request197StaticHandler
{
	private static ValueTask<Response197> Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request197SealedHandler
{
	private ValueTask<Response197> Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request198(long Id) : Mediator.IRequest<Response198>, MediatR.IRequest<Response198>;

public sealed record Response198(long Id);

public sealed partial class Request198TraditionalHandler
	: Mediator.IRequestHandler<Request198, Response198>,
	MediatR.IRequestHandler<Request198, Response198>
{
	ValueTask<Response198> Mediator.IRequestHandler<Request198, Response198>.Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response198> MediatR.IRequestHandler<Request198, Response198>.Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request198StaticHandler
{
	private static ValueTask<Response198> Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request198SealedHandler
{
	private ValueTask<Response198> Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request199(long Id) : Mediator.IRequest<Response199>, MediatR.IRequest<Response199>;

public sealed record Response199(long Id);

public sealed partial class Request199TraditionalHandler
	: Mediator.IRequestHandler<Request199, Response199>,
	MediatR.IRequestHandler<Request199, Response199>
{
	ValueTask<Response199> Mediator.IRequestHandler<Request199, Response199>.Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response199> MediatR.IRequestHandler<Request199, Response199>.Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request199StaticHandler
{
	private static ValueTask<Response199> Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request199SealedHandler
{
	private ValueTask<Response199> Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request200(long Id) : Mediator.IRequest<Response200>, MediatR.IRequest<Response200>;

public sealed record Response200(long Id);

public sealed partial class Request200TraditionalHandler
	: Mediator.IRequestHandler<Request200, Response200>,
	MediatR.IRequestHandler<Request200, Response200>
{
	ValueTask<Response200> Mediator.IRequestHandler<Request200, Response200>.Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response200> MediatR.IRequestHandler<Request200, Response200>.Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request200StaticHandler
{
	private static ValueTask<Response200> Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request200SealedHandler
{
	private ValueTask<Response200> Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request201(long Id) : Mediator.IRequest<Response201>, MediatR.IRequest<Response201>;

public sealed record Response201(long Id);

public sealed partial class Request201TraditionalHandler
	: Mediator.IRequestHandler<Request201, Response201>,
	MediatR.IRequestHandler<Request201, Response201>
{
	ValueTask<Response201> Mediator.IRequestHandler<Request201, Response201>.Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response201> MediatR.IRequestHandler<Request201, Response201>.Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request201StaticHandler
{
	private static ValueTask<Response201> Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request201SealedHandler
{
	private ValueTask<Response201> Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request202(long Id) : Mediator.IRequest<Response202>, MediatR.IRequest<Response202>;

public sealed record Response202(long Id);

public sealed partial class Request202TraditionalHandler
	: Mediator.IRequestHandler<Request202, Response202>,
	MediatR.IRequestHandler<Request202, Response202>
{
	ValueTask<Response202> Mediator.IRequestHandler<Request202, Response202>.Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response202> MediatR.IRequestHandler<Request202, Response202>.Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request202StaticHandler
{
	private static ValueTask<Response202> Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request202SealedHandler
{
	private ValueTask<Response202> Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request203(long Id) : Mediator.IRequest<Response203>, MediatR.IRequest<Response203>;

public sealed record Response203(long Id);

public sealed partial class Request203TraditionalHandler
	: Mediator.IRequestHandler<Request203, Response203>,
	MediatR.IRequestHandler<Request203, Response203>
{
	ValueTask<Response203> Mediator.IRequestHandler<Request203, Response203>.Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response203> MediatR.IRequestHandler<Request203, Response203>.Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request203StaticHandler
{
	private static ValueTask<Response203> Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request203SealedHandler
{
	private ValueTask<Response203> Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request204(long Id) : Mediator.IRequest<Response204>, MediatR.IRequest<Response204>;

public sealed record Response204(long Id);

public sealed partial class Request204TraditionalHandler
	: Mediator.IRequestHandler<Request204, Response204>,
	MediatR.IRequestHandler<Request204, Response204>
{
	ValueTask<Response204> Mediator.IRequestHandler<Request204, Response204>.Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response204> MediatR.IRequestHandler<Request204, Response204>.Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request204StaticHandler
{
	private static ValueTask<Response204> Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request204SealedHandler
{
	private ValueTask<Response204> Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request205(long Id) : Mediator.IRequest<Response205>, MediatR.IRequest<Response205>;

public sealed record Response205(long Id);

public sealed partial class Request205TraditionalHandler
	: Mediator.IRequestHandler<Request205, Response205>,
	MediatR.IRequestHandler<Request205, Response205>
{
	ValueTask<Response205> Mediator.IRequestHandler<Request205, Response205>.Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response205> MediatR.IRequestHandler<Request205, Response205>.Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request205StaticHandler
{
	private static ValueTask<Response205> Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request205SealedHandler
{
	private ValueTask<Response205> Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request206(long Id) : Mediator.IRequest<Response206>, MediatR.IRequest<Response206>;

public sealed record Response206(long Id);

public sealed partial class Request206TraditionalHandler
	: Mediator.IRequestHandler<Request206, Response206>,
	MediatR.IRequestHandler<Request206, Response206>
{
	ValueTask<Response206> Mediator.IRequestHandler<Request206, Response206>.Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response206> MediatR.IRequestHandler<Request206, Response206>.Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request206StaticHandler
{
	private static ValueTask<Response206> Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request206SealedHandler
{
	private ValueTask<Response206> Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request207(long Id) : Mediator.IRequest<Response207>, MediatR.IRequest<Response207>;

public sealed record Response207(long Id);

public sealed partial class Request207TraditionalHandler
	: Mediator.IRequestHandler<Request207, Response207>,
	MediatR.IRequestHandler<Request207, Response207>
{
	ValueTask<Response207> Mediator.IRequestHandler<Request207, Response207>.Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response207> MediatR.IRequestHandler<Request207, Response207>.Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request207StaticHandler
{
	private static ValueTask<Response207> Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request207SealedHandler
{
	private ValueTask<Response207> Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request208(long Id) : Mediator.IRequest<Response208>, MediatR.IRequest<Response208>;

public sealed record Response208(long Id);

public sealed partial class Request208TraditionalHandler
	: Mediator.IRequestHandler<Request208, Response208>,
	MediatR.IRequestHandler<Request208, Response208>
{
	ValueTask<Response208> Mediator.IRequestHandler<Request208, Response208>.Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response208> MediatR.IRequestHandler<Request208, Response208>.Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request208StaticHandler
{
	private static ValueTask<Response208> Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request208SealedHandler
{
	private ValueTask<Response208> Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request209(long Id) : Mediator.IRequest<Response209>, MediatR.IRequest<Response209>;

public sealed record Response209(long Id);

public sealed partial class Request209TraditionalHandler
	: Mediator.IRequestHandler<Request209, Response209>,
	MediatR.IRequestHandler<Request209, Response209>
{
	ValueTask<Response209> Mediator.IRequestHandler<Request209, Response209>.Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response209> MediatR.IRequestHandler<Request209, Response209>.Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request209StaticHandler
{
	private static ValueTask<Response209> Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request209SealedHandler
{
	private ValueTask<Response209> Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request210(long Id) : Mediator.IRequest<Response210>, MediatR.IRequest<Response210>;

public sealed record Response210(long Id);

public sealed partial class Request210TraditionalHandler
	: Mediator.IRequestHandler<Request210, Response210>,
	MediatR.IRequestHandler<Request210, Response210>
{
	ValueTask<Response210> Mediator.IRequestHandler<Request210, Response210>.Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response210> MediatR.IRequestHandler<Request210, Response210>.Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request210StaticHandler
{
	private static ValueTask<Response210> Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request210SealedHandler
{
	private ValueTask<Response210> Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request211(long Id) : Mediator.IRequest<Response211>, MediatR.IRequest<Response211>;

public sealed record Response211(long Id);

public sealed partial class Request211TraditionalHandler
	: Mediator.IRequestHandler<Request211, Response211>,
	MediatR.IRequestHandler<Request211, Response211>
{
	ValueTask<Response211> Mediator.IRequestHandler<Request211, Response211>.Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response211> MediatR.IRequestHandler<Request211, Response211>.Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request211StaticHandler
{
	private static ValueTask<Response211> Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request211SealedHandler
{
	private ValueTask<Response211> Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request212(long Id) : Mediator.IRequest<Response212>, MediatR.IRequest<Response212>;

public sealed record Response212(long Id);

public sealed partial class Request212TraditionalHandler
	: Mediator.IRequestHandler<Request212, Response212>,
	MediatR.IRequestHandler<Request212, Response212>
{
	ValueTask<Response212> Mediator.IRequestHandler<Request212, Response212>.Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response212> MediatR.IRequestHandler<Request212, Response212>.Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request212StaticHandler
{
	private static ValueTask<Response212> Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request212SealedHandler
{
	private ValueTask<Response212> Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request213(long Id) : Mediator.IRequest<Response213>, MediatR.IRequest<Response213>;

public sealed record Response213(long Id);

public sealed partial class Request213TraditionalHandler
	: Mediator.IRequestHandler<Request213, Response213>,
	MediatR.IRequestHandler<Request213, Response213>
{
	ValueTask<Response213> Mediator.IRequestHandler<Request213, Response213>.Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response213> MediatR.IRequestHandler<Request213, Response213>.Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request213StaticHandler
{
	private static ValueTask<Response213> Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request213SealedHandler
{
	private ValueTask<Response213> Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request214(long Id) : Mediator.IRequest<Response214>, MediatR.IRequest<Response214>;

public sealed record Response214(long Id);

public sealed partial class Request214TraditionalHandler
	: Mediator.IRequestHandler<Request214, Response214>,
	MediatR.IRequestHandler<Request214, Response214>
{
	ValueTask<Response214> Mediator.IRequestHandler<Request214, Response214>.Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response214> MediatR.IRequestHandler<Request214, Response214>.Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request214StaticHandler
{
	private static ValueTask<Response214> Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request214SealedHandler
{
	private ValueTask<Response214> Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request215(long Id) : Mediator.IRequest<Response215>, MediatR.IRequest<Response215>;

public sealed record Response215(long Id);

public sealed partial class Request215TraditionalHandler
	: Mediator.IRequestHandler<Request215, Response215>,
	MediatR.IRequestHandler<Request215, Response215>
{
	ValueTask<Response215> Mediator.IRequestHandler<Request215, Response215>.Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response215> MediatR.IRequestHandler<Request215, Response215>.Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request215StaticHandler
{
	private static ValueTask<Response215> Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request215SealedHandler
{
	private ValueTask<Response215> Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request216(long Id) : Mediator.IRequest<Response216>, MediatR.IRequest<Response216>;

public sealed record Response216(long Id);

public sealed partial class Request216TraditionalHandler
	: Mediator.IRequestHandler<Request216, Response216>,
	MediatR.IRequestHandler<Request216, Response216>
{
	ValueTask<Response216> Mediator.IRequestHandler<Request216, Response216>.Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response216> MediatR.IRequestHandler<Request216, Response216>.Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request216StaticHandler
{
	private static ValueTask<Response216> Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request216SealedHandler
{
	private ValueTask<Response216> Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request217(long Id) : Mediator.IRequest<Response217>, MediatR.IRequest<Response217>;

public sealed record Response217(long Id);

public sealed partial class Request217TraditionalHandler
	: Mediator.IRequestHandler<Request217, Response217>,
	MediatR.IRequestHandler<Request217, Response217>
{
	ValueTask<Response217> Mediator.IRequestHandler<Request217, Response217>.Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response217> MediatR.IRequestHandler<Request217, Response217>.Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request217StaticHandler
{
	private static ValueTask<Response217> Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request217SealedHandler
{
	private ValueTask<Response217> Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request218(long Id) : Mediator.IRequest<Response218>, MediatR.IRequest<Response218>;

public sealed record Response218(long Id);

public sealed partial class Request218TraditionalHandler
	: Mediator.IRequestHandler<Request218, Response218>,
	MediatR.IRequestHandler<Request218, Response218>
{
	ValueTask<Response218> Mediator.IRequestHandler<Request218, Response218>.Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response218> MediatR.IRequestHandler<Request218, Response218>.Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request218StaticHandler
{
	private static ValueTask<Response218> Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request218SealedHandler
{
	private ValueTask<Response218> Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request219(long Id) : Mediator.IRequest<Response219>, MediatR.IRequest<Response219>;

public sealed record Response219(long Id);

public sealed partial class Request219TraditionalHandler
	: Mediator.IRequestHandler<Request219, Response219>,
	MediatR.IRequestHandler<Request219, Response219>
{
	ValueTask<Response219> Mediator.IRequestHandler<Request219, Response219>.Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response219> MediatR.IRequestHandler<Request219, Response219>.Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request219StaticHandler
{
	private static ValueTask<Response219> Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request219SealedHandler
{
	private ValueTask<Response219> Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request220(long Id) : Mediator.IRequest<Response220>, MediatR.IRequest<Response220>;

public sealed record Response220(long Id);

public sealed partial class Request220TraditionalHandler
	: Mediator.IRequestHandler<Request220, Response220>,
	MediatR.IRequestHandler<Request220, Response220>
{
	ValueTask<Response220> Mediator.IRequestHandler<Request220, Response220>.Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response220> MediatR.IRequestHandler<Request220, Response220>.Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request220StaticHandler
{
	private static ValueTask<Response220> Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request220SealedHandler
{
	private ValueTask<Response220> Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request221(long Id) : Mediator.IRequest<Response221>, MediatR.IRequest<Response221>;

public sealed record Response221(long Id);

public sealed partial class Request221TraditionalHandler
	: Mediator.IRequestHandler<Request221, Response221>,
	MediatR.IRequestHandler<Request221, Response221>
{
	ValueTask<Response221> Mediator.IRequestHandler<Request221, Response221>.Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response221> MediatR.IRequestHandler<Request221, Response221>.Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request221StaticHandler
{
	private static ValueTask<Response221> Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request221SealedHandler
{
	private ValueTask<Response221> Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request222(long Id) : Mediator.IRequest<Response222>, MediatR.IRequest<Response222>;

public sealed record Response222(long Id);

public sealed partial class Request222TraditionalHandler
	: Mediator.IRequestHandler<Request222, Response222>,
	MediatR.IRequestHandler<Request222, Response222>
{
	ValueTask<Response222> Mediator.IRequestHandler<Request222, Response222>.Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response222> MediatR.IRequestHandler<Request222, Response222>.Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request222StaticHandler
{
	private static ValueTask<Response222> Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request222SealedHandler
{
	private ValueTask<Response222> Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request223(long Id) : Mediator.IRequest<Response223>, MediatR.IRequest<Response223>;

public sealed record Response223(long Id);

public sealed partial class Request223TraditionalHandler
	: Mediator.IRequestHandler<Request223, Response223>,
	MediatR.IRequestHandler<Request223, Response223>
{
	ValueTask<Response223> Mediator.IRequestHandler<Request223, Response223>.Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response223> MediatR.IRequestHandler<Request223, Response223>.Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request223StaticHandler
{
	private static ValueTask<Response223> Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request223SealedHandler
{
	private ValueTask<Response223> Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request224(long Id) : Mediator.IRequest<Response224>, MediatR.IRequest<Response224>;

public sealed record Response224(long Id);

public sealed partial class Request224TraditionalHandler
	: Mediator.IRequestHandler<Request224, Response224>,
	MediatR.IRequestHandler<Request224, Response224>
{
	ValueTask<Response224> Mediator.IRequestHandler<Request224, Response224>.Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response224> MediatR.IRequestHandler<Request224, Response224>.Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request224StaticHandler
{
	private static ValueTask<Response224> Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request224SealedHandler
{
	private ValueTask<Response224> Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request225(long Id) : Mediator.IRequest<Response225>, MediatR.IRequest<Response225>;

public sealed record Response225(long Id);

public sealed partial class Request225TraditionalHandler
	: Mediator.IRequestHandler<Request225, Response225>,
	MediatR.IRequestHandler<Request225, Response225>
{
	ValueTask<Response225> Mediator.IRequestHandler<Request225, Response225>.Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response225> MediatR.IRequestHandler<Request225, Response225>.Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request225StaticHandler
{
	private static ValueTask<Response225> Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request225SealedHandler
{
	private ValueTask<Response225> Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request226(long Id) : Mediator.IRequest<Response226>, MediatR.IRequest<Response226>;

public sealed record Response226(long Id);

public sealed partial class Request226TraditionalHandler
	: Mediator.IRequestHandler<Request226, Response226>,
	MediatR.IRequestHandler<Request226, Response226>
{
	ValueTask<Response226> Mediator.IRequestHandler<Request226, Response226>.Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response226> MediatR.IRequestHandler<Request226, Response226>.Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request226StaticHandler
{
	private static ValueTask<Response226> Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request226SealedHandler
{
	private ValueTask<Response226> Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request227(long Id) : Mediator.IRequest<Response227>, MediatR.IRequest<Response227>;

public sealed record Response227(long Id);

public sealed partial class Request227TraditionalHandler
	: Mediator.IRequestHandler<Request227, Response227>,
	MediatR.IRequestHandler<Request227, Response227>
{
	ValueTask<Response227> Mediator.IRequestHandler<Request227, Response227>.Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response227> MediatR.IRequestHandler<Request227, Response227>.Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request227StaticHandler
{
	private static ValueTask<Response227> Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request227SealedHandler
{
	private ValueTask<Response227> Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request228(long Id) : Mediator.IRequest<Response228>, MediatR.IRequest<Response228>;

public sealed record Response228(long Id);

public sealed partial class Request228TraditionalHandler
	: Mediator.IRequestHandler<Request228, Response228>,
	MediatR.IRequestHandler<Request228, Response228>
{
	ValueTask<Response228> Mediator.IRequestHandler<Request228, Response228>.Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response228> MediatR.IRequestHandler<Request228, Response228>.Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request228StaticHandler
{
	private static ValueTask<Response228> Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request228SealedHandler
{
	private ValueTask<Response228> Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request229(long Id) : Mediator.IRequest<Response229>, MediatR.IRequest<Response229>;

public sealed record Response229(long Id);

public sealed partial class Request229TraditionalHandler
	: Mediator.IRequestHandler<Request229, Response229>,
	MediatR.IRequestHandler<Request229, Response229>
{
	ValueTask<Response229> Mediator.IRequestHandler<Request229, Response229>.Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response229> MediatR.IRequestHandler<Request229, Response229>.Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request229StaticHandler
{
	private static ValueTask<Response229> Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request229SealedHandler
{
	private ValueTask<Response229> Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request230(long Id) : Mediator.IRequest<Response230>, MediatR.IRequest<Response230>;

public sealed record Response230(long Id);

public sealed partial class Request230TraditionalHandler
	: Mediator.IRequestHandler<Request230, Response230>,
	MediatR.IRequestHandler<Request230, Response230>
{
	ValueTask<Response230> Mediator.IRequestHandler<Request230, Response230>.Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response230> MediatR.IRequestHandler<Request230, Response230>.Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request230StaticHandler
{
	private static ValueTask<Response230> Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request230SealedHandler
{
	private ValueTask<Response230> Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request231(long Id) : Mediator.IRequest<Response231>, MediatR.IRequest<Response231>;

public sealed record Response231(long Id);

public sealed partial class Request231TraditionalHandler
	: Mediator.IRequestHandler<Request231, Response231>,
	MediatR.IRequestHandler<Request231, Response231>
{
	ValueTask<Response231> Mediator.IRequestHandler<Request231, Response231>.Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response231> MediatR.IRequestHandler<Request231, Response231>.Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request231StaticHandler
{
	private static ValueTask<Response231> Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request231SealedHandler
{
	private ValueTask<Response231> Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request232(long Id) : Mediator.IRequest<Response232>, MediatR.IRequest<Response232>;

public sealed record Response232(long Id);

public sealed partial class Request232TraditionalHandler
	: Mediator.IRequestHandler<Request232, Response232>,
	MediatR.IRequestHandler<Request232, Response232>
{
	ValueTask<Response232> Mediator.IRequestHandler<Request232, Response232>.Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response232> MediatR.IRequestHandler<Request232, Response232>.Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request232StaticHandler
{
	private static ValueTask<Response232> Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request232SealedHandler
{
	private ValueTask<Response232> Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request233(long Id) : Mediator.IRequest<Response233>, MediatR.IRequest<Response233>;

public sealed record Response233(long Id);

public sealed partial class Request233TraditionalHandler
	: Mediator.IRequestHandler<Request233, Response233>,
	MediatR.IRequestHandler<Request233, Response233>
{
	ValueTask<Response233> Mediator.IRequestHandler<Request233, Response233>.Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response233> MediatR.IRequestHandler<Request233, Response233>.Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request233StaticHandler
{
	private static ValueTask<Response233> Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request233SealedHandler
{
	private ValueTask<Response233> Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request234(long Id) : Mediator.IRequest<Response234>, MediatR.IRequest<Response234>;

public sealed record Response234(long Id);

public sealed partial class Request234TraditionalHandler
	: Mediator.IRequestHandler<Request234, Response234>,
	MediatR.IRequestHandler<Request234, Response234>
{
	ValueTask<Response234> Mediator.IRequestHandler<Request234, Response234>.Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response234> MediatR.IRequestHandler<Request234, Response234>.Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request234StaticHandler
{
	private static ValueTask<Response234> Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request234SealedHandler
{
	private ValueTask<Response234> Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request235(long Id) : Mediator.IRequest<Response235>, MediatR.IRequest<Response235>;

public sealed record Response235(long Id);

public sealed partial class Request235TraditionalHandler
	: Mediator.IRequestHandler<Request235, Response235>,
	MediatR.IRequestHandler<Request235, Response235>
{
	ValueTask<Response235> Mediator.IRequestHandler<Request235, Response235>.Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response235> MediatR.IRequestHandler<Request235, Response235>.Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request235StaticHandler
{
	private static ValueTask<Response235> Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request235SealedHandler
{
	private ValueTask<Response235> Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request236(long Id) : Mediator.IRequest<Response236>, MediatR.IRequest<Response236>;

public sealed record Response236(long Id);

public sealed partial class Request236TraditionalHandler
	: Mediator.IRequestHandler<Request236, Response236>,
	MediatR.IRequestHandler<Request236, Response236>
{
	ValueTask<Response236> Mediator.IRequestHandler<Request236, Response236>.Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response236> MediatR.IRequestHandler<Request236, Response236>.Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request236StaticHandler
{
	private static ValueTask<Response236> Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request236SealedHandler
{
	private ValueTask<Response236> Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request237(long Id) : Mediator.IRequest<Response237>, MediatR.IRequest<Response237>;

public sealed record Response237(long Id);

public sealed partial class Request237TraditionalHandler
	: Mediator.IRequestHandler<Request237, Response237>,
	MediatR.IRequestHandler<Request237, Response237>
{
	ValueTask<Response237> Mediator.IRequestHandler<Request237, Response237>.Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response237> MediatR.IRequestHandler<Request237, Response237>.Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request237StaticHandler
{
	private static ValueTask<Response237> Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request237SealedHandler
{
	private ValueTask<Response237> Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request238(long Id) : Mediator.IRequest<Response238>, MediatR.IRequest<Response238>;

public sealed record Response238(long Id);

public sealed partial class Request238TraditionalHandler
	: Mediator.IRequestHandler<Request238, Response238>,
	MediatR.IRequestHandler<Request238, Response238>
{
	ValueTask<Response238> Mediator.IRequestHandler<Request238, Response238>.Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response238> MediatR.IRequestHandler<Request238, Response238>.Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request238StaticHandler
{
	private static ValueTask<Response238> Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request238SealedHandler
{
	private ValueTask<Response238> Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request239(long Id) : Mediator.IRequest<Response239>, MediatR.IRequest<Response239>;

public sealed record Response239(long Id);

public sealed partial class Request239TraditionalHandler
	: Mediator.IRequestHandler<Request239, Response239>,
	MediatR.IRequestHandler<Request239, Response239>
{
	ValueTask<Response239> Mediator.IRequestHandler<Request239, Response239>.Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response239> MediatR.IRequestHandler<Request239, Response239>.Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request239StaticHandler
{
	private static ValueTask<Response239> Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request239SealedHandler
{
	private ValueTask<Response239> Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request240(long Id) : Mediator.IRequest<Response240>, MediatR.IRequest<Response240>;

public sealed record Response240(long Id);

public sealed partial class Request240TraditionalHandler
	: Mediator.IRequestHandler<Request240, Response240>,
	MediatR.IRequestHandler<Request240, Response240>
{
	ValueTask<Response240> Mediator.IRequestHandler<Request240, Response240>.Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response240> MediatR.IRequestHandler<Request240, Response240>.Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request240StaticHandler
{
	private static ValueTask<Response240> Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request240SealedHandler
{
	private ValueTask<Response240> Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request241(long Id) : Mediator.IRequest<Response241>, MediatR.IRequest<Response241>;

public sealed record Response241(long Id);

public sealed partial class Request241TraditionalHandler
	: Mediator.IRequestHandler<Request241, Response241>,
	MediatR.IRequestHandler<Request241, Response241>
{
	ValueTask<Response241> Mediator.IRequestHandler<Request241, Response241>.Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response241> MediatR.IRequestHandler<Request241, Response241>.Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request241StaticHandler
{
	private static ValueTask<Response241> Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request241SealedHandler
{
	private ValueTask<Response241> Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request242(long Id) : Mediator.IRequest<Response242>, MediatR.IRequest<Response242>;

public sealed record Response242(long Id);

public sealed partial class Request242TraditionalHandler
	: Mediator.IRequestHandler<Request242, Response242>,
	MediatR.IRequestHandler<Request242, Response242>
{
	ValueTask<Response242> Mediator.IRequestHandler<Request242, Response242>.Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response242> MediatR.IRequestHandler<Request242, Response242>.Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request242StaticHandler
{
	private static ValueTask<Response242> Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request242SealedHandler
{
	private ValueTask<Response242> Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request243(long Id) : Mediator.IRequest<Response243>, MediatR.IRequest<Response243>;

public sealed record Response243(long Id);

public sealed partial class Request243TraditionalHandler
	: Mediator.IRequestHandler<Request243, Response243>,
	MediatR.IRequestHandler<Request243, Response243>
{
	ValueTask<Response243> Mediator.IRequestHandler<Request243, Response243>.Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response243> MediatR.IRequestHandler<Request243, Response243>.Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request243StaticHandler
{
	private static ValueTask<Response243> Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request243SealedHandler
{
	private ValueTask<Response243> Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request244(long Id) : Mediator.IRequest<Response244>, MediatR.IRequest<Response244>;

public sealed record Response244(long Id);

public sealed partial class Request244TraditionalHandler
	: Mediator.IRequestHandler<Request244, Response244>,
	MediatR.IRequestHandler<Request244, Response244>
{
	ValueTask<Response244> Mediator.IRequestHandler<Request244, Response244>.Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response244> MediatR.IRequestHandler<Request244, Response244>.Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request244StaticHandler
{
	private static ValueTask<Response244> Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request244SealedHandler
{
	private ValueTask<Response244> Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request245(long Id) : Mediator.IRequest<Response245>, MediatR.IRequest<Response245>;

public sealed record Response245(long Id);

public sealed partial class Request245TraditionalHandler
	: Mediator.IRequestHandler<Request245, Response245>,
	MediatR.IRequestHandler<Request245, Response245>
{
	ValueTask<Response245> Mediator.IRequestHandler<Request245, Response245>.Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response245> MediatR.IRequestHandler<Request245, Response245>.Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request245StaticHandler
{
	private static ValueTask<Response245> Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request245SealedHandler
{
	private ValueTask<Response245> Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request246(long Id) : Mediator.IRequest<Response246>, MediatR.IRequest<Response246>;

public sealed record Response246(long Id);

public sealed partial class Request246TraditionalHandler
	: Mediator.IRequestHandler<Request246, Response246>,
	MediatR.IRequestHandler<Request246, Response246>
{
	ValueTask<Response246> Mediator.IRequestHandler<Request246, Response246>.Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response246> MediatR.IRequestHandler<Request246, Response246>.Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request246StaticHandler
{
	private static ValueTask<Response246> Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request246SealedHandler
{
	private ValueTask<Response246> Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request247(long Id) : Mediator.IRequest<Response247>, MediatR.IRequest<Response247>;

public sealed record Response247(long Id);

public sealed partial class Request247TraditionalHandler
	: Mediator.IRequestHandler<Request247, Response247>,
	MediatR.IRequestHandler<Request247, Response247>
{
	ValueTask<Response247> Mediator.IRequestHandler<Request247, Response247>.Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response247> MediatR.IRequestHandler<Request247, Response247>.Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request247StaticHandler
{
	private static ValueTask<Response247> Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request247SealedHandler
{
	private ValueTask<Response247> Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request248(long Id) : Mediator.IRequest<Response248>, MediatR.IRequest<Response248>;

public sealed record Response248(long Id);

public sealed partial class Request248TraditionalHandler
	: Mediator.IRequestHandler<Request248, Response248>,
	MediatR.IRequestHandler<Request248, Response248>
{
	ValueTask<Response248> Mediator.IRequestHandler<Request248, Response248>.Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response248> MediatR.IRequestHandler<Request248, Response248>.Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request248StaticHandler
{
	private static ValueTask<Response248> Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request248SealedHandler
{
	private ValueTask<Response248> Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request249(long Id) : Mediator.IRequest<Response249>, MediatR.IRequest<Response249>;

public sealed record Response249(long Id);

public sealed partial class Request249TraditionalHandler
	: Mediator.IRequestHandler<Request249, Response249>,
	MediatR.IRequestHandler<Request249, Response249>
{
	ValueTask<Response249> Mediator.IRequestHandler<Request249, Response249>.Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response249> MediatR.IRequestHandler<Request249, Response249>.Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request249StaticHandler
{
	private static ValueTask<Response249> Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request249SealedHandler
{
	private ValueTask<Response249> Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request250(long Id) : Mediator.IRequest<Response250>, MediatR.IRequest<Response250>;

public sealed record Response250(long Id);

public sealed partial class Request250TraditionalHandler
	: Mediator.IRequestHandler<Request250, Response250>,
	MediatR.IRequestHandler<Request250, Response250>
{
	ValueTask<Response250> Mediator.IRequestHandler<Request250, Response250>.Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response250> MediatR.IRequestHandler<Request250, Response250>.Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request250StaticHandler
{
	private static ValueTask<Response250> Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request250SealedHandler
{
	private ValueTask<Response250> Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request251(long Id) : Mediator.IRequest<Response251>, MediatR.IRequest<Response251>;

public sealed record Response251(long Id);

public sealed partial class Request251TraditionalHandler
	: Mediator.IRequestHandler<Request251, Response251>,
	MediatR.IRequestHandler<Request251, Response251>
{
	ValueTask<Response251> Mediator.IRequestHandler<Request251, Response251>.Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response251> MediatR.IRequestHandler<Request251, Response251>.Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request251StaticHandler
{
	private static ValueTask<Response251> Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request251SealedHandler
{
	private ValueTask<Response251> Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request252(long Id) : Mediator.IRequest<Response252>, MediatR.IRequest<Response252>;

public sealed record Response252(long Id);

public sealed partial class Request252TraditionalHandler
	: Mediator.IRequestHandler<Request252, Response252>,
	MediatR.IRequestHandler<Request252, Response252>
{
	ValueTask<Response252> Mediator.IRequestHandler<Request252, Response252>.Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response252> MediatR.IRequestHandler<Request252, Response252>.Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request252StaticHandler
{
	private static ValueTask<Response252> Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request252SealedHandler
{
	private ValueTask<Response252> Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request253(long Id) : Mediator.IRequest<Response253>, MediatR.IRequest<Response253>;

public sealed record Response253(long Id);

public sealed partial class Request253TraditionalHandler
	: Mediator.IRequestHandler<Request253, Response253>,
	MediatR.IRequestHandler<Request253, Response253>
{
	ValueTask<Response253> Mediator.IRequestHandler<Request253, Response253>.Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response253> MediatR.IRequestHandler<Request253, Response253>.Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request253StaticHandler
{
	private static ValueTask<Response253> Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request253SealedHandler
{
	private ValueTask<Response253> Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request254(long Id) : Mediator.IRequest<Response254>, MediatR.IRequest<Response254>;

public sealed record Response254(long Id);

public sealed partial class Request254TraditionalHandler
	: Mediator.IRequestHandler<Request254, Response254>,
	MediatR.IRequestHandler<Request254, Response254>
{
	ValueTask<Response254> Mediator.IRequestHandler<Request254, Response254>.Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response254> MediatR.IRequestHandler<Request254, Response254>.Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request254StaticHandler
{
	private static ValueTask<Response254> Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request254SealedHandler
{
	private ValueTask<Response254> Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request255(long Id) : Mediator.IRequest<Response255>, MediatR.IRequest<Response255>;

public sealed record Response255(long Id);

public sealed partial class Request255TraditionalHandler
	: Mediator.IRequestHandler<Request255, Response255>,
	MediatR.IRequestHandler<Request255, Response255>
{
	ValueTask<Response255> Mediator.IRequestHandler<Request255, Response255>.Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response255> MediatR.IRequestHandler<Request255, Response255>.Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request255StaticHandler
{
	private static ValueTask<Response255> Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request255SealedHandler
{
	private ValueTask<Response255> Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request256(long Id) : Mediator.IRequest<Response256>, MediatR.IRequest<Response256>;

public sealed record Response256(long Id);

public sealed partial class Request256TraditionalHandler
	: Mediator.IRequestHandler<Request256, Response256>,
	MediatR.IRequestHandler<Request256, Response256>
{
	ValueTask<Response256> Mediator.IRequestHandler<Request256, Response256>.Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response256> MediatR.IRequestHandler<Request256, Response256>.Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request256StaticHandler
{
	private static ValueTask<Response256> Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request256SealedHandler
{
	private ValueTask<Response256> Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request257(long Id) : Mediator.IRequest<Response257>, MediatR.IRequest<Response257>;

public sealed record Response257(long Id);

public sealed partial class Request257TraditionalHandler
	: Mediator.IRequestHandler<Request257, Response257>,
	MediatR.IRequestHandler<Request257, Response257>
{
	ValueTask<Response257> Mediator.IRequestHandler<Request257, Response257>.Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response257> MediatR.IRequestHandler<Request257, Response257>.Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request257StaticHandler
{
	private static ValueTask<Response257> Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request257SealedHandler
{
	private ValueTask<Response257> Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request258(long Id) : Mediator.IRequest<Response258>, MediatR.IRequest<Response258>;

public sealed record Response258(long Id);

public sealed partial class Request258TraditionalHandler
	: Mediator.IRequestHandler<Request258, Response258>,
	MediatR.IRequestHandler<Request258, Response258>
{
	ValueTask<Response258> Mediator.IRequestHandler<Request258, Response258>.Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response258> MediatR.IRequestHandler<Request258, Response258>.Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request258StaticHandler
{
	private static ValueTask<Response258> Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request258SealedHandler
{
	private ValueTask<Response258> Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request259(long Id) : Mediator.IRequest<Response259>, MediatR.IRequest<Response259>;

public sealed record Response259(long Id);

public sealed partial class Request259TraditionalHandler
	: Mediator.IRequestHandler<Request259, Response259>,
	MediatR.IRequestHandler<Request259, Response259>
{
	ValueTask<Response259> Mediator.IRequestHandler<Request259, Response259>.Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response259> MediatR.IRequestHandler<Request259, Response259>.Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request259StaticHandler
{
	private static ValueTask<Response259> Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request259SealedHandler
{
	private ValueTask<Response259> Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request260(long Id) : Mediator.IRequest<Response260>, MediatR.IRequest<Response260>;

public sealed record Response260(long Id);

public sealed partial class Request260TraditionalHandler
	: Mediator.IRequestHandler<Request260, Response260>,
	MediatR.IRequestHandler<Request260, Response260>
{
	ValueTask<Response260> Mediator.IRequestHandler<Request260, Response260>.Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response260> MediatR.IRequestHandler<Request260, Response260>.Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request260StaticHandler
{
	private static ValueTask<Response260> Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request260SealedHandler
{
	private ValueTask<Response260> Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request261(long Id) : Mediator.IRequest<Response261>, MediatR.IRequest<Response261>;

public sealed record Response261(long Id);

public sealed partial class Request261TraditionalHandler
	: Mediator.IRequestHandler<Request261, Response261>,
	MediatR.IRequestHandler<Request261, Response261>
{
	ValueTask<Response261> Mediator.IRequestHandler<Request261, Response261>.Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response261> MediatR.IRequestHandler<Request261, Response261>.Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request261StaticHandler
{
	private static ValueTask<Response261> Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request261SealedHandler
{
	private ValueTask<Response261> Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request262(long Id) : Mediator.IRequest<Response262>, MediatR.IRequest<Response262>;

public sealed record Response262(long Id);

public sealed partial class Request262TraditionalHandler
	: Mediator.IRequestHandler<Request262, Response262>,
	MediatR.IRequestHandler<Request262, Response262>
{
	ValueTask<Response262> Mediator.IRequestHandler<Request262, Response262>.Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response262> MediatR.IRequestHandler<Request262, Response262>.Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request262StaticHandler
{
	private static ValueTask<Response262> Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request262SealedHandler
{
	private ValueTask<Response262> Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request263(long Id) : Mediator.IRequest<Response263>, MediatR.IRequest<Response263>;

public sealed record Response263(long Id);

public sealed partial class Request263TraditionalHandler
	: Mediator.IRequestHandler<Request263, Response263>,
	MediatR.IRequestHandler<Request263, Response263>
{
	ValueTask<Response263> Mediator.IRequestHandler<Request263, Response263>.Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response263> MediatR.IRequestHandler<Request263, Response263>.Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request263StaticHandler
{
	private static ValueTask<Response263> Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request263SealedHandler
{
	private ValueTask<Response263> Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request264(long Id) : Mediator.IRequest<Response264>, MediatR.IRequest<Response264>;

public sealed record Response264(long Id);

public sealed partial class Request264TraditionalHandler
	: Mediator.IRequestHandler<Request264, Response264>,
	MediatR.IRequestHandler<Request264, Response264>
{
	ValueTask<Response264> Mediator.IRequestHandler<Request264, Response264>.Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response264> MediatR.IRequestHandler<Request264, Response264>.Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request264StaticHandler
{
	private static ValueTask<Response264> Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request264SealedHandler
{
	private ValueTask<Response264> Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request265(long Id) : Mediator.IRequest<Response265>, MediatR.IRequest<Response265>;

public sealed record Response265(long Id);

public sealed partial class Request265TraditionalHandler
	: Mediator.IRequestHandler<Request265, Response265>,
	MediatR.IRequestHandler<Request265, Response265>
{
	ValueTask<Response265> Mediator.IRequestHandler<Request265, Response265>.Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response265> MediatR.IRequestHandler<Request265, Response265>.Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request265StaticHandler
{
	private static ValueTask<Response265> Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request265SealedHandler
{
	private ValueTask<Response265> Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request266(long Id) : Mediator.IRequest<Response266>, MediatR.IRequest<Response266>;

public sealed record Response266(long Id);

public sealed partial class Request266TraditionalHandler
	: Mediator.IRequestHandler<Request266, Response266>,
	MediatR.IRequestHandler<Request266, Response266>
{
	ValueTask<Response266> Mediator.IRequestHandler<Request266, Response266>.Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response266> MediatR.IRequestHandler<Request266, Response266>.Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request266StaticHandler
{
	private static ValueTask<Response266> Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request266SealedHandler
{
	private ValueTask<Response266> Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request267(long Id) : Mediator.IRequest<Response267>, MediatR.IRequest<Response267>;

public sealed record Response267(long Id);

public sealed partial class Request267TraditionalHandler
	: Mediator.IRequestHandler<Request267, Response267>,
	MediatR.IRequestHandler<Request267, Response267>
{
	ValueTask<Response267> Mediator.IRequestHandler<Request267, Response267>.Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response267> MediatR.IRequestHandler<Request267, Response267>.Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request267StaticHandler
{
	private static ValueTask<Response267> Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request267SealedHandler
{
	private ValueTask<Response267> Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request268(long Id) : Mediator.IRequest<Response268>, MediatR.IRequest<Response268>;

public sealed record Response268(long Id);

public sealed partial class Request268TraditionalHandler
	: Mediator.IRequestHandler<Request268, Response268>,
	MediatR.IRequestHandler<Request268, Response268>
{
	ValueTask<Response268> Mediator.IRequestHandler<Request268, Response268>.Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response268> MediatR.IRequestHandler<Request268, Response268>.Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request268StaticHandler
{
	private static ValueTask<Response268> Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request268SealedHandler
{
	private ValueTask<Response268> Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request269(long Id) : Mediator.IRequest<Response269>, MediatR.IRequest<Response269>;

public sealed record Response269(long Id);

public sealed partial class Request269TraditionalHandler
	: Mediator.IRequestHandler<Request269, Response269>,
	MediatR.IRequestHandler<Request269, Response269>
{
	ValueTask<Response269> Mediator.IRequestHandler<Request269, Response269>.Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response269> MediatR.IRequestHandler<Request269, Response269>.Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request269StaticHandler
{
	private static ValueTask<Response269> Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request269SealedHandler
{
	private ValueTask<Response269> Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request270(long Id) : Mediator.IRequest<Response270>, MediatR.IRequest<Response270>;

public sealed record Response270(long Id);

public sealed partial class Request270TraditionalHandler
	: Mediator.IRequestHandler<Request270, Response270>,
	MediatR.IRequestHandler<Request270, Response270>
{
	ValueTask<Response270> Mediator.IRequestHandler<Request270, Response270>.Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response270> MediatR.IRequestHandler<Request270, Response270>.Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request270StaticHandler
{
	private static ValueTask<Response270> Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request270SealedHandler
{
	private ValueTask<Response270> Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request271(long Id) : Mediator.IRequest<Response271>, MediatR.IRequest<Response271>;

public sealed record Response271(long Id);

public sealed partial class Request271TraditionalHandler
	: Mediator.IRequestHandler<Request271, Response271>,
	MediatR.IRequestHandler<Request271, Response271>
{
	ValueTask<Response271> Mediator.IRequestHandler<Request271, Response271>.Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response271> MediatR.IRequestHandler<Request271, Response271>.Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request271StaticHandler
{
	private static ValueTask<Response271> Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request271SealedHandler
{
	private ValueTask<Response271> Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request272(long Id) : Mediator.IRequest<Response272>, MediatR.IRequest<Response272>;

public sealed record Response272(long Id);

public sealed partial class Request272TraditionalHandler
	: Mediator.IRequestHandler<Request272, Response272>,
	MediatR.IRequestHandler<Request272, Response272>
{
	ValueTask<Response272> Mediator.IRequestHandler<Request272, Response272>.Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response272> MediatR.IRequestHandler<Request272, Response272>.Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request272StaticHandler
{
	private static ValueTask<Response272> Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request272SealedHandler
{
	private ValueTask<Response272> Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request273(long Id) : Mediator.IRequest<Response273>, MediatR.IRequest<Response273>;

public sealed record Response273(long Id);

public sealed partial class Request273TraditionalHandler
	: Mediator.IRequestHandler<Request273, Response273>,
	MediatR.IRequestHandler<Request273, Response273>
{
	ValueTask<Response273> Mediator.IRequestHandler<Request273, Response273>.Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response273> MediatR.IRequestHandler<Request273, Response273>.Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request273StaticHandler
{
	private static ValueTask<Response273> Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request273SealedHandler
{
	private ValueTask<Response273> Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request274(long Id) : Mediator.IRequest<Response274>, MediatR.IRequest<Response274>;

public sealed record Response274(long Id);

public sealed partial class Request274TraditionalHandler
	: Mediator.IRequestHandler<Request274, Response274>,
	MediatR.IRequestHandler<Request274, Response274>
{
	ValueTask<Response274> Mediator.IRequestHandler<Request274, Response274>.Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response274> MediatR.IRequestHandler<Request274, Response274>.Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request274StaticHandler
{
	private static ValueTask<Response274> Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request274SealedHandler
{
	private ValueTask<Response274> Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request275(long Id) : Mediator.IRequest<Response275>, MediatR.IRequest<Response275>;

public sealed record Response275(long Id);

public sealed partial class Request275TraditionalHandler
	: Mediator.IRequestHandler<Request275, Response275>,
	MediatR.IRequestHandler<Request275, Response275>
{
	ValueTask<Response275> Mediator.IRequestHandler<Request275, Response275>.Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response275> MediatR.IRequestHandler<Request275, Response275>.Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request275StaticHandler
{
	private static ValueTask<Response275> Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request275SealedHandler
{
	private ValueTask<Response275> Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request276(long Id) : Mediator.IRequest<Response276>, MediatR.IRequest<Response276>;

public sealed record Response276(long Id);

public sealed partial class Request276TraditionalHandler
	: Mediator.IRequestHandler<Request276, Response276>,
	MediatR.IRequestHandler<Request276, Response276>
{
	ValueTask<Response276> Mediator.IRequestHandler<Request276, Response276>.Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response276> MediatR.IRequestHandler<Request276, Response276>.Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request276StaticHandler
{
	private static ValueTask<Response276> Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request276SealedHandler
{
	private ValueTask<Response276> Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request277(long Id) : Mediator.IRequest<Response277>, MediatR.IRequest<Response277>;

public sealed record Response277(long Id);

public sealed partial class Request277TraditionalHandler
	: Mediator.IRequestHandler<Request277, Response277>,
	MediatR.IRequestHandler<Request277, Response277>
{
	ValueTask<Response277> Mediator.IRequestHandler<Request277, Response277>.Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response277> MediatR.IRequestHandler<Request277, Response277>.Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request277StaticHandler
{
	private static ValueTask<Response277> Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request277SealedHandler
{
	private ValueTask<Response277> Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request278(long Id) : Mediator.IRequest<Response278>, MediatR.IRequest<Response278>;

public sealed record Response278(long Id);

public sealed partial class Request278TraditionalHandler
	: Mediator.IRequestHandler<Request278, Response278>,
	MediatR.IRequestHandler<Request278, Response278>
{
	ValueTask<Response278> Mediator.IRequestHandler<Request278, Response278>.Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response278> MediatR.IRequestHandler<Request278, Response278>.Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request278StaticHandler
{
	private static ValueTask<Response278> Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request278SealedHandler
{
	private ValueTask<Response278> Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request279(long Id) : Mediator.IRequest<Response279>, MediatR.IRequest<Response279>;

public sealed record Response279(long Id);

public sealed partial class Request279TraditionalHandler
	: Mediator.IRequestHandler<Request279, Response279>,
	MediatR.IRequestHandler<Request279, Response279>
{
	ValueTask<Response279> Mediator.IRequestHandler<Request279, Response279>.Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response279> MediatR.IRequestHandler<Request279, Response279>.Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request279StaticHandler
{
	private static ValueTask<Response279> Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request279SealedHandler
{
	private ValueTask<Response279> Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request280(long Id) : Mediator.IRequest<Response280>, MediatR.IRequest<Response280>;

public sealed record Response280(long Id);

public sealed partial class Request280TraditionalHandler
	: Mediator.IRequestHandler<Request280, Response280>,
	MediatR.IRequestHandler<Request280, Response280>
{
	ValueTask<Response280> Mediator.IRequestHandler<Request280, Response280>.Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response280> MediatR.IRequestHandler<Request280, Response280>.Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request280StaticHandler
{
	private static ValueTask<Response280> Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request280SealedHandler
{
	private ValueTask<Response280> Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request281(long Id) : Mediator.IRequest<Response281>, MediatR.IRequest<Response281>;

public sealed record Response281(long Id);

public sealed partial class Request281TraditionalHandler
	: Mediator.IRequestHandler<Request281, Response281>,
	MediatR.IRequestHandler<Request281, Response281>
{
	ValueTask<Response281> Mediator.IRequestHandler<Request281, Response281>.Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response281> MediatR.IRequestHandler<Request281, Response281>.Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request281StaticHandler
{
	private static ValueTask<Response281> Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request281SealedHandler
{
	private ValueTask<Response281> Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request282(long Id) : Mediator.IRequest<Response282>, MediatR.IRequest<Response282>;

public sealed record Response282(long Id);

public sealed partial class Request282TraditionalHandler
	: Mediator.IRequestHandler<Request282, Response282>,
	MediatR.IRequestHandler<Request282, Response282>
{
	ValueTask<Response282> Mediator.IRequestHandler<Request282, Response282>.Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response282> MediatR.IRequestHandler<Request282, Response282>.Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request282StaticHandler
{
	private static ValueTask<Response282> Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request282SealedHandler
{
	private ValueTask<Response282> Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request283(long Id) : Mediator.IRequest<Response283>, MediatR.IRequest<Response283>;

public sealed record Response283(long Id);

public sealed partial class Request283TraditionalHandler
	: Mediator.IRequestHandler<Request283, Response283>,
	MediatR.IRequestHandler<Request283, Response283>
{
	ValueTask<Response283> Mediator.IRequestHandler<Request283, Response283>.Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response283> MediatR.IRequestHandler<Request283, Response283>.Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request283StaticHandler
{
	private static ValueTask<Response283> Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request283SealedHandler
{
	private ValueTask<Response283> Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request284(long Id) : Mediator.IRequest<Response284>, MediatR.IRequest<Response284>;

public sealed record Response284(long Id);

public sealed partial class Request284TraditionalHandler
	: Mediator.IRequestHandler<Request284, Response284>,
	MediatR.IRequestHandler<Request284, Response284>
{
	ValueTask<Response284> Mediator.IRequestHandler<Request284, Response284>.Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response284> MediatR.IRequestHandler<Request284, Response284>.Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request284StaticHandler
{
	private static ValueTask<Response284> Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request284SealedHandler
{
	private ValueTask<Response284> Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request285(long Id) : Mediator.IRequest<Response285>, MediatR.IRequest<Response285>;

public sealed record Response285(long Id);

public sealed partial class Request285TraditionalHandler
	: Mediator.IRequestHandler<Request285, Response285>,
	MediatR.IRequestHandler<Request285, Response285>
{
	ValueTask<Response285> Mediator.IRequestHandler<Request285, Response285>.Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response285> MediatR.IRequestHandler<Request285, Response285>.Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request285StaticHandler
{
	private static ValueTask<Response285> Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request285SealedHandler
{
	private ValueTask<Response285> Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request286(long Id) : Mediator.IRequest<Response286>, MediatR.IRequest<Response286>;

public sealed record Response286(long Id);

public sealed partial class Request286TraditionalHandler
	: Mediator.IRequestHandler<Request286, Response286>,
	MediatR.IRequestHandler<Request286, Response286>
{
	ValueTask<Response286> Mediator.IRequestHandler<Request286, Response286>.Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response286> MediatR.IRequestHandler<Request286, Response286>.Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request286StaticHandler
{
	private static ValueTask<Response286> Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request286SealedHandler
{
	private ValueTask<Response286> Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request287(long Id) : Mediator.IRequest<Response287>, MediatR.IRequest<Response287>;

public sealed record Response287(long Id);

public sealed partial class Request287TraditionalHandler
	: Mediator.IRequestHandler<Request287, Response287>,
	MediatR.IRequestHandler<Request287, Response287>
{
	ValueTask<Response287> Mediator.IRequestHandler<Request287, Response287>.Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response287> MediatR.IRequestHandler<Request287, Response287>.Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request287StaticHandler
{
	private static ValueTask<Response287> Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request287SealedHandler
{
	private ValueTask<Response287> Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request288(long Id) : Mediator.IRequest<Response288>, MediatR.IRequest<Response288>;

public sealed record Response288(long Id);

public sealed partial class Request288TraditionalHandler
	: Mediator.IRequestHandler<Request288, Response288>,
	MediatR.IRequestHandler<Request288, Response288>
{
	ValueTask<Response288> Mediator.IRequestHandler<Request288, Response288>.Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response288> MediatR.IRequestHandler<Request288, Response288>.Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request288StaticHandler
{
	private static ValueTask<Response288> Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request288SealedHandler
{
	private ValueTask<Response288> Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request289(long Id) : Mediator.IRequest<Response289>, MediatR.IRequest<Response289>;

public sealed record Response289(long Id);

public sealed partial class Request289TraditionalHandler
	: Mediator.IRequestHandler<Request289, Response289>,
	MediatR.IRequestHandler<Request289, Response289>
{
	ValueTask<Response289> Mediator.IRequestHandler<Request289, Response289>.Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response289> MediatR.IRequestHandler<Request289, Response289>.Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request289StaticHandler
{
	private static ValueTask<Response289> Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request289SealedHandler
{
	private ValueTask<Response289> Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request290(long Id) : Mediator.IRequest<Response290>, MediatR.IRequest<Response290>;

public sealed record Response290(long Id);

public sealed partial class Request290TraditionalHandler
	: Mediator.IRequestHandler<Request290, Response290>,
	MediatR.IRequestHandler<Request290, Response290>
{
	ValueTask<Response290> Mediator.IRequestHandler<Request290, Response290>.Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response290> MediatR.IRequestHandler<Request290, Response290>.Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request290StaticHandler
{
	private static ValueTask<Response290> Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request290SealedHandler
{
	private ValueTask<Response290> Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request291(long Id) : Mediator.IRequest<Response291>, MediatR.IRequest<Response291>;

public sealed record Response291(long Id);

public sealed partial class Request291TraditionalHandler
	: Mediator.IRequestHandler<Request291, Response291>,
	MediatR.IRequestHandler<Request291, Response291>
{
	ValueTask<Response291> Mediator.IRequestHandler<Request291, Response291>.Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response291> MediatR.IRequestHandler<Request291, Response291>.Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request291StaticHandler
{
	private static ValueTask<Response291> Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request291SealedHandler
{
	private ValueTask<Response291> Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request292(long Id) : Mediator.IRequest<Response292>, MediatR.IRequest<Response292>;

public sealed record Response292(long Id);

public sealed partial class Request292TraditionalHandler
	: Mediator.IRequestHandler<Request292, Response292>,
	MediatR.IRequestHandler<Request292, Response292>
{
	ValueTask<Response292> Mediator.IRequestHandler<Request292, Response292>.Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response292> MediatR.IRequestHandler<Request292, Response292>.Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request292StaticHandler
{
	private static ValueTask<Response292> Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request292SealedHandler
{
	private ValueTask<Response292> Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request293(long Id) : Mediator.IRequest<Response293>, MediatR.IRequest<Response293>;

public sealed record Response293(long Id);

public sealed partial class Request293TraditionalHandler
	: Mediator.IRequestHandler<Request293, Response293>,
	MediatR.IRequestHandler<Request293, Response293>
{
	ValueTask<Response293> Mediator.IRequestHandler<Request293, Response293>.Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response293> MediatR.IRequestHandler<Request293, Response293>.Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request293StaticHandler
{
	private static ValueTask<Response293> Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request293SealedHandler
{
	private ValueTask<Response293> Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request294(long Id) : Mediator.IRequest<Response294>, MediatR.IRequest<Response294>;

public sealed record Response294(long Id);

public sealed partial class Request294TraditionalHandler
	: Mediator.IRequestHandler<Request294, Response294>,
	MediatR.IRequestHandler<Request294, Response294>
{
	ValueTask<Response294> Mediator.IRequestHandler<Request294, Response294>.Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response294> MediatR.IRequestHandler<Request294, Response294>.Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request294StaticHandler
{
	private static ValueTask<Response294> Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request294SealedHandler
{
	private ValueTask<Response294> Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request295(long Id) : Mediator.IRequest<Response295>, MediatR.IRequest<Response295>;

public sealed record Response295(long Id);

public sealed partial class Request295TraditionalHandler
	: Mediator.IRequestHandler<Request295, Response295>,
	MediatR.IRequestHandler<Request295, Response295>
{
	ValueTask<Response295> Mediator.IRequestHandler<Request295, Response295>.Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response295> MediatR.IRequestHandler<Request295, Response295>.Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request295StaticHandler
{
	private static ValueTask<Response295> Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request295SealedHandler
{
	private ValueTask<Response295> Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request296(long Id) : Mediator.IRequest<Response296>, MediatR.IRequest<Response296>;

public sealed record Response296(long Id);

public sealed partial class Request296TraditionalHandler
	: Mediator.IRequestHandler<Request296, Response296>,
	MediatR.IRequestHandler<Request296, Response296>
{
	ValueTask<Response296> Mediator.IRequestHandler<Request296, Response296>.Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response296> MediatR.IRequestHandler<Request296, Response296>.Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request296StaticHandler
{
	private static ValueTask<Response296> Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request296SealedHandler
{
	private ValueTask<Response296> Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request297(long Id) : Mediator.IRequest<Response297>, MediatR.IRequest<Response297>;

public sealed record Response297(long Id);

public sealed partial class Request297TraditionalHandler
	: Mediator.IRequestHandler<Request297, Response297>,
	MediatR.IRequestHandler<Request297, Response297>
{
	ValueTask<Response297> Mediator.IRequestHandler<Request297, Response297>.Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response297> MediatR.IRequestHandler<Request297, Response297>.Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request297StaticHandler
{
	private static ValueTask<Response297> Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request297SealedHandler
{
	private ValueTask<Response297> Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request298(long Id) : Mediator.IRequest<Response298>, MediatR.IRequest<Response298>;

public sealed record Response298(long Id);

public sealed partial class Request298TraditionalHandler
	: Mediator.IRequestHandler<Request298, Response298>,
	MediatR.IRequestHandler<Request298, Response298>
{
	ValueTask<Response298> Mediator.IRequestHandler<Request298, Response298>.Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response298> MediatR.IRequestHandler<Request298, Response298>.Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request298StaticHandler
{
	private static ValueTask<Response298> Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request298SealedHandler
{
	private ValueTask<Response298> Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request299(long Id) : Mediator.IRequest<Response299>, MediatR.IRequest<Response299>;

public sealed record Response299(long Id);

public sealed partial class Request299TraditionalHandler
	: Mediator.IRequestHandler<Request299, Response299>,
	MediatR.IRequestHandler<Request299, Response299>
{
	ValueTask<Response299> Mediator.IRequestHandler<Request299, Response299>.Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response299> MediatR.IRequestHandler<Request299, Response299>.Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request299StaticHandler
{
	private static ValueTask<Response299> Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request299SealedHandler
{
	private ValueTask<Response299> Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request300(long Id) : Mediator.IRequest<Response300>, MediatR.IRequest<Response300>;

public sealed record Response300(long Id);

public sealed partial class Request300TraditionalHandler
	: Mediator.IRequestHandler<Request300, Response300>,
	MediatR.IRequestHandler<Request300, Response300>
{
	ValueTask<Response300> Mediator.IRequestHandler<Request300, Response300>.Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response300> MediatR.IRequestHandler<Request300, Response300>.Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request300StaticHandler
{
	private static ValueTask<Response300> Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request300SealedHandler
{
	private ValueTask<Response300> Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request301(long Id) : Mediator.IRequest<Response301>, MediatR.IRequest<Response301>;

public sealed record Response301(long Id);

public sealed partial class Request301TraditionalHandler
	: Mediator.IRequestHandler<Request301, Response301>,
	MediatR.IRequestHandler<Request301, Response301>
{
	ValueTask<Response301> Mediator.IRequestHandler<Request301, Response301>.Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response301> MediatR.IRequestHandler<Request301, Response301>.Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request301StaticHandler
{
	private static ValueTask<Response301> Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request301SealedHandler
{
	private ValueTask<Response301> Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request302(long Id) : Mediator.IRequest<Response302>, MediatR.IRequest<Response302>;

public sealed record Response302(long Id);

public sealed partial class Request302TraditionalHandler
	: Mediator.IRequestHandler<Request302, Response302>,
	MediatR.IRequestHandler<Request302, Response302>
{
	ValueTask<Response302> Mediator.IRequestHandler<Request302, Response302>.Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response302> MediatR.IRequestHandler<Request302, Response302>.Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request302StaticHandler
{
	private static ValueTask<Response302> Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request302SealedHandler
{
	private ValueTask<Response302> Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request303(long Id) : Mediator.IRequest<Response303>, MediatR.IRequest<Response303>;

public sealed record Response303(long Id);

public sealed partial class Request303TraditionalHandler
	: Mediator.IRequestHandler<Request303, Response303>,
	MediatR.IRequestHandler<Request303, Response303>
{
	ValueTask<Response303> Mediator.IRequestHandler<Request303, Response303>.Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response303> MediatR.IRequestHandler<Request303, Response303>.Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request303StaticHandler
{
	private static ValueTask<Response303> Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request303SealedHandler
{
	private ValueTask<Response303> Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request304(long Id) : Mediator.IRequest<Response304>, MediatR.IRequest<Response304>;

public sealed record Response304(long Id);

public sealed partial class Request304TraditionalHandler
	: Mediator.IRequestHandler<Request304, Response304>,
	MediatR.IRequestHandler<Request304, Response304>
{
	ValueTask<Response304> Mediator.IRequestHandler<Request304, Response304>.Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response304> MediatR.IRequestHandler<Request304, Response304>.Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request304StaticHandler
{
	private static ValueTask<Response304> Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request304SealedHandler
{
	private ValueTask<Response304> Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request305(long Id) : Mediator.IRequest<Response305>, MediatR.IRequest<Response305>;

public sealed record Response305(long Id);

public sealed partial class Request305TraditionalHandler
	: Mediator.IRequestHandler<Request305, Response305>,
	MediatR.IRequestHandler<Request305, Response305>
{
	ValueTask<Response305> Mediator.IRequestHandler<Request305, Response305>.Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response305> MediatR.IRequestHandler<Request305, Response305>.Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request305StaticHandler
{
	private static ValueTask<Response305> Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request305SealedHandler
{
	private ValueTask<Response305> Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request306(long Id) : Mediator.IRequest<Response306>, MediatR.IRequest<Response306>;

public sealed record Response306(long Id);

public sealed partial class Request306TraditionalHandler
	: Mediator.IRequestHandler<Request306, Response306>,
	MediatR.IRequestHandler<Request306, Response306>
{
	ValueTask<Response306> Mediator.IRequestHandler<Request306, Response306>.Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response306> MediatR.IRequestHandler<Request306, Response306>.Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request306StaticHandler
{
	private static ValueTask<Response306> Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request306SealedHandler
{
	private ValueTask<Response306> Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request307(long Id) : Mediator.IRequest<Response307>, MediatR.IRequest<Response307>;

public sealed record Response307(long Id);

public sealed partial class Request307TraditionalHandler
	: Mediator.IRequestHandler<Request307, Response307>,
	MediatR.IRequestHandler<Request307, Response307>
{
	ValueTask<Response307> Mediator.IRequestHandler<Request307, Response307>.Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response307> MediatR.IRequestHandler<Request307, Response307>.Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request307StaticHandler
{
	private static ValueTask<Response307> Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request307SealedHandler
{
	private ValueTask<Response307> Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request308(long Id) : Mediator.IRequest<Response308>, MediatR.IRequest<Response308>;

public sealed record Response308(long Id);

public sealed partial class Request308TraditionalHandler
	: Mediator.IRequestHandler<Request308, Response308>,
	MediatR.IRequestHandler<Request308, Response308>
{
	ValueTask<Response308> Mediator.IRequestHandler<Request308, Response308>.Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response308> MediatR.IRequestHandler<Request308, Response308>.Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request308StaticHandler
{
	private static ValueTask<Response308> Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request308SealedHandler
{
	private ValueTask<Response308> Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request309(long Id) : Mediator.IRequest<Response309>, MediatR.IRequest<Response309>;

public sealed record Response309(long Id);

public sealed partial class Request309TraditionalHandler
	: Mediator.IRequestHandler<Request309, Response309>,
	MediatR.IRequestHandler<Request309, Response309>
{
	ValueTask<Response309> Mediator.IRequestHandler<Request309, Response309>.Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response309> MediatR.IRequestHandler<Request309, Response309>.Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request309StaticHandler
{
	private static ValueTask<Response309> Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request309SealedHandler
{
	private ValueTask<Response309> Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request310(long Id) : Mediator.IRequest<Response310>, MediatR.IRequest<Response310>;

public sealed record Response310(long Id);

public sealed partial class Request310TraditionalHandler
	: Mediator.IRequestHandler<Request310, Response310>,
	MediatR.IRequestHandler<Request310, Response310>
{
	ValueTask<Response310> Mediator.IRequestHandler<Request310, Response310>.Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response310> MediatR.IRequestHandler<Request310, Response310>.Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request310StaticHandler
{
	private static ValueTask<Response310> Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request310SealedHandler
{
	private ValueTask<Response310> Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request311(long Id) : Mediator.IRequest<Response311>, MediatR.IRequest<Response311>;

public sealed record Response311(long Id);

public sealed partial class Request311TraditionalHandler
	: Mediator.IRequestHandler<Request311, Response311>,
	MediatR.IRequestHandler<Request311, Response311>
{
	ValueTask<Response311> Mediator.IRequestHandler<Request311, Response311>.Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response311> MediatR.IRequestHandler<Request311, Response311>.Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request311StaticHandler
{
	private static ValueTask<Response311> Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request311SealedHandler
{
	private ValueTask<Response311> Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request312(long Id) : Mediator.IRequest<Response312>, MediatR.IRequest<Response312>;

public sealed record Response312(long Id);

public sealed partial class Request312TraditionalHandler
	: Mediator.IRequestHandler<Request312, Response312>,
	MediatR.IRequestHandler<Request312, Response312>
{
	ValueTask<Response312> Mediator.IRequestHandler<Request312, Response312>.Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response312> MediatR.IRequestHandler<Request312, Response312>.Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request312StaticHandler
{
	private static ValueTask<Response312> Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request312SealedHandler
{
	private ValueTask<Response312> Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request313(long Id) : Mediator.IRequest<Response313>, MediatR.IRequest<Response313>;

public sealed record Response313(long Id);

public sealed partial class Request313TraditionalHandler
	: Mediator.IRequestHandler<Request313, Response313>,
	MediatR.IRequestHandler<Request313, Response313>
{
	ValueTask<Response313> Mediator.IRequestHandler<Request313, Response313>.Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response313> MediatR.IRequestHandler<Request313, Response313>.Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request313StaticHandler
{
	private static ValueTask<Response313> Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request313SealedHandler
{
	private ValueTask<Response313> Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request314(long Id) : Mediator.IRequest<Response314>, MediatR.IRequest<Response314>;

public sealed record Response314(long Id);

public sealed partial class Request314TraditionalHandler
	: Mediator.IRequestHandler<Request314, Response314>,
	MediatR.IRequestHandler<Request314, Response314>
{
	ValueTask<Response314> Mediator.IRequestHandler<Request314, Response314>.Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response314> MediatR.IRequestHandler<Request314, Response314>.Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request314StaticHandler
{
	private static ValueTask<Response314> Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request314SealedHandler
{
	private ValueTask<Response314> Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request315(long Id) : Mediator.IRequest<Response315>, MediatR.IRequest<Response315>;

public sealed record Response315(long Id);

public sealed partial class Request315TraditionalHandler
	: Mediator.IRequestHandler<Request315, Response315>,
	MediatR.IRequestHandler<Request315, Response315>
{
	ValueTask<Response315> Mediator.IRequestHandler<Request315, Response315>.Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response315> MediatR.IRequestHandler<Request315, Response315>.Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request315StaticHandler
{
	private static ValueTask<Response315> Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request315SealedHandler
{
	private ValueTask<Response315> Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request316(long Id) : Mediator.IRequest<Response316>, MediatR.IRequest<Response316>;

public sealed record Response316(long Id);

public sealed partial class Request316TraditionalHandler
	: Mediator.IRequestHandler<Request316, Response316>,
	MediatR.IRequestHandler<Request316, Response316>
{
	ValueTask<Response316> Mediator.IRequestHandler<Request316, Response316>.Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response316> MediatR.IRequestHandler<Request316, Response316>.Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request316StaticHandler
{
	private static ValueTask<Response316> Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request316SealedHandler
{
	private ValueTask<Response316> Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request317(long Id) : Mediator.IRequest<Response317>, MediatR.IRequest<Response317>;

public sealed record Response317(long Id);

public sealed partial class Request317TraditionalHandler
	: Mediator.IRequestHandler<Request317, Response317>,
	MediatR.IRequestHandler<Request317, Response317>
{
	ValueTask<Response317> Mediator.IRequestHandler<Request317, Response317>.Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response317> MediatR.IRequestHandler<Request317, Response317>.Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request317StaticHandler
{
	private static ValueTask<Response317> Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request317SealedHandler
{
	private ValueTask<Response317> Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request318(long Id) : Mediator.IRequest<Response318>, MediatR.IRequest<Response318>;

public sealed record Response318(long Id);

public sealed partial class Request318TraditionalHandler
	: Mediator.IRequestHandler<Request318, Response318>,
	MediatR.IRequestHandler<Request318, Response318>
{
	ValueTask<Response318> Mediator.IRequestHandler<Request318, Response318>.Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response318> MediatR.IRequestHandler<Request318, Response318>.Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request318StaticHandler
{
	private static ValueTask<Response318> Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request318SealedHandler
{
	private ValueTask<Response318> Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request319(long Id) : Mediator.IRequest<Response319>, MediatR.IRequest<Response319>;

public sealed record Response319(long Id);

public sealed partial class Request319TraditionalHandler
	: Mediator.IRequestHandler<Request319, Response319>,
	MediatR.IRequestHandler<Request319, Response319>
{
	ValueTask<Response319> Mediator.IRequestHandler<Request319, Response319>.Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response319> MediatR.IRequestHandler<Request319, Response319>.Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request319StaticHandler
{
	private static ValueTask<Response319> Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request319SealedHandler
{
	private ValueTask<Response319> Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request320(long Id) : Mediator.IRequest<Response320>, MediatR.IRequest<Response320>;

public sealed record Response320(long Id);

public sealed partial class Request320TraditionalHandler
	: Mediator.IRequestHandler<Request320, Response320>,
	MediatR.IRequestHandler<Request320, Response320>
{
	ValueTask<Response320> Mediator.IRequestHandler<Request320, Response320>.Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response320> MediatR.IRequestHandler<Request320, Response320>.Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request320StaticHandler
{
	private static ValueTask<Response320> Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request320SealedHandler
{
	private ValueTask<Response320> Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request321(long Id) : Mediator.IRequest<Response321>, MediatR.IRequest<Response321>;

public sealed record Response321(long Id);

public sealed partial class Request321TraditionalHandler
	: Mediator.IRequestHandler<Request321, Response321>,
	MediatR.IRequestHandler<Request321, Response321>
{
	ValueTask<Response321> Mediator.IRequestHandler<Request321, Response321>.Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response321> MediatR.IRequestHandler<Request321, Response321>.Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request321StaticHandler
{
	private static ValueTask<Response321> Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request321SealedHandler
{
	private ValueTask<Response321> Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request322(long Id) : Mediator.IRequest<Response322>, MediatR.IRequest<Response322>;

public sealed record Response322(long Id);

public sealed partial class Request322TraditionalHandler
	: Mediator.IRequestHandler<Request322, Response322>,
	MediatR.IRequestHandler<Request322, Response322>
{
	ValueTask<Response322> Mediator.IRequestHandler<Request322, Response322>.Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response322> MediatR.IRequestHandler<Request322, Response322>.Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request322StaticHandler
{
	private static ValueTask<Response322> Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request322SealedHandler
{
	private ValueTask<Response322> Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request323(long Id) : Mediator.IRequest<Response323>, MediatR.IRequest<Response323>;

public sealed record Response323(long Id);

public sealed partial class Request323TraditionalHandler
	: Mediator.IRequestHandler<Request323, Response323>,
	MediatR.IRequestHandler<Request323, Response323>
{
	ValueTask<Response323> Mediator.IRequestHandler<Request323, Response323>.Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response323> MediatR.IRequestHandler<Request323, Response323>.Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request323StaticHandler
{
	private static ValueTask<Response323> Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request323SealedHandler
{
	private ValueTask<Response323> Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request324(long Id) : Mediator.IRequest<Response324>, MediatR.IRequest<Response324>;

public sealed record Response324(long Id);

public sealed partial class Request324TraditionalHandler
	: Mediator.IRequestHandler<Request324, Response324>,
	MediatR.IRequestHandler<Request324, Response324>
{
	ValueTask<Response324> Mediator.IRequestHandler<Request324, Response324>.Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response324> MediatR.IRequestHandler<Request324, Response324>.Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request324StaticHandler
{
	private static ValueTask<Response324> Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request324SealedHandler
{
	private ValueTask<Response324> Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request325(long Id) : Mediator.IRequest<Response325>, MediatR.IRequest<Response325>;

public sealed record Response325(long Id);

public sealed partial class Request325TraditionalHandler
	: Mediator.IRequestHandler<Request325, Response325>,
	MediatR.IRequestHandler<Request325, Response325>
{
	ValueTask<Response325> Mediator.IRequestHandler<Request325, Response325>.Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response325> MediatR.IRequestHandler<Request325, Response325>.Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request325StaticHandler
{
	private static ValueTask<Response325> Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request325SealedHandler
{
	private ValueTask<Response325> Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request326(long Id) : Mediator.IRequest<Response326>, MediatR.IRequest<Response326>;

public sealed record Response326(long Id);

public sealed partial class Request326TraditionalHandler
	: Mediator.IRequestHandler<Request326, Response326>,
	MediatR.IRequestHandler<Request326, Response326>
{
	ValueTask<Response326> Mediator.IRequestHandler<Request326, Response326>.Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response326> MediatR.IRequestHandler<Request326, Response326>.Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request326StaticHandler
{
	private static ValueTask<Response326> Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request326SealedHandler
{
	private ValueTask<Response326> Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request327(long Id) : Mediator.IRequest<Response327>, MediatR.IRequest<Response327>;

public sealed record Response327(long Id);

public sealed partial class Request327TraditionalHandler
	: Mediator.IRequestHandler<Request327, Response327>,
	MediatR.IRequestHandler<Request327, Response327>
{
	ValueTask<Response327> Mediator.IRequestHandler<Request327, Response327>.Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response327> MediatR.IRequestHandler<Request327, Response327>.Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request327StaticHandler
{
	private static ValueTask<Response327> Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request327SealedHandler
{
	private ValueTask<Response327> Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request328(long Id) : Mediator.IRequest<Response328>, MediatR.IRequest<Response328>;

public sealed record Response328(long Id);

public sealed partial class Request328TraditionalHandler
	: Mediator.IRequestHandler<Request328, Response328>,
	MediatR.IRequestHandler<Request328, Response328>
{
	ValueTask<Response328> Mediator.IRequestHandler<Request328, Response328>.Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response328> MediatR.IRequestHandler<Request328, Response328>.Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request328StaticHandler
{
	private static ValueTask<Response328> Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request328SealedHandler
{
	private ValueTask<Response328> Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request329(long Id) : Mediator.IRequest<Response329>, MediatR.IRequest<Response329>;

public sealed record Response329(long Id);

public sealed partial class Request329TraditionalHandler
	: Mediator.IRequestHandler<Request329, Response329>,
	MediatR.IRequestHandler<Request329, Response329>
{
	ValueTask<Response329> Mediator.IRequestHandler<Request329, Response329>.Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response329> MediatR.IRequestHandler<Request329, Response329>.Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request329StaticHandler
{
	private static ValueTask<Response329> Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request329SealedHandler
{
	private ValueTask<Response329> Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request330(long Id) : Mediator.IRequest<Response330>, MediatR.IRequest<Response330>;

public sealed record Response330(long Id);

public sealed partial class Request330TraditionalHandler
	: Mediator.IRequestHandler<Request330, Response330>,
	MediatR.IRequestHandler<Request330, Response330>
{
	ValueTask<Response330> Mediator.IRequestHandler<Request330, Response330>.Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response330> MediatR.IRequestHandler<Request330, Response330>.Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request330StaticHandler
{
	private static ValueTask<Response330> Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request330SealedHandler
{
	private ValueTask<Response330> Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request331(long Id) : Mediator.IRequest<Response331>, MediatR.IRequest<Response331>;

public sealed record Response331(long Id);

public sealed partial class Request331TraditionalHandler
	: Mediator.IRequestHandler<Request331, Response331>,
	MediatR.IRequestHandler<Request331, Response331>
{
	ValueTask<Response331> Mediator.IRequestHandler<Request331, Response331>.Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response331> MediatR.IRequestHandler<Request331, Response331>.Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request331StaticHandler
{
	private static ValueTask<Response331> Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request331SealedHandler
{
	private ValueTask<Response331> Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request332(long Id) : Mediator.IRequest<Response332>, MediatR.IRequest<Response332>;

public sealed record Response332(long Id);

public sealed partial class Request332TraditionalHandler
	: Mediator.IRequestHandler<Request332, Response332>,
	MediatR.IRequestHandler<Request332, Response332>
{
	ValueTask<Response332> Mediator.IRequestHandler<Request332, Response332>.Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response332> MediatR.IRequestHandler<Request332, Response332>.Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request332StaticHandler
{
	private static ValueTask<Response332> Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request332SealedHandler
{
	private ValueTask<Response332> Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request333(long Id) : Mediator.IRequest<Response333>, MediatR.IRequest<Response333>;

public sealed record Response333(long Id);

public sealed partial class Request333TraditionalHandler
	: Mediator.IRequestHandler<Request333, Response333>,
	MediatR.IRequestHandler<Request333, Response333>
{
	ValueTask<Response333> Mediator.IRequestHandler<Request333, Response333>.Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response333> MediatR.IRequestHandler<Request333, Response333>.Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request333StaticHandler
{
	private static ValueTask<Response333> Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request333SealedHandler
{
	private ValueTask<Response333> Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request334(long Id) : Mediator.IRequest<Response334>, MediatR.IRequest<Response334>;

public sealed record Response334(long Id);

public sealed partial class Request334TraditionalHandler
	: Mediator.IRequestHandler<Request334, Response334>,
	MediatR.IRequestHandler<Request334, Response334>
{
	ValueTask<Response334> Mediator.IRequestHandler<Request334, Response334>.Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response334> MediatR.IRequestHandler<Request334, Response334>.Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request334StaticHandler
{
	private static ValueTask<Response334> Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request334SealedHandler
{
	private ValueTask<Response334> Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request335(long Id) : Mediator.IRequest<Response335>, MediatR.IRequest<Response335>;

public sealed record Response335(long Id);

public sealed partial class Request335TraditionalHandler
	: Mediator.IRequestHandler<Request335, Response335>,
	MediatR.IRequestHandler<Request335, Response335>
{
	ValueTask<Response335> Mediator.IRequestHandler<Request335, Response335>.Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response335> MediatR.IRequestHandler<Request335, Response335>.Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request335StaticHandler
{
	private static ValueTask<Response335> Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request335SealedHandler
{
	private ValueTask<Response335> Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request336(long Id) : Mediator.IRequest<Response336>, MediatR.IRequest<Response336>;

public sealed record Response336(long Id);

public sealed partial class Request336TraditionalHandler
	: Mediator.IRequestHandler<Request336, Response336>,
	MediatR.IRequestHandler<Request336, Response336>
{
	ValueTask<Response336> Mediator.IRequestHandler<Request336, Response336>.Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response336> MediatR.IRequestHandler<Request336, Response336>.Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request336StaticHandler
{
	private static ValueTask<Response336> Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request336SealedHandler
{
	private ValueTask<Response336> Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request337(long Id) : Mediator.IRequest<Response337>, MediatR.IRequest<Response337>;

public sealed record Response337(long Id);

public sealed partial class Request337TraditionalHandler
	: Mediator.IRequestHandler<Request337, Response337>,
	MediatR.IRequestHandler<Request337, Response337>
{
	ValueTask<Response337> Mediator.IRequestHandler<Request337, Response337>.Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response337> MediatR.IRequestHandler<Request337, Response337>.Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request337StaticHandler
{
	private static ValueTask<Response337> Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request337SealedHandler
{
	private ValueTask<Response337> Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request338(long Id) : Mediator.IRequest<Response338>, MediatR.IRequest<Response338>;

public sealed record Response338(long Id);

public sealed partial class Request338TraditionalHandler
	: Mediator.IRequestHandler<Request338, Response338>,
	MediatR.IRequestHandler<Request338, Response338>
{
	ValueTask<Response338> Mediator.IRequestHandler<Request338, Response338>.Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response338> MediatR.IRequestHandler<Request338, Response338>.Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request338StaticHandler
{
	private static ValueTask<Response338> Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request338SealedHandler
{
	private ValueTask<Response338> Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request339(long Id) : Mediator.IRequest<Response339>, MediatR.IRequest<Response339>;

public sealed record Response339(long Id);

public sealed partial class Request339TraditionalHandler
	: Mediator.IRequestHandler<Request339, Response339>,
	MediatR.IRequestHandler<Request339, Response339>
{
	ValueTask<Response339> Mediator.IRequestHandler<Request339, Response339>.Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response339> MediatR.IRequestHandler<Request339, Response339>.Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request339StaticHandler
{
	private static ValueTask<Response339> Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request339SealedHandler
{
	private ValueTask<Response339> Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request340(long Id) : Mediator.IRequest<Response340>, MediatR.IRequest<Response340>;

public sealed record Response340(long Id);

public sealed partial class Request340TraditionalHandler
	: Mediator.IRequestHandler<Request340, Response340>,
	MediatR.IRequestHandler<Request340, Response340>
{
	ValueTask<Response340> Mediator.IRequestHandler<Request340, Response340>.Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response340> MediatR.IRequestHandler<Request340, Response340>.Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request340StaticHandler
{
	private static ValueTask<Response340> Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request340SealedHandler
{
	private ValueTask<Response340> Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request341(long Id) : Mediator.IRequest<Response341>, MediatR.IRequest<Response341>;

public sealed record Response341(long Id);

public sealed partial class Request341TraditionalHandler
	: Mediator.IRequestHandler<Request341, Response341>,
	MediatR.IRequestHandler<Request341, Response341>
{
	ValueTask<Response341> Mediator.IRequestHandler<Request341, Response341>.Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response341> MediatR.IRequestHandler<Request341, Response341>.Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request341StaticHandler
{
	private static ValueTask<Response341> Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request341SealedHandler
{
	private ValueTask<Response341> Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request342(long Id) : Mediator.IRequest<Response342>, MediatR.IRequest<Response342>;

public sealed record Response342(long Id);

public sealed partial class Request342TraditionalHandler
	: Mediator.IRequestHandler<Request342, Response342>,
	MediatR.IRequestHandler<Request342, Response342>
{
	ValueTask<Response342> Mediator.IRequestHandler<Request342, Response342>.Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response342> MediatR.IRequestHandler<Request342, Response342>.Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request342StaticHandler
{
	private static ValueTask<Response342> Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request342SealedHandler
{
	private ValueTask<Response342> Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request343(long Id) : Mediator.IRequest<Response343>, MediatR.IRequest<Response343>;

public sealed record Response343(long Id);

public sealed partial class Request343TraditionalHandler
	: Mediator.IRequestHandler<Request343, Response343>,
	MediatR.IRequestHandler<Request343, Response343>
{
	ValueTask<Response343> Mediator.IRequestHandler<Request343, Response343>.Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response343> MediatR.IRequestHandler<Request343, Response343>.Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request343StaticHandler
{
	private static ValueTask<Response343> Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request343SealedHandler
{
	private ValueTask<Response343> Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request344(long Id) : Mediator.IRequest<Response344>, MediatR.IRequest<Response344>;

public sealed record Response344(long Id);

public sealed partial class Request344TraditionalHandler
	: Mediator.IRequestHandler<Request344, Response344>,
	MediatR.IRequestHandler<Request344, Response344>
{
	ValueTask<Response344> Mediator.IRequestHandler<Request344, Response344>.Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response344> MediatR.IRequestHandler<Request344, Response344>.Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request344StaticHandler
{
	private static ValueTask<Response344> Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request344SealedHandler
{
	private ValueTask<Response344> Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request345(long Id) : Mediator.IRequest<Response345>, MediatR.IRequest<Response345>;

public sealed record Response345(long Id);

public sealed partial class Request345TraditionalHandler
	: Mediator.IRequestHandler<Request345, Response345>,
	MediatR.IRequestHandler<Request345, Response345>
{
	ValueTask<Response345> Mediator.IRequestHandler<Request345, Response345>.Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response345> MediatR.IRequestHandler<Request345, Response345>.Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request345StaticHandler
{
	private static ValueTask<Response345> Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request345SealedHandler
{
	private ValueTask<Response345> Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request346(long Id) : Mediator.IRequest<Response346>, MediatR.IRequest<Response346>;

public sealed record Response346(long Id);

public sealed partial class Request346TraditionalHandler
	: Mediator.IRequestHandler<Request346, Response346>,
	MediatR.IRequestHandler<Request346, Response346>
{
	ValueTask<Response346> Mediator.IRequestHandler<Request346, Response346>.Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response346> MediatR.IRequestHandler<Request346, Response346>.Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request346StaticHandler
{
	private static ValueTask<Response346> Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request346SealedHandler
{
	private ValueTask<Response346> Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request347(long Id) : Mediator.IRequest<Response347>, MediatR.IRequest<Response347>;

public sealed record Response347(long Id);

public sealed partial class Request347TraditionalHandler
	: Mediator.IRequestHandler<Request347, Response347>,
	MediatR.IRequestHandler<Request347, Response347>
{
	ValueTask<Response347> Mediator.IRequestHandler<Request347, Response347>.Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response347> MediatR.IRequestHandler<Request347, Response347>.Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request347StaticHandler
{
	private static ValueTask<Response347> Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request347SealedHandler
{
	private ValueTask<Response347> Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request348(long Id) : Mediator.IRequest<Response348>, MediatR.IRequest<Response348>;

public sealed record Response348(long Id);

public sealed partial class Request348TraditionalHandler
	: Mediator.IRequestHandler<Request348, Response348>,
	MediatR.IRequestHandler<Request348, Response348>
{
	ValueTask<Response348> Mediator.IRequestHandler<Request348, Response348>.Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response348> MediatR.IRequestHandler<Request348, Response348>.Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request348StaticHandler
{
	private static ValueTask<Response348> Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request348SealedHandler
{
	private ValueTask<Response348> Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request349(long Id) : Mediator.IRequest<Response349>, MediatR.IRequest<Response349>;

public sealed record Response349(long Id);

public sealed partial class Request349TraditionalHandler
	: Mediator.IRequestHandler<Request349, Response349>,
	MediatR.IRequestHandler<Request349, Response349>
{
	ValueTask<Response349> Mediator.IRequestHandler<Request349, Response349>.Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response349> MediatR.IRequestHandler<Request349, Response349>.Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request349StaticHandler
{
	private static ValueTask<Response349> Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request349SealedHandler
{
	private ValueTask<Response349> Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request350(long Id) : Mediator.IRequest<Response350>, MediatR.IRequest<Response350>;

public sealed record Response350(long Id);

public sealed partial class Request350TraditionalHandler
	: Mediator.IRequestHandler<Request350, Response350>,
	MediatR.IRequestHandler<Request350, Response350>
{
	ValueTask<Response350> Mediator.IRequestHandler<Request350, Response350>.Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response350> MediatR.IRequestHandler<Request350, Response350>.Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request350StaticHandler
{
	private static ValueTask<Response350> Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request350SealedHandler
{
	private ValueTask<Response350> Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request351(long Id) : Mediator.IRequest<Response351>, MediatR.IRequest<Response351>;

public sealed record Response351(long Id);

public sealed partial class Request351TraditionalHandler
	: Mediator.IRequestHandler<Request351, Response351>,
	MediatR.IRequestHandler<Request351, Response351>
{
	ValueTask<Response351> Mediator.IRequestHandler<Request351, Response351>.Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response351> MediatR.IRequestHandler<Request351, Response351>.Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request351StaticHandler
{
	private static ValueTask<Response351> Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request351SealedHandler
{
	private ValueTask<Response351> Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request352(long Id) : Mediator.IRequest<Response352>, MediatR.IRequest<Response352>;

public sealed record Response352(long Id);

public sealed partial class Request352TraditionalHandler
	: Mediator.IRequestHandler<Request352, Response352>,
	MediatR.IRequestHandler<Request352, Response352>
{
	ValueTask<Response352> Mediator.IRequestHandler<Request352, Response352>.Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response352> MediatR.IRequestHandler<Request352, Response352>.Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request352StaticHandler
{
	private static ValueTask<Response352> Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request352SealedHandler
{
	private ValueTask<Response352> Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request353(long Id) : Mediator.IRequest<Response353>, MediatR.IRequest<Response353>;

public sealed record Response353(long Id);

public sealed partial class Request353TraditionalHandler
	: Mediator.IRequestHandler<Request353, Response353>,
	MediatR.IRequestHandler<Request353, Response353>
{
	ValueTask<Response353> Mediator.IRequestHandler<Request353, Response353>.Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response353> MediatR.IRequestHandler<Request353, Response353>.Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request353StaticHandler
{
	private static ValueTask<Response353> Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request353SealedHandler
{
	private ValueTask<Response353> Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request354(long Id) : Mediator.IRequest<Response354>, MediatR.IRequest<Response354>;

public sealed record Response354(long Id);

public sealed partial class Request354TraditionalHandler
	: Mediator.IRequestHandler<Request354, Response354>,
	MediatR.IRequestHandler<Request354, Response354>
{
	ValueTask<Response354> Mediator.IRequestHandler<Request354, Response354>.Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response354> MediatR.IRequestHandler<Request354, Response354>.Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request354StaticHandler
{
	private static ValueTask<Response354> Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request354SealedHandler
{
	private ValueTask<Response354> Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request355(long Id) : Mediator.IRequest<Response355>, MediatR.IRequest<Response355>;

public sealed record Response355(long Id);

public sealed partial class Request355TraditionalHandler
	: Mediator.IRequestHandler<Request355, Response355>,
	MediatR.IRequestHandler<Request355, Response355>
{
	ValueTask<Response355> Mediator.IRequestHandler<Request355, Response355>.Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response355> MediatR.IRequestHandler<Request355, Response355>.Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request355StaticHandler
{
	private static ValueTask<Response355> Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request355SealedHandler
{
	private ValueTask<Response355> Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request356(long Id) : Mediator.IRequest<Response356>, MediatR.IRequest<Response356>;

public sealed record Response356(long Id);

public sealed partial class Request356TraditionalHandler
	: Mediator.IRequestHandler<Request356, Response356>,
	MediatR.IRequestHandler<Request356, Response356>
{
	ValueTask<Response356> Mediator.IRequestHandler<Request356, Response356>.Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response356> MediatR.IRequestHandler<Request356, Response356>.Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request356StaticHandler
{
	private static ValueTask<Response356> Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request356SealedHandler
{
	private ValueTask<Response356> Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request357(long Id) : Mediator.IRequest<Response357>, MediatR.IRequest<Response357>;

public sealed record Response357(long Id);

public sealed partial class Request357TraditionalHandler
	: Mediator.IRequestHandler<Request357, Response357>,
	MediatR.IRequestHandler<Request357, Response357>
{
	ValueTask<Response357> Mediator.IRequestHandler<Request357, Response357>.Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response357> MediatR.IRequestHandler<Request357, Response357>.Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request357StaticHandler
{
	private static ValueTask<Response357> Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request357SealedHandler
{
	private ValueTask<Response357> Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request358(long Id) : Mediator.IRequest<Response358>, MediatR.IRequest<Response358>;

public sealed record Response358(long Id);

public sealed partial class Request358TraditionalHandler
	: Mediator.IRequestHandler<Request358, Response358>,
	MediatR.IRequestHandler<Request358, Response358>
{
	ValueTask<Response358> Mediator.IRequestHandler<Request358, Response358>.Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response358> MediatR.IRequestHandler<Request358, Response358>.Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request358StaticHandler
{
	private static ValueTask<Response358> Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request358SealedHandler
{
	private ValueTask<Response358> Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request359(long Id) : Mediator.IRequest<Response359>, MediatR.IRequest<Response359>;

public sealed record Response359(long Id);

public sealed partial class Request359TraditionalHandler
	: Mediator.IRequestHandler<Request359, Response359>,
	MediatR.IRequestHandler<Request359, Response359>
{
	ValueTask<Response359> Mediator.IRequestHandler<Request359, Response359>.Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response359> MediatR.IRequestHandler<Request359, Response359>.Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request359StaticHandler
{
	private static ValueTask<Response359> Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request359SealedHandler
{
	private ValueTask<Response359> Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request360(long Id) : Mediator.IRequest<Response360>, MediatR.IRequest<Response360>;

public sealed record Response360(long Id);

public sealed partial class Request360TraditionalHandler
	: Mediator.IRequestHandler<Request360, Response360>,
	MediatR.IRequestHandler<Request360, Response360>
{
	ValueTask<Response360> Mediator.IRequestHandler<Request360, Response360>.Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response360> MediatR.IRequestHandler<Request360, Response360>.Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request360StaticHandler
{
	private static ValueTask<Response360> Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request360SealedHandler
{
	private ValueTask<Response360> Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request361(long Id) : Mediator.IRequest<Response361>, MediatR.IRequest<Response361>;

public sealed record Response361(long Id);

public sealed partial class Request361TraditionalHandler
	: Mediator.IRequestHandler<Request361, Response361>,
	MediatR.IRequestHandler<Request361, Response361>
{
	ValueTask<Response361> Mediator.IRequestHandler<Request361, Response361>.Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response361> MediatR.IRequestHandler<Request361, Response361>.Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request361StaticHandler
{
	private static ValueTask<Response361> Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request361SealedHandler
{
	private ValueTask<Response361> Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request362(long Id) : Mediator.IRequest<Response362>, MediatR.IRequest<Response362>;

public sealed record Response362(long Id);

public sealed partial class Request362TraditionalHandler
	: Mediator.IRequestHandler<Request362, Response362>,
	MediatR.IRequestHandler<Request362, Response362>
{
	ValueTask<Response362> Mediator.IRequestHandler<Request362, Response362>.Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response362> MediatR.IRequestHandler<Request362, Response362>.Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request362StaticHandler
{
	private static ValueTask<Response362> Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request362SealedHandler
{
	private ValueTask<Response362> Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request363(long Id) : Mediator.IRequest<Response363>, MediatR.IRequest<Response363>;

public sealed record Response363(long Id);

public sealed partial class Request363TraditionalHandler
	: Mediator.IRequestHandler<Request363, Response363>,
	MediatR.IRequestHandler<Request363, Response363>
{
	ValueTask<Response363> Mediator.IRequestHandler<Request363, Response363>.Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response363> MediatR.IRequestHandler<Request363, Response363>.Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request363StaticHandler
{
	private static ValueTask<Response363> Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request363SealedHandler
{
	private ValueTask<Response363> Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request364(long Id) : Mediator.IRequest<Response364>, MediatR.IRequest<Response364>;

public sealed record Response364(long Id);

public sealed partial class Request364TraditionalHandler
	: Mediator.IRequestHandler<Request364, Response364>,
	MediatR.IRequestHandler<Request364, Response364>
{
	ValueTask<Response364> Mediator.IRequestHandler<Request364, Response364>.Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response364> MediatR.IRequestHandler<Request364, Response364>.Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request364StaticHandler
{
	private static ValueTask<Response364> Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request364SealedHandler
{
	private ValueTask<Response364> Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request365(long Id) : Mediator.IRequest<Response365>, MediatR.IRequest<Response365>;

public sealed record Response365(long Id);

public sealed partial class Request365TraditionalHandler
	: Mediator.IRequestHandler<Request365, Response365>,
	MediatR.IRequestHandler<Request365, Response365>
{
	ValueTask<Response365> Mediator.IRequestHandler<Request365, Response365>.Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response365> MediatR.IRequestHandler<Request365, Response365>.Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request365StaticHandler
{
	private static ValueTask<Response365> Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request365SealedHandler
{
	private ValueTask<Response365> Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request366(long Id) : Mediator.IRequest<Response366>, MediatR.IRequest<Response366>;

public sealed record Response366(long Id);

public sealed partial class Request366TraditionalHandler
	: Mediator.IRequestHandler<Request366, Response366>,
	MediatR.IRequestHandler<Request366, Response366>
{
	ValueTask<Response366> Mediator.IRequestHandler<Request366, Response366>.Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response366> MediatR.IRequestHandler<Request366, Response366>.Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request366StaticHandler
{
	private static ValueTask<Response366> Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request366SealedHandler
{
	private ValueTask<Response366> Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request367(long Id) : Mediator.IRequest<Response367>, MediatR.IRequest<Response367>;

public sealed record Response367(long Id);

public sealed partial class Request367TraditionalHandler
	: Mediator.IRequestHandler<Request367, Response367>,
	MediatR.IRequestHandler<Request367, Response367>
{
	ValueTask<Response367> Mediator.IRequestHandler<Request367, Response367>.Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response367> MediatR.IRequestHandler<Request367, Response367>.Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request367StaticHandler
{
	private static ValueTask<Response367> Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request367SealedHandler
{
	private ValueTask<Response367> Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request368(long Id) : Mediator.IRequest<Response368>, MediatR.IRequest<Response368>;

public sealed record Response368(long Id);

public sealed partial class Request368TraditionalHandler
	: Mediator.IRequestHandler<Request368, Response368>,
	MediatR.IRequestHandler<Request368, Response368>
{
	ValueTask<Response368> Mediator.IRequestHandler<Request368, Response368>.Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response368> MediatR.IRequestHandler<Request368, Response368>.Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request368StaticHandler
{
	private static ValueTask<Response368> Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request368SealedHandler
{
	private ValueTask<Response368> Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request369(long Id) : Mediator.IRequest<Response369>, MediatR.IRequest<Response369>;

public sealed record Response369(long Id);

public sealed partial class Request369TraditionalHandler
	: Mediator.IRequestHandler<Request369, Response369>,
	MediatR.IRequestHandler<Request369, Response369>
{
	ValueTask<Response369> Mediator.IRequestHandler<Request369, Response369>.Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response369> MediatR.IRequestHandler<Request369, Response369>.Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request369StaticHandler
{
	private static ValueTask<Response369> Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request369SealedHandler
{
	private ValueTask<Response369> Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request370(long Id) : Mediator.IRequest<Response370>, MediatR.IRequest<Response370>;

public sealed record Response370(long Id);

public sealed partial class Request370TraditionalHandler
	: Mediator.IRequestHandler<Request370, Response370>,
	MediatR.IRequestHandler<Request370, Response370>
{
	ValueTask<Response370> Mediator.IRequestHandler<Request370, Response370>.Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response370> MediatR.IRequestHandler<Request370, Response370>.Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request370StaticHandler
{
	private static ValueTask<Response370> Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request370SealedHandler
{
	private ValueTask<Response370> Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request371(long Id) : Mediator.IRequest<Response371>, MediatR.IRequest<Response371>;

public sealed record Response371(long Id);

public sealed partial class Request371TraditionalHandler
	: Mediator.IRequestHandler<Request371, Response371>,
	MediatR.IRequestHandler<Request371, Response371>
{
	ValueTask<Response371> Mediator.IRequestHandler<Request371, Response371>.Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response371> MediatR.IRequestHandler<Request371, Response371>.Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request371StaticHandler
{
	private static ValueTask<Response371> Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request371SealedHandler
{
	private ValueTask<Response371> Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request372(long Id) : Mediator.IRequest<Response372>, MediatR.IRequest<Response372>;

public sealed record Response372(long Id);

public sealed partial class Request372TraditionalHandler
	: Mediator.IRequestHandler<Request372, Response372>,
	MediatR.IRequestHandler<Request372, Response372>
{
	ValueTask<Response372> Mediator.IRequestHandler<Request372, Response372>.Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response372> MediatR.IRequestHandler<Request372, Response372>.Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request372StaticHandler
{
	private static ValueTask<Response372> Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request372SealedHandler
{
	private ValueTask<Response372> Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request373(long Id) : Mediator.IRequest<Response373>, MediatR.IRequest<Response373>;

public sealed record Response373(long Id);

public sealed partial class Request373TraditionalHandler
	: Mediator.IRequestHandler<Request373, Response373>,
	MediatR.IRequestHandler<Request373, Response373>
{
	ValueTask<Response373> Mediator.IRequestHandler<Request373, Response373>.Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response373> MediatR.IRequestHandler<Request373, Response373>.Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request373StaticHandler
{
	private static ValueTask<Response373> Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request373SealedHandler
{
	private ValueTask<Response373> Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request374(long Id) : Mediator.IRequest<Response374>, MediatR.IRequest<Response374>;

public sealed record Response374(long Id);

public sealed partial class Request374TraditionalHandler
	: Mediator.IRequestHandler<Request374, Response374>,
	MediatR.IRequestHandler<Request374, Response374>
{
	ValueTask<Response374> Mediator.IRequestHandler<Request374, Response374>.Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response374> MediatR.IRequestHandler<Request374, Response374>.Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request374StaticHandler
{
	private static ValueTask<Response374> Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request374SealedHandler
{
	private ValueTask<Response374> Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request375(long Id) : Mediator.IRequest<Response375>, MediatR.IRequest<Response375>;

public sealed record Response375(long Id);

public sealed partial class Request375TraditionalHandler
	: Mediator.IRequestHandler<Request375, Response375>,
	MediatR.IRequestHandler<Request375, Response375>
{
	ValueTask<Response375> Mediator.IRequestHandler<Request375, Response375>.Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response375> MediatR.IRequestHandler<Request375, Response375>.Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request375StaticHandler
{
	private static ValueTask<Response375> Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request375SealedHandler
{
	private ValueTask<Response375> Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request376(long Id) : Mediator.IRequest<Response376>, MediatR.IRequest<Response376>;

public sealed record Response376(long Id);

public sealed partial class Request376TraditionalHandler
	: Mediator.IRequestHandler<Request376, Response376>,
	MediatR.IRequestHandler<Request376, Response376>
{
	ValueTask<Response376> Mediator.IRequestHandler<Request376, Response376>.Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response376> MediatR.IRequestHandler<Request376, Response376>.Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request376StaticHandler
{
	private static ValueTask<Response376> Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request376SealedHandler
{
	private ValueTask<Response376> Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request377(long Id) : Mediator.IRequest<Response377>, MediatR.IRequest<Response377>;

public sealed record Response377(long Id);

public sealed partial class Request377TraditionalHandler
	: Mediator.IRequestHandler<Request377, Response377>,
	MediatR.IRequestHandler<Request377, Response377>
{
	ValueTask<Response377> Mediator.IRequestHandler<Request377, Response377>.Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response377> MediatR.IRequestHandler<Request377, Response377>.Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request377StaticHandler
{
	private static ValueTask<Response377> Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request377SealedHandler
{
	private ValueTask<Response377> Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request378(long Id) : Mediator.IRequest<Response378>, MediatR.IRequest<Response378>;

public sealed record Response378(long Id);

public sealed partial class Request378TraditionalHandler
	: Mediator.IRequestHandler<Request378, Response378>,
	MediatR.IRequestHandler<Request378, Response378>
{
	ValueTask<Response378> Mediator.IRequestHandler<Request378, Response378>.Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response378> MediatR.IRequestHandler<Request378, Response378>.Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request378StaticHandler
{
	private static ValueTask<Response378> Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request378SealedHandler
{
	private ValueTask<Response378> Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request379(long Id) : Mediator.IRequest<Response379>, MediatR.IRequest<Response379>;

public sealed record Response379(long Id);

public sealed partial class Request379TraditionalHandler
	: Mediator.IRequestHandler<Request379, Response379>,
	MediatR.IRequestHandler<Request379, Response379>
{
	ValueTask<Response379> Mediator.IRequestHandler<Request379, Response379>.Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response379> MediatR.IRequestHandler<Request379, Response379>.Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request379StaticHandler
{
	private static ValueTask<Response379> Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request379SealedHandler
{
	private ValueTask<Response379> Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request380(long Id) : Mediator.IRequest<Response380>, MediatR.IRequest<Response380>;

public sealed record Response380(long Id);

public sealed partial class Request380TraditionalHandler
	: Mediator.IRequestHandler<Request380, Response380>,
	MediatR.IRequestHandler<Request380, Response380>
{
	ValueTask<Response380> Mediator.IRequestHandler<Request380, Response380>.Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response380> MediatR.IRequestHandler<Request380, Response380>.Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request380StaticHandler
{
	private static ValueTask<Response380> Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request380SealedHandler
{
	private ValueTask<Response380> Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request381(long Id) : Mediator.IRequest<Response381>, MediatR.IRequest<Response381>;

public sealed record Response381(long Id);

public sealed partial class Request381TraditionalHandler
	: Mediator.IRequestHandler<Request381, Response381>,
	MediatR.IRequestHandler<Request381, Response381>
{
	ValueTask<Response381> Mediator.IRequestHandler<Request381, Response381>.Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response381> MediatR.IRequestHandler<Request381, Response381>.Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request381StaticHandler
{
	private static ValueTask<Response381> Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request381SealedHandler
{
	private ValueTask<Response381> Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request382(long Id) : Mediator.IRequest<Response382>, MediatR.IRequest<Response382>;

public sealed record Response382(long Id);

public sealed partial class Request382TraditionalHandler
	: Mediator.IRequestHandler<Request382, Response382>,
	MediatR.IRequestHandler<Request382, Response382>
{
	ValueTask<Response382> Mediator.IRequestHandler<Request382, Response382>.Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response382> MediatR.IRequestHandler<Request382, Response382>.Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request382StaticHandler
{
	private static ValueTask<Response382> Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request382SealedHandler
{
	private ValueTask<Response382> Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request383(long Id) : Mediator.IRequest<Response383>, MediatR.IRequest<Response383>;

public sealed record Response383(long Id);

public sealed partial class Request383TraditionalHandler
	: Mediator.IRequestHandler<Request383, Response383>,
	MediatR.IRequestHandler<Request383, Response383>
{
	ValueTask<Response383> Mediator.IRequestHandler<Request383, Response383>.Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response383> MediatR.IRequestHandler<Request383, Response383>.Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request383StaticHandler
{
	private static ValueTask<Response383> Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request383SealedHandler
{
	private ValueTask<Response383> Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request384(long Id) : Mediator.IRequest<Response384>, MediatR.IRequest<Response384>;

public sealed record Response384(long Id);

public sealed partial class Request384TraditionalHandler
	: Mediator.IRequestHandler<Request384, Response384>,
	MediatR.IRequestHandler<Request384, Response384>
{
	ValueTask<Response384> Mediator.IRequestHandler<Request384, Response384>.Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response384> MediatR.IRequestHandler<Request384, Response384>.Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request384StaticHandler
{
	private static ValueTask<Response384> Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request384SealedHandler
{
	private ValueTask<Response384> Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request385(long Id) : Mediator.IRequest<Response385>, MediatR.IRequest<Response385>;

public sealed record Response385(long Id);

public sealed partial class Request385TraditionalHandler
	: Mediator.IRequestHandler<Request385, Response385>,
	MediatR.IRequestHandler<Request385, Response385>
{
	ValueTask<Response385> Mediator.IRequestHandler<Request385, Response385>.Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response385> MediatR.IRequestHandler<Request385, Response385>.Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request385StaticHandler
{
	private static ValueTask<Response385> Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request385SealedHandler
{
	private ValueTask<Response385> Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request386(long Id) : Mediator.IRequest<Response386>, MediatR.IRequest<Response386>;

public sealed record Response386(long Id);

public sealed partial class Request386TraditionalHandler
	: Mediator.IRequestHandler<Request386, Response386>,
	MediatR.IRequestHandler<Request386, Response386>
{
	ValueTask<Response386> Mediator.IRequestHandler<Request386, Response386>.Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response386> MediatR.IRequestHandler<Request386, Response386>.Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request386StaticHandler
{
	private static ValueTask<Response386> Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request386SealedHandler
{
	private ValueTask<Response386> Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request387(long Id) : Mediator.IRequest<Response387>, MediatR.IRequest<Response387>;

public sealed record Response387(long Id);

public sealed partial class Request387TraditionalHandler
	: Mediator.IRequestHandler<Request387, Response387>,
	MediatR.IRequestHandler<Request387, Response387>
{
	ValueTask<Response387> Mediator.IRequestHandler<Request387, Response387>.Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response387> MediatR.IRequestHandler<Request387, Response387>.Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request387StaticHandler
{
	private static ValueTask<Response387> Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request387SealedHandler
{
	private ValueTask<Response387> Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request388(long Id) : Mediator.IRequest<Response388>, MediatR.IRequest<Response388>;

public sealed record Response388(long Id);

public sealed partial class Request388TraditionalHandler
	: Mediator.IRequestHandler<Request388, Response388>,
	MediatR.IRequestHandler<Request388, Response388>
{
	ValueTask<Response388> Mediator.IRequestHandler<Request388, Response388>.Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response388> MediatR.IRequestHandler<Request388, Response388>.Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request388StaticHandler
{
	private static ValueTask<Response388> Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request388SealedHandler
{
	private ValueTask<Response388> Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request389(long Id) : Mediator.IRequest<Response389>, MediatR.IRequest<Response389>;

public sealed record Response389(long Id);

public sealed partial class Request389TraditionalHandler
	: Mediator.IRequestHandler<Request389, Response389>,
	MediatR.IRequestHandler<Request389, Response389>
{
	ValueTask<Response389> Mediator.IRequestHandler<Request389, Response389>.Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response389> MediatR.IRequestHandler<Request389, Response389>.Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request389StaticHandler
{
	private static ValueTask<Response389> Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request389SealedHandler
{
	private ValueTask<Response389> Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request390(long Id) : Mediator.IRequest<Response390>, MediatR.IRequest<Response390>;

public sealed record Response390(long Id);

public sealed partial class Request390TraditionalHandler
	: Mediator.IRequestHandler<Request390, Response390>,
	MediatR.IRequestHandler<Request390, Response390>
{
	ValueTask<Response390> Mediator.IRequestHandler<Request390, Response390>.Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response390> MediatR.IRequestHandler<Request390, Response390>.Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request390StaticHandler
{
	private static ValueTask<Response390> Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request390SealedHandler
{
	private ValueTask<Response390> Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request391(long Id) : Mediator.IRequest<Response391>, MediatR.IRequest<Response391>;

public sealed record Response391(long Id);

public sealed partial class Request391TraditionalHandler
	: Mediator.IRequestHandler<Request391, Response391>,
	MediatR.IRequestHandler<Request391, Response391>
{
	ValueTask<Response391> Mediator.IRequestHandler<Request391, Response391>.Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response391> MediatR.IRequestHandler<Request391, Response391>.Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request391StaticHandler
{
	private static ValueTask<Response391> Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request391SealedHandler
{
	private ValueTask<Response391> Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request392(long Id) : Mediator.IRequest<Response392>, MediatR.IRequest<Response392>;

public sealed record Response392(long Id);

public sealed partial class Request392TraditionalHandler
	: Mediator.IRequestHandler<Request392, Response392>,
	MediatR.IRequestHandler<Request392, Response392>
{
	ValueTask<Response392> Mediator.IRequestHandler<Request392, Response392>.Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response392> MediatR.IRequestHandler<Request392, Response392>.Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request392StaticHandler
{
	private static ValueTask<Response392> Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request392SealedHandler
{
	private ValueTask<Response392> Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request393(long Id) : Mediator.IRequest<Response393>, MediatR.IRequest<Response393>;

public sealed record Response393(long Id);

public sealed partial class Request393TraditionalHandler
	: Mediator.IRequestHandler<Request393, Response393>,
	MediatR.IRequestHandler<Request393, Response393>
{
	ValueTask<Response393> Mediator.IRequestHandler<Request393, Response393>.Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response393> MediatR.IRequestHandler<Request393, Response393>.Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request393StaticHandler
{
	private static ValueTask<Response393> Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request393SealedHandler
{
	private ValueTask<Response393> Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request394(long Id) : Mediator.IRequest<Response394>, MediatR.IRequest<Response394>;

public sealed record Response394(long Id);

public sealed partial class Request394TraditionalHandler
	: Mediator.IRequestHandler<Request394, Response394>,
	MediatR.IRequestHandler<Request394, Response394>
{
	ValueTask<Response394> Mediator.IRequestHandler<Request394, Response394>.Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response394> MediatR.IRequestHandler<Request394, Response394>.Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request394StaticHandler
{
	private static ValueTask<Response394> Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request394SealedHandler
{
	private ValueTask<Response394> Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request395(long Id) : Mediator.IRequest<Response395>, MediatR.IRequest<Response395>;

public sealed record Response395(long Id);

public sealed partial class Request395TraditionalHandler
	: Mediator.IRequestHandler<Request395, Response395>,
	MediatR.IRequestHandler<Request395, Response395>
{
	ValueTask<Response395> Mediator.IRequestHandler<Request395, Response395>.Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response395> MediatR.IRequestHandler<Request395, Response395>.Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request395StaticHandler
{
	private static ValueTask<Response395> Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request395SealedHandler
{
	private ValueTask<Response395> Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request396(long Id) : Mediator.IRequest<Response396>, MediatR.IRequest<Response396>;

public sealed record Response396(long Id);

public sealed partial class Request396TraditionalHandler
	: Mediator.IRequestHandler<Request396, Response396>,
	MediatR.IRequestHandler<Request396, Response396>
{
	ValueTask<Response396> Mediator.IRequestHandler<Request396, Response396>.Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response396> MediatR.IRequestHandler<Request396, Response396>.Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request396StaticHandler
{
	private static ValueTask<Response396> Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request396SealedHandler
{
	private ValueTask<Response396> Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request397(long Id) : Mediator.IRequest<Response397>, MediatR.IRequest<Response397>;

public sealed record Response397(long Id);

public sealed partial class Request397TraditionalHandler
	: Mediator.IRequestHandler<Request397, Response397>,
	MediatR.IRequestHandler<Request397, Response397>
{
	ValueTask<Response397> Mediator.IRequestHandler<Request397, Response397>.Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response397> MediatR.IRequestHandler<Request397, Response397>.Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request397StaticHandler
{
	private static ValueTask<Response397> Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request397SealedHandler
{
	private ValueTask<Response397> Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request398(long Id) : Mediator.IRequest<Response398>, MediatR.IRequest<Response398>;

public sealed record Response398(long Id);

public sealed partial class Request398TraditionalHandler
	: Mediator.IRequestHandler<Request398, Response398>,
	MediatR.IRequestHandler<Request398, Response398>
{
	ValueTask<Response398> Mediator.IRequestHandler<Request398, Response398>.Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response398> MediatR.IRequestHandler<Request398, Response398>.Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request398StaticHandler
{
	private static ValueTask<Response398> Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request398SealedHandler
{
	private ValueTask<Response398> Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request399(long Id) : Mediator.IRequest<Response399>, MediatR.IRequest<Response399>;

public sealed record Response399(long Id);

public sealed partial class Request399TraditionalHandler
	: Mediator.IRequestHandler<Request399, Response399>,
	MediatR.IRequestHandler<Request399, Response399>
{
	ValueTask<Response399> Mediator.IRequestHandler<Request399, Response399>.Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response399> MediatR.IRequestHandler<Request399, Response399>.Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request399StaticHandler
{
	private static ValueTask<Response399> Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request399SealedHandler
{
	private ValueTask<Response399> Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request400(long Id) : Mediator.IRequest<Response400>, MediatR.IRequest<Response400>;

public sealed record Response400(long Id);

public sealed partial class Request400TraditionalHandler
	: Mediator.IRequestHandler<Request400, Response400>,
	MediatR.IRequestHandler<Request400, Response400>
{
	ValueTask<Response400> Mediator.IRequestHandler<Request400, Response400>.Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response400> MediatR.IRequestHandler<Request400, Response400>.Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request400StaticHandler
{
	private static ValueTask<Response400> Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request400SealedHandler
{
	private ValueTask<Response400> Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request401(long Id) : Mediator.IRequest<Response401>, MediatR.IRequest<Response401>;

public sealed record Response401(long Id);

public sealed partial class Request401TraditionalHandler
	: Mediator.IRequestHandler<Request401, Response401>,
	MediatR.IRequestHandler<Request401, Response401>
{
	ValueTask<Response401> Mediator.IRequestHandler<Request401, Response401>.Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response401> MediatR.IRequestHandler<Request401, Response401>.Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request401StaticHandler
{
	private static ValueTask<Response401> Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request401SealedHandler
{
	private ValueTask<Response401> Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request402(long Id) : Mediator.IRequest<Response402>, MediatR.IRequest<Response402>;

public sealed record Response402(long Id);

public sealed partial class Request402TraditionalHandler
	: Mediator.IRequestHandler<Request402, Response402>,
	MediatR.IRequestHandler<Request402, Response402>
{
	ValueTask<Response402> Mediator.IRequestHandler<Request402, Response402>.Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response402> MediatR.IRequestHandler<Request402, Response402>.Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request402StaticHandler
{
	private static ValueTask<Response402> Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request402SealedHandler
{
	private ValueTask<Response402> Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request403(long Id) : Mediator.IRequest<Response403>, MediatR.IRequest<Response403>;

public sealed record Response403(long Id);

public sealed partial class Request403TraditionalHandler
	: Mediator.IRequestHandler<Request403, Response403>,
	MediatR.IRequestHandler<Request403, Response403>
{
	ValueTask<Response403> Mediator.IRequestHandler<Request403, Response403>.Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response403> MediatR.IRequestHandler<Request403, Response403>.Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request403StaticHandler
{
	private static ValueTask<Response403> Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request403SealedHandler
{
	private ValueTask<Response403> Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request404(long Id) : Mediator.IRequest<Response404>, MediatR.IRequest<Response404>;

public sealed record Response404(long Id);

public sealed partial class Request404TraditionalHandler
	: Mediator.IRequestHandler<Request404, Response404>,
	MediatR.IRequestHandler<Request404, Response404>
{
	ValueTask<Response404> Mediator.IRequestHandler<Request404, Response404>.Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response404> MediatR.IRequestHandler<Request404, Response404>.Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request404StaticHandler
{
	private static ValueTask<Response404> Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request404SealedHandler
{
	private ValueTask<Response404> Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request405(long Id) : Mediator.IRequest<Response405>, MediatR.IRequest<Response405>;

public sealed record Response405(long Id);

public sealed partial class Request405TraditionalHandler
	: Mediator.IRequestHandler<Request405, Response405>,
	MediatR.IRequestHandler<Request405, Response405>
{
	ValueTask<Response405> Mediator.IRequestHandler<Request405, Response405>.Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response405> MediatR.IRequestHandler<Request405, Response405>.Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request405StaticHandler
{
	private static ValueTask<Response405> Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request405SealedHandler
{
	private ValueTask<Response405> Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request406(long Id) : Mediator.IRequest<Response406>, MediatR.IRequest<Response406>;

public sealed record Response406(long Id);

public sealed partial class Request406TraditionalHandler
	: Mediator.IRequestHandler<Request406, Response406>,
	MediatR.IRequestHandler<Request406, Response406>
{
	ValueTask<Response406> Mediator.IRequestHandler<Request406, Response406>.Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response406> MediatR.IRequestHandler<Request406, Response406>.Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request406StaticHandler
{
	private static ValueTask<Response406> Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request406SealedHandler
{
	private ValueTask<Response406> Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request407(long Id) : Mediator.IRequest<Response407>, MediatR.IRequest<Response407>;

public sealed record Response407(long Id);

public sealed partial class Request407TraditionalHandler
	: Mediator.IRequestHandler<Request407, Response407>,
	MediatR.IRequestHandler<Request407, Response407>
{
	ValueTask<Response407> Mediator.IRequestHandler<Request407, Response407>.Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response407> MediatR.IRequestHandler<Request407, Response407>.Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request407StaticHandler
{
	private static ValueTask<Response407> Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request407SealedHandler
{
	private ValueTask<Response407> Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request408(long Id) : Mediator.IRequest<Response408>, MediatR.IRequest<Response408>;

public sealed record Response408(long Id);

public sealed partial class Request408TraditionalHandler
	: Mediator.IRequestHandler<Request408, Response408>,
	MediatR.IRequestHandler<Request408, Response408>
{
	ValueTask<Response408> Mediator.IRequestHandler<Request408, Response408>.Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response408> MediatR.IRequestHandler<Request408, Response408>.Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request408StaticHandler
{
	private static ValueTask<Response408> Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request408SealedHandler
{
	private ValueTask<Response408> Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request409(long Id) : Mediator.IRequest<Response409>, MediatR.IRequest<Response409>;

public sealed record Response409(long Id);

public sealed partial class Request409TraditionalHandler
	: Mediator.IRequestHandler<Request409, Response409>,
	MediatR.IRequestHandler<Request409, Response409>
{
	ValueTask<Response409> Mediator.IRequestHandler<Request409, Response409>.Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response409> MediatR.IRequestHandler<Request409, Response409>.Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request409StaticHandler
{
	private static ValueTask<Response409> Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request409SealedHandler
{
	private ValueTask<Response409> Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request410(long Id) : Mediator.IRequest<Response410>, MediatR.IRequest<Response410>;

public sealed record Response410(long Id);

public sealed partial class Request410TraditionalHandler
	: Mediator.IRequestHandler<Request410, Response410>,
	MediatR.IRequestHandler<Request410, Response410>
{
	ValueTask<Response410> Mediator.IRequestHandler<Request410, Response410>.Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response410> MediatR.IRequestHandler<Request410, Response410>.Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request410StaticHandler
{
	private static ValueTask<Response410> Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request410SealedHandler
{
	private ValueTask<Response410> Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request411(long Id) : Mediator.IRequest<Response411>, MediatR.IRequest<Response411>;

public sealed record Response411(long Id);

public sealed partial class Request411TraditionalHandler
	: Mediator.IRequestHandler<Request411, Response411>,
	MediatR.IRequestHandler<Request411, Response411>
{
	ValueTask<Response411> Mediator.IRequestHandler<Request411, Response411>.Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response411> MediatR.IRequestHandler<Request411, Response411>.Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request411StaticHandler
{
	private static ValueTask<Response411> Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request411SealedHandler
{
	private ValueTask<Response411> Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request412(long Id) : Mediator.IRequest<Response412>, MediatR.IRequest<Response412>;

public sealed record Response412(long Id);

public sealed partial class Request412TraditionalHandler
	: Mediator.IRequestHandler<Request412, Response412>,
	MediatR.IRequestHandler<Request412, Response412>
{
	ValueTask<Response412> Mediator.IRequestHandler<Request412, Response412>.Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response412> MediatR.IRequestHandler<Request412, Response412>.Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request412StaticHandler
{
	private static ValueTask<Response412> Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request412SealedHandler
{
	private ValueTask<Response412> Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request413(long Id) : Mediator.IRequest<Response413>, MediatR.IRequest<Response413>;

public sealed record Response413(long Id);

public sealed partial class Request413TraditionalHandler
	: Mediator.IRequestHandler<Request413, Response413>,
	MediatR.IRequestHandler<Request413, Response413>
{
	ValueTask<Response413> Mediator.IRequestHandler<Request413, Response413>.Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response413> MediatR.IRequestHandler<Request413, Response413>.Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request413StaticHandler
{
	private static ValueTask<Response413> Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request413SealedHandler
{
	private ValueTask<Response413> Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request414(long Id) : Mediator.IRequest<Response414>, MediatR.IRequest<Response414>;

public sealed record Response414(long Id);

public sealed partial class Request414TraditionalHandler
	: Mediator.IRequestHandler<Request414, Response414>,
	MediatR.IRequestHandler<Request414, Response414>
{
	ValueTask<Response414> Mediator.IRequestHandler<Request414, Response414>.Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response414> MediatR.IRequestHandler<Request414, Response414>.Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request414StaticHandler
{
	private static ValueTask<Response414> Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request414SealedHandler
{
	private ValueTask<Response414> Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request415(long Id) : Mediator.IRequest<Response415>, MediatR.IRequest<Response415>;

public sealed record Response415(long Id);

public sealed partial class Request415TraditionalHandler
	: Mediator.IRequestHandler<Request415, Response415>,
	MediatR.IRequestHandler<Request415, Response415>
{
	ValueTask<Response415> Mediator.IRequestHandler<Request415, Response415>.Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response415> MediatR.IRequestHandler<Request415, Response415>.Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request415StaticHandler
{
	private static ValueTask<Response415> Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request415SealedHandler
{
	private ValueTask<Response415> Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request416(long Id) : Mediator.IRequest<Response416>, MediatR.IRequest<Response416>;

public sealed record Response416(long Id);

public sealed partial class Request416TraditionalHandler
	: Mediator.IRequestHandler<Request416, Response416>,
	MediatR.IRequestHandler<Request416, Response416>
{
	ValueTask<Response416> Mediator.IRequestHandler<Request416, Response416>.Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response416> MediatR.IRequestHandler<Request416, Response416>.Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request416StaticHandler
{
	private static ValueTask<Response416> Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request416SealedHandler
{
	private ValueTask<Response416> Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request417(long Id) : Mediator.IRequest<Response417>, MediatR.IRequest<Response417>;

public sealed record Response417(long Id);

public sealed partial class Request417TraditionalHandler
	: Mediator.IRequestHandler<Request417, Response417>,
	MediatR.IRequestHandler<Request417, Response417>
{
	ValueTask<Response417> Mediator.IRequestHandler<Request417, Response417>.Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response417> MediatR.IRequestHandler<Request417, Response417>.Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request417StaticHandler
{
	private static ValueTask<Response417> Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request417SealedHandler
{
	private ValueTask<Response417> Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request418(long Id) : Mediator.IRequest<Response418>, MediatR.IRequest<Response418>;

public sealed record Response418(long Id);

public sealed partial class Request418TraditionalHandler
	: Mediator.IRequestHandler<Request418, Response418>,
	MediatR.IRequestHandler<Request418, Response418>
{
	ValueTask<Response418> Mediator.IRequestHandler<Request418, Response418>.Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response418> MediatR.IRequestHandler<Request418, Response418>.Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request418StaticHandler
{
	private static ValueTask<Response418> Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request418SealedHandler
{
	private ValueTask<Response418> Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request419(long Id) : Mediator.IRequest<Response419>, MediatR.IRequest<Response419>;

public sealed record Response419(long Id);

public sealed partial class Request419TraditionalHandler
	: Mediator.IRequestHandler<Request419, Response419>,
	MediatR.IRequestHandler<Request419, Response419>
{
	ValueTask<Response419> Mediator.IRequestHandler<Request419, Response419>.Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response419> MediatR.IRequestHandler<Request419, Response419>.Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request419StaticHandler
{
	private static ValueTask<Response419> Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request419SealedHandler
{
	private ValueTask<Response419> Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request420(long Id) : Mediator.IRequest<Response420>, MediatR.IRequest<Response420>;

public sealed record Response420(long Id);

public sealed partial class Request420TraditionalHandler
	: Mediator.IRequestHandler<Request420, Response420>,
	MediatR.IRequestHandler<Request420, Response420>
{
	ValueTask<Response420> Mediator.IRequestHandler<Request420, Response420>.Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response420> MediatR.IRequestHandler<Request420, Response420>.Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request420StaticHandler
{
	private static ValueTask<Response420> Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request420SealedHandler
{
	private ValueTask<Response420> Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request421(long Id) : Mediator.IRequest<Response421>, MediatR.IRequest<Response421>;

public sealed record Response421(long Id);

public sealed partial class Request421TraditionalHandler
	: Mediator.IRequestHandler<Request421, Response421>,
	MediatR.IRequestHandler<Request421, Response421>
{
	ValueTask<Response421> Mediator.IRequestHandler<Request421, Response421>.Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response421> MediatR.IRequestHandler<Request421, Response421>.Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request421StaticHandler
{
	private static ValueTask<Response421> Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request421SealedHandler
{
	private ValueTask<Response421> Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request422(long Id) : Mediator.IRequest<Response422>, MediatR.IRequest<Response422>;

public sealed record Response422(long Id);

public sealed partial class Request422TraditionalHandler
	: Mediator.IRequestHandler<Request422, Response422>,
	MediatR.IRequestHandler<Request422, Response422>
{
	ValueTask<Response422> Mediator.IRequestHandler<Request422, Response422>.Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response422> MediatR.IRequestHandler<Request422, Response422>.Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request422StaticHandler
{
	private static ValueTask<Response422> Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request422SealedHandler
{
	private ValueTask<Response422> Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request423(long Id) : Mediator.IRequest<Response423>, MediatR.IRequest<Response423>;

public sealed record Response423(long Id);

public sealed partial class Request423TraditionalHandler
	: Mediator.IRequestHandler<Request423, Response423>,
	MediatR.IRequestHandler<Request423, Response423>
{
	ValueTask<Response423> Mediator.IRequestHandler<Request423, Response423>.Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response423> MediatR.IRequestHandler<Request423, Response423>.Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request423StaticHandler
{
	private static ValueTask<Response423> Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request423SealedHandler
{
	private ValueTask<Response423> Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request424(long Id) : Mediator.IRequest<Response424>, MediatR.IRequest<Response424>;

public sealed record Response424(long Id);

public sealed partial class Request424TraditionalHandler
	: Mediator.IRequestHandler<Request424, Response424>,
	MediatR.IRequestHandler<Request424, Response424>
{
	ValueTask<Response424> Mediator.IRequestHandler<Request424, Response424>.Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response424> MediatR.IRequestHandler<Request424, Response424>.Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request424StaticHandler
{
	private static ValueTask<Response424> Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request424SealedHandler
{
	private ValueTask<Response424> Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request425(long Id) : Mediator.IRequest<Response425>, MediatR.IRequest<Response425>;

public sealed record Response425(long Id);

public sealed partial class Request425TraditionalHandler
	: Mediator.IRequestHandler<Request425, Response425>,
	MediatR.IRequestHandler<Request425, Response425>
{
	ValueTask<Response425> Mediator.IRequestHandler<Request425, Response425>.Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response425> MediatR.IRequestHandler<Request425, Response425>.Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request425StaticHandler
{
	private static ValueTask<Response425> Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request425SealedHandler
{
	private ValueTask<Response425> Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request426(long Id) : Mediator.IRequest<Response426>, MediatR.IRequest<Response426>;

public sealed record Response426(long Id);

public sealed partial class Request426TraditionalHandler
	: Mediator.IRequestHandler<Request426, Response426>,
	MediatR.IRequestHandler<Request426, Response426>
{
	ValueTask<Response426> Mediator.IRequestHandler<Request426, Response426>.Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response426> MediatR.IRequestHandler<Request426, Response426>.Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request426StaticHandler
{
	private static ValueTask<Response426> Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request426SealedHandler
{
	private ValueTask<Response426> Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request427(long Id) : Mediator.IRequest<Response427>, MediatR.IRequest<Response427>;

public sealed record Response427(long Id);

public sealed partial class Request427TraditionalHandler
	: Mediator.IRequestHandler<Request427, Response427>,
	MediatR.IRequestHandler<Request427, Response427>
{
	ValueTask<Response427> Mediator.IRequestHandler<Request427, Response427>.Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response427> MediatR.IRequestHandler<Request427, Response427>.Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request427StaticHandler
{
	private static ValueTask<Response427> Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request427SealedHandler
{
	private ValueTask<Response427> Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request428(long Id) : Mediator.IRequest<Response428>, MediatR.IRequest<Response428>;

public sealed record Response428(long Id);

public sealed partial class Request428TraditionalHandler
	: Mediator.IRequestHandler<Request428, Response428>,
	MediatR.IRequestHandler<Request428, Response428>
{
	ValueTask<Response428> Mediator.IRequestHandler<Request428, Response428>.Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response428> MediatR.IRequestHandler<Request428, Response428>.Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request428StaticHandler
{
	private static ValueTask<Response428> Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request428SealedHandler
{
	private ValueTask<Response428> Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request429(long Id) : Mediator.IRequest<Response429>, MediatR.IRequest<Response429>;

public sealed record Response429(long Id);

public sealed partial class Request429TraditionalHandler
	: Mediator.IRequestHandler<Request429, Response429>,
	MediatR.IRequestHandler<Request429, Response429>
{
	ValueTask<Response429> Mediator.IRequestHandler<Request429, Response429>.Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response429> MediatR.IRequestHandler<Request429, Response429>.Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request429StaticHandler
{
	private static ValueTask<Response429> Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request429SealedHandler
{
	private ValueTask<Response429> Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request430(long Id) : Mediator.IRequest<Response430>, MediatR.IRequest<Response430>;

public sealed record Response430(long Id);

public sealed partial class Request430TraditionalHandler
	: Mediator.IRequestHandler<Request430, Response430>,
	MediatR.IRequestHandler<Request430, Response430>
{
	ValueTask<Response430> Mediator.IRequestHandler<Request430, Response430>.Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response430> MediatR.IRequestHandler<Request430, Response430>.Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request430StaticHandler
{
	private static ValueTask<Response430> Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request430SealedHandler
{
	private ValueTask<Response430> Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request431(long Id) : Mediator.IRequest<Response431>, MediatR.IRequest<Response431>;

public sealed record Response431(long Id);

public sealed partial class Request431TraditionalHandler
	: Mediator.IRequestHandler<Request431, Response431>,
	MediatR.IRequestHandler<Request431, Response431>
{
	ValueTask<Response431> Mediator.IRequestHandler<Request431, Response431>.Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response431> MediatR.IRequestHandler<Request431, Response431>.Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request431StaticHandler
{
	private static ValueTask<Response431> Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request431SealedHandler
{
	private ValueTask<Response431> Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request432(long Id) : Mediator.IRequest<Response432>, MediatR.IRequest<Response432>;

public sealed record Response432(long Id);

public sealed partial class Request432TraditionalHandler
	: Mediator.IRequestHandler<Request432, Response432>,
	MediatR.IRequestHandler<Request432, Response432>
{
	ValueTask<Response432> Mediator.IRequestHandler<Request432, Response432>.Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response432> MediatR.IRequestHandler<Request432, Response432>.Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request432StaticHandler
{
	private static ValueTask<Response432> Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request432SealedHandler
{
	private ValueTask<Response432> Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request433(long Id) : Mediator.IRequest<Response433>, MediatR.IRequest<Response433>;

public sealed record Response433(long Id);

public sealed partial class Request433TraditionalHandler
	: Mediator.IRequestHandler<Request433, Response433>,
	MediatR.IRequestHandler<Request433, Response433>
{
	ValueTask<Response433> Mediator.IRequestHandler<Request433, Response433>.Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response433> MediatR.IRequestHandler<Request433, Response433>.Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request433StaticHandler
{
	private static ValueTask<Response433> Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request433SealedHandler
{
	private ValueTask<Response433> Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request434(long Id) : Mediator.IRequest<Response434>, MediatR.IRequest<Response434>;

public sealed record Response434(long Id);

public sealed partial class Request434TraditionalHandler
	: Mediator.IRequestHandler<Request434, Response434>,
	MediatR.IRequestHandler<Request434, Response434>
{
	ValueTask<Response434> Mediator.IRequestHandler<Request434, Response434>.Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response434> MediatR.IRequestHandler<Request434, Response434>.Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request434StaticHandler
{
	private static ValueTask<Response434> Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request434SealedHandler
{
	private ValueTask<Response434> Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request435(long Id) : Mediator.IRequest<Response435>, MediatR.IRequest<Response435>;

public sealed record Response435(long Id);

public sealed partial class Request435TraditionalHandler
	: Mediator.IRequestHandler<Request435, Response435>,
	MediatR.IRequestHandler<Request435, Response435>
{
	ValueTask<Response435> Mediator.IRequestHandler<Request435, Response435>.Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response435> MediatR.IRequestHandler<Request435, Response435>.Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request435StaticHandler
{
	private static ValueTask<Response435> Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request435SealedHandler
{
	private ValueTask<Response435> Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request436(long Id) : Mediator.IRequest<Response436>, MediatR.IRequest<Response436>;

public sealed record Response436(long Id);

public sealed partial class Request436TraditionalHandler
	: Mediator.IRequestHandler<Request436, Response436>,
	MediatR.IRequestHandler<Request436, Response436>
{
	ValueTask<Response436> Mediator.IRequestHandler<Request436, Response436>.Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response436> MediatR.IRequestHandler<Request436, Response436>.Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request436StaticHandler
{
	private static ValueTask<Response436> Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request436SealedHandler
{
	private ValueTask<Response436> Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request437(long Id) : Mediator.IRequest<Response437>, MediatR.IRequest<Response437>;

public sealed record Response437(long Id);

public sealed partial class Request437TraditionalHandler
	: Mediator.IRequestHandler<Request437, Response437>,
	MediatR.IRequestHandler<Request437, Response437>
{
	ValueTask<Response437> Mediator.IRequestHandler<Request437, Response437>.Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response437> MediatR.IRequestHandler<Request437, Response437>.Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request437StaticHandler
{
	private static ValueTask<Response437> Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request437SealedHandler
{
	private ValueTask<Response437> Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request438(long Id) : Mediator.IRequest<Response438>, MediatR.IRequest<Response438>;

public sealed record Response438(long Id);

public sealed partial class Request438TraditionalHandler
	: Mediator.IRequestHandler<Request438, Response438>,
	MediatR.IRequestHandler<Request438, Response438>
{
	ValueTask<Response438> Mediator.IRequestHandler<Request438, Response438>.Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response438> MediatR.IRequestHandler<Request438, Response438>.Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request438StaticHandler
{
	private static ValueTask<Response438> Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request438SealedHandler
{
	private ValueTask<Response438> Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request439(long Id) : Mediator.IRequest<Response439>, MediatR.IRequest<Response439>;

public sealed record Response439(long Id);

public sealed partial class Request439TraditionalHandler
	: Mediator.IRequestHandler<Request439, Response439>,
	MediatR.IRequestHandler<Request439, Response439>
{
	ValueTask<Response439> Mediator.IRequestHandler<Request439, Response439>.Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response439> MediatR.IRequestHandler<Request439, Response439>.Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request439StaticHandler
{
	private static ValueTask<Response439> Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request439SealedHandler
{
	private ValueTask<Response439> Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request440(long Id) : Mediator.IRequest<Response440>, MediatR.IRequest<Response440>;

public sealed record Response440(long Id);

public sealed partial class Request440TraditionalHandler
	: Mediator.IRequestHandler<Request440, Response440>,
	MediatR.IRequestHandler<Request440, Response440>
{
	ValueTask<Response440> Mediator.IRequestHandler<Request440, Response440>.Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response440> MediatR.IRequestHandler<Request440, Response440>.Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request440StaticHandler
{
	private static ValueTask<Response440> Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request440SealedHandler
{
	private ValueTask<Response440> Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request441(long Id) : Mediator.IRequest<Response441>, MediatR.IRequest<Response441>;

public sealed record Response441(long Id);

public sealed partial class Request441TraditionalHandler
	: Mediator.IRequestHandler<Request441, Response441>,
	MediatR.IRequestHandler<Request441, Response441>
{
	ValueTask<Response441> Mediator.IRequestHandler<Request441, Response441>.Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response441> MediatR.IRequestHandler<Request441, Response441>.Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request441StaticHandler
{
	private static ValueTask<Response441> Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request441SealedHandler
{
	private ValueTask<Response441> Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request442(long Id) : Mediator.IRequest<Response442>, MediatR.IRequest<Response442>;

public sealed record Response442(long Id);

public sealed partial class Request442TraditionalHandler
	: Mediator.IRequestHandler<Request442, Response442>,
	MediatR.IRequestHandler<Request442, Response442>
{
	ValueTask<Response442> Mediator.IRequestHandler<Request442, Response442>.Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response442> MediatR.IRequestHandler<Request442, Response442>.Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request442StaticHandler
{
	private static ValueTask<Response442> Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request442SealedHandler
{
	private ValueTask<Response442> Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request443(long Id) : Mediator.IRequest<Response443>, MediatR.IRequest<Response443>;

public sealed record Response443(long Id);

public sealed partial class Request443TraditionalHandler
	: Mediator.IRequestHandler<Request443, Response443>,
	MediatR.IRequestHandler<Request443, Response443>
{
	ValueTask<Response443> Mediator.IRequestHandler<Request443, Response443>.Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response443> MediatR.IRequestHandler<Request443, Response443>.Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request443StaticHandler
{
	private static ValueTask<Response443> Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request443SealedHandler
{
	private ValueTask<Response443> Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request444(long Id) : Mediator.IRequest<Response444>, MediatR.IRequest<Response444>;

public sealed record Response444(long Id);

public sealed partial class Request444TraditionalHandler
	: Mediator.IRequestHandler<Request444, Response444>,
	MediatR.IRequestHandler<Request444, Response444>
{
	ValueTask<Response444> Mediator.IRequestHandler<Request444, Response444>.Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response444> MediatR.IRequestHandler<Request444, Response444>.Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request444StaticHandler
{
	private static ValueTask<Response444> Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request444SealedHandler
{
	private ValueTask<Response444> Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request445(long Id) : Mediator.IRequest<Response445>, MediatR.IRequest<Response445>;

public sealed record Response445(long Id);

public sealed partial class Request445TraditionalHandler
	: Mediator.IRequestHandler<Request445, Response445>,
	MediatR.IRequestHandler<Request445, Response445>
{
	ValueTask<Response445> Mediator.IRequestHandler<Request445, Response445>.Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response445> MediatR.IRequestHandler<Request445, Response445>.Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request445StaticHandler
{
	private static ValueTask<Response445> Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request445SealedHandler
{
	private ValueTask<Response445> Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request446(long Id) : Mediator.IRequest<Response446>, MediatR.IRequest<Response446>;

public sealed record Response446(long Id);

public sealed partial class Request446TraditionalHandler
	: Mediator.IRequestHandler<Request446, Response446>,
	MediatR.IRequestHandler<Request446, Response446>
{
	ValueTask<Response446> Mediator.IRequestHandler<Request446, Response446>.Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response446> MediatR.IRequestHandler<Request446, Response446>.Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request446StaticHandler
{
	private static ValueTask<Response446> Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request446SealedHandler
{
	private ValueTask<Response446> Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request447(long Id) : Mediator.IRequest<Response447>, MediatR.IRequest<Response447>;

public sealed record Response447(long Id);

public sealed partial class Request447TraditionalHandler
	: Mediator.IRequestHandler<Request447, Response447>,
	MediatR.IRequestHandler<Request447, Response447>
{
	ValueTask<Response447> Mediator.IRequestHandler<Request447, Response447>.Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response447> MediatR.IRequestHandler<Request447, Response447>.Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request447StaticHandler
{
	private static ValueTask<Response447> Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request447SealedHandler
{
	private ValueTask<Response447> Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request448(long Id) : Mediator.IRequest<Response448>, MediatR.IRequest<Response448>;

public sealed record Response448(long Id);

public sealed partial class Request448TraditionalHandler
	: Mediator.IRequestHandler<Request448, Response448>,
	MediatR.IRequestHandler<Request448, Response448>
{
	ValueTask<Response448> Mediator.IRequestHandler<Request448, Response448>.Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response448> MediatR.IRequestHandler<Request448, Response448>.Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request448StaticHandler
{
	private static ValueTask<Response448> Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request448SealedHandler
{
	private ValueTask<Response448> Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request449(long Id) : Mediator.IRequest<Response449>, MediatR.IRequest<Response449>;

public sealed record Response449(long Id);

public sealed partial class Request449TraditionalHandler
	: Mediator.IRequestHandler<Request449, Response449>,
	MediatR.IRequestHandler<Request449, Response449>
{
	ValueTask<Response449> Mediator.IRequestHandler<Request449, Response449>.Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response449> MediatR.IRequestHandler<Request449, Response449>.Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request449StaticHandler
{
	private static ValueTask<Response449> Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request449SealedHandler
{
	private ValueTask<Response449> Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request450(long Id) : Mediator.IRequest<Response450>, MediatR.IRequest<Response450>;

public sealed record Response450(long Id);

public sealed partial class Request450TraditionalHandler
	: Mediator.IRequestHandler<Request450, Response450>,
	MediatR.IRequestHandler<Request450, Response450>
{
	ValueTask<Response450> Mediator.IRequestHandler<Request450, Response450>.Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response450> MediatR.IRequestHandler<Request450, Response450>.Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request450StaticHandler
{
	private static ValueTask<Response450> Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request450SealedHandler
{
	private ValueTask<Response450> Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request451(long Id) : Mediator.IRequest<Response451>, MediatR.IRequest<Response451>;

public sealed record Response451(long Id);

public sealed partial class Request451TraditionalHandler
	: Mediator.IRequestHandler<Request451, Response451>,
	MediatR.IRequestHandler<Request451, Response451>
{
	ValueTask<Response451> Mediator.IRequestHandler<Request451, Response451>.Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response451> MediatR.IRequestHandler<Request451, Response451>.Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request451StaticHandler
{
	private static ValueTask<Response451> Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request451SealedHandler
{
	private ValueTask<Response451> Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request452(long Id) : Mediator.IRequest<Response452>, MediatR.IRequest<Response452>;

public sealed record Response452(long Id);

public sealed partial class Request452TraditionalHandler
	: Mediator.IRequestHandler<Request452, Response452>,
	MediatR.IRequestHandler<Request452, Response452>
{
	ValueTask<Response452> Mediator.IRequestHandler<Request452, Response452>.Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response452> MediatR.IRequestHandler<Request452, Response452>.Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request452StaticHandler
{
	private static ValueTask<Response452> Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request452SealedHandler
{
	private ValueTask<Response452> Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request453(long Id) : Mediator.IRequest<Response453>, MediatR.IRequest<Response453>;

public sealed record Response453(long Id);

public sealed partial class Request453TraditionalHandler
	: Mediator.IRequestHandler<Request453, Response453>,
	MediatR.IRequestHandler<Request453, Response453>
{
	ValueTask<Response453> Mediator.IRequestHandler<Request453, Response453>.Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response453> MediatR.IRequestHandler<Request453, Response453>.Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request453StaticHandler
{
	private static ValueTask<Response453> Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request453SealedHandler
{
	private ValueTask<Response453> Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request454(long Id) : Mediator.IRequest<Response454>, MediatR.IRequest<Response454>;

public sealed record Response454(long Id);

public sealed partial class Request454TraditionalHandler
	: Mediator.IRequestHandler<Request454, Response454>,
	MediatR.IRequestHandler<Request454, Response454>
{
	ValueTask<Response454> Mediator.IRequestHandler<Request454, Response454>.Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response454> MediatR.IRequestHandler<Request454, Response454>.Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request454StaticHandler
{
	private static ValueTask<Response454> Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request454SealedHandler
{
	private ValueTask<Response454> Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request455(long Id) : Mediator.IRequest<Response455>, MediatR.IRequest<Response455>;

public sealed record Response455(long Id);

public sealed partial class Request455TraditionalHandler
	: Mediator.IRequestHandler<Request455, Response455>,
	MediatR.IRequestHandler<Request455, Response455>
{
	ValueTask<Response455> Mediator.IRequestHandler<Request455, Response455>.Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response455> MediatR.IRequestHandler<Request455, Response455>.Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request455StaticHandler
{
	private static ValueTask<Response455> Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request455SealedHandler
{
	private ValueTask<Response455> Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request456(long Id) : Mediator.IRequest<Response456>, MediatR.IRequest<Response456>;

public sealed record Response456(long Id);

public sealed partial class Request456TraditionalHandler
	: Mediator.IRequestHandler<Request456, Response456>,
	MediatR.IRequestHandler<Request456, Response456>
{
	ValueTask<Response456> Mediator.IRequestHandler<Request456, Response456>.Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response456> MediatR.IRequestHandler<Request456, Response456>.Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request456StaticHandler
{
	private static ValueTask<Response456> Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request456SealedHandler
{
	private ValueTask<Response456> Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request457(long Id) : Mediator.IRequest<Response457>, MediatR.IRequest<Response457>;

public sealed record Response457(long Id);

public sealed partial class Request457TraditionalHandler
	: Mediator.IRequestHandler<Request457, Response457>,
	MediatR.IRequestHandler<Request457, Response457>
{
	ValueTask<Response457> Mediator.IRequestHandler<Request457, Response457>.Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response457> MediatR.IRequestHandler<Request457, Response457>.Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request457StaticHandler
{
	private static ValueTask<Response457> Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request457SealedHandler
{
	private ValueTask<Response457> Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request458(long Id) : Mediator.IRequest<Response458>, MediatR.IRequest<Response458>;

public sealed record Response458(long Id);

public sealed partial class Request458TraditionalHandler
	: Mediator.IRequestHandler<Request458, Response458>,
	MediatR.IRequestHandler<Request458, Response458>
{
	ValueTask<Response458> Mediator.IRequestHandler<Request458, Response458>.Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response458> MediatR.IRequestHandler<Request458, Response458>.Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request458StaticHandler
{
	private static ValueTask<Response458> Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request458SealedHandler
{
	private ValueTask<Response458> Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request459(long Id) : Mediator.IRequest<Response459>, MediatR.IRequest<Response459>;

public sealed record Response459(long Id);

public sealed partial class Request459TraditionalHandler
	: Mediator.IRequestHandler<Request459, Response459>,
	MediatR.IRequestHandler<Request459, Response459>
{
	ValueTask<Response459> Mediator.IRequestHandler<Request459, Response459>.Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response459> MediatR.IRequestHandler<Request459, Response459>.Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request459StaticHandler
{
	private static ValueTask<Response459> Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request459SealedHandler
{
	private ValueTask<Response459> Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request460(long Id) : Mediator.IRequest<Response460>, MediatR.IRequest<Response460>;

public sealed record Response460(long Id);

public sealed partial class Request460TraditionalHandler
	: Mediator.IRequestHandler<Request460, Response460>,
	MediatR.IRequestHandler<Request460, Response460>
{
	ValueTask<Response460> Mediator.IRequestHandler<Request460, Response460>.Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response460> MediatR.IRequestHandler<Request460, Response460>.Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request460StaticHandler
{
	private static ValueTask<Response460> Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request460SealedHandler
{
	private ValueTask<Response460> Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request461(long Id) : Mediator.IRequest<Response461>, MediatR.IRequest<Response461>;

public sealed record Response461(long Id);

public sealed partial class Request461TraditionalHandler
	: Mediator.IRequestHandler<Request461, Response461>,
	MediatR.IRequestHandler<Request461, Response461>
{
	ValueTask<Response461> Mediator.IRequestHandler<Request461, Response461>.Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response461> MediatR.IRequestHandler<Request461, Response461>.Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request461StaticHandler
{
	private static ValueTask<Response461> Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request461SealedHandler
{
	private ValueTask<Response461> Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request462(long Id) : Mediator.IRequest<Response462>, MediatR.IRequest<Response462>;

public sealed record Response462(long Id);

public sealed partial class Request462TraditionalHandler
	: Mediator.IRequestHandler<Request462, Response462>,
	MediatR.IRequestHandler<Request462, Response462>
{
	ValueTask<Response462> Mediator.IRequestHandler<Request462, Response462>.Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response462> MediatR.IRequestHandler<Request462, Response462>.Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request462StaticHandler
{
	private static ValueTask<Response462> Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request462SealedHandler
{
	private ValueTask<Response462> Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request463(long Id) : Mediator.IRequest<Response463>, MediatR.IRequest<Response463>;

public sealed record Response463(long Id);

public sealed partial class Request463TraditionalHandler
	: Mediator.IRequestHandler<Request463, Response463>,
	MediatR.IRequestHandler<Request463, Response463>
{
	ValueTask<Response463> Mediator.IRequestHandler<Request463, Response463>.Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response463> MediatR.IRequestHandler<Request463, Response463>.Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request463StaticHandler
{
	private static ValueTask<Response463> Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request463SealedHandler
{
	private ValueTask<Response463> Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request464(long Id) : Mediator.IRequest<Response464>, MediatR.IRequest<Response464>;

public sealed record Response464(long Id);

public sealed partial class Request464TraditionalHandler
	: Mediator.IRequestHandler<Request464, Response464>,
	MediatR.IRequestHandler<Request464, Response464>
{
	ValueTask<Response464> Mediator.IRequestHandler<Request464, Response464>.Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response464> MediatR.IRequestHandler<Request464, Response464>.Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request464StaticHandler
{
	private static ValueTask<Response464> Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request464SealedHandler
{
	private ValueTask<Response464> Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request465(long Id) : Mediator.IRequest<Response465>, MediatR.IRequest<Response465>;

public sealed record Response465(long Id);

public sealed partial class Request465TraditionalHandler
	: Mediator.IRequestHandler<Request465, Response465>,
	MediatR.IRequestHandler<Request465, Response465>
{
	ValueTask<Response465> Mediator.IRequestHandler<Request465, Response465>.Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response465> MediatR.IRequestHandler<Request465, Response465>.Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request465StaticHandler
{
	private static ValueTask<Response465> Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request465SealedHandler
{
	private ValueTask<Response465> Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request466(long Id) : Mediator.IRequest<Response466>, MediatR.IRequest<Response466>;

public sealed record Response466(long Id);

public sealed partial class Request466TraditionalHandler
	: Mediator.IRequestHandler<Request466, Response466>,
	MediatR.IRequestHandler<Request466, Response466>
{
	ValueTask<Response466> Mediator.IRequestHandler<Request466, Response466>.Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response466> MediatR.IRequestHandler<Request466, Response466>.Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request466StaticHandler
{
	private static ValueTask<Response466> Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request466SealedHandler
{
	private ValueTask<Response466> Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request467(long Id) : Mediator.IRequest<Response467>, MediatR.IRequest<Response467>;

public sealed record Response467(long Id);

public sealed partial class Request467TraditionalHandler
	: Mediator.IRequestHandler<Request467, Response467>,
	MediatR.IRequestHandler<Request467, Response467>
{
	ValueTask<Response467> Mediator.IRequestHandler<Request467, Response467>.Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response467> MediatR.IRequestHandler<Request467, Response467>.Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request467StaticHandler
{
	private static ValueTask<Response467> Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request467SealedHandler
{
	private ValueTask<Response467> Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request468(long Id) : Mediator.IRequest<Response468>, MediatR.IRequest<Response468>;

public sealed record Response468(long Id);

public sealed partial class Request468TraditionalHandler
	: Mediator.IRequestHandler<Request468, Response468>,
	MediatR.IRequestHandler<Request468, Response468>
{
	ValueTask<Response468> Mediator.IRequestHandler<Request468, Response468>.Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response468> MediatR.IRequestHandler<Request468, Response468>.Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request468StaticHandler
{
	private static ValueTask<Response468> Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request468SealedHandler
{
	private ValueTask<Response468> Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request469(long Id) : Mediator.IRequest<Response469>, MediatR.IRequest<Response469>;

public sealed record Response469(long Id);

public sealed partial class Request469TraditionalHandler
	: Mediator.IRequestHandler<Request469, Response469>,
	MediatR.IRequestHandler<Request469, Response469>
{
	ValueTask<Response469> Mediator.IRequestHandler<Request469, Response469>.Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response469> MediatR.IRequestHandler<Request469, Response469>.Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request469StaticHandler
{
	private static ValueTask<Response469> Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request469SealedHandler
{
	private ValueTask<Response469> Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request470(long Id) : Mediator.IRequest<Response470>, MediatR.IRequest<Response470>;

public sealed record Response470(long Id);

public sealed partial class Request470TraditionalHandler
	: Mediator.IRequestHandler<Request470, Response470>,
	MediatR.IRequestHandler<Request470, Response470>
{
	ValueTask<Response470> Mediator.IRequestHandler<Request470, Response470>.Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response470> MediatR.IRequestHandler<Request470, Response470>.Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request470StaticHandler
{
	private static ValueTask<Response470> Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request470SealedHandler
{
	private ValueTask<Response470> Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request471(long Id) : Mediator.IRequest<Response471>, MediatR.IRequest<Response471>;

public sealed record Response471(long Id);

public sealed partial class Request471TraditionalHandler
	: Mediator.IRequestHandler<Request471, Response471>,
	MediatR.IRequestHandler<Request471, Response471>
{
	ValueTask<Response471> Mediator.IRequestHandler<Request471, Response471>.Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response471> MediatR.IRequestHandler<Request471, Response471>.Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request471StaticHandler
{
	private static ValueTask<Response471> Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request471SealedHandler
{
	private ValueTask<Response471> Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request472(long Id) : Mediator.IRequest<Response472>, MediatR.IRequest<Response472>;

public sealed record Response472(long Id);

public sealed partial class Request472TraditionalHandler
	: Mediator.IRequestHandler<Request472, Response472>,
	MediatR.IRequestHandler<Request472, Response472>
{
	ValueTask<Response472> Mediator.IRequestHandler<Request472, Response472>.Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response472> MediatR.IRequestHandler<Request472, Response472>.Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request472StaticHandler
{
	private static ValueTask<Response472> Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request472SealedHandler
{
	private ValueTask<Response472> Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request473(long Id) : Mediator.IRequest<Response473>, MediatR.IRequest<Response473>;

public sealed record Response473(long Id);

public sealed partial class Request473TraditionalHandler
	: Mediator.IRequestHandler<Request473, Response473>,
	MediatR.IRequestHandler<Request473, Response473>
{
	ValueTask<Response473> Mediator.IRequestHandler<Request473, Response473>.Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response473> MediatR.IRequestHandler<Request473, Response473>.Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request473StaticHandler
{
	private static ValueTask<Response473> Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request473SealedHandler
{
	private ValueTask<Response473> Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request474(long Id) : Mediator.IRequest<Response474>, MediatR.IRequest<Response474>;

public sealed record Response474(long Id);

public sealed partial class Request474TraditionalHandler
	: Mediator.IRequestHandler<Request474, Response474>,
	MediatR.IRequestHandler<Request474, Response474>
{
	ValueTask<Response474> Mediator.IRequestHandler<Request474, Response474>.Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response474> MediatR.IRequestHandler<Request474, Response474>.Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request474StaticHandler
{
	private static ValueTask<Response474> Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request474SealedHandler
{
	private ValueTask<Response474> Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request475(long Id) : Mediator.IRequest<Response475>, MediatR.IRequest<Response475>;

public sealed record Response475(long Id);

public sealed partial class Request475TraditionalHandler
	: Mediator.IRequestHandler<Request475, Response475>,
	MediatR.IRequestHandler<Request475, Response475>
{
	ValueTask<Response475> Mediator.IRequestHandler<Request475, Response475>.Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response475> MediatR.IRequestHandler<Request475, Response475>.Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request475StaticHandler
{
	private static ValueTask<Response475> Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request475SealedHandler
{
	private ValueTask<Response475> Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request476(long Id) : Mediator.IRequest<Response476>, MediatR.IRequest<Response476>;

public sealed record Response476(long Id);

public sealed partial class Request476TraditionalHandler
	: Mediator.IRequestHandler<Request476, Response476>,
	MediatR.IRequestHandler<Request476, Response476>
{
	ValueTask<Response476> Mediator.IRequestHandler<Request476, Response476>.Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response476> MediatR.IRequestHandler<Request476, Response476>.Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request476StaticHandler
{
	private static ValueTask<Response476> Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request476SealedHandler
{
	private ValueTask<Response476> Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request477(long Id) : Mediator.IRequest<Response477>, MediatR.IRequest<Response477>;

public sealed record Response477(long Id);

public sealed partial class Request477TraditionalHandler
	: Mediator.IRequestHandler<Request477, Response477>,
	MediatR.IRequestHandler<Request477, Response477>
{
	ValueTask<Response477> Mediator.IRequestHandler<Request477, Response477>.Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response477> MediatR.IRequestHandler<Request477, Response477>.Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request477StaticHandler
{
	private static ValueTask<Response477> Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request477SealedHandler
{
	private ValueTask<Response477> Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request478(long Id) : Mediator.IRequest<Response478>, MediatR.IRequest<Response478>;

public sealed record Response478(long Id);

public sealed partial class Request478TraditionalHandler
	: Mediator.IRequestHandler<Request478, Response478>,
	MediatR.IRequestHandler<Request478, Response478>
{
	ValueTask<Response478> Mediator.IRequestHandler<Request478, Response478>.Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response478> MediatR.IRequestHandler<Request478, Response478>.Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request478StaticHandler
{
	private static ValueTask<Response478> Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request478SealedHandler
{
	private ValueTask<Response478> Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request479(long Id) : Mediator.IRequest<Response479>, MediatR.IRequest<Response479>;

public sealed record Response479(long Id);

public sealed partial class Request479TraditionalHandler
	: Mediator.IRequestHandler<Request479, Response479>,
	MediatR.IRequestHandler<Request479, Response479>
{
	ValueTask<Response479> Mediator.IRequestHandler<Request479, Response479>.Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response479> MediatR.IRequestHandler<Request479, Response479>.Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request479StaticHandler
{
	private static ValueTask<Response479> Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request479SealedHandler
{
	private ValueTask<Response479> Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request480(long Id) : Mediator.IRequest<Response480>, MediatR.IRequest<Response480>;

public sealed record Response480(long Id);

public sealed partial class Request480TraditionalHandler
	: Mediator.IRequestHandler<Request480, Response480>,
	MediatR.IRequestHandler<Request480, Response480>
{
	ValueTask<Response480> Mediator.IRequestHandler<Request480, Response480>.Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response480> MediatR.IRequestHandler<Request480, Response480>.Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request480StaticHandler
{
	private static ValueTask<Response480> Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request480SealedHandler
{
	private ValueTask<Response480> Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request481(long Id) : Mediator.IRequest<Response481>, MediatR.IRequest<Response481>;

public sealed record Response481(long Id);

public sealed partial class Request481TraditionalHandler
	: Mediator.IRequestHandler<Request481, Response481>,
	MediatR.IRequestHandler<Request481, Response481>
{
	ValueTask<Response481> Mediator.IRequestHandler<Request481, Response481>.Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response481> MediatR.IRequestHandler<Request481, Response481>.Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request481StaticHandler
{
	private static ValueTask<Response481> Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request481SealedHandler
{
	private ValueTask<Response481> Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request482(long Id) : Mediator.IRequest<Response482>, MediatR.IRequest<Response482>;

public sealed record Response482(long Id);

public sealed partial class Request482TraditionalHandler
	: Mediator.IRequestHandler<Request482, Response482>,
	MediatR.IRequestHandler<Request482, Response482>
{
	ValueTask<Response482> Mediator.IRequestHandler<Request482, Response482>.Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response482> MediatR.IRequestHandler<Request482, Response482>.Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request482StaticHandler
{
	private static ValueTask<Response482> Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request482SealedHandler
{
	private ValueTask<Response482> Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request483(long Id) : Mediator.IRequest<Response483>, MediatR.IRequest<Response483>;

public sealed record Response483(long Id);

public sealed partial class Request483TraditionalHandler
	: Mediator.IRequestHandler<Request483, Response483>,
	MediatR.IRequestHandler<Request483, Response483>
{
	ValueTask<Response483> Mediator.IRequestHandler<Request483, Response483>.Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response483> MediatR.IRequestHandler<Request483, Response483>.Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request483StaticHandler
{
	private static ValueTask<Response483> Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request483SealedHandler
{
	private ValueTask<Response483> Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request484(long Id) : Mediator.IRequest<Response484>, MediatR.IRequest<Response484>;

public sealed record Response484(long Id);

public sealed partial class Request484TraditionalHandler
	: Mediator.IRequestHandler<Request484, Response484>,
	MediatR.IRequestHandler<Request484, Response484>
{
	ValueTask<Response484> Mediator.IRequestHandler<Request484, Response484>.Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response484> MediatR.IRequestHandler<Request484, Response484>.Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request484StaticHandler
{
	private static ValueTask<Response484> Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request484SealedHandler
{
	private ValueTask<Response484> Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request485(long Id) : Mediator.IRequest<Response485>, MediatR.IRequest<Response485>;

public sealed record Response485(long Id);

public sealed partial class Request485TraditionalHandler
	: Mediator.IRequestHandler<Request485, Response485>,
	MediatR.IRequestHandler<Request485, Response485>
{
	ValueTask<Response485> Mediator.IRequestHandler<Request485, Response485>.Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response485> MediatR.IRequestHandler<Request485, Response485>.Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request485StaticHandler
{
	private static ValueTask<Response485> Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request485SealedHandler
{
	private ValueTask<Response485> Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request486(long Id) : Mediator.IRequest<Response486>, MediatR.IRequest<Response486>;

public sealed record Response486(long Id);

public sealed partial class Request486TraditionalHandler
	: Mediator.IRequestHandler<Request486, Response486>,
	MediatR.IRequestHandler<Request486, Response486>
{
	ValueTask<Response486> Mediator.IRequestHandler<Request486, Response486>.Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response486> MediatR.IRequestHandler<Request486, Response486>.Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request486StaticHandler
{
	private static ValueTask<Response486> Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request486SealedHandler
{
	private ValueTask<Response486> Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request487(long Id) : Mediator.IRequest<Response487>, MediatR.IRequest<Response487>;

public sealed record Response487(long Id);

public sealed partial class Request487TraditionalHandler
	: Mediator.IRequestHandler<Request487, Response487>,
	MediatR.IRequestHandler<Request487, Response487>
{
	ValueTask<Response487> Mediator.IRequestHandler<Request487, Response487>.Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response487> MediatR.IRequestHandler<Request487, Response487>.Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request487StaticHandler
{
	private static ValueTask<Response487> Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request487SealedHandler
{
	private ValueTask<Response487> Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request488(long Id) : Mediator.IRequest<Response488>, MediatR.IRequest<Response488>;

public sealed record Response488(long Id);

public sealed partial class Request488TraditionalHandler
	: Mediator.IRequestHandler<Request488, Response488>,
	MediatR.IRequestHandler<Request488, Response488>
{
	ValueTask<Response488> Mediator.IRequestHandler<Request488, Response488>.Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response488> MediatR.IRequestHandler<Request488, Response488>.Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request488StaticHandler
{
	private static ValueTask<Response488> Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request488SealedHandler
{
	private ValueTask<Response488> Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request489(long Id) : Mediator.IRequest<Response489>, MediatR.IRequest<Response489>;

public sealed record Response489(long Id);

public sealed partial class Request489TraditionalHandler
	: Mediator.IRequestHandler<Request489, Response489>,
	MediatR.IRequestHandler<Request489, Response489>
{
	ValueTask<Response489> Mediator.IRequestHandler<Request489, Response489>.Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response489> MediatR.IRequestHandler<Request489, Response489>.Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request489StaticHandler
{
	private static ValueTask<Response489> Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request489SealedHandler
{
	private ValueTask<Response489> Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request490(long Id) : Mediator.IRequest<Response490>, MediatR.IRequest<Response490>;

public sealed record Response490(long Id);

public sealed partial class Request490TraditionalHandler
	: Mediator.IRequestHandler<Request490, Response490>,
	MediatR.IRequestHandler<Request490, Response490>
{
	ValueTask<Response490> Mediator.IRequestHandler<Request490, Response490>.Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response490> MediatR.IRequestHandler<Request490, Response490>.Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request490StaticHandler
{
	private static ValueTask<Response490> Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request490SealedHandler
{
	private ValueTask<Response490> Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request491(long Id) : Mediator.IRequest<Response491>, MediatR.IRequest<Response491>;

public sealed record Response491(long Id);

public sealed partial class Request491TraditionalHandler
	: Mediator.IRequestHandler<Request491, Response491>,
	MediatR.IRequestHandler<Request491, Response491>
{
	ValueTask<Response491> Mediator.IRequestHandler<Request491, Response491>.Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response491> MediatR.IRequestHandler<Request491, Response491>.Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request491StaticHandler
{
	private static ValueTask<Response491> Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request491SealedHandler
{
	private ValueTask<Response491> Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request492(long Id) : Mediator.IRequest<Response492>, MediatR.IRequest<Response492>;

public sealed record Response492(long Id);

public sealed partial class Request492TraditionalHandler
	: Mediator.IRequestHandler<Request492, Response492>,
	MediatR.IRequestHandler<Request492, Response492>
{
	ValueTask<Response492> Mediator.IRequestHandler<Request492, Response492>.Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response492> MediatR.IRequestHandler<Request492, Response492>.Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request492StaticHandler
{
	private static ValueTask<Response492> Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request492SealedHandler
{
	private ValueTask<Response492> Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request493(long Id) : Mediator.IRequest<Response493>, MediatR.IRequest<Response493>;

public sealed record Response493(long Id);

public sealed partial class Request493TraditionalHandler
	: Mediator.IRequestHandler<Request493, Response493>,
	MediatR.IRequestHandler<Request493, Response493>
{
	ValueTask<Response493> Mediator.IRequestHandler<Request493, Response493>.Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response493> MediatR.IRequestHandler<Request493, Response493>.Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request493StaticHandler
{
	private static ValueTask<Response493> Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request493SealedHandler
{
	private ValueTask<Response493> Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request494(long Id) : Mediator.IRequest<Response494>, MediatR.IRequest<Response494>;

public sealed record Response494(long Id);

public sealed partial class Request494TraditionalHandler
	: Mediator.IRequestHandler<Request494, Response494>,
	MediatR.IRequestHandler<Request494, Response494>
{
	ValueTask<Response494> Mediator.IRequestHandler<Request494, Response494>.Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response494> MediatR.IRequestHandler<Request494, Response494>.Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request494StaticHandler
{
	private static ValueTask<Response494> Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request494SealedHandler
{
	private ValueTask<Response494> Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request495(long Id) : Mediator.IRequest<Response495>, MediatR.IRequest<Response495>;

public sealed record Response495(long Id);

public sealed partial class Request495TraditionalHandler
	: Mediator.IRequestHandler<Request495, Response495>,
	MediatR.IRequestHandler<Request495, Response495>
{
	ValueTask<Response495> Mediator.IRequestHandler<Request495, Response495>.Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response495> MediatR.IRequestHandler<Request495, Response495>.Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request495StaticHandler
{
	private static ValueTask<Response495> Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request495SealedHandler
{
	private ValueTask<Response495> Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request496(long Id) : Mediator.IRequest<Response496>, MediatR.IRequest<Response496>;

public sealed record Response496(long Id);

public sealed partial class Request496TraditionalHandler
	: Mediator.IRequestHandler<Request496, Response496>,
	MediatR.IRequestHandler<Request496, Response496>
{
	ValueTask<Response496> Mediator.IRequestHandler<Request496, Response496>.Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response496> MediatR.IRequestHandler<Request496, Response496>.Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request496StaticHandler
{
	private static ValueTask<Response496> Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request496SealedHandler
{
	private ValueTask<Response496> Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request497(long Id) : Mediator.IRequest<Response497>, MediatR.IRequest<Response497>;

public sealed record Response497(long Id);

public sealed partial class Request497TraditionalHandler
	: Mediator.IRequestHandler<Request497, Response497>,
	MediatR.IRequestHandler<Request497, Response497>
{
	ValueTask<Response497> Mediator.IRequestHandler<Request497, Response497>.Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response497> MediatR.IRequestHandler<Request497, Response497>.Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request497StaticHandler
{
	private static ValueTask<Response497> Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request497SealedHandler
{
	private ValueTask<Response497> Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request498(long Id) : Mediator.IRequest<Response498>, MediatR.IRequest<Response498>;

public sealed record Response498(long Id);

public sealed partial class Request498TraditionalHandler
	: Mediator.IRequestHandler<Request498, Response498>,
	MediatR.IRequestHandler<Request498, Response498>
{
	ValueTask<Response498> Mediator.IRequestHandler<Request498, Response498>.Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response498> MediatR.IRequestHandler<Request498, Response498>.Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request498StaticHandler
{
	private static ValueTask<Response498> Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request498SealedHandler
{
	private ValueTask<Response498> Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request499(long Id) : Mediator.IRequest<Response499>, MediatR.IRequest<Response499>;

public sealed record Response499(long Id);

public sealed partial class Request499TraditionalHandler
	: Mediator.IRequestHandler<Request499, Response499>,
	MediatR.IRequestHandler<Request499, Response499>
{
	ValueTask<Response499> Mediator.IRequestHandler<Request499, Response499>.Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response499> MediatR.IRequestHandler<Request499, Response499>.Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request499StaticHandler
{
	private static ValueTask<Response499> Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request499SealedHandler
{
	private ValueTask<Response499> Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request500(long Id) : Mediator.IRequest<Response500>, MediatR.IRequest<Response500>;

public sealed record Response500(long Id);

public sealed partial class Request500TraditionalHandler
	: Mediator.IRequestHandler<Request500, Response500>,
	MediatR.IRequestHandler<Request500, Response500>
{
	ValueTask<Response500> Mediator.IRequestHandler<Request500, Response500>.Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response500> MediatR.IRequestHandler<Request500, Response500>.Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request500StaticHandler
{
	private static ValueTask<Response500> Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request500SealedHandler
{
	private ValueTask<Response500> Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request501(long Id) : Mediator.IRequest<Response501>, MediatR.IRequest<Response501>;

public sealed record Response501(long Id);

public sealed partial class Request501TraditionalHandler
	: Mediator.IRequestHandler<Request501, Response501>,
	MediatR.IRequestHandler<Request501, Response501>
{
	ValueTask<Response501> Mediator.IRequestHandler<Request501, Response501>.Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response501> MediatR.IRequestHandler<Request501, Response501>.Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request501StaticHandler
{
	private static ValueTask<Response501> Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request501SealedHandler
{
	private ValueTask<Response501> Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request502(long Id) : Mediator.IRequest<Response502>, MediatR.IRequest<Response502>;

public sealed record Response502(long Id);

public sealed partial class Request502TraditionalHandler
	: Mediator.IRequestHandler<Request502, Response502>,
	MediatR.IRequestHandler<Request502, Response502>
{
	ValueTask<Response502> Mediator.IRequestHandler<Request502, Response502>.Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response502> MediatR.IRequestHandler<Request502, Response502>.Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request502StaticHandler
{
	private static ValueTask<Response502> Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request502SealedHandler
{
	private ValueTask<Response502> Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request503(long Id) : Mediator.IRequest<Response503>, MediatR.IRequest<Response503>;

public sealed record Response503(long Id);

public sealed partial class Request503TraditionalHandler
	: Mediator.IRequestHandler<Request503, Response503>,
	MediatR.IRequestHandler<Request503, Response503>
{
	ValueTask<Response503> Mediator.IRequestHandler<Request503, Response503>.Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response503> MediatR.IRequestHandler<Request503, Response503>.Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request503StaticHandler
{
	private static ValueTask<Response503> Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request503SealedHandler
{
	private ValueTask<Response503> Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request504(long Id) : Mediator.IRequest<Response504>, MediatR.IRequest<Response504>;

public sealed record Response504(long Id);

public sealed partial class Request504TraditionalHandler
	: Mediator.IRequestHandler<Request504, Response504>,
	MediatR.IRequestHandler<Request504, Response504>
{
	ValueTask<Response504> Mediator.IRequestHandler<Request504, Response504>.Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response504> MediatR.IRequestHandler<Request504, Response504>.Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request504StaticHandler
{
	private static ValueTask<Response504> Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request504SealedHandler
{
	private ValueTask<Response504> Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request505(long Id) : Mediator.IRequest<Response505>, MediatR.IRequest<Response505>;

public sealed record Response505(long Id);

public sealed partial class Request505TraditionalHandler
	: Mediator.IRequestHandler<Request505, Response505>,
	MediatR.IRequestHandler<Request505, Response505>
{
	ValueTask<Response505> Mediator.IRequestHandler<Request505, Response505>.Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response505> MediatR.IRequestHandler<Request505, Response505>.Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request505StaticHandler
{
	private static ValueTask<Response505> Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request505SealedHandler
{
	private ValueTask<Response505> Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request506(long Id) : Mediator.IRequest<Response506>, MediatR.IRequest<Response506>;

public sealed record Response506(long Id);

public sealed partial class Request506TraditionalHandler
	: Mediator.IRequestHandler<Request506, Response506>,
	MediatR.IRequestHandler<Request506, Response506>
{
	ValueTask<Response506> Mediator.IRequestHandler<Request506, Response506>.Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response506> MediatR.IRequestHandler<Request506, Response506>.Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request506StaticHandler
{
	private static ValueTask<Response506> Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request506SealedHandler
{
	private ValueTask<Response506> Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request507(long Id) : Mediator.IRequest<Response507>, MediatR.IRequest<Response507>;

public sealed record Response507(long Id);

public sealed partial class Request507TraditionalHandler
	: Mediator.IRequestHandler<Request507, Response507>,
	MediatR.IRequestHandler<Request507, Response507>
{
	ValueTask<Response507> Mediator.IRequestHandler<Request507, Response507>.Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response507> MediatR.IRequestHandler<Request507, Response507>.Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request507StaticHandler
{
	private static ValueTask<Response507> Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request507SealedHandler
{
	private ValueTask<Response507> Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request508(long Id) : Mediator.IRequest<Response508>, MediatR.IRequest<Response508>;

public sealed record Response508(long Id);

public sealed partial class Request508TraditionalHandler
	: Mediator.IRequestHandler<Request508, Response508>,
	MediatR.IRequestHandler<Request508, Response508>
{
	ValueTask<Response508> Mediator.IRequestHandler<Request508, Response508>.Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response508> MediatR.IRequestHandler<Request508, Response508>.Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request508StaticHandler
{
	private static ValueTask<Response508> Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request508SealedHandler
{
	private ValueTask<Response508> Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request509(long Id) : Mediator.IRequest<Response509>, MediatR.IRequest<Response509>;

public sealed record Response509(long Id);

public sealed partial class Request509TraditionalHandler
	: Mediator.IRequestHandler<Request509, Response509>,
	MediatR.IRequestHandler<Request509, Response509>
{
	ValueTask<Response509> Mediator.IRequestHandler<Request509, Response509>.Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response509> MediatR.IRequestHandler<Request509, Response509>.Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request509StaticHandler
{
	private static ValueTask<Response509> Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request509SealedHandler
{
	private ValueTask<Response509> Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request510(long Id) : Mediator.IRequest<Response510>, MediatR.IRequest<Response510>;

public sealed record Response510(long Id);

public sealed partial class Request510TraditionalHandler
	: Mediator.IRequestHandler<Request510, Response510>,
	MediatR.IRequestHandler<Request510, Response510>
{
	ValueTask<Response510> Mediator.IRequestHandler<Request510, Response510>.Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response510> MediatR.IRequestHandler<Request510, Response510>.Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request510StaticHandler
{
	private static ValueTask<Response510> Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request510SealedHandler
{
	private ValueTask<Response510> Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request511(long Id) : Mediator.IRequest<Response511>, MediatR.IRequest<Response511>;

public sealed record Response511(long Id);

public sealed partial class Request511TraditionalHandler
	: Mediator.IRequestHandler<Request511, Response511>,
	MediatR.IRequestHandler<Request511, Response511>
{
	ValueTask<Response511> Mediator.IRequestHandler<Request511, Response511>.Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response511> MediatR.IRequestHandler<Request511, Response511>.Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request511StaticHandler
{
	private static ValueTask<Response511> Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request511SealedHandler
{
	private ValueTask<Response511> Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request512(long Id) : Mediator.IRequest<Response512>, MediatR.IRequest<Response512>;

public sealed record Response512(long Id);

public sealed partial class Request512TraditionalHandler
	: Mediator.IRequestHandler<Request512, Response512>,
	MediatR.IRequestHandler<Request512, Response512>
{
	ValueTask<Response512> Mediator.IRequestHandler<Request512, Response512>.Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response512> MediatR.IRequestHandler<Request512, Response512>.Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request512StaticHandler
{
	private static ValueTask<Response512> Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request512SealedHandler
{
	private ValueTask<Response512> Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request513(long Id) : Mediator.IRequest<Response513>, MediatR.IRequest<Response513>;

public sealed record Response513(long Id);

public sealed partial class Request513TraditionalHandler
	: Mediator.IRequestHandler<Request513, Response513>,
	MediatR.IRequestHandler<Request513, Response513>
{
	ValueTask<Response513> Mediator.IRequestHandler<Request513, Response513>.Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response513> MediatR.IRequestHandler<Request513, Response513>.Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request513StaticHandler
{
	private static ValueTask<Response513> Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request513SealedHandler
{
	private ValueTask<Response513> Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request514(long Id) : Mediator.IRequest<Response514>, MediatR.IRequest<Response514>;

public sealed record Response514(long Id);

public sealed partial class Request514TraditionalHandler
	: Mediator.IRequestHandler<Request514, Response514>,
	MediatR.IRequestHandler<Request514, Response514>
{
	ValueTask<Response514> Mediator.IRequestHandler<Request514, Response514>.Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response514> MediatR.IRequestHandler<Request514, Response514>.Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request514StaticHandler
{
	private static ValueTask<Response514> Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request514SealedHandler
{
	private ValueTask<Response514> Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request515(long Id) : Mediator.IRequest<Response515>, MediatR.IRequest<Response515>;

public sealed record Response515(long Id);

public sealed partial class Request515TraditionalHandler
	: Mediator.IRequestHandler<Request515, Response515>,
	MediatR.IRequestHandler<Request515, Response515>
{
	ValueTask<Response515> Mediator.IRequestHandler<Request515, Response515>.Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response515> MediatR.IRequestHandler<Request515, Response515>.Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request515StaticHandler
{
	private static ValueTask<Response515> Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request515SealedHandler
{
	private ValueTask<Response515> Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request516(long Id) : Mediator.IRequest<Response516>, MediatR.IRequest<Response516>;

public sealed record Response516(long Id);

public sealed partial class Request516TraditionalHandler
	: Mediator.IRequestHandler<Request516, Response516>,
	MediatR.IRequestHandler<Request516, Response516>
{
	ValueTask<Response516> Mediator.IRequestHandler<Request516, Response516>.Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response516> MediatR.IRequestHandler<Request516, Response516>.Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request516StaticHandler
{
	private static ValueTask<Response516> Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request516SealedHandler
{
	private ValueTask<Response516> Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request517(long Id) : Mediator.IRequest<Response517>, MediatR.IRequest<Response517>;

public sealed record Response517(long Id);

public sealed partial class Request517TraditionalHandler
	: Mediator.IRequestHandler<Request517, Response517>,
	MediatR.IRequestHandler<Request517, Response517>
{
	ValueTask<Response517> Mediator.IRequestHandler<Request517, Response517>.Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response517> MediatR.IRequestHandler<Request517, Response517>.Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request517StaticHandler
{
	private static ValueTask<Response517> Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request517SealedHandler
{
	private ValueTask<Response517> Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request518(long Id) : Mediator.IRequest<Response518>, MediatR.IRequest<Response518>;

public sealed record Response518(long Id);

public sealed partial class Request518TraditionalHandler
	: Mediator.IRequestHandler<Request518, Response518>,
	MediatR.IRequestHandler<Request518, Response518>
{
	ValueTask<Response518> Mediator.IRequestHandler<Request518, Response518>.Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response518> MediatR.IRequestHandler<Request518, Response518>.Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request518StaticHandler
{
	private static ValueTask<Response518> Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request518SealedHandler
{
	private ValueTask<Response518> Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request519(long Id) : Mediator.IRequest<Response519>, MediatR.IRequest<Response519>;

public sealed record Response519(long Id);

public sealed partial class Request519TraditionalHandler
	: Mediator.IRequestHandler<Request519, Response519>,
	MediatR.IRequestHandler<Request519, Response519>
{
	ValueTask<Response519> Mediator.IRequestHandler<Request519, Response519>.Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response519> MediatR.IRequestHandler<Request519, Response519>.Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request519StaticHandler
{
	private static ValueTask<Response519> Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request519SealedHandler
{
	private ValueTask<Response519> Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request520(long Id) : Mediator.IRequest<Response520>, MediatR.IRequest<Response520>;

public sealed record Response520(long Id);

public sealed partial class Request520TraditionalHandler
	: Mediator.IRequestHandler<Request520, Response520>,
	MediatR.IRequestHandler<Request520, Response520>
{
	ValueTask<Response520> Mediator.IRequestHandler<Request520, Response520>.Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response520> MediatR.IRequestHandler<Request520, Response520>.Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request520StaticHandler
{
	private static ValueTask<Response520> Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request520SealedHandler
{
	private ValueTask<Response520> Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request521(long Id) : Mediator.IRequest<Response521>, MediatR.IRequest<Response521>;

public sealed record Response521(long Id);

public sealed partial class Request521TraditionalHandler
	: Mediator.IRequestHandler<Request521, Response521>,
	MediatR.IRequestHandler<Request521, Response521>
{
	ValueTask<Response521> Mediator.IRequestHandler<Request521, Response521>.Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response521> MediatR.IRequestHandler<Request521, Response521>.Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request521StaticHandler
{
	private static ValueTask<Response521> Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request521SealedHandler
{
	private ValueTask<Response521> Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request522(long Id) : Mediator.IRequest<Response522>, MediatR.IRequest<Response522>;

public sealed record Response522(long Id);

public sealed partial class Request522TraditionalHandler
	: Mediator.IRequestHandler<Request522, Response522>,
	MediatR.IRequestHandler<Request522, Response522>
{
	ValueTask<Response522> Mediator.IRequestHandler<Request522, Response522>.Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response522> MediatR.IRequestHandler<Request522, Response522>.Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request522StaticHandler
{
	private static ValueTask<Response522> Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request522SealedHandler
{
	private ValueTask<Response522> Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request523(long Id) : Mediator.IRequest<Response523>, MediatR.IRequest<Response523>;

public sealed record Response523(long Id);

public sealed partial class Request523TraditionalHandler
	: Mediator.IRequestHandler<Request523, Response523>,
	MediatR.IRequestHandler<Request523, Response523>
{
	ValueTask<Response523> Mediator.IRequestHandler<Request523, Response523>.Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response523> MediatR.IRequestHandler<Request523, Response523>.Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request523StaticHandler
{
	private static ValueTask<Response523> Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request523SealedHandler
{
	private ValueTask<Response523> Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request524(long Id) : Mediator.IRequest<Response524>, MediatR.IRequest<Response524>;

public sealed record Response524(long Id);

public sealed partial class Request524TraditionalHandler
	: Mediator.IRequestHandler<Request524, Response524>,
	MediatR.IRequestHandler<Request524, Response524>
{
	ValueTask<Response524> Mediator.IRequestHandler<Request524, Response524>.Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response524> MediatR.IRequestHandler<Request524, Response524>.Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request524StaticHandler
{
	private static ValueTask<Response524> Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request524SealedHandler
{
	private ValueTask<Response524> Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request525(long Id) : Mediator.IRequest<Response525>, MediatR.IRequest<Response525>;

public sealed record Response525(long Id);

public sealed partial class Request525TraditionalHandler
	: Mediator.IRequestHandler<Request525, Response525>,
	MediatR.IRequestHandler<Request525, Response525>
{
	ValueTask<Response525> Mediator.IRequestHandler<Request525, Response525>.Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response525> MediatR.IRequestHandler<Request525, Response525>.Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request525StaticHandler
{
	private static ValueTask<Response525> Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request525SealedHandler
{
	private ValueTask<Response525> Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request526(long Id) : Mediator.IRequest<Response526>, MediatR.IRequest<Response526>;

public sealed record Response526(long Id);

public sealed partial class Request526TraditionalHandler
	: Mediator.IRequestHandler<Request526, Response526>,
	MediatR.IRequestHandler<Request526, Response526>
{
	ValueTask<Response526> Mediator.IRequestHandler<Request526, Response526>.Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response526> MediatR.IRequestHandler<Request526, Response526>.Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request526StaticHandler
{
	private static ValueTask<Response526> Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request526SealedHandler
{
	private ValueTask<Response526> Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request527(long Id) : Mediator.IRequest<Response527>, MediatR.IRequest<Response527>;

public sealed record Response527(long Id);

public sealed partial class Request527TraditionalHandler
	: Mediator.IRequestHandler<Request527, Response527>,
	MediatR.IRequestHandler<Request527, Response527>
{
	ValueTask<Response527> Mediator.IRequestHandler<Request527, Response527>.Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response527> MediatR.IRequestHandler<Request527, Response527>.Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request527StaticHandler
{
	private static ValueTask<Response527> Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request527SealedHandler
{
	private ValueTask<Response527> Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request528(long Id) : Mediator.IRequest<Response528>, MediatR.IRequest<Response528>;

public sealed record Response528(long Id);

public sealed partial class Request528TraditionalHandler
	: Mediator.IRequestHandler<Request528, Response528>,
	MediatR.IRequestHandler<Request528, Response528>
{
	ValueTask<Response528> Mediator.IRequestHandler<Request528, Response528>.Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response528> MediatR.IRequestHandler<Request528, Response528>.Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request528StaticHandler
{
	private static ValueTask<Response528> Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request528SealedHandler
{
	private ValueTask<Response528> Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request529(long Id) : Mediator.IRequest<Response529>, MediatR.IRequest<Response529>;

public sealed record Response529(long Id);

public sealed partial class Request529TraditionalHandler
	: Mediator.IRequestHandler<Request529, Response529>,
	MediatR.IRequestHandler<Request529, Response529>
{
	ValueTask<Response529> Mediator.IRequestHandler<Request529, Response529>.Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response529> MediatR.IRequestHandler<Request529, Response529>.Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request529StaticHandler
{
	private static ValueTask<Response529> Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request529SealedHandler
{
	private ValueTask<Response529> Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request530(long Id) : Mediator.IRequest<Response530>, MediatR.IRequest<Response530>;

public sealed record Response530(long Id);

public sealed partial class Request530TraditionalHandler
	: Mediator.IRequestHandler<Request530, Response530>,
	MediatR.IRequestHandler<Request530, Response530>
{
	ValueTask<Response530> Mediator.IRequestHandler<Request530, Response530>.Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response530> MediatR.IRequestHandler<Request530, Response530>.Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request530StaticHandler
{
	private static ValueTask<Response530> Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request530SealedHandler
{
	private ValueTask<Response530> Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request531(long Id) : Mediator.IRequest<Response531>, MediatR.IRequest<Response531>;

public sealed record Response531(long Id);

public sealed partial class Request531TraditionalHandler
	: Mediator.IRequestHandler<Request531, Response531>,
	MediatR.IRequestHandler<Request531, Response531>
{
	ValueTask<Response531> Mediator.IRequestHandler<Request531, Response531>.Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response531> MediatR.IRequestHandler<Request531, Response531>.Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request531StaticHandler
{
	private static ValueTask<Response531> Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request531SealedHandler
{
	private ValueTask<Response531> Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request532(long Id) : Mediator.IRequest<Response532>, MediatR.IRequest<Response532>;

public sealed record Response532(long Id);

public sealed partial class Request532TraditionalHandler
	: Mediator.IRequestHandler<Request532, Response532>,
	MediatR.IRequestHandler<Request532, Response532>
{
	ValueTask<Response532> Mediator.IRequestHandler<Request532, Response532>.Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response532> MediatR.IRequestHandler<Request532, Response532>.Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request532StaticHandler
{
	private static ValueTask<Response532> Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request532SealedHandler
{
	private ValueTask<Response532> Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request533(long Id) : Mediator.IRequest<Response533>, MediatR.IRequest<Response533>;

public sealed record Response533(long Id);

public sealed partial class Request533TraditionalHandler
	: Mediator.IRequestHandler<Request533, Response533>,
	MediatR.IRequestHandler<Request533, Response533>
{
	ValueTask<Response533> Mediator.IRequestHandler<Request533, Response533>.Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response533> MediatR.IRequestHandler<Request533, Response533>.Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request533StaticHandler
{
	private static ValueTask<Response533> Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request533SealedHandler
{
	private ValueTask<Response533> Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request534(long Id) : Mediator.IRequest<Response534>, MediatR.IRequest<Response534>;

public sealed record Response534(long Id);

public sealed partial class Request534TraditionalHandler
	: Mediator.IRequestHandler<Request534, Response534>,
	MediatR.IRequestHandler<Request534, Response534>
{
	ValueTask<Response534> Mediator.IRequestHandler<Request534, Response534>.Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response534> MediatR.IRequestHandler<Request534, Response534>.Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request534StaticHandler
{
	private static ValueTask<Response534> Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request534SealedHandler
{
	private ValueTask<Response534> Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request535(long Id) : Mediator.IRequest<Response535>, MediatR.IRequest<Response535>;

public sealed record Response535(long Id);

public sealed partial class Request535TraditionalHandler
	: Mediator.IRequestHandler<Request535, Response535>,
	MediatR.IRequestHandler<Request535, Response535>
{
	ValueTask<Response535> Mediator.IRequestHandler<Request535, Response535>.Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response535> MediatR.IRequestHandler<Request535, Response535>.Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request535StaticHandler
{
	private static ValueTask<Response535> Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request535SealedHandler
{
	private ValueTask<Response535> Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request536(long Id) : Mediator.IRequest<Response536>, MediatR.IRequest<Response536>;

public sealed record Response536(long Id);

public sealed partial class Request536TraditionalHandler
	: Mediator.IRequestHandler<Request536, Response536>,
	MediatR.IRequestHandler<Request536, Response536>
{
	ValueTask<Response536> Mediator.IRequestHandler<Request536, Response536>.Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response536> MediatR.IRequestHandler<Request536, Response536>.Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request536StaticHandler
{
	private static ValueTask<Response536> Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request536SealedHandler
{
	private ValueTask<Response536> Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request537(long Id) : Mediator.IRequest<Response537>, MediatR.IRequest<Response537>;

public sealed record Response537(long Id);

public sealed partial class Request537TraditionalHandler
	: Mediator.IRequestHandler<Request537, Response537>,
	MediatR.IRequestHandler<Request537, Response537>
{
	ValueTask<Response537> Mediator.IRequestHandler<Request537, Response537>.Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response537> MediatR.IRequestHandler<Request537, Response537>.Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request537StaticHandler
{
	private static ValueTask<Response537> Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request537SealedHandler
{
	private ValueTask<Response537> Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request538(long Id) : Mediator.IRequest<Response538>, MediatR.IRequest<Response538>;

public sealed record Response538(long Id);

public sealed partial class Request538TraditionalHandler
	: Mediator.IRequestHandler<Request538, Response538>,
	MediatR.IRequestHandler<Request538, Response538>
{
	ValueTask<Response538> Mediator.IRequestHandler<Request538, Response538>.Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response538> MediatR.IRequestHandler<Request538, Response538>.Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request538StaticHandler
{
	private static ValueTask<Response538> Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request538SealedHandler
{
	private ValueTask<Response538> Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request539(long Id) : Mediator.IRequest<Response539>, MediatR.IRequest<Response539>;

public sealed record Response539(long Id);

public sealed partial class Request539TraditionalHandler
	: Mediator.IRequestHandler<Request539, Response539>,
	MediatR.IRequestHandler<Request539, Response539>
{
	ValueTask<Response539> Mediator.IRequestHandler<Request539, Response539>.Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response539> MediatR.IRequestHandler<Request539, Response539>.Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request539StaticHandler
{
	private static ValueTask<Response539> Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request539SealedHandler
{
	private ValueTask<Response539> Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request540(long Id) : Mediator.IRequest<Response540>, MediatR.IRequest<Response540>;

public sealed record Response540(long Id);

public sealed partial class Request540TraditionalHandler
	: Mediator.IRequestHandler<Request540, Response540>,
	MediatR.IRequestHandler<Request540, Response540>
{
	ValueTask<Response540> Mediator.IRequestHandler<Request540, Response540>.Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response540> MediatR.IRequestHandler<Request540, Response540>.Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request540StaticHandler
{
	private static ValueTask<Response540> Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request540SealedHandler
{
	private ValueTask<Response540> Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request541(long Id) : Mediator.IRequest<Response541>, MediatR.IRequest<Response541>;

public sealed record Response541(long Id);

public sealed partial class Request541TraditionalHandler
	: Mediator.IRequestHandler<Request541, Response541>,
	MediatR.IRequestHandler<Request541, Response541>
{
	ValueTask<Response541> Mediator.IRequestHandler<Request541, Response541>.Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response541> MediatR.IRequestHandler<Request541, Response541>.Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request541StaticHandler
{
	private static ValueTask<Response541> Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request541SealedHandler
{
	private ValueTask<Response541> Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request542(long Id) : Mediator.IRequest<Response542>, MediatR.IRequest<Response542>;

public sealed record Response542(long Id);

public sealed partial class Request542TraditionalHandler
	: Mediator.IRequestHandler<Request542, Response542>,
	MediatR.IRequestHandler<Request542, Response542>
{
	ValueTask<Response542> Mediator.IRequestHandler<Request542, Response542>.Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response542> MediatR.IRequestHandler<Request542, Response542>.Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request542StaticHandler
{
	private static ValueTask<Response542> Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request542SealedHandler
{
	private ValueTask<Response542> Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request543(long Id) : Mediator.IRequest<Response543>, MediatR.IRequest<Response543>;

public sealed record Response543(long Id);

public sealed partial class Request543TraditionalHandler
	: Mediator.IRequestHandler<Request543, Response543>,
	MediatR.IRequestHandler<Request543, Response543>
{
	ValueTask<Response543> Mediator.IRequestHandler<Request543, Response543>.Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response543> MediatR.IRequestHandler<Request543, Response543>.Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request543StaticHandler
{
	private static ValueTask<Response543> Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request543SealedHandler
{
	private ValueTask<Response543> Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request544(long Id) : Mediator.IRequest<Response544>, MediatR.IRequest<Response544>;

public sealed record Response544(long Id);

public sealed partial class Request544TraditionalHandler
	: Mediator.IRequestHandler<Request544, Response544>,
	MediatR.IRequestHandler<Request544, Response544>
{
	ValueTask<Response544> Mediator.IRequestHandler<Request544, Response544>.Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response544> MediatR.IRequestHandler<Request544, Response544>.Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request544StaticHandler
{
	private static ValueTask<Response544> Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request544SealedHandler
{
	private ValueTask<Response544> Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request545(long Id) : Mediator.IRequest<Response545>, MediatR.IRequest<Response545>;

public sealed record Response545(long Id);

public sealed partial class Request545TraditionalHandler
	: Mediator.IRequestHandler<Request545, Response545>,
	MediatR.IRequestHandler<Request545, Response545>
{
	ValueTask<Response545> Mediator.IRequestHandler<Request545, Response545>.Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response545> MediatR.IRequestHandler<Request545, Response545>.Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request545StaticHandler
{
	private static ValueTask<Response545> Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request545SealedHandler
{
	private ValueTask<Response545> Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request546(long Id) : Mediator.IRequest<Response546>, MediatR.IRequest<Response546>;

public sealed record Response546(long Id);

public sealed partial class Request546TraditionalHandler
	: Mediator.IRequestHandler<Request546, Response546>,
	MediatR.IRequestHandler<Request546, Response546>
{
	ValueTask<Response546> Mediator.IRequestHandler<Request546, Response546>.Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response546> MediatR.IRequestHandler<Request546, Response546>.Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request546StaticHandler
{
	private static ValueTask<Response546> Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request546SealedHandler
{
	private ValueTask<Response546> Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request547(long Id) : Mediator.IRequest<Response547>, MediatR.IRequest<Response547>;

public sealed record Response547(long Id);

public sealed partial class Request547TraditionalHandler
	: Mediator.IRequestHandler<Request547, Response547>,
	MediatR.IRequestHandler<Request547, Response547>
{
	ValueTask<Response547> Mediator.IRequestHandler<Request547, Response547>.Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response547> MediatR.IRequestHandler<Request547, Response547>.Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request547StaticHandler
{
	private static ValueTask<Response547> Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request547SealedHandler
{
	private ValueTask<Response547> Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request548(long Id) : Mediator.IRequest<Response548>, MediatR.IRequest<Response548>;

public sealed record Response548(long Id);

public sealed partial class Request548TraditionalHandler
	: Mediator.IRequestHandler<Request548, Response548>,
	MediatR.IRequestHandler<Request548, Response548>
{
	ValueTask<Response548> Mediator.IRequestHandler<Request548, Response548>.Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response548> MediatR.IRequestHandler<Request548, Response548>.Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request548StaticHandler
{
	private static ValueTask<Response548> Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request548SealedHandler
{
	private ValueTask<Response548> Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request549(long Id) : Mediator.IRequest<Response549>, MediatR.IRequest<Response549>;

public sealed record Response549(long Id);

public sealed partial class Request549TraditionalHandler
	: Mediator.IRequestHandler<Request549, Response549>,
	MediatR.IRequestHandler<Request549, Response549>
{
	ValueTask<Response549> Mediator.IRequestHandler<Request549, Response549>.Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response549> MediatR.IRequestHandler<Request549, Response549>.Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request549StaticHandler
{
	private static ValueTask<Response549> Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request549SealedHandler
{
	private ValueTask<Response549> Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request550(long Id) : Mediator.IRequest<Response550>, MediatR.IRequest<Response550>;

public sealed record Response550(long Id);

public sealed partial class Request550TraditionalHandler
	: Mediator.IRequestHandler<Request550, Response550>,
	MediatR.IRequestHandler<Request550, Response550>
{
	ValueTask<Response550> Mediator.IRequestHandler<Request550, Response550>.Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response550> MediatR.IRequestHandler<Request550, Response550>.Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request550StaticHandler
{
	private static ValueTask<Response550> Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request550SealedHandler
{
	private ValueTask<Response550> Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request551(long Id) : Mediator.IRequest<Response551>, MediatR.IRequest<Response551>;

public sealed record Response551(long Id);

public sealed partial class Request551TraditionalHandler
	: Mediator.IRequestHandler<Request551, Response551>,
	MediatR.IRequestHandler<Request551, Response551>
{
	ValueTask<Response551> Mediator.IRequestHandler<Request551, Response551>.Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response551> MediatR.IRequestHandler<Request551, Response551>.Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request551StaticHandler
{
	private static ValueTask<Response551> Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request551SealedHandler
{
	private ValueTask<Response551> Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request552(long Id) : Mediator.IRequest<Response552>, MediatR.IRequest<Response552>;

public sealed record Response552(long Id);

public sealed partial class Request552TraditionalHandler
	: Mediator.IRequestHandler<Request552, Response552>,
	MediatR.IRequestHandler<Request552, Response552>
{
	ValueTask<Response552> Mediator.IRequestHandler<Request552, Response552>.Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response552> MediatR.IRequestHandler<Request552, Response552>.Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request552StaticHandler
{
	private static ValueTask<Response552> Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request552SealedHandler
{
	private ValueTask<Response552> Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request553(long Id) : Mediator.IRequest<Response553>, MediatR.IRequest<Response553>;

public sealed record Response553(long Id);

public sealed partial class Request553TraditionalHandler
	: Mediator.IRequestHandler<Request553, Response553>,
	MediatR.IRequestHandler<Request553, Response553>
{
	ValueTask<Response553> Mediator.IRequestHandler<Request553, Response553>.Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response553> MediatR.IRequestHandler<Request553, Response553>.Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request553StaticHandler
{
	private static ValueTask<Response553> Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request553SealedHandler
{
	private ValueTask<Response553> Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request554(long Id) : Mediator.IRequest<Response554>, MediatR.IRequest<Response554>;

public sealed record Response554(long Id);

public sealed partial class Request554TraditionalHandler
	: Mediator.IRequestHandler<Request554, Response554>,
	MediatR.IRequestHandler<Request554, Response554>
{
	ValueTask<Response554> Mediator.IRequestHandler<Request554, Response554>.Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response554> MediatR.IRequestHandler<Request554, Response554>.Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request554StaticHandler
{
	private static ValueTask<Response554> Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request554SealedHandler
{
	private ValueTask<Response554> Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request555(long Id) : Mediator.IRequest<Response555>, MediatR.IRequest<Response555>;

public sealed record Response555(long Id);

public sealed partial class Request555TraditionalHandler
	: Mediator.IRequestHandler<Request555, Response555>,
	MediatR.IRequestHandler<Request555, Response555>
{
	ValueTask<Response555> Mediator.IRequestHandler<Request555, Response555>.Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response555> MediatR.IRequestHandler<Request555, Response555>.Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request555StaticHandler
{
	private static ValueTask<Response555> Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request555SealedHandler
{
	private ValueTask<Response555> Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request556(long Id) : Mediator.IRequest<Response556>, MediatR.IRequest<Response556>;

public sealed record Response556(long Id);

public sealed partial class Request556TraditionalHandler
	: Mediator.IRequestHandler<Request556, Response556>,
	MediatR.IRequestHandler<Request556, Response556>
{
	ValueTask<Response556> Mediator.IRequestHandler<Request556, Response556>.Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response556> MediatR.IRequestHandler<Request556, Response556>.Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request556StaticHandler
{
	private static ValueTask<Response556> Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request556SealedHandler
{
	private ValueTask<Response556> Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request557(long Id) : Mediator.IRequest<Response557>, MediatR.IRequest<Response557>;

public sealed record Response557(long Id);

public sealed partial class Request557TraditionalHandler
	: Mediator.IRequestHandler<Request557, Response557>,
	MediatR.IRequestHandler<Request557, Response557>
{
	ValueTask<Response557> Mediator.IRequestHandler<Request557, Response557>.Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response557> MediatR.IRequestHandler<Request557, Response557>.Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request557StaticHandler
{
	private static ValueTask<Response557> Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request557SealedHandler
{
	private ValueTask<Response557> Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request558(long Id) : Mediator.IRequest<Response558>, MediatR.IRequest<Response558>;

public sealed record Response558(long Id);

public sealed partial class Request558TraditionalHandler
	: Mediator.IRequestHandler<Request558, Response558>,
	MediatR.IRequestHandler<Request558, Response558>
{
	ValueTask<Response558> Mediator.IRequestHandler<Request558, Response558>.Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response558> MediatR.IRequestHandler<Request558, Response558>.Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request558StaticHandler
{
	private static ValueTask<Response558> Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request558SealedHandler
{
	private ValueTask<Response558> Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request559(long Id) : Mediator.IRequest<Response559>, MediatR.IRequest<Response559>;

public sealed record Response559(long Id);

public sealed partial class Request559TraditionalHandler
	: Mediator.IRequestHandler<Request559, Response559>,
	MediatR.IRequestHandler<Request559, Response559>
{
	ValueTask<Response559> Mediator.IRequestHandler<Request559, Response559>.Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response559> MediatR.IRequestHandler<Request559, Response559>.Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request559StaticHandler
{
	private static ValueTask<Response559> Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request559SealedHandler
{
	private ValueTask<Response559> Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request560(long Id) : Mediator.IRequest<Response560>, MediatR.IRequest<Response560>;

public sealed record Response560(long Id);

public sealed partial class Request560TraditionalHandler
	: Mediator.IRequestHandler<Request560, Response560>,
	MediatR.IRequestHandler<Request560, Response560>
{
	ValueTask<Response560> Mediator.IRequestHandler<Request560, Response560>.Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response560> MediatR.IRequestHandler<Request560, Response560>.Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request560StaticHandler
{
	private static ValueTask<Response560> Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request560SealedHandler
{
	private ValueTask<Response560> Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request561(long Id) : Mediator.IRequest<Response561>, MediatR.IRequest<Response561>;

public sealed record Response561(long Id);

public sealed partial class Request561TraditionalHandler
	: Mediator.IRequestHandler<Request561, Response561>,
	MediatR.IRequestHandler<Request561, Response561>
{
	ValueTask<Response561> Mediator.IRequestHandler<Request561, Response561>.Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response561> MediatR.IRequestHandler<Request561, Response561>.Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request561StaticHandler
{
	private static ValueTask<Response561> Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request561SealedHandler
{
	private ValueTask<Response561> Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request562(long Id) : Mediator.IRequest<Response562>, MediatR.IRequest<Response562>;

public sealed record Response562(long Id);

public sealed partial class Request562TraditionalHandler
	: Mediator.IRequestHandler<Request562, Response562>,
	MediatR.IRequestHandler<Request562, Response562>
{
	ValueTask<Response562> Mediator.IRequestHandler<Request562, Response562>.Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response562> MediatR.IRequestHandler<Request562, Response562>.Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request562StaticHandler
{
	private static ValueTask<Response562> Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request562SealedHandler
{
	private ValueTask<Response562> Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request563(long Id) : Mediator.IRequest<Response563>, MediatR.IRequest<Response563>;

public sealed record Response563(long Id);

public sealed partial class Request563TraditionalHandler
	: Mediator.IRequestHandler<Request563, Response563>,
	MediatR.IRequestHandler<Request563, Response563>
{
	ValueTask<Response563> Mediator.IRequestHandler<Request563, Response563>.Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response563> MediatR.IRequestHandler<Request563, Response563>.Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request563StaticHandler
{
	private static ValueTask<Response563> Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request563SealedHandler
{
	private ValueTask<Response563> Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request564(long Id) : Mediator.IRequest<Response564>, MediatR.IRequest<Response564>;

public sealed record Response564(long Id);

public sealed partial class Request564TraditionalHandler
	: Mediator.IRequestHandler<Request564, Response564>,
	MediatR.IRequestHandler<Request564, Response564>
{
	ValueTask<Response564> Mediator.IRequestHandler<Request564, Response564>.Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response564> MediatR.IRequestHandler<Request564, Response564>.Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request564StaticHandler
{
	private static ValueTask<Response564> Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request564SealedHandler
{
	private ValueTask<Response564> Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request565(long Id) : Mediator.IRequest<Response565>, MediatR.IRequest<Response565>;

public sealed record Response565(long Id);

public sealed partial class Request565TraditionalHandler
	: Mediator.IRequestHandler<Request565, Response565>,
	MediatR.IRequestHandler<Request565, Response565>
{
	ValueTask<Response565> Mediator.IRequestHandler<Request565, Response565>.Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response565> MediatR.IRequestHandler<Request565, Response565>.Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request565StaticHandler
{
	private static ValueTask<Response565> Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request565SealedHandler
{
	private ValueTask<Response565> Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request566(long Id) : Mediator.IRequest<Response566>, MediatR.IRequest<Response566>;

public sealed record Response566(long Id);

public sealed partial class Request566TraditionalHandler
	: Mediator.IRequestHandler<Request566, Response566>,
	MediatR.IRequestHandler<Request566, Response566>
{
	ValueTask<Response566> Mediator.IRequestHandler<Request566, Response566>.Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response566> MediatR.IRequestHandler<Request566, Response566>.Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request566StaticHandler
{
	private static ValueTask<Response566> Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request566SealedHandler
{
	private ValueTask<Response566> Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request567(long Id) : Mediator.IRequest<Response567>, MediatR.IRequest<Response567>;

public sealed record Response567(long Id);

public sealed partial class Request567TraditionalHandler
	: Mediator.IRequestHandler<Request567, Response567>,
	MediatR.IRequestHandler<Request567, Response567>
{
	ValueTask<Response567> Mediator.IRequestHandler<Request567, Response567>.Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response567> MediatR.IRequestHandler<Request567, Response567>.Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request567StaticHandler
{
	private static ValueTask<Response567> Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request567SealedHandler
{
	private ValueTask<Response567> Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request568(long Id) : Mediator.IRequest<Response568>, MediatR.IRequest<Response568>;

public sealed record Response568(long Id);

public sealed partial class Request568TraditionalHandler
	: Mediator.IRequestHandler<Request568, Response568>,
	MediatR.IRequestHandler<Request568, Response568>
{
	ValueTask<Response568> Mediator.IRequestHandler<Request568, Response568>.Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response568> MediatR.IRequestHandler<Request568, Response568>.Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request568StaticHandler
{
	private static ValueTask<Response568> Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request568SealedHandler
{
	private ValueTask<Response568> Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request569(long Id) : Mediator.IRequest<Response569>, MediatR.IRequest<Response569>;

public sealed record Response569(long Id);

public sealed partial class Request569TraditionalHandler
	: Mediator.IRequestHandler<Request569, Response569>,
	MediatR.IRequestHandler<Request569, Response569>
{
	ValueTask<Response569> Mediator.IRequestHandler<Request569, Response569>.Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response569> MediatR.IRequestHandler<Request569, Response569>.Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request569StaticHandler
{
	private static ValueTask<Response569> Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request569SealedHandler
{
	private ValueTask<Response569> Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request570(long Id) : Mediator.IRequest<Response570>, MediatR.IRequest<Response570>;

public sealed record Response570(long Id);

public sealed partial class Request570TraditionalHandler
	: Mediator.IRequestHandler<Request570, Response570>,
	MediatR.IRequestHandler<Request570, Response570>
{
	ValueTask<Response570> Mediator.IRequestHandler<Request570, Response570>.Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response570> MediatR.IRequestHandler<Request570, Response570>.Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request570StaticHandler
{
	private static ValueTask<Response570> Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request570SealedHandler
{
	private ValueTask<Response570> Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request571(long Id) : Mediator.IRequest<Response571>, MediatR.IRequest<Response571>;

public sealed record Response571(long Id);

public sealed partial class Request571TraditionalHandler
	: Mediator.IRequestHandler<Request571, Response571>,
	MediatR.IRequestHandler<Request571, Response571>
{
	ValueTask<Response571> Mediator.IRequestHandler<Request571, Response571>.Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response571> MediatR.IRequestHandler<Request571, Response571>.Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request571StaticHandler
{
	private static ValueTask<Response571> Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request571SealedHandler
{
	private ValueTask<Response571> Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request572(long Id) : Mediator.IRequest<Response572>, MediatR.IRequest<Response572>;

public sealed record Response572(long Id);

public sealed partial class Request572TraditionalHandler
	: Mediator.IRequestHandler<Request572, Response572>,
	MediatR.IRequestHandler<Request572, Response572>
{
	ValueTask<Response572> Mediator.IRequestHandler<Request572, Response572>.Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response572> MediatR.IRequestHandler<Request572, Response572>.Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request572StaticHandler
{
	private static ValueTask<Response572> Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request572SealedHandler
{
	private ValueTask<Response572> Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request573(long Id) : Mediator.IRequest<Response573>, MediatR.IRequest<Response573>;

public sealed record Response573(long Id);

public sealed partial class Request573TraditionalHandler
	: Mediator.IRequestHandler<Request573, Response573>,
	MediatR.IRequestHandler<Request573, Response573>
{
	ValueTask<Response573> Mediator.IRequestHandler<Request573, Response573>.Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response573> MediatR.IRequestHandler<Request573, Response573>.Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request573StaticHandler
{
	private static ValueTask<Response573> Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request573SealedHandler
{
	private ValueTask<Response573> Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request574(long Id) : Mediator.IRequest<Response574>, MediatR.IRequest<Response574>;

public sealed record Response574(long Id);

public sealed partial class Request574TraditionalHandler
	: Mediator.IRequestHandler<Request574, Response574>,
	MediatR.IRequestHandler<Request574, Response574>
{
	ValueTask<Response574> Mediator.IRequestHandler<Request574, Response574>.Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response574> MediatR.IRequestHandler<Request574, Response574>.Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request574StaticHandler
{
	private static ValueTask<Response574> Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request574SealedHandler
{
	private ValueTask<Response574> Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request575(long Id) : Mediator.IRequest<Response575>, MediatR.IRequest<Response575>;

public sealed record Response575(long Id);

public sealed partial class Request575TraditionalHandler
	: Mediator.IRequestHandler<Request575, Response575>,
	MediatR.IRequestHandler<Request575, Response575>
{
	ValueTask<Response575> Mediator.IRequestHandler<Request575, Response575>.Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response575> MediatR.IRequestHandler<Request575, Response575>.Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request575StaticHandler
{
	private static ValueTask<Response575> Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request575SealedHandler
{
	private ValueTask<Response575> Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request576(long Id) : Mediator.IRequest<Response576>, MediatR.IRequest<Response576>;

public sealed record Response576(long Id);

public sealed partial class Request576TraditionalHandler
	: Mediator.IRequestHandler<Request576, Response576>,
	MediatR.IRequestHandler<Request576, Response576>
{
	ValueTask<Response576> Mediator.IRequestHandler<Request576, Response576>.Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response576> MediatR.IRequestHandler<Request576, Response576>.Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request576StaticHandler
{
	private static ValueTask<Response576> Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request576SealedHandler
{
	private ValueTask<Response576> Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request577(long Id) : Mediator.IRequest<Response577>, MediatR.IRequest<Response577>;

public sealed record Response577(long Id);

public sealed partial class Request577TraditionalHandler
	: Mediator.IRequestHandler<Request577, Response577>,
	MediatR.IRequestHandler<Request577, Response577>
{
	ValueTask<Response577> Mediator.IRequestHandler<Request577, Response577>.Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response577> MediatR.IRequestHandler<Request577, Response577>.Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request577StaticHandler
{
	private static ValueTask<Response577> Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request577SealedHandler
{
	private ValueTask<Response577> Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request578(long Id) : Mediator.IRequest<Response578>, MediatR.IRequest<Response578>;

public sealed record Response578(long Id);

public sealed partial class Request578TraditionalHandler
	: Mediator.IRequestHandler<Request578, Response578>,
	MediatR.IRequestHandler<Request578, Response578>
{
	ValueTask<Response578> Mediator.IRequestHandler<Request578, Response578>.Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response578> MediatR.IRequestHandler<Request578, Response578>.Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request578StaticHandler
{
	private static ValueTask<Response578> Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request578SealedHandler
{
	private ValueTask<Response578> Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request579(long Id) : Mediator.IRequest<Response579>, MediatR.IRequest<Response579>;

public sealed record Response579(long Id);

public sealed partial class Request579TraditionalHandler
	: Mediator.IRequestHandler<Request579, Response579>,
	MediatR.IRequestHandler<Request579, Response579>
{
	ValueTask<Response579> Mediator.IRequestHandler<Request579, Response579>.Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response579> MediatR.IRequestHandler<Request579, Response579>.Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request579StaticHandler
{
	private static ValueTask<Response579> Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request579SealedHandler
{
	private ValueTask<Response579> Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request580(long Id) : Mediator.IRequest<Response580>, MediatR.IRequest<Response580>;

public sealed record Response580(long Id);

public sealed partial class Request580TraditionalHandler
	: Mediator.IRequestHandler<Request580, Response580>,
	MediatR.IRequestHandler<Request580, Response580>
{
	ValueTask<Response580> Mediator.IRequestHandler<Request580, Response580>.Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response580> MediatR.IRequestHandler<Request580, Response580>.Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request580StaticHandler
{
	private static ValueTask<Response580> Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request580SealedHandler
{
	private ValueTask<Response580> Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request581(long Id) : Mediator.IRequest<Response581>, MediatR.IRequest<Response581>;

public sealed record Response581(long Id);

public sealed partial class Request581TraditionalHandler
	: Mediator.IRequestHandler<Request581, Response581>,
	MediatR.IRequestHandler<Request581, Response581>
{
	ValueTask<Response581> Mediator.IRequestHandler<Request581, Response581>.Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response581> MediatR.IRequestHandler<Request581, Response581>.Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request581StaticHandler
{
	private static ValueTask<Response581> Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request581SealedHandler
{
	private ValueTask<Response581> Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request582(long Id) : Mediator.IRequest<Response582>, MediatR.IRequest<Response582>;

public sealed record Response582(long Id);

public sealed partial class Request582TraditionalHandler
	: Mediator.IRequestHandler<Request582, Response582>,
	MediatR.IRequestHandler<Request582, Response582>
{
	ValueTask<Response582> Mediator.IRequestHandler<Request582, Response582>.Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response582> MediatR.IRequestHandler<Request582, Response582>.Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request582StaticHandler
{
	private static ValueTask<Response582> Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request582SealedHandler
{
	private ValueTask<Response582> Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request583(long Id) : Mediator.IRequest<Response583>, MediatR.IRequest<Response583>;

public sealed record Response583(long Id);

public sealed partial class Request583TraditionalHandler
	: Mediator.IRequestHandler<Request583, Response583>,
	MediatR.IRequestHandler<Request583, Response583>
{
	ValueTask<Response583> Mediator.IRequestHandler<Request583, Response583>.Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response583> MediatR.IRequestHandler<Request583, Response583>.Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request583StaticHandler
{
	private static ValueTask<Response583> Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request583SealedHandler
{
	private ValueTask<Response583> Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request584(long Id) : Mediator.IRequest<Response584>, MediatR.IRequest<Response584>;

public sealed record Response584(long Id);

public sealed partial class Request584TraditionalHandler
	: Mediator.IRequestHandler<Request584, Response584>,
	MediatR.IRequestHandler<Request584, Response584>
{
	ValueTask<Response584> Mediator.IRequestHandler<Request584, Response584>.Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response584> MediatR.IRequestHandler<Request584, Response584>.Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request584StaticHandler
{
	private static ValueTask<Response584> Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request584SealedHandler
{
	private ValueTask<Response584> Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request585(long Id) : Mediator.IRequest<Response585>, MediatR.IRequest<Response585>;

public sealed record Response585(long Id);

public sealed partial class Request585TraditionalHandler
	: Mediator.IRequestHandler<Request585, Response585>,
	MediatR.IRequestHandler<Request585, Response585>
{
	ValueTask<Response585> Mediator.IRequestHandler<Request585, Response585>.Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response585> MediatR.IRequestHandler<Request585, Response585>.Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request585StaticHandler
{
	private static ValueTask<Response585> Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request585SealedHandler
{
	private ValueTask<Response585> Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request586(long Id) : Mediator.IRequest<Response586>, MediatR.IRequest<Response586>;

public sealed record Response586(long Id);

public sealed partial class Request586TraditionalHandler
	: Mediator.IRequestHandler<Request586, Response586>,
	MediatR.IRequestHandler<Request586, Response586>
{
	ValueTask<Response586> Mediator.IRequestHandler<Request586, Response586>.Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response586> MediatR.IRequestHandler<Request586, Response586>.Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request586StaticHandler
{
	private static ValueTask<Response586> Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request586SealedHandler
{
	private ValueTask<Response586> Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request587(long Id) : Mediator.IRequest<Response587>, MediatR.IRequest<Response587>;

public sealed record Response587(long Id);

public sealed partial class Request587TraditionalHandler
	: Mediator.IRequestHandler<Request587, Response587>,
	MediatR.IRequestHandler<Request587, Response587>
{
	ValueTask<Response587> Mediator.IRequestHandler<Request587, Response587>.Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response587> MediatR.IRequestHandler<Request587, Response587>.Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request587StaticHandler
{
	private static ValueTask<Response587> Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request587SealedHandler
{
	private ValueTask<Response587> Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request588(long Id) : Mediator.IRequest<Response588>, MediatR.IRequest<Response588>;

public sealed record Response588(long Id);

public sealed partial class Request588TraditionalHandler
	: Mediator.IRequestHandler<Request588, Response588>,
	MediatR.IRequestHandler<Request588, Response588>
{
	ValueTask<Response588> Mediator.IRequestHandler<Request588, Response588>.Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response588> MediatR.IRequestHandler<Request588, Response588>.Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request588StaticHandler
{
	private static ValueTask<Response588> Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request588SealedHandler
{
	private ValueTask<Response588> Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request589(long Id) : Mediator.IRequest<Response589>, MediatR.IRequest<Response589>;

public sealed record Response589(long Id);

public sealed partial class Request589TraditionalHandler
	: Mediator.IRequestHandler<Request589, Response589>,
	MediatR.IRequestHandler<Request589, Response589>
{
	ValueTask<Response589> Mediator.IRequestHandler<Request589, Response589>.Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response589> MediatR.IRequestHandler<Request589, Response589>.Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request589StaticHandler
{
	private static ValueTask<Response589> Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request589SealedHandler
{
	private ValueTask<Response589> Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request590(long Id) : Mediator.IRequest<Response590>, MediatR.IRequest<Response590>;

public sealed record Response590(long Id);

public sealed partial class Request590TraditionalHandler
	: Mediator.IRequestHandler<Request590, Response590>,
	MediatR.IRequestHandler<Request590, Response590>
{
	ValueTask<Response590> Mediator.IRequestHandler<Request590, Response590>.Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response590> MediatR.IRequestHandler<Request590, Response590>.Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request590StaticHandler
{
	private static ValueTask<Response590> Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request590SealedHandler
{
	private ValueTask<Response590> Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request591(long Id) : Mediator.IRequest<Response591>, MediatR.IRequest<Response591>;

public sealed record Response591(long Id);

public sealed partial class Request591TraditionalHandler
	: Mediator.IRequestHandler<Request591, Response591>,
	MediatR.IRequestHandler<Request591, Response591>
{
	ValueTask<Response591> Mediator.IRequestHandler<Request591, Response591>.Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response591> MediatR.IRequestHandler<Request591, Response591>.Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request591StaticHandler
{
	private static ValueTask<Response591> Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request591SealedHandler
{
	private ValueTask<Response591> Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request592(long Id) : Mediator.IRequest<Response592>, MediatR.IRequest<Response592>;

public sealed record Response592(long Id);

public sealed partial class Request592TraditionalHandler
	: Mediator.IRequestHandler<Request592, Response592>,
	MediatR.IRequestHandler<Request592, Response592>
{
	ValueTask<Response592> Mediator.IRequestHandler<Request592, Response592>.Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response592> MediatR.IRequestHandler<Request592, Response592>.Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request592StaticHandler
{
	private static ValueTask<Response592> Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request592SealedHandler
{
	private ValueTask<Response592> Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request593(long Id) : Mediator.IRequest<Response593>, MediatR.IRequest<Response593>;

public sealed record Response593(long Id);

public sealed partial class Request593TraditionalHandler
	: Mediator.IRequestHandler<Request593, Response593>,
	MediatR.IRequestHandler<Request593, Response593>
{
	ValueTask<Response593> Mediator.IRequestHandler<Request593, Response593>.Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response593> MediatR.IRequestHandler<Request593, Response593>.Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request593StaticHandler
{
	private static ValueTask<Response593> Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request593SealedHandler
{
	private ValueTask<Response593> Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request594(long Id) : Mediator.IRequest<Response594>, MediatR.IRequest<Response594>;

public sealed record Response594(long Id);

public sealed partial class Request594TraditionalHandler
	: Mediator.IRequestHandler<Request594, Response594>,
	MediatR.IRequestHandler<Request594, Response594>
{
	ValueTask<Response594> Mediator.IRequestHandler<Request594, Response594>.Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response594> MediatR.IRequestHandler<Request594, Response594>.Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request594StaticHandler
{
	private static ValueTask<Response594> Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request594SealedHandler
{
	private ValueTask<Response594> Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request595(long Id) : Mediator.IRequest<Response595>, MediatR.IRequest<Response595>;

public sealed record Response595(long Id);

public sealed partial class Request595TraditionalHandler
	: Mediator.IRequestHandler<Request595, Response595>,
	MediatR.IRequestHandler<Request595, Response595>
{
	ValueTask<Response595> Mediator.IRequestHandler<Request595, Response595>.Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response595> MediatR.IRequestHandler<Request595, Response595>.Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request595StaticHandler
{
	private static ValueTask<Response595> Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request595SealedHandler
{
	private ValueTask<Response595> Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request596(long Id) : Mediator.IRequest<Response596>, MediatR.IRequest<Response596>;

public sealed record Response596(long Id);

public sealed partial class Request596TraditionalHandler
	: Mediator.IRequestHandler<Request596, Response596>,
	MediatR.IRequestHandler<Request596, Response596>
{
	ValueTask<Response596> Mediator.IRequestHandler<Request596, Response596>.Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response596> MediatR.IRequestHandler<Request596, Response596>.Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request596StaticHandler
{
	private static ValueTask<Response596> Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request596SealedHandler
{
	private ValueTask<Response596> Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request597(long Id) : Mediator.IRequest<Response597>, MediatR.IRequest<Response597>;

public sealed record Response597(long Id);

public sealed partial class Request597TraditionalHandler
	: Mediator.IRequestHandler<Request597, Response597>,
	MediatR.IRequestHandler<Request597, Response597>
{
	ValueTask<Response597> Mediator.IRequestHandler<Request597, Response597>.Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response597> MediatR.IRequestHandler<Request597, Response597>.Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request597StaticHandler
{
	private static ValueTask<Response597> Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request597SealedHandler
{
	private ValueTask<Response597> Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request598(long Id) : Mediator.IRequest<Response598>, MediatR.IRequest<Response598>;

public sealed record Response598(long Id);

public sealed partial class Request598TraditionalHandler
	: Mediator.IRequestHandler<Request598, Response598>,
	MediatR.IRequestHandler<Request598, Response598>
{
	ValueTask<Response598> Mediator.IRequestHandler<Request598, Response598>.Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response598> MediatR.IRequestHandler<Request598, Response598>.Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request598StaticHandler
{
	private static ValueTask<Response598> Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request598SealedHandler
{
	private ValueTask<Response598> Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request599(long Id) : Mediator.IRequest<Response599>, MediatR.IRequest<Response599>;

public sealed record Response599(long Id);

public sealed partial class Request599TraditionalHandler
	: Mediator.IRequestHandler<Request599, Response599>,
	MediatR.IRequestHandler<Request599, Response599>
{
	ValueTask<Response599> Mediator.IRequestHandler<Request599, Response599>.Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response599> MediatR.IRequestHandler<Request599, Response599>.Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request599StaticHandler
{
	private static ValueTask<Response599> Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request599SealedHandler
{
	private ValueTask<Response599> Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request600(long Id) : Mediator.IRequest<Response600>, MediatR.IRequest<Response600>;

public sealed record Response600(long Id);

public sealed partial class Request600TraditionalHandler
	: Mediator.IRequestHandler<Request600, Response600>,
	MediatR.IRequestHandler<Request600, Response600>
{
	ValueTask<Response600> Mediator.IRequestHandler<Request600, Response600>.Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response600> MediatR.IRequestHandler<Request600, Response600>.Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request600StaticHandler
{
	private static ValueTask<Response600> Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request600SealedHandler
{
	private ValueTask<Response600> Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request601(long Id) : Mediator.IRequest<Response601>, MediatR.IRequest<Response601>;

public sealed record Response601(long Id);

public sealed partial class Request601TraditionalHandler
	: Mediator.IRequestHandler<Request601, Response601>,
	MediatR.IRequestHandler<Request601, Response601>
{
	ValueTask<Response601> Mediator.IRequestHandler<Request601, Response601>.Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response601> MediatR.IRequestHandler<Request601, Response601>.Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request601StaticHandler
{
	private static ValueTask<Response601> Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request601SealedHandler
{
	private ValueTask<Response601> Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request602(long Id) : Mediator.IRequest<Response602>, MediatR.IRequest<Response602>;

public sealed record Response602(long Id);

public sealed partial class Request602TraditionalHandler
	: Mediator.IRequestHandler<Request602, Response602>,
	MediatR.IRequestHandler<Request602, Response602>
{
	ValueTask<Response602> Mediator.IRequestHandler<Request602, Response602>.Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response602> MediatR.IRequestHandler<Request602, Response602>.Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request602StaticHandler
{
	private static ValueTask<Response602> Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request602SealedHandler
{
	private ValueTask<Response602> Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request603(long Id) : Mediator.IRequest<Response603>, MediatR.IRequest<Response603>;

public sealed record Response603(long Id);

public sealed partial class Request603TraditionalHandler
	: Mediator.IRequestHandler<Request603, Response603>,
	MediatR.IRequestHandler<Request603, Response603>
{
	ValueTask<Response603> Mediator.IRequestHandler<Request603, Response603>.Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response603> MediatR.IRequestHandler<Request603, Response603>.Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request603StaticHandler
{
	private static ValueTask<Response603> Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request603SealedHandler
{
	private ValueTask<Response603> Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request604(long Id) : Mediator.IRequest<Response604>, MediatR.IRequest<Response604>;

public sealed record Response604(long Id);

public sealed partial class Request604TraditionalHandler
	: Mediator.IRequestHandler<Request604, Response604>,
	MediatR.IRequestHandler<Request604, Response604>
{
	ValueTask<Response604> Mediator.IRequestHandler<Request604, Response604>.Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response604> MediatR.IRequestHandler<Request604, Response604>.Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request604StaticHandler
{
	private static ValueTask<Response604> Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request604SealedHandler
{
	private ValueTask<Response604> Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request605(long Id) : Mediator.IRequest<Response605>, MediatR.IRequest<Response605>;

public sealed record Response605(long Id);

public sealed partial class Request605TraditionalHandler
	: Mediator.IRequestHandler<Request605, Response605>,
	MediatR.IRequestHandler<Request605, Response605>
{
	ValueTask<Response605> Mediator.IRequestHandler<Request605, Response605>.Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response605> MediatR.IRequestHandler<Request605, Response605>.Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request605StaticHandler
{
	private static ValueTask<Response605> Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request605SealedHandler
{
	private ValueTask<Response605> Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request606(long Id) : Mediator.IRequest<Response606>, MediatR.IRequest<Response606>;

public sealed record Response606(long Id);

public sealed partial class Request606TraditionalHandler
	: Mediator.IRequestHandler<Request606, Response606>,
	MediatR.IRequestHandler<Request606, Response606>
{
	ValueTask<Response606> Mediator.IRequestHandler<Request606, Response606>.Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response606> MediatR.IRequestHandler<Request606, Response606>.Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request606StaticHandler
{
	private static ValueTask<Response606> Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request606SealedHandler
{
	private ValueTask<Response606> Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request607(long Id) : Mediator.IRequest<Response607>, MediatR.IRequest<Response607>;

public sealed record Response607(long Id);

public sealed partial class Request607TraditionalHandler
	: Mediator.IRequestHandler<Request607, Response607>,
	MediatR.IRequestHandler<Request607, Response607>
{
	ValueTask<Response607> Mediator.IRequestHandler<Request607, Response607>.Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response607> MediatR.IRequestHandler<Request607, Response607>.Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request607StaticHandler
{
	private static ValueTask<Response607> Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request607SealedHandler
{
	private ValueTask<Response607> Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request608(long Id) : Mediator.IRequest<Response608>, MediatR.IRequest<Response608>;

public sealed record Response608(long Id);

public sealed partial class Request608TraditionalHandler
	: Mediator.IRequestHandler<Request608, Response608>,
	MediatR.IRequestHandler<Request608, Response608>
{
	ValueTask<Response608> Mediator.IRequestHandler<Request608, Response608>.Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response608> MediatR.IRequestHandler<Request608, Response608>.Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request608StaticHandler
{
	private static ValueTask<Response608> Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request608SealedHandler
{
	private ValueTask<Response608> Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request609(long Id) : Mediator.IRequest<Response609>, MediatR.IRequest<Response609>;

public sealed record Response609(long Id);

public sealed partial class Request609TraditionalHandler
	: Mediator.IRequestHandler<Request609, Response609>,
	MediatR.IRequestHandler<Request609, Response609>
{
	ValueTask<Response609> Mediator.IRequestHandler<Request609, Response609>.Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response609> MediatR.IRequestHandler<Request609, Response609>.Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request609StaticHandler
{
	private static ValueTask<Response609> Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request609SealedHandler
{
	private ValueTask<Response609> Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request610(long Id) : Mediator.IRequest<Response610>, MediatR.IRequest<Response610>;

public sealed record Response610(long Id);

public sealed partial class Request610TraditionalHandler
	: Mediator.IRequestHandler<Request610, Response610>,
	MediatR.IRequestHandler<Request610, Response610>
{
	ValueTask<Response610> Mediator.IRequestHandler<Request610, Response610>.Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response610> MediatR.IRequestHandler<Request610, Response610>.Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request610StaticHandler
{
	private static ValueTask<Response610> Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request610SealedHandler
{
	private ValueTask<Response610> Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request611(long Id) : Mediator.IRequest<Response611>, MediatR.IRequest<Response611>;

public sealed record Response611(long Id);

public sealed partial class Request611TraditionalHandler
	: Mediator.IRequestHandler<Request611, Response611>,
	MediatR.IRequestHandler<Request611, Response611>
{
	ValueTask<Response611> Mediator.IRequestHandler<Request611, Response611>.Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response611> MediatR.IRequestHandler<Request611, Response611>.Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request611StaticHandler
{
	private static ValueTask<Response611> Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request611SealedHandler
{
	private ValueTask<Response611> Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request612(long Id) : Mediator.IRequest<Response612>, MediatR.IRequest<Response612>;

public sealed record Response612(long Id);

public sealed partial class Request612TraditionalHandler
	: Mediator.IRequestHandler<Request612, Response612>,
	MediatR.IRequestHandler<Request612, Response612>
{
	ValueTask<Response612> Mediator.IRequestHandler<Request612, Response612>.Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response612> MediatR.IRequestHandler<Request612, Response612>.Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request612StaticHandler
{
	private static ValueTask<Response612> Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request612SealedHandler
{
	private ValueTask<Response612> Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request613(long Id) : Mediator.IRequest<Response613>, MediatR.IRequest<Response613>;

public sealed record Response613(long Id);

public sealed partial class Request613TraditionalHandler
	: Mediator.IRequestHandler<Request613, Response613>,
	MediatR.IRequestHandler<Request613, Response613>
{
	ValueTask<Response613> Mediator.IRequestHandler<Request613, Response613>.Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response613> MediatR.IRequestHandler<Request613, Response613>.Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request613StaticHandler
{
	private static ValueTask<Response613> Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request613SealedHandler
{
	private ValueTask<Response613> Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request614(long Id) : Mediator.IRequest<Response614>, MediatR.IRequest<Response614>;

public sealed record Response614(long Id);

public sealed partial class Request614TraditionalHandler
	: Mediator.IRequestHandler<Request614, Response614>,
	MediatR.IRequestHandler<Request614, Response614>
{
	ValueTask<Response614> Mediator.IRequestHandler<Request614, Response614>.Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response614> MediatR.IRequestHandler<Request614, Response614>.Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request614StaticHandler
{
	private static ValueTask<Response614> Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request614SealedHandler
{
	private ValueTask<Response614> Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request615(long Id) : Mediator.IRequest<Response615>, MediatR.IRequest<Response615>;

public sealed record Response615(long Id);

public sealed partial class Request615TraditionalHandler
	: Mediator.IRequestHandler<Request615, Response615>,
	MediatR.IRequestHandler<Request615, Response615>
{
	ValueTask<Response615> Mediator.IRequestHandler<Request615, Response615>.Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response615> MediatR.IRequestHandler<Request615, Response615>.Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request615StaticHandler
{
	private static ValueTask<Response615> Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request615SealedHandler
{
	private ValueTask<Response615> Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request616(long Id) : Mediator.IRequest<Response616>, MediatR.IRequest<Response616>;

public sealed record Response616(long Id);

public sealed partial class Request616TraditionalHandler
	: Mediator.IRequestHandler<Request616, Response616>,
	MediatR.IRequestHandler<Request616, Response616>
{
	ValueTask<Response616> Mediator.IRequestHandler<Request616, Response616>.Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response616> MediatR.IRequestHandler<Request616, Response616>.Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request616StaticHandler
{
	private static ValueTask<Response616> Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request616SealedHandler
{
	private ValueTask<Response616> Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request617(long Id) : Mediator.IRequest<Response617>, MediatR.IRequest<Response617>;

public sealed record Response617(long Id);

public sealed partial class Request617TraditionalHandler
	: Mediator.IRequestHandler<Request617, Response617>,
	MediatR.IRequestHandler<Request617, Response617>
{
	ValueTask<Response617> Mediator.IRequestHandler<Request617, Response617>.Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response617> MediatR.IRequestHandler<Request617, Response617>.Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request617StaticHandler
{
	private static ValueTask<Response617> Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request617SealedHandler
{
	private ValueTask<Response617> Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request618(long Id) : Mediator.IRequest<Response618>, MediatR.IRequest<Response618>;

public sealed record Response618(long Id);

public sealed partial class Request618TraditionalHandler
	: Mediator.IRequestHandler<Request618, Response618>,
	MediatR.IRequestHandler<Request618, Response618>
{
	ValueTask<Response618> Mediator.IRequestHandler<Request618, Response618>.Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response618> MediatR.IRequestHandler<Request618, Response618>.Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request618StaticHandler
{
	private static ValueTask<Response618> Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request618SealedHandler
{
	private ValueTask<Response618> Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request619(long Id) : Mediator.IRequest<Response619>, MediatR.IRequest<Response619>;

public sealed record Response619(long Id);

public sealed partial class Request619TraditionalHandler
	: Mediator.IRequestHandler<Request619, Response619>,
	MediatR.IRequestHandler<Request619, Response619>
{
	ValueTask<Response619> Mediator.IRequestHandler<Request619, Response619>.Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response619> MediatR.IRequestHandler<Request619, Response619>.Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request619StaticHandler
{
	private static ValueTask<Response619> Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request619SealedHandler
{
	private ValueTask<Response619> Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request620(long Id) : Mediator.IRequest<Response620>, MediatR.IRequest<Response620>;

public sealed record Response620(long Id);

public sealed partial class Request620TraditionalHandler
	: Mediator.IRequestHandler<Request620, Response620>,
	MediatR.IRequestHandler<Request620, Response620>
{
	ValueTask<Response620> Mediator.IRequestHandler<Request620, Response620>.Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response620> MediatR.IRequestHandler<Request620, Response620>.Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request620StaticHandler
{
	private static ValueTask<Response620> Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request620SealedHandler
{
	private ValueTask<Response620> Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request621(long Id) : Mediator.IRequest<Response621>, MediatR.IRequest<Response621>;

public sealed record Response621(long Id);

public sealed partial class Request621TraditionalHandler
	: Mediator.IRequestHandler<Request621, Response621>,
	MediatR.IRequestHandler<Request621, Response621>
{
	ValueTask<Response621> Mediator.IRequestHandler<Request621, Response621>.Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response621> MediatR.IRequestHandler<Request621, Response621>.Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request621StaticHandler
{
	private static ValueTask<Response621> Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request621SealedHandler
{
	private ValueTask<Response621> Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request622(long Id) : Mediator.IRequest<Response622>, MediatR.IRequest<Response622>;

public sealed record Response622(long Id);

public sealed partial class Request622TraditionalHandler
	: Mediator.IRequestHandler<Request622, Response622>,
	MediatR.IRequestHandler<Request622, Response622>
{
	ValueTask<Response622> Mediator.IRequestHandler<Request622, Response622>.Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response622> MediatR.IRequestHandler<Request622, Response622>.Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request622StaticHandler
{
	private static ValueTask<Response622> Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request622SealedHandler
{
	private ValueTask<Response622> Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request623(long Id) : Mediator.IRequest<Response623>, MediatR.IRequest<Response623>;

public sealed record Response623(long Id);

public sealed partial class Request623TraditionalHandler
	: Mediator.IRequestHandler<Request623, Response623>,
	MediatR.IRequestHandler<Request623, Response623>
{
	ValueTask<Response623> Mediator.IRequestHandler<Request623, Response623>.Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response623> MediatR.IRequestHandler<Request623, Response623>.Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request623StaticHandler
{
	private static ValueTask<Response623> Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request623SealedHandler
{
	private ValueTask<Response623> Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request624(long Id) : Mediator.IRequest<Response624>, MediatR.IRequest<Response624>;

public sealed record Response624(long Id);

public sealed partial class Request624TraditionalHandler
	: Mediator.IRequestHandler<Request624, Response624>,
	MediatR.IRequestHandler<Request624, Response624>
{
	ValueTask<Response624> Mediator.IRequestHandler<Request624, Response624>.Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response624> MediatR.IRequestHandler<Request624, Response624>.Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request624StaticHandler
{
	private static ValueTask<Response624> Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request624SealedHandler
{
	private ValueTask<Response624> Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request625(long Id) : Mediator.IRequest<Response625>, MediatR.IRequest<Response625>;

public sealed record Response625(long Id);

public sealed partial class Request625TraditionalHandler
	: Mediator.IRequestHandler<Request625, Response625>,
	MediatR.IRequestHandler<Request625, Response625>
{
	ValueTask<Response625> Mediator.IRequestHandler<Request625, Response625>.Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response625> MediatR.IRequestHandler<Request625, Response625>.Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request625StaticHandler
{
	private static ValueTask<Response625> Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request625SealedHandler
{
	private ValueTask<Response625> Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request626(long Id) : Mediator.IRequest<Response626>, MediatR.IRequest<Response626>;

public sealed record Response626(long Id);

public sealed partial class Request626TraditionalHandler
	: Mediator.IRequestHandler<Request626, Response626>,
	MediatR.IRequestHandler<Request626, Response626>
{
	ValueTask<Response626> Mediator.IRequestHandler<Request626, Response626>.Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response626> MediatR.IRequestHandler<Request626, Response626>.Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request626StaticHandler
{
	private static ValueTask<Response626> Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request626SealedHandler
{
	private ValueTask<Response626> Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request627(long Id) : Mediator.IRequest<Response627>, MediatR.IRequest<Response627>;

public sealed record Response627(long Id);

public sealed partial class Request627TraditionalHandler
	: Mediator.IRequestHandler<Request627, Response627>,
	MediatR.IRequestHandler<Request627, Response627>
{
	ValueTask<Response627> Mediator.IRequestHandler<Request627, Response627>.Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response627> MediatR.IRequestHandler<Request627, Response627>.Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request627StaticHandler
{
	private static ValueTask<Response627> Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request627SealedHandler
{
	private ValueTask<Response627> Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request628(long Id) : Mediator.IRequest<Response628>, MediatR.IRequest<Response628>;

public sealed record Response628(long Id);

public sealed partial class Request628TraditionalHandler
	: Mediator.IRequestHandler<Request628, Response628>,
	MediatR.IRequestHandler<Request628, Response628>
{
	ValueTask<Response628> Mediator.IRequestHandler<Request628, Response628>.Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response628> MediatR.IRequestHandler<Request628, Response628>.Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request628StaticHandler
{
	private static ValueTask<Response628> Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request628SealedHandler
{
	private ValueTask<Response628> Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request629(long Id) : Mediator.IRequest<Response629>, MediatR.IRequest<Response629>;

public sealed record Response629(long Id);

public sealed partial class Request629TraditionalHandler
	: Mediator.IRequestHandler<Request629, Response629>,
	MediatR.IRequestHandler<Request629, Response629>
{
	ValueTask<Response629> Mediator.IRequestHandler<Request629, Response629>.Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response629> MediatR.IRequestHandler<Request629, Response629>.Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request629StaticHandler
{
	private static ValueTask<Response629> Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request629SealedHandler
{
	private ValueTask<Response629> Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request630(long Id) : Mediator.IRequest<Response630>, MediatR.IRequest<Response630>;

public sealed record Response630(long Id);

public sealed partial class Request630TraditionalHandler
	: Mediator.IRequestHandler<Request630, Response630>,
	MediatR.IRequestHandler<Request630, Response630>
{
	ValueTask<Response630> Mediator.IRequestHandler<Request630, Response630>.Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response630> MediatR.IRequestHandler<Request630, Response630>.Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request630StaticHandler
{
	private static ValueTask<Response630> Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request630SealedHandler
{
	private ValueTask<Response630> Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request631(long Id) : Mediator.IRequest<Response631>, MediatR.IRequest<Response631>;

public sealed record Response631(long Id);

public sealed partial class Request631TraditionalHandler
	: Mediator.IRequestHandler<Request631, Response631>,
	MediatR.IRequestHandler<Request631, Response631>
{
	ValueTask<Response631> Mediator.IRequestHandler<Request631, Response631>.Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response631> MediatR.IRequestHandler<Request631, Response631>.Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request631StaticHandler
{
	private static ValueTask<Response631> Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request631SealedHandler
{
	private ValueTask<Response631> Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request632(long Id) : Mediator.IRequest<Response632>, MediatR.IRequest<Response632>;

public sealed record Response632(long Id);

public sealed partial class Request632TraditionalHandler
	: Mediator.IRequestHandler<Request632, Response632>,
	MediatR.IRequestHandler<Request632, Response632>
{
	ValueTask<Response632> Mediator.IRequestHandler<Request632, Response632>.Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response632> MediatR.IRequestHandler<Request632, Response632>.Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request632StaticHandler
{
	private static ValueTask<Response632> Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request632SealedHandler
{
	private ValueTask<Response632> Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request633(long Id) : Mediator.IRequest<Response633>, MediatR.IRequest<Response633>;

public sealed record Response633(long Id);

public sealed partial class Request633TraditionalHandler
	: Mediator.IRequestHandler<Request633, Response633>,
	MediatR.IRequestHandler<Request633, Response633>
{
	ValueTask<Response633> Mediator.IRequestHandler<Request633, Response633>.Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response633> MediatR.IRequestHandler<Request633, Response633>.Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request633StaticHandler
{
	private static ValueTask<Response633> Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request633SealedHandler
{
	private ValueTask<Response633> Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request634(long Id) : Mediator.IRequest<Response634>, MediatR.IRequest<Response634>;

public sealed record Response634(long Id);

public sealed partial class Request634TraditionalHandler
	: Mediator.IRequestHandler<Request634, Response634>,
	MediatR.IRequestHandler<Request634, Response634>
{
	ValueTask<Response634> Mediator.IRequestHandler<Request634, Response634>.Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response634> MediatR.IRequestHandler<Request634, Response634>.Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request634StaticHandler
{
	private static ValueTask<Response634> Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request634SealedHandler
{
	private ValueTask<Response634> Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request635(long Id) : Mediator.IRequest<Response635>, MediatR.IRequest<Response635>;

public sealed record Response635(long Id);

public sealed partial class Request635TraditionalHandler
	: Mediator.IRequestHandler<Request635, Response635>,
	MediatR.IRequestHandler<Request635, Response635>
{
	ValueTask<Response635> Mediator.IRequestHandler<Request635, Response635>.Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response635> MediatR.IRequestHandler<Request635, Response635>.Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request635StaticHandler
{
	private static ValueTask<Response635> Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request635SealedHandler
{
	private ValueTask<Response635> Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request636(long Id) : Mediator.IRequest<Response636>, MediatR.IRequest<Response636>;

public sealed record Response636(long Id);

public sealed partial class Request636TraditionalHandler
	: Mediator.IRequestHandler<Request636, Response636>,
	MediatR.IRequestHandler<Request636, Response636>
{
	ValueTask<Response636> Mediator.IRequestHandler<Request636, Response636>.Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response636> MediatR.IRequestHandler<Request636, Response636>.Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request636StaticHandler
{
	private static ValueTask<Response636> Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request636SealedHandler
{
	private ValueTask<Response636> Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request637(long Id) : Mediator.IRequest<Response637>, MediatR.IRequest<Response637>;

public sealed record Response637(long Id);

public sealed partial class Request637TraditionalHandler
	: Mediator.IRequestHandler<Request637, Response637>,
	MediatR.IRequestHandler<Request637, Response637>
{
	ValueTask<Response637> Mediator.IRequestHandler<Request637, Response637>.Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response637> MediatR.IRequestHandler<Request637, Response637>.Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request637StaticHandler
{
	private static ValueTask<Response637> Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request637SealedHandler
{
	private ValueTask<Response637> Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request638(long Id) : Mediator.IRequest<Response638>, MediatR.IRequest<Response638>;

public sealed record Response638(long Id);

public sealed partial class Request638TraditionalHandler
	: Mediator.IRequestHandler<Request638, Response638>,
	MediatR.IRequestHandler<Request638, Response638>
{
	ValueTask<Response638> Mediator.IRequestHandler<Request638, Response638>.Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response638> MediatR.IRequestHandler<Request638, Response638>.Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request638StaticHandler
{
	private static ValueTask<Response638> Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request638SealedHandler
{
	private ValueTask<Response638> Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request639(long Id) : Mediator.IRequest<Response639>, MediatR.IRequest<Response639>;

public sealed record Response639(long Id);

public sealed partial class Request639TraditionalHandler
	: Mediator.IRequestHandler<Request639, Response639>,
	MediatR.IRequestHandler<Request639, Response639>
{
	ValueTask<Response639> Mediator.IRequestHandler<Request639, Response639>.Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response639> MediatR.IRequestHandler<Request639, Response639>.Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request639StaticHandler
{
	private static ValueTask<Response639> Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request639SealedHandler
{
	private ValueTask<Response639> Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request640(long Id) : Mediator.IRequest<Response640>, MediatR.IRequest<Response640>;

public sealed record Response640(long Id);

public sealed partial class Request640TraditionalHandler
	: Mediator.IRequestHandler<Request640, Response640>,
	MediatR.IRequestHandler<Request640, Response640>
{
	ValueTask<Response640> Mediator.IRequestHandler<Request640, Response640>.Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response640> MediatR.IRequestHandler<Request640, Response640>.Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request640StaticHandler
{
	private static ValueTask<Response640> Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request640SealedHandler
{
	private ValueTask<Response640> Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request641(long Id) : Mediator.IRequest<Response641>, MediatR.IRequest<Response641>;

public sealed record Response641(long Id);

public sealed partial class Request641TraditionalHandler
	: Mediator.IRequestHandler<Request641, Response641>,
	MediatR.IRequestHandler<Request641, Response641>
{
	ValueTask<Response641> Mediator.IRequestHandler<Request641, Response641>.Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response641> MediatR.IRequestHandler<Request641, Response641>.Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request641StaticHandler
{
	private static ValueTask<Response641> Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request641SealedHandler
{
	private ValueTask<Response641> Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request642(long Id) : Mediator.IRequest<Response642>, MediatR.IRequest<Response642>;

public sealed record Response642(long Id);

public sealed partial class Request642TraditionalHandler
	: Mediator.IRequestHandler<Request642, Response642>,
	MediatR.IRequestHandler<Request642, Response642>
{
	ValueTask<Response642> Mediator.IRequestHandler<Request642, Response642>.Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response642> MediatR.IRequestHandler<Request642, Response642>.Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request642StaticHandler
{
	private static ValueTask<Response642> Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request642SealedHandler
{
	private ValueTask<Response642> Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request643(long Id) : Mediator.IRequest<Response643>, MediatR.IRequest<Response643>;

public sealed record Response643(long Id);

public sealed partial class Request643TraditionalHandler
	: Mediator.IRequestHandler<Request643, Response643>,
	MediatR.IRequestHandler<Request643, Response643>
{
	ValueTask<Response643> Mediator.IRequestHandler<Request643, Response643>.Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response643> MediatR.IRequestHandler<Request643, Response643>.Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request643StaticHandler
{
	private static ValueTask<Response643> Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request643SealedHandler
{
	private ValueTask<Response643> Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request644(long Id) : Mediator.IRequest<Response644>, MediatR.IRequest<Response644>;

public sealed record Response644(long Id);

public sealed partial class Request644TraditionalHandler
	: Mediator.IRequestHandler<Request644, Response644>,
	MediatR.IRequestHandler<Request644, Response644>
{
	ValueTask<Response644> Mediator.IRequestHandler<Request644, Response644>.Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response644> MediatR.IRequestHandler<Request644, Response644>.Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request644StaticHandler
{
	private static ValueTask<Response644> Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request644SealedHandler
{
	private ValueTask<Response644> Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request645(long Id) : Mediator.IRequest<Response645>, MediatR.IRequest<Response645>;

public sealed record Response645(long Id);

public sealed partial class Request645TraditionalHandler
	: Mediator.IRequestHandler<Request645, Response645>,
	MediatR.IRequestHandler<Request645, Response645>
{
	ValueTask<Response645> Mediator.IRequestHandler<Request645, Response645>.Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response645> MediatR.IRequestHandler<Request645, Response645>.Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request645StaticHandler
{
	private static ValueTask<Response645> Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request645SealedHandler
{
	private ValueTask<Response645> Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request646(long Id) : Mediator.IRequest<Response646>, MediatR.IRequest<Response646>;

public sealed record Response646(long Id);

public sealed partial class Request646TraditionalHandler
	: Mediator.IRequestHandler<Request646, Response646>,
	MediatR.IRequestHandler<Request646, Response646>
{
	ValueTask<Response646> Mediator.IRequestHandler<Request646, Response646>.Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response646> MediatR.IRequestHandler<Request646, Response646>.Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request646StaticHandler
{
	private static ValueTask<Response646> Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request646SealedHandler
{
	private ValueTask<Response646> Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request647(long Id) : Mediator.IRequest<Response647>, MediatR.IRequest<Response647>;

public sealed record Response647(long Id);

public sealed partial class Request647TraditionalHandler
	: Mediator.IRequestHandler<Request647, Response647>,
	MediatR.IRequestHandler<Request647, Response647>
{
	ValueTask<Response647> Mediator.IRequestHandler<Request647, Response647>.Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response647> MediatR.IRequestHandler<Request647, Response647>.Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request647StaticHandler
{
	private static ValueTask<Response647> Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request647SealedHandler
{
	private ValueTask<Response647> Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request648(long Id) : Mediator.IRequest<Response648>, MediatR.IRequest<Response648>;

public sealed record Response648(long Id);

public sealed partial class Request648TraditionalHandler
	: Mediator.IRequestHandler<Request648, Response648>,
	MediatR.IRequestHandler<Request648, Response648>
{
	ValueTask<Response648> Mediator.IRequestHandler<Request648, Response648>.Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response648> MediatR.IRequestHandler<Request648, Response648>.Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request648StaticHandler
{
	private static ValueTask<Response648> Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request648SealedHandler
{
	private ValueTask<Response648> Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request649(long Id) : Mediator.IRequest<Response649>, MediatR.IRequest<Response649>;

public sealed record Response649(long Id);

public sealed partial class Request649TraditionalHandler
	: Mediator.IRequestHandler<Request649, Response649>,
	MediatR.IRequestHandler<Request649, Response649>
{
	ValueTask<Response649> Mediator.IRequestHandler<Request649, Response649>.Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response649> MediatR.IRequestHandler<Request649, Response649>.Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request649StaticHandler
{
	private static ValueTask<Response649> Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request649SealedHandler
{
	private ValueTask<Response649> Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request650(long Id) : Mediator.IRequest<Response650>, MediatR.IRequest<Response650>;

public sealed record Response650(long Id);

public sealed partial class Request650TraditionalHandler
	: Mediator.IRequestHandler<Request650, Response650>,
	MediatR.IRequestHandler<Request650, Response650>
{
	ValueTask<Response650> Mediator.IRequestHandler<Request650, Response650>.Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response650> MediatR.IRequestHandler<Request650, Response650>.Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request650StaticHandler
{
	private static ValueTask<Response650> Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request650SealedHandler
{
	private ValueTask<Response650> Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request651(long Id) : Mediator.IRequest<Response651>, MediatR.IRequest<Response651>;

public sealed record Response651(long Id);

public sealed partial class Request651TraditionalHandler
	: Mediator.IRequestHandler<Request651, Response651>,
	MediatR.IRequestHandler<Request651, Response651>
{
	ValueTask<Response651> Mediator.IRequestHandler<Request651, Response651>.Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response651> MediatR.IRequestHandler<Request651, Response651>.Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request651StaticHandler
{
	private static ValueTask<Response651> Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request651SealedHandler
{
	private ValueTask<Response651> Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request652(long Id) : Mediator.IRequest<Response652>, MediatR.IRequest<Response652>;

public sealed record Response652(long Id);

public sealed partial class Request652TraditionalHandler
	: Mediator.IRequestHandler<Request652, Response652>,
	MediatR.IRequestHandler<Request652, Response652>
{
	ValueTask<Response652> Mediator.IRequestHandler<Request652, Response652>.Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response652> MediatR.IRequestHandler<Request652, Response652>.Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request652StaticHandler
{
	private static ValueTask<Response652> Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request652SealedHandler
{
	private ValueTask<Response652> Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request653(long Id) : Mediator.IRequest<Response653>, MediatR.IRequest<Response653>;

public sealed record Response653(long Id);

public sealed partial class Request653TraditionalHandler
	: Mediator.IRequestHandler<Request653, Response653>,
	MediatR.IRequestHandler<Request653, Response653>
{
	ValueTask<Response653> Mediator.IRequestHandler<Request653, Response653>.Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response653> MediatR.IRequestHandler<Request653, Response653>.Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request653StaticHandler
{
	private static ValueTask<Response653> Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request653SealedHandler
{
	private ValueTask<Response653> Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request654(long Id) : Mediator.IRequest<Response654>, MediatR.IRequest<Response654>;

public sealed record Response654(long Id);

public sealed partial class Request654TraditionalHandler
	: Mediator.IRequestHandler<Request654, Response654>,
	MediatR.IRequestHandler<Request654, Response654>
{
	ValueTask<Response654> Mediator.IRequestHandler<Request654, Response654>.Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response654> MediatR.IRequestHandler<Request654, Response654>.Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request654StaticHandler
{
	private static ValueTask<Response654> Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request654SealedHandler
{
	private ValueTask<Response654> Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request655(long Id) : Mediator.IRequest<Response655>, MediatR.IRequest<Response655>;

public sealed record Response655(long Id);

public sealed partial class Request655TraditionalHandler
	: Mediator.IRequestHandler<Request655, Response655>,
	MediatR.IRequestHandler<Request655, Response655>
{
	ValueTask<Response655> Mediator.IRequestHandler<Request655, Response655>.Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response655> MediatR.IRequestHandler<Request655, Response655>.Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request655StaticHandler
{
	private static ValueTask<Response655> Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request655SealedHandler
{
	private ValueTask<Response655> Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request656(long Id) : Mediator.IRequest<Response656>, MediatR.IRequest<Response656>;

public sealed record Response656(long Id);

public sealed partial class Request656TraditionalHandler
	: Mediator.IRequestHandler<Request656, Response656>,
	MediatR.IRequestHandler<Request656, Response656>
{
	ValueTask<Response656> Mediator.IRequestHandler<Request656, Response656>.Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response656> MediatR.IRequestHandler<Request656, Response656>.Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request656StaticHandler
{
	private static ValueTask<Response656> Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request656SealedHandler
{
	private ValueTask<Response656> Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request657(long Id) : Mediator.IRequest<Response657>, MediatR.IRequest<Response657>;

public sealed record Response657(long Id);

public sealed partial class Request657TraditionalHandler
	: Mediator.IRequestHandler<Request657, Response657>,
	MediatR.IRequestHandler<Request657, Response657>
{
	ValueTask<Response657> Mediator.IRequestHandler<Request657, Response657>.Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response657> MediatR.IRequestHandler<Request657, Response657>.Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request657StaticHandler
{
	private static ValueTask<Response657> Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request657SealedHandler
{
	private ValueTask<Response657> Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request658(long Id) : Mediator.IRequest<Response658>, MediatR.IRequest<Response658>;

public sealed record Response658(long Id);

public sealed partial class Request658TraditionalHandler
	: Mediator.IRequestHandler<Request658, Response658>,
	MediatR.IRequestHandler<Request658, Response658>
{
	ValueTask<Response658> Mediator.IRequestHandler<Request658, Response658>.Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response658> MediatR.IRequestHandler<Request658, Response658>.Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request658StaticHandler
{
	private static ValueTask<Response658> Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request658SealedHandler
{
	private ValueTask<Response658> Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request659(long Id) : Mediator.IRequest<Response659>, MediatR.IRequest<Response659>;

public sealed record Response659(long Id);

public sealed partial class Request659TraditionalHandler
	: Mediator.IRequestHandler<Request659, Response659>,
	MediatR.IRequestHandler<Request659, Response659>
{
	ValueTask<Response659> Mediator.IRequestHandler<Request659, Response659>.Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response659> MediatR.IRequestHandler<Request659, Response659>.Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request659StaticHandler
{
	private static ValueTask<Response659> Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request659SealedHandler
{
	private ValueTask<Response659> Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request660(long Id) : Mediator.IRequest<Response660>, MediatR.IRequest<Response660>;

public sealed record Response660(long Id);

public sealed partial class Request660TraditionalHandler
	: Mediator.IRequestHandler<Request660, Response660>,
	MediatR.IRequestHandler<Request660, Response660>
{
	ValueTask<Response660> Mediator.IRequestHandler<Request660, Response660>.Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response660> MediatR.IRequestHandler<Request660, Response660>.Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request660StaticHandler
{
	private static ValueTask<Response660> Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request660SealedHandler
{
	private ValueTask<Response660> Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request661(long Id) : Mediator.IRequest<Response661>, MediatR.IRequest<Response661>;

public sealed record Response661(long Id);

public sealed partial class Request661TraditionalHandler
	: Mediator.IRequestHandler<Request661, Response661>,
	MediatR.IRequestHandler<Request661, Response661>
{
	ValueTask<Response661> Mediator.IRequestHandler<Request661, Response661>.Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response661> MediatR.IRequestHandler<Request661, Response661>.Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request661StaticHandler
{
	private static ValueTask<Response661> Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request661SealedHandler
{
	private ValueTask<Response661> Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request662(long Id) : Mediator.IRequest<Response662>, MediatR.IRequest<Response662>;

public sealed record Response662(long Id);

public sealed partial class Request662TraditionalHandler
	: Mediator.IRequestHandler<Request662, Response662>,
	MediatR.IRequestHandler<Request662, Response662>
{
	ValueTask<Response662> Mediator.IRequestHandler<Request662, Response662>.Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response662> MediatR.IRequestHandler<Request662, Response662>.Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request662StaticHandler
{
	private static ValueTask<Response662> Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request662SealedHandler
{
	private ValueTask<Response662> Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request663(long Id) : Mediator.IRequest<Response663>, MediatR.IRequest<Response663>;

public sealed record Response663(long Id);

public sealed partial class Request663TraditionalHandler
	: Mediator.IRequestHandler<Request663, Response663>,
	MediatR.IRequestHandler<Request663, Response663>
{
	ValueTask<Response663> Mediator.IRequestHandler<Request663, Response663>.Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response663> MediatR.IRequestHandler<Request663, Response663>.Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request663StaticHandler
{
	private static ValueTask<Response663> Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request663SealedHandler
{
	private ValueTask<Response663> Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request664(long Id) : Mediator.IRequest<Response664>, MediatR.IRequest<Response664>;

public sealed record Response664(long Id);

public sealed partial class Request664TraditionalHandler
	: Mediator.IRequestHandler<Request664, Response664>,
	MediatR.IRequestHandler<Request664, Response664>
{
	ValueTask<Response664> Mediator.IRequestHandler<Request664, Response664>.Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response664> MediatR.IRequestHandler<Request664, Response664>.Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request664StaticHandler
{
	private static ValueTask<Response664> Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request664SealedHandler
{
	private ValueTask<Response664> Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request665(long Id) : Mediator.IRequest<Response665>, MediatR.IRequest<Response665>;

public sealed record Response665(long Id);

public sealed partial class Request665TraditionalHandler
	: Mediator.IRequestHandler<Request665, Response665>,
	MediatR.IRequestHandler<Request665, Response665>
{
	ValueTask<Response665> Mediator.IRequestHandler<Request665, Response665>.Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response665> MediatR.IRequestHandler<Request665, Response665>.Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request665StaticHandler
{
	private static ValueTask<Response665> Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request665SealedHandler
{
	private ValueTask<Response665> Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request666(long Id) : Mediator.IRequest<Response666>, MediatR.IRequest<Response666>;

public sealed record Response666(long Id);

public sealed partial class Request666TraditionalHandler
	: Mediator.IRequestHandler<Request666, Response666>,
	MediatR.IRequestHandler<Request666, Response666>
{
	ValueTask<Response666> Mediator.IRequestHandler<Request666, Response666>.Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response666> MediatR.IRequestHandler<Request666, Response666>.Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request666StaticHandler
{
	private static ValueTask<Response666> Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request666SealedHandler
{
	private ValueTask<Response666> Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request667(long Id) : Mediator.IRequest<Response667>, MediatR.IRequest<Response667>;

public sealed record Response667(long Id);

public sealed partial class Request667TraditionalHandler
	: Mediator.IRequestHandler<Request667, Response667>,
	MediatR.IRequestHandler<Request667, Response667>
{
	ValueTask<Response667> Mediator.IRequestHandler<Request667, Response667>.Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response667> MediatR.IRequestHandler<Request667, Response667>.Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request667StaticHandler
{
	private static ValueTask<Response667> Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request667SealedHandler
{
	private ValueTask<Response667> Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request668(long Id) : Mediator.IRequest<Response668>, MediatR.IRequest<Response668>;

public sealed record Response668(long Id);

public sealed partial class Request668TraditionalHandler
	: Mediator.IRequestHandler<Request668, Response668>,
	MediatR.IRequestHandler<Request668, Response668>
{
	ValueTask<Response668> Mediator.IRequestHandler<Request668, Response668>.Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response668> MediatR.IRequestHandler<Request668, Response668>.Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request668StaticHandler
{
	private static ValueTask<Response668> Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request668SealedHandler
{
	private ValueTask<Response668> Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request669(long Id) : Mediator.IRequest<Response669>, MediatR.IRequest<Response669>;

public sealed record Response669(long Id);

public sealed partial class Request669TraditionalHandler
	: Mediator.IRequestHandler<Request669, Response669>,
	MediatR.IRequestHandler<Request669, Response669>
{
	ValueTask<Response669> Mediator.IRequestHandler<Request669, Response669>.Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response669> MediatR.IRequestHandler<Request669, Response669>.Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request669StaticHandler
{
	private static ValueTask<Response669> Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request669SealedHandler
{
	private ValueTask<Response669> Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request670(long Id) : Mediator.IRequest<Response670>, MediatR.IRequest<Response670>;

public sealed record Response670(long Id);

public sealed partial class Request670TraditionalHandler
	: Mediator.IRequestHandler<Request670, Response670>,
	MediatR.IRequestHandler<Request670, Response670>
{
	ValueTask<Response670> Mediator.IRequestHandler<Request670, Response670>.Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response670> MediatR.IRequestHandler<Request670, Response670>.Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request670StaticHandler
{
	private static ValueTask<Response670> Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request670SealedHandler
{
	private ValueTask<Response670> Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request671(long Id) : Mediator.IRequest<Response671>, MediatR.IRequest<Response671>;

public sealed record Response671(long Id);

public sealed partial class Request671TraditionalHandler
	: Mediator.IRequestHandler<Request671, Response671>,
	MediatR.IRequestHandler<Request671, Response671>
{
	ValueTask<Response671> Mediator.IRequestHandler<Request671, Response671>.Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response671> MediatR.IRequestHandler<Request671, Response671>.Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request671StaticHandler
{
	private static ValueTask<Response671> Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request671SealedHandler
{
	private ValueTask<Response671> Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request672(long Id) : Mediator.IRequest<Response672>, MediatR.IRequest<Response672>;

public sealed record Response672(long Id);

public sealed partial class Request672TraditionalHandler
	: Mediator.IRequestHandler<Request672, Response672>,
	MediatR.IRequestHandler<Request672, Response672>
{
	ValueTask<Response672> Mediator.IRequestHandler<Request672, Response672>.Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response672> MediatR.IRequestHandler<Request672, Response672>.Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request672StaticHandler
{
	private static ValueTask<Response672> Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request672SealedHandler
{
	private ValueTask<Response672> Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request673(long Id) : Mediator.IRequest<Response673>, MediatR.IRequest<Response673>;

public sealed record Response673(long Id);

public sealed partial class Request673TraditionalHandler
	: Mediator.IRequestHandler<Request673, Response673>,
	MediatR.IRequestHandler<Request673, Response673>
{
	ValueTask<Response673> Mediator.IRequestHandler<Request673, Response673>.Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response673> MediatR.IRequestHandler<Request673, Response673>.Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request673StaticHandler
{
	private static ValueTask<Response673> Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request673SealedHandler
{
	private ValueTask<Response673> Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request674(long Id) : Mediator.IRequest<Response674>, MediatR.IRequest<Response674>;

public sealed record Response674(long Id);

public sealed partial class Request674TraditionalHandler
	: Mediator.IRequestHandler<Request674, Response674>,
	MediatR.IRequestHandler<Request674, Response674>
{
	ValueTask<Response674> Mediator.IRequestHandler<Request674, Response674>.Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response674> MediatR.IRequestHandler<Request674, Response674>.Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request674StaticHandler
{
	private static ValueTask<Response674> Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request674SealedHandler
{
	private ValueTask<Response674> Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request675(long Id) : Mediator.IRequest<Response675>, MediatR.IRequest<Response675>;

public sealed record Response675(long Id);

public sealed partial class Request675TraditionalHandler
	: Mediator.IRequestHandler<Request675, Response675>,
	MediatR.IRequestHandler<Request675, Response675>
{
	ValueTask<Response675> Mediator.IRequestHandler<Request675, Response675>.Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response675> MediatR.IRequestHandler<Request675, Response675>.Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request675StaticHandler
{
	private static ValueTask<Response675> Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request675SealedHandler
{
	private ValueTask<Response675> Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request676(long Id) : Mediator.IRequest<Response676>, MediatR.IRequest<Response676>;

public sealed record Response676(long Id);

public sealed partial class Request676TraditionalHandler
	: Mediator.IRequestHandler<Request676, Response676>,
	MediatR.IRequestHandler<Request676, Response676>
{
	ValueTask<Response676> Mediator.IRequestHandler<Request676, Response676>.Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response676> MediatR.IRequestHandler<Request676, Response676>.Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request676StaticHandler
{
	private static ValueTask<Response676> Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request676SealedHandler
{
	private ValueTask<Response676> Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request677(long Id) : Mediator.IRequest<Response677>, MediatR.IRequest<Response677>;

public sealed record Response677(long Id);

public sealed partial class Request677TraditionalHandler
	: Mediator.IRequestHandler<Request677, Response677>,
	MediatR.IRequestHandler<Request677, Response677>
{
	ValueTask<Response677> Mediator.IRequestHandler<Request677, Response677>.Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response677> MediatR.IRequestHandler<Request677, Response677>.Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request677StaticHandler
{
	private static ValueTask<Response677> Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request677SealedHandler
{
	private ValueTask<Response677> Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request678(long Id) : Mediator.IRequest<Response678>, MediatR.IRequest<Response678>;

public sealed record Response678(long Id);

public sealed partial class Request678TraditionalHandler
	: Mediator.IRequestHandler<Request678, Response678>,
	MediatR.IRequestHandler<Request678, Response678>
{
	ValueTask<Response678> Mediator.IRequestHandler<Request678, Response678>.Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response678> MediatR.IRequestHandler<Request678, Response678>.Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request678StaticHandler
{
	private static ValueTask<Response678> Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request678SealedHandler
{
	private ValueTask<Response678> Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request679(long Id) : Mediator.IRequest<Response679>, MediatR.IRequest<Response679>;

public sealed record Response679(long Id);

public sealed partial class Request679TraditionalHandler
	: Mediator.IRequestHandler<Request679, Response679>,
	MediatR.IRequestHandler<Request679, Response679>
{
	ValueTask<Response679> Mediator.IRequestHandler<Request679, Response679>.Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response679> MediatR.IRequestHandler<Request679, Response679>.Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request679StaticHandler
{
	private static ValueTask<Response679> Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request679SealedHandler
{
	private ValueTask<Response679> Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request680(long Id) : Mediator.IRequest<Response680>, MediatR.IRequest<Response680>;

public sealed record Response680(long Id);

public sealed partial class Request680TraditionalHandler
	: Mediator.IRequestHandler<Request680, Response680>,
	MediatR.IRequestHandler<Request680, Response680>
{
	ValueTask<Response680> Mediator.IRequestHandler<Request680, Response680>.Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response680> MediatR.IRequestHandler<Request680, Response680>.Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request680StaticHandler
{
	private static ValueTask<Response680> Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request680SealedHandler
{
	private ValueTask<Response680> Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request681(long Id) : Mediator.IRequest<Response681>, MediatR.IRequest<Response681>;

public sealed record Response681(long Id);

public sealed partial class Request681TraditionalHandler
	: Mediator.IRequestHandler<Request681, Response681>,
	MediatR.IRequestHandler<Request681, Response681>
{
	ValueTask<Response681> Mediator.IRequestHandler<Request681, Response681>.Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response681> MediatR.IRequestHandler<Request681, Response681>.Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request681StaticHandler
{
	private static ValueTask<Response681> Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request681SealedHandler
{
	private ValueTask<Response681> Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request682(long Id) : Mediator.IRequest<Response682>, MediatR.IRequest<Response682>;

public sealed record Response682(long Id);

public sealed partial class Request682TraditionalHandler
	: Mediator.IRequestHandler<Request682, Response682>,
	MediatR.IRequestHandler<Request682, Response682>
{
	ValueTask<Response682> Mediator.IRequestHandler<Request682, Response682>.Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response682> MediatR.IRequestHandler<Request682, Response682>.Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request682StaticHandler
{
	private static ValueTask<Response682> Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request682SealedHandler
{
	private ValueTask<Response682> Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request683(long Id) : Mediator.IRequest<Response683>, MediatR.IRequest<Response683>;

public sealed record Response683(long Id);

public sealed partial class Request683TraditionalHandler
	: Mediator.IRequestHandler<Request683, Response683>,
	MediatR.IRequestHandler<Request683, Response683>
{
	ValueTask<Response683> Mediator.IRequestHandler<Request683, Response683>.Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response683> MediatR.IRequestHandler<Request683, Response683>.Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request683StaticHandler
{
	private static ValueTask<Response683> Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request683SealedHandler
{
	private ValueTask<Response683> Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request684(long Id) : Mediator.IRequest<Response684>, MediatR.IRequest<Response684>;

public sealed record Response684(long Id);

public sealed partial class Request684TraditionalHandler
	: Mediator.IRequestHandler<Request684, Response684>,
	MediatR.IRequestHandler<Request684, Response684>
{
	ValueTask<Response684> Mediator.IRequestHandler<Request684, Response684>.Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response684> MediatR.IRequestHandler<Request684, Response684>.Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request684StaticHandler
{
	private static ValueTask<Response684> Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request684SealedHandler
{
	private ValueTask<Response684> Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request685(long Id) : Mediator.IRequest<Response685>, MediatR.IRequest<Response685>;

public sealed record Response685(long Id);

public sealed partial class Request685TraditionalHandler
	: Mediator.IRequestHandler<Request685, Response685>,
	MediatR.IRequestHandler<Request685, Response685>
{
	ValueTask<Response685> Mediator.IRequestHandler<Request685, Response685>.Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response685> MediatR.IRequestHandler<Request685, Response685>.Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request685StaticHandler
{
	private static ValueTask<Response685> Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request685SealedHandler
{
	private ValueTask<Response685> Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request686(long Id) : Mediator.IRequest<Response686>, MediatR.IRequest<Response686>;

public sealed record Response686(long Id);

public sealed partial class Request686TraditionalHandler
	: Mediator.IRequestHandler<Request686, Response686>,
	MediatR.IRequestHandler<Request686, Response686>
{
	ValueTask<Response686> Mediator.IRequestHandler<Request686, Response686>.Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response686> MediatR.IRequestHandler<Request686, Response686>.Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request686StaticHandler
{
	private static ValueTask<Response686> Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request686SealedHandler
{
	private ValueTask<Response686> Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request687(long Id) : Mediator.IRequest<Response687>, MediatR.IRequest<Response687>;

public sealed record Response687(long Id);

public sealed partial class Request687TraditionalHandler
	: Mediator.IRequestHandler<Request687, Response687>,
	MediatR.IRequestHandler<Request687, Response687>
{
	ValueTask<Response687> Mediator.IRequestHandler<Request687, Response687>.Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response687> MediatR.IRequestHandler<Request687, Response687>.Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request687StaticHandler
{
	private static ValueTask<Response687> Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request687SealedHandler
{
	private ValueTask<Response687> Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request688(long Id) : Mediator.IRequest<Response688>, MediatR.IRequest<Response688>;

public sealed record Response688(long Id);

public sealed partial class Request688TraditionalHandler
	: Mediator.IRequestHandler<Request688, Response688>,
	MediatR.IRequestHandler<Request688, Response688>
{
	ValueTask<Response688> Mediator.IRequestHandler<Request688, Response688>.Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response688> MediatR.IRequestHandler<Request688, Response688>.Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request688StaticHandler
{
	private static ValueTask<Response688> Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request688SealedHandler
{
	private ValueTask<Response688> Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request689(long Id) : Mediator.IRequest<Response689>, MediatR.IRequest<Response689>;

public sealed record Response689(long Id);

public sealed partial class Request689TraditionalHandler
	: Mediator.IRequestHandler<Request689, Response689>,
	MediatR.IRequestHandler<Request689, Response689>
{
	ValueTask<Response689> Mediator.IRequestHandler<Request689, Response689>.Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response689> MediatR.IRequestHandler<Request689, Response689>.Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request689StaticHandler
{
	private static ValueTask<Response689> Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request689SealedHandler
{
	private ValueTask<Response689> Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request690(long Id) : Mediator.IRequest<Response690>, MediatR.IRequest<Response690>;

public sealed record Response690(long Id);

public sealed partial class Request690TraditionalHandler
	: Mediator.IRequestHandler<Request690, Response690>,
	MediatR.IRequestHandler<Request690, Response690>
{
	ValueTask<Response690> Mediator.IRequestHandler<Request690, Response690>.Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response690> MediatR.IRequestHandler<Request690, Response690>.Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request690StaticHandler
{
	private static ValueTask<Response690> Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request690SealedHandler
{
	private ValueTask<Response690> Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request691(long Id) : Mediator.IRequest<Response691>, MediatR.IRequest<Response691>;

public sealed record Response691(long Id);

public sealed partial class Request691TraditionalHandler
	: Mediator.IRequestHandler<Request691, Response691>,
	MediatR.IRequestHandler<Request691, Response691>
{
	ValueTask<Response691> Mediator.IRequestHandler<Request691, Response691>.Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response691> MediatR.IRequestHandler<Request691, Response691>.Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request691StaticHandler
{
	private static ValueTask<Response691> Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request691SealedHandler
{
	private ValueTask<Response691> Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request692(long Id) : Mediator.IRequest<Response692>, MediatR.IRequest<Response692>;

public sealed record Response692(long Id);

public sealed partial class Request692TraditionalHandler
	: Mediator.IRequestHandler<Request692, Response692>,
	MediatR.IRequestHandler<Request692, Response692>
{
	ValueTask<Response692> Mediator.IRequestHandler<Request692, Response692>.Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response692> MediatR.IRequestHandler<Request692, Response692>.Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request692StaticHandler
{
	private static ValueTask<Response692> Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request692SealedHandler
{
	private ValueTask<Response692> Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request693(long Id) : Mediator.IRequest<Response693>, MediatR.IRequest<Response693>;

public sealed record Response693(long Id);

public sealed partial class Request693TraditionalHandler
	: Mediator.IRequestHandler<Request693, Response693>,
	MediatR.IRequestHandler<Request693, Response693>
{
	ValueTask<Response693> Mediator.IRequestHandler<Request693, Response693>.Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response693> MediatR.IRequestHandler<Request693, Response693>.Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request693StaticHandler
{
	private static ValueTask<Response693> Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request693SealedHandler
{
	private ValueTask<Response693> Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request694(long Id) : Mediator.IRequest<Response694>, MediatR.IRequest<Response694>;

public sealed record Response694(long Id);

public sealed partial class Request694TraditionalHandler
	: Mediator.IRequestHandler<Request694, Response694>,
	MediatR.IRequestHandler<Request694, Response694>
{
	ValueTask<Response694> Mediator.IRequestHandler<Request694, Response694>.Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response694> MediatR.IRequestHandler<Request694, Response694>.Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request694StaticHandler
{
	private static ValueTask<Response694> Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request694SealedHandler
{
	private ValueTask<Response694> Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request695(long Id) : Mediator.IRequest<Response695>, MediatR.IRequest<Response695>;

public sealed record Response695(long Id);

public sealed partial class Request695TraditionalHandler
	: Mediator.IRequestHandler<Request695, Response695>,
	MediatR.IRequestHandler<Request695, Response695>
{
	ValueTask<Response695> Mediator.IRequestHandler<Request695, Response695>.Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response695> MediatR.IRequestHandler<Request695, Response695>.Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request695StaticHandler
{
	private static ValueTask<Response695> Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request695SealedHandler
{
	private ValueTask<Response695> Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request696(long Id) : Mediator.IRequest<Response696>, MediatR.IRequest<Response696>;

public sealed record Response696(long Id);

public sealed partial class Request696TraditionalHandler
	: Mediator.IRequestHandler<Request696, Response696>,
	MediatR.IRequestHandler<Request696, Response696>
{
	ValueTask<Response696> Mediator.IRequestHandler<Request696, Response696>.Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response696> MediatR.IRequestHandler<Request696, Response696>.Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request696StaticHandler
{
	private static ValueTask<Response696> Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request696SealedHandler
{
	private ValueTask<Response696> Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request697(long Id) : Mediator.IRequest<Response697>, MediatR.IRequest<Response697>;

public sealed record Response697(long Id);

public sealed partial class Request697TraditionalHandler
	: Mediator.IRequestHandler<Request697, Response697>,
	MediatR.IRequestHandler<Request697, Response697>
{
	ValueTask<Response697> Mediator.IRequestHandler<Request697, Response697>.Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response697> MediatR.IRequestHandler<Request697, Response697>.Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request697StaticHandler
{
	private static ValueTask<Response697> Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request697SealedHandler
{
	private ValueTask<Response697> Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request698(long Id) : Mediator.IRequest<Response698>, MediatR.IRequest<Response698>;

public sealed record Response698(long Id);

public sealed partial class Request698TraditionalHandler
	: Mediator.IRequestHandler<Request698, Response698>,
	MediatR.IRequestHandler<Request698, Response698>
{
	ValueTask<Response698> Mediator.IRequestHandler<Request698, Response698>.Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response698> MediatR.IRequestHandler<Request698, Response698>.Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request698StaticHandler
{
	private static ValueTask<Response698> Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request698SealedHandler
{
	private ValueTask<Response698> Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request699(long Id) : Mediator.IRequest<Response699>, MediatR.IRequest<Response699>;

public sealed record Response699(long Id);

public sealed partial class Request699TraditionalHandler
	: Mediator.IRequestHandler<Request699, Response699>,
	MediatR.IRequestHandler<Request699, Response699>
{
	ValueTask<Response699> Mediator.IRequestHandler<Request699, Response699>.Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response699> MediatR.IRequestHandler<Request699, Response699>.Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request699StaticHandler
{
	private static ValueTask<Response699> Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request699SealedHandler
{
	private ValueTask<Response699> Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request700(long Id) : Mediator.IRequest<Response700>, MediatR.IRequest<Response700>;

public sealed record Response700(long Id);

public sealed partial class Request700TraditionalHandler
	: Mediator.IRequestHandler<Request700, Response700>,
	MediatR.IRequestHandler<Request700, Response700>
{
	ValueTask<Response700> Mediator.IRequestHandler<Request700, Response700>.Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response700> MediatR.IRequestHandler<Request700, Response700>.Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request700StaticHandler
{
	private static ValueTask<Response700> Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request700SealedHandler
{
	private ValueTask<Response700> Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request701(long Id) : Mediator.IRequest<Response701>, MediatR.IRequest<Response701>;

public sealed record Response701(long Id);

public sealed partial class Request701TraditionalHandler
	: Mediator.IRequestHandler<Request701, Response701>,
	MediatR.IRequestHandler<Request701, Response701>
{
	ValueTask<Response701> Mediator.IRequestHandler<Request701, Response701>.Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response701> MediatR.IRequestHandler<Request701, Response701>.Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request701StaticHandler
{
	private static ValueTask<Response701> Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request701SealedHandler
{
	private ValueTask<Response701> Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request702(long Id) : Mediator.IRequest<Response702>, MediatR.IRequest<Response702>;

public sealed record Response702(long Id);

public sealed partial class Request702TraditionalHandler
	: Mediator.IRequestHandler<Request702, Response702>,
	MediatR.IRequestHandler<Request702, Response702>
{
	ValueTask<Response702> Mediator.IRequestHandler<Request702, Response702>.Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response702> MediatR.IRequestHandler<Request702, Response702>.Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request702StaticHandler
{
	private static ValueTask<Response702> Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request702SealedHandler
{
	private ValueTask<Response702> Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request703(long Id) : Mediator.IRequest<Response703>, MediatR.IRequest<Response703>;

public sealed record Response703(long Id);

public sealed partial class Request703TraditionalHandler
	: Mediator.IRequestHandler<Request703, Response703>,
	MediatR.IRequestHandler<Request703, Response703>
{
	ValueTask<Response703> Mediator.IRequestHandler<Request703, Response703>.Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response703> MediatR.IRequestHandler<Request703, Response703>.Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request703StaticHandler
{
	private static ValueTask<Response703> Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request703SealedHandler
{
	private ValueTask<Response703> Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request704(long Id) : Mediator.IRequest<Response704>, MediatR.IRequest<Response704>;

public sealed record Response704(long Id);

public sealed partial class Request704TraditionalHandler
	: Mediator.IRequestHandler<Request704, Response704>,
	MediatR.IRequestHandler<Request704, Response704>
{
	ValueTask<Response704> Mediator.IRequestHandler<Request704, Response704>.Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response704> MediatR.IRequestHandler<Request704, Response704>.Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request704StaticHandler
{
	private static ValueTask<Response704> Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request704SealedHandler
{
	private ValueTask<Response704> Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request705(long Id) : Mediator.IRequest<Response705>, MediatR.IRequest<Response705>;

public sealed record Response705(long Id);

public sealed partial class Request705TraditionalHandler
	: Mediator.IRequestHandler<Request705, Response705>,
	MediatR.IRequestHandler<Request705, Response705>
{
	ValueTask<Response705> Mediator.IRequestHandler<Request705, Response705>.Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response705> MediatR.IRequestHandler<Request705, Response705>.Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request705StaticHandler
{
	private static ValueTask<Response705> Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request705SealedHandler
{
	private ValueTask<Response705> Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request706(long Id) : Mediator.IRequest<Response706>, MediatR.IRequest<Response706>;

public sealed record Response706(long Id);

public sealed partial class Request706TraditionalHandler
	: Mediator.IRequestHandler<Request706, Response706>,
	MediatR.IRequestHandler<Request706, Response706>
{
	ValueTask<Response706> Mediator.IRequestHandler<Request706, Response706>.Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response706> MediatR.IRequestHandler<Request706, Response706>.Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request706StaticHandler
{
	private static ValueTask<Response706> Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request706SealedHandler
{
	private ValueTask<Response706> Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request707(long Id) : Mediator.IRequest<Response707>, MediatR.IRequest<Response707>;

public sealed record Response707(long Id);

public sealed partial class Request707TraditionalHandler
	: Mediator.IRequestHandler<Request707, Response707>,
	MediatR.IRequestHandler<Request707, Response707>
{
	ValueTask<Response707> Mediator.IRequestHandler<Request707, Response707>.Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response707> MediatR.IRequestHandler<Request707, Response707>.Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request707StaticHandler
{
	private static ValueTask<Response707> Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request707SealedHandler
{
	private ValueTask<Response707> Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request708(long Id) : Mediator.IRequest<Response708>, MediatR.IRequest<Response708>;

public sealed record Response708(long Id);

public sealed partial class Request708TraditionalHandler
	: Mediator.IRequestHandler<Request708, Response708>,
	MediatR.IRequestHandler<Request708, Response708>
{
	ValueTask<Response708> Mediator.IRequestHandler<Request708, Response708>.Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response708> MediatR.IRequestHandler<Request708, Response708>.Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request708StaticHandler
{
	private static ValueTask<Response708> Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request708SealedHandler
{
	private ValueTask<Response708> Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request709(long Id) : Mediator.IRequest<Response709>, MediatR.IRequest<Response709>;

public sealed record Response709(long Id);

public sealed partial class Request709TraditionalHandler
	: Mediator.IRequestHandler<Request709, Response709>,
	MediatR.IRequestHandler<Request709, Response709>
{
	ValueTask<Response709> Mediator.IRequestHandler<Request709, Response709>.Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response709> MediatR.IRequestHandler<Request709, Response709>.Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request709StaticHandler
{
	private static ValueTask<Response709> Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request709SealedHandler
{
	private ValueTask<Response709> Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request710(long Id) : Mediator.IRequest<Response710>, MediatR.IRequest<Response710>;

public sealed record Response710(long Id);

public sealed partial class Request710TraditionalHandler
	: Mediator.IRequestHandler<Request710, Response710>,
	MediatR.IRequestHandler<Request710, Response710>
{
	ValueTask<Response710> Mediator.IRequestHandler<Request710, Response710>.Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response710> MediatR.IRequestHandler<Request710, Response710>.Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request710StaticHandler
{
	private static ValueTask<Response710> Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request710SealedHandler
{
	private ValueTask<Response710> Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request711(long Id) : Mediator.IRequest<Response711>, MediatR.IRequest<Response711>;

public sealed record Response711(long Id);

public sealed partial class Request711TraditionalHandler
	: Mediator.IRequestHandler<Request711, Response711>,
	MediatR.IRequestHandler<Request711, Response711>
{
	ValueTask<Response711> Mediator.IRequestHandler<Request711, Response711>.Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response711> MediatR.IRequestHandler<Request711, Response711>.Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request711StaticHandler
{
	private static ValueTask<Response711> Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request711SealedHandler
{
	private ValueTask<Response711> Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request712(long Id) : Mediator.IRequest<Response712>, MediatR.IRequest<Response712>;

public sealed record Response712(long Id);

public sealed partial class Request712TraditionalHandler
	: Mediator.IRequestHandler<Request712, Response712>,
	MediatR.IRequestHandler<Request712, Response712>
{
	ValueTask<Response712> Mediator.IRequestHandler<Request712, Response712>.Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response712> MediatR.IRequestHandler<Request712, Response712>.Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request712StaticHandler
{
	private static ValueTask<Response712> Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request712SealedHandler
{
	private ValueTask<Response712> Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request713(long Id) : Mediator.IRequest<Response713>, MediatR.IRequest<Response713>;

public sealed record Response713(long Id);

public sealed partial class Request713TraditionalHandler
	: Mediator.IRequestHandler<Request713, Response713>,
	MediatR.IRequestHandler<Request713, Response713>
{
	ValueTask<Response713> Mediator.IRequestHandler<Request713, Response713>.Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response713> MediatR.IRequestHandler<Request713, Response713>.Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request713StaticHandler
{
	private static ValueTask<Response713> Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request713SealedHandler
{
	private ValueTask<Response713> Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request714(long Id) : Mediator.IRequest<Response714>, MediatR.IRequest<Response714>;

public sealed record Response714(long Id);

public sealed partial class Request714TraditionalHandler
	: Mediator.IRequestHandler<Request714, Response714>,
	MediatR.IRequestHandler<Request714, Response714>
{
	ValueTask<Response714> Mediator.IRequestHandler<Request714, Response714>.Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response714> MediatR.IRequestHandler<Request714, Response714>.Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request714StaticHandler
{
	private static ValueTask<Response714> Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request714SealedHandler
{
	private ValueTask<Response714> Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request715(long Id) : Mediator.IRequest<Response715>, MediatR.IRequest<Response715>;

public sealed record Response715(long Id);

public sealed partial class Request715TraditionalHandler
	: Mediator.IRequestHandler<Request715, Response715>,
	MediatR.IRequestHandler<Request715, Response715>
{
	ValueTask<Response715> Mediator.IRequestHandler<Request715, Response715>.Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response715> MediatR.IRequestHandler<Request715, Response715>.Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request715StaticHandler
{
	private static ValueTask<Response715> Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request715SealedHandler
{
	private ValueTask<Response715> Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request716(long Id) : Mediator.IRequest<Response716>, MediatR.IRequest<Response716>;

public sealed record Response716(long Id);

public sealed partial class Request716TraditionalHandler
	: Mediator.IRequestHandler<Request716, Response716>,
	MediatR.IRequestHandler<Request716, Response716>
{
	ValueTask<Response716> Mediator.IRequestHandler<Request716, Response716>.Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response716> MediatR.IRequestHandler<Request716, Response716>.Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request716StaticHandler
{
	private static ValueTask<Response716> Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request716SealedHandler
{
	private ValueTask<Response716> Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request717(long Id) : Mediator.IRequest<Response717>, MediatR.IRequest<Response717>;

public sealed record Response717(long Id);

public sealed partial class Request717TraditionalHandler
	: Mediator.IRequestHandler<Request717, Response717>,
	MediatR.IRequestHandler<Request717, Response717>
{
	ValueTask<Response717> Mediator.IRequestHandler<Request717, Response717>.Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response717> MediatR.IRequestHandler<Request717, Response717>.Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request717StaticHandler
{
	private static ValueTask<Response717> Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request717SealedHandler
{
	private ValueTask<Response717> Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request718(long Id) : Mediator.IRequest<Response718>, MediatR.IRequest<Response718>;

public sealed record Response718(long Id);

public sealed partial class Request718TraditionalHandler
	: Mediator.IRequestHandler<Request718, Response718>,
	MediatR.IRequestHandler<Request718, Response718>
{
	ValueTask<Response718> Mediator.IRequestHandler<Request718, Response718>.Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response718> MediatR.IRequestHandler<Request718, Response718>.Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request718StaticHandler
{
	private static ValueTask<Response718> Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request718SealedHandler
{
	private ValueTask<Response718> Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request719(long Id) : Mediator.IRequest<Response719>, MediatR.IRequest<Response719>;

public sealed record Response719(long Id);

public sealed partial class Request719TraditionalHandler
	: Mediator.IRequestHandler<Request719, Response719>,
	MediatR.IRequestHandler<Request719, Response719>
{
	ValueTask<Response719> Mediator.IRequestHandler<Request719, Response719>.Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response719> MediatR.IRequestHandler<Request719, Response719>.Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request719StaticHandler
{
	private static ValueTask<Response719> Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request719SealedHandler
{
	private ValueTask<Response719> Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request720(long Id) : Mediator.IRequest<Response720>, MediatR.IRequest<Response720>;

public sealed record Response720(long Id);

public sealed partial class Request720TraditionalHandler
	: Mediator.IRequestHandler<Request720, Response720>,
	MediatR.IRequestHandler<Request720, Response720>
{
	ValueTask<Response720> Mediator.IRequestHandler<Request720, Response720>.Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response720> MediatR.IRequestHandler<Request720, Response720>.Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request720StaticHandler
{
	private static ValueTask<Response720> Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request720SealedHandler
{
	private ValueTask<Response720> Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request721(long Id) : Mediator.IRequest<Response721>, MediatR.IRequest<Response721>;

public sealed record Response721(long Id);

public sealed partial class Request721TraditionalHandler
	: Mediator.IRequestHandler<Request721, Response721>,
	MediatR.IRequestHandler<Request721, Response721>
{
	ValueTask<Response721> Mediator.IRequestHandler<Request721, Response721>.Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response721> MediatR.IRequestHandler<Request721, Response721>.Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request721StaticHandler
{
	private static ValueTask<Response721> Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request721SealedHandler
{
	private ValueTask<Response721> Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request722(long Id) : Mediator.IRequest<Response722>, MediatR.IRequest<Response722>;

public sealed record Response722(long Id);

public sealed partial class Request722TraditionalHandler
	: Mediator.IRequestHandler<Request722, Response722>,
	MediatR.IRequestHandler<Request722, Response722>
{
	ValueTask<Response722> Mediator.IRequestHandler<Request722, Response722>.Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response722> MediatR.IRequestHandler<Request722, Response722>.Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request722StaticHandler
{
	private static ValueTask<Response722> Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request722SealedHandler
{
	private ValueTask<Response722> Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request723(long Id) : Mediator.IRequest<Response723>, MediatR.IRequest<Response723>;

public sealed record Response723(long Id);

public sealed partial class Request723TraditionalHandler
	: Mediator.IRequestHandler<Request723, Response723>,
	MediatR.IRequestHandler<Request723, Response723>
{
	ValueTask<Response723> Mediator.IRequestHandler<Request723, Response723>.Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response723> MediatR.IRequestHandler<Request723, Response723>.Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request723StaticHandler
{
	private static ValueTask<Response723> Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request723SealedHandler
{
	private ValueTask<Response723> Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request724(long Id) : Mediator.IRequest<Response724>, MediatR.IRequest<Response724>;

public sealed record Response724(long Id);

public sealed partial class Request724TraditionalHandler
	: Mediator.IRequestHandler<Request724, Response724>,
	MediatR.IRequestHandler<Request724, Response724>
{
	ValueTask<Response724> Mediator.IRequestHandler<Request724, Response724>.Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response724> MediatR.IRequestHandler<Request724, Response724>.Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request724StaticHandler
{
	private static ValueTask<Response724> Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request724SealedHandler
{
	private ValueTask<Response724> Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request725(long Id) : Mediator.IRequest<Response725>, MediatR.IRequest<Response725>;

public sealed record Response725(long Id);

public sealed partial class Request725TraditionalHandler
	: Mediator.IRequestHandler<Request725, Response725>,
	MediatR.IRequestHandler<Request725, Response725>
{
	ValueTask<Response725> Mediator.IRequestHandler<Request725, Response725>.Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response725> MediatR.IRequestHandler<Request725, Response725>.Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request725StaticHandler
{
	private static ValueTask<Response725> Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request725SealedHandler
{
	private ValueTask<Response725> Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request726(long Id) : Mediator.IRequest<Response726>, MediatR.IRequest<Response726>;

public sealed record Response726(long Id);

public sealed partial class Request726TraditionalHandler
	: Mediator.IRequestHandler<Request726, Response726>,
	MediatR.IRequestHandler<Request726, Response726>
{
	ValueTask<Response726> Mediator.IRequestHandler<Request726, Response726>.Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response726> MediatR.IRequestHandler<Request726, Response726>.Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request726StaticHandler
{
	private static ValueTask<Response726> Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request726SealedHandler
{
	private ValueTask<Response726> Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request727(long Id) : Mediator.IRequest<Response727>, MediatR.IRequest<Response727>;

public sealed record Response727(long Id);

public sealed partial class Request727TraditionalHandler
	: Mediator.IRequestHandler<Request727, Response727>,
	MediatR.IRequestHandler<Request727, Response727>
{
	ValueTask<Response727> Mediator.IRequestHandler<Request727, Response727>.Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response727> MediatR.IRequestHandler<Request727, Response727>.Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request727StaticHandler
{
	private static ValueTask<Response727> Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request727SealedHandler
{
	private ValueTask<Response727> Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request728(long Id) : Mediator.IRequest<Response728>, MediatR.IRequest<Response728>;

public sealed record Response728(long Id);

public sealed partial class Request728TraditionalHandler
	: Mediator.IRequestHandler<Request728, Response728>,
	MediatR.IRequestHandler<Request728, Response728>
{
	ValueTask<Response728> Mediator.IRequestHandler<Request728, Response728>.Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response728> MediatR.IRequestHandler<Request728, Response728>.Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request728StaticHandler
{
	private static ValueTask<Response728> Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request728SealedHandler
{
	private ValueTask<Response728> Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request729(long Id) : Mediator.IRequest<Response729>, MediatR.IRequest<Response729>;

public sealed record Response729(long Id);

public sealed partial class Request729TraditionalHandler
	: Mediator.IRequestHandler<Request729, Response729>,
	MediatR.IRequestHandler<Request729, Response729>
{
	ValueTask<Response729> Mediator.IRequestHandler<Request729, Response729>.Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response729> MediatR.IRequestHandler<Request729, Response729>.Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request729StaticHandler
{
	private static ValueTask<Response729> Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request729SealedHandler
{
	private ValueTask<Response729> Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request730(long Id) : Mediator.IRequest<Response730>, MediatR.IRequest<Response730>;

public sealed record Response730(long Id);

public sealed partial class Request730TraditionalHandler
	: Mediator.IRequestHandler<Request730, Response730>,
	MediatR.IRequestHandler<Request730, Response730>
{
	ValueTask<Response730> Mediator.IRequestHandler<Request730, Response730>.Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response730> MediatR.IRequestHandler<Request730, Response730>.Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request730StaticHandler
{
	private static ValueTask<Response730> Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request730SealedHandler
{
	private ValueTask<Response730> Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request731(long Id) : Mediator.IRequest<Response731>, MediatR.IRequest<Response731>;

public sealed record Response731(long Id);

public sealed partial class Request731TraditionalHandler
	: Mediator.IRequestHandler<Request731, Response731>,
	MediatR.IRequestHandler<Request731, Response731>
{
	ValueTask<Response731> Mediator.IRequestHandler<Request731, Response731>.Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response731> MediatR.IRequestHandler<Request731, Response731>.Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request731StaticHandler
{
	private static ValueTask<Response731> Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request731SealedHandler
{
	private ValueTask<Response731> Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request732(long Id) : Mediator.IRequest<Response732>, MediatR.IRequest<Response732>;

public sealed record Response732(long Id);

public sealed partial class Request732TraditionalHandler
	: Mediator.IRequestHandler<Request732, Response732>,
	MediatR.IRequestHandler<Request732, Response732>
{
	ValueTask<Response732> Mediator.IRequestHandler<Request732, Response732>.Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response732> MediatR.IRequestHandler<Request732, Response732>.Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request732StaticHandler
{
	private static ValueTask<Response732> Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request732SealedHandler
{
	private ValueTask<Response732> Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request733(long Id) : Mediator.IRequest<Response733>, MediatR.IRequest<Response733>;

public sealed record Response733(long Id);

public sealed partial class Request733TraditionalHandler
	: Mediator.IRequestHandler<Request733, Response733>,
	MediatR.IRequestHandler<Request733, Response733>
{
	ValueTask<Response733> Mediator.IRequestHandler<Request733, Response733>.Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response733> MediatR.IRequestHandler<Request733, Response733>.Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request733StaticHandler
{
	private static ValueTask<Response733> Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request733SealedHandler
{
	private ValueTask<Response733> Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request734(long Id) : Mediator.IRequest<Response734>, MediatR.IRequest<Response734>;

public sealed record Response734(long Id);

public sealed partial class Request734TraditionalHandler
	: Mediator.IRequestHandler<Request734, Response734>,
	MediatR.IRequestHandler<Request734, Response734>
{
	ValueTask<Response734> Mediator.IRequestHandler<Request734, Response734>.Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response734> MediatR.IRequestHandler<Request734, Response734>.Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request734StaticHandler
{
	private static ValueTask<Response734> Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request734SealedHandler
{
	private ValueTask<Response734> Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request735(long Id) : Mediator.IRequest<Response735>, MediatR.IRequest<Response735>;

public sealed record Response735(long Id);

public sealed partial class Request735TraditionalHandler
	: Mediator.IRequestHandler<Request735, Response735>,
	MediatR.IRequestHandler<Request735, Response735>
{
	ValueTask<Response735> Mediator.IRequestHandler<Request735, Response735>.Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response735> MediatR.IRequestHandler<Request735, Response735>.Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request735StaticHandler
{
	private static ValueTask<Response735> Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request735SealedHandler
{
	private ValueTask<Response735> Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request736(long Id) : Mediator.IRequest<Response736>, MediatR.IRequest<Response736>;

public sealed record Response736(long Id);

public sealed partial class Request736TraditionalHandler
	: Mediator.IRequestHandler<Request736, Response736>,
	MediatR.IRequestHandler<Request736, Response736>
{
	ValueTask<Response736> Mediator.IRequestHandler<Request736, Response736>.Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response736> MediatR.IRequestHandler<Request736, Response736>.Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request736StaticHandler
{
	private static ValueTask<Response736> Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request736SealedHandler
{
	private ValueTask<Response736> Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request737(long Id) : Mediator.IRequest<Response737>, MediatR.IRequest<Response737>;

public sealed record Response737(long Id);

public sealed partial class Request737TraditionalHandler
	: Mediator.IRequestHandler<Request737, Response737>,
	MediatR.IRequestHandler<Request737, Response737>
{
	ValueTask<Response737> Mediator.IRequestHandler<Request737, Response737>.Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response737> MediatR.IRequestHandler<Request737, Response737>.Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request737StaticHandler
{
	private static ValueTask<Response737> Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request737SealedHandler
{
	private ValueTask<Response737> Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request738(long Id) : Mediator.IRequest<Response738>, MediatR.IRequest<Response738>;

public sealed record Response738(long Id);

public sealed partial class Request738TraditionalHandler
	: Mediator.IRequestHandler<Request738, Response738>,
	MediatR.IRequestHandler<Request738, Response738>
{
	ValueTask<Response738> Mediator.IRequestHandler<Request738, Response738>.Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response738> MediatR.IRequestHandler<Request738, Response738>.Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request738StaticHandler
{
	private static ValueTask<Response738> Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request738SealedHandler
{
	private ValueTask<Response738> Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request739(long Id) : Mediator.IRequest<Response739>, MediatR.IRequest<Response739>;

public sealed record Response739(long Id);

public sealed partial class Request739TraditionalHandler
	: Mediator.IRequestHandler<Request739, Response739>,
	MediatR.IRequestHandler<Request739, Response739>
{
	ValueTask<Response739> Mediator.IRequestHandler<Request739, Response739>.Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response739> MediatR.IRequestHandler<Request739, Response739>.Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request739StaticHandler
{
	private static ValueTask<Response739> Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request739SealedHandler
{
	private ValueTask<Response739> Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request740(long Id) : Mediator.IRequest<Response740>, MediatR.IRequest<Response740>;

public sealed record Response740(long Id);

public sealed partial class Request740TraditionalHandler
	: Mediator.IRequestHandler<Request740, Response740>,
	MediatR.IRequestHandler<Request740, Response740>
{
	ValueTask<Response740> Mediator.IRequestHandler<Request740, Response740>.Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response740> MediatR.IRequestHandler<Request740, Response740>.Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request740StaticHandler
{
	private static ValueTask<Response740> Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request740SealedHandler
{
	private ValueTask<Response740> Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request741(long Id) : Mediator.IRequest<Response741>, MediatR.IRequest<Response741>;

public sealed record Response741(long Id);

public sealed partial class Request741TraditionalHandler
	: Mediator.IRequestHandler<Request741, Response741>,
	MediatR.IRequestHandler<Request741, Response741>
{
	ValueTask<Response741> Mediator.IRequestHandler<Request741, Response741>.Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response741> MediatR.IRequestHandler<Request741, Response741>.Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request741StaticHandler
{
	private static ValueTask<Response741> Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request741SealedHandler
{
	private ValueTask<Response741> Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request742(long Id) : Mediator.IRequest<Response742>, MediatR.IRequest<Response742>;

public sealed record Response742(long Id);

public sealed partial class Request742TraditionalHandler
	: Mediator.IRequestHandler<Request742, Response742>,
	MediatR.IRequestHandler<Request742, Response742>
{
	ValueTask<Response742> Mediator.IRequestHandler<Request742, Response742>.Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response742> MediatR.IRequestHandler<Request742, Response742>.Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request742StaticHandler
{
	private static ValueTask<Response742> Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request742SealedHandler
{
	private ValueTask<Response742> Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request743(long Id) : Mediator.IRequest<Response743>, MediatR.IRequest<Response743>;

public sealed record Response743(long Id);

public sealed partial class Request743TraditionalHandler
	: Mediator.IRequestHandler<Request743, Response743>,
	MediatR.IRequestHandler<Request743, Response743>
{
	ValueTask<Response743> Mediator.IRequestHandler<Request743, Response743>.Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response743> MediatR.IRequestHandler<Request743, Response743>.Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request743StaticHandler
{
	private static ValueTask<Response743> Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request743SealedHandler
{
	private ValueTask<Response743> Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request744(long Id) : Mediator.IRequest<Response744>, MediatR.IRequest<Response744>;

public sealed record Response744(long Id);

public sealed partial class Request744TraditionalHandler
	: Mediator.IRequestHandler<Request744, Response744>,
	MediatR.IRequestHandler<Request744, Response744>
{
	ValueTask<Response744> Mediator.IRequestHandler<Request744, Response744>.Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response744> MediatR.IRequestHandler<Request744, Response744>.Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request744StaticHandler
{
	private static ValueTask<Response744> Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request744SealedHandler
{
	private ValueTask<Response744> Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request745(long Id) : Mediator.IRequest<Response745>, MediatR.IRequest<Response745>;

public sealed record Response745(long Id);

public sealed partial class Request745TraditionalHandler
	: Mediator.IRequestHandler<Request745, Response745>,
	MediatR.IRequestHandler<Request745, Response745>
{
	ValueTask<Response745> Mediator.IRequestHandler<Request745, Response745>.Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response745> MediatR.IRequestHandler<Request745, Response745>.Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request745StaticHandler
{
	private static ValueTask<Response745> Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request745SealedHandler
{
	private ValueTask<Response745> Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request746(long Id) : Mediator.IRequest<Response746>, MediatR.IRequest<Response746>;

public sealed record Response746(long Id);

public sealed partial class Request746TraditionalHandler
	: Mediator.IRequestHandler<Request746, Response746>,
	MediatR.IRequestHandler<Request746, Response746>
{
	ValueTask<Response746> Mediator.IRequestHandler<Request746, Response746>.Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response746> MediatR.IRequestHandler<Request746, Response746>.Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request746StaticHandler
{
	private static ValueTask<Response746> Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request746SealedHandler
{
	private ValueTask<Response746> Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request747(long Id) : Mediator.IRequest<Response747>, MediatR.IRequest<Response747>;

public sealed record Response747(long Id);

public sealed partial class Request747TraditionalHandler
	: Mediator.IRequestHandler<Request747, Response747>,
	MediatR.IRequestHandler<Request747, Response747>
{
	ValueTask<Response747> Mediator.IRequestHandler<Request747, Response747>.Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response747> MediatR.IRequestHandler<Request747, Response747>.Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request747StaticHandler
{
	private static ValueTask<Response747> Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request747SealedHandler
{
	private ValueTask<Response747> Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request748(long Id) : Mediator.IRequest<Response748>, MediatR.IRequest<Response748>;

public sealed record Response748(long Id);

public sealed partial class Request748TraditionalHandler
	: Mediator.IRequestHandler<Request748, Response748>,
	MediatR.IRequestHandler<Request748, Response748>
{
	ValueTask<Response748> Mediator.IRequestHandler<Request748, Response748>.Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response748> MediatR.IRequestHandler<Request748, Response748>.Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request748StaticHandler
{
	private static ValueTask<Response748> Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request748SealedHandler
{
	private ValueTask<Response748> Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request749(long Id) : Mediator.IRequest<Response749>, MediatR.IRequest<Response749>;

public sealed record Response749(long Id);

public sealed partial class Request749TraditionalHandler
	: Mediator.IRequestHandler<Request749, Response749>,
	MediatR.IRequestHandler<Request749, Response749>
{
	ValueTask<Response749> Mediator.IRequestHandler<Request749, Response749>.Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response749> MediatR.IRequestHandler<Request749, Response749>.Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request749StaticHandler
{
	private static ValueTask<Response749> Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request749SealedHandler
{
	private ValueTask<Response749> Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request750(long Id) : Mediator.IRequest<Response750>, MediatR.IRequest<Response750>;

public sealed record Response750(long Id);

public sealed partial class Request750TraditionalHandler
	: Mediator.IRequestHandler<Request750, Response750>,
	MediatR.IRequestHandler<Request750, Response750>
{
	ValueTask<Response750> Mediator.IRequestHandler<Request750, Response750>.Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response750> MediatR.IRequestHandler<Request750, Response750>.Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request750StaticHandler
{
	private static ValueTask<Response750> Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request750SealedHandler
{
	private ValueTask<Response750> Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request751(long Id) : Mediator.IRequest<Response751>, MediatR.IRequest<Response751>;

public sealed record Response751(long Id);

public sealed partial class Request751TraditionalHandler
	: Mediator.IRequestHandler<Request751, Response751>,
	MediatR.IRequestHandler<Request751, Response751>
{
	ValueTask<Response751> Mediator.IRequestHandler<Request751, Response751>.Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response751> MediatR.IRequestHandler<Request751, Response751>.Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request751StaticHandler
{
	private static ValueTask<Response751> Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request751SealedHandler
{
	private ValueTask<Response751> Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request752(long Id) : Mediator.IRequest<Response752>, MediatR.IRequest<Response752>;

public sealed record Response752(long Id);

public sealed partial class Request752TraditionalHandler
	: Mediator.IRequestHandler<Request752, Response752>,
	MediatR.IRequestHandler<Request752, Response752>
{
	ValueTask<Response752> Mediator.IRequestHandler<Request752, Response752>.Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response752> MediatR.IRequestHandler<Request752, Response752>.Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request752StaticHandler
{
	private static ValueTask<Response752> Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request752SealedHandler
{
	private ValueTask<Response752> Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request753(long Id) : Mediator.IRequest<Response753>, MediatR.IRequest<Response753>;

public sealed record Response753(long Id);

public sealed partial class Request753TraditionalHandler
	: Mediator.IRequestHandler<Request753, Response753>,
	MediatR.IRequestHandler<Request753, Response753>
{
	ValueTask<Response753> Mediator.IRequestHandler<Request753, Response753>.Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response753> MediatR.IRequestHandler<Request753, Response753>.Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request753StaticHandler
{
	private static ValueTask<Response753> Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request753SealedHandler
{
	private ValueTask<Response753> Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request754(long Id) : Mediator.IRequest<Response754>, MediatR.IRequest<Response754>;

public sealed record Response754(long Id);

public sealed partial class Request754TraditionalHandler
	: Mediator.IRequestHandler<Request754, Response754>,
	MediatR.IRequestHandler<Request754, Response754>
{
	ValueTask<Response754> Mediator.IRequestHandler<Request754, Response754>.Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response754> MediatR.IRequestHandler<Request754, Response754>.Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request754StaticHandler
{
	private static ValueTask<Response754> Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request754SealedHandler
{
	private ValueTask<Response754> Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request755(long Id) : Mediator.IRequest<Response755>, MediatR.IRequest<Response755>;

public sealed record Response755(long Id);

public sealed partial class Request755TraditionalHandler
	: Mediator.IRequestHandler<Request755, Response755>,
	MediatR.IRequestHandler<Request755, Response755>
{
	ValueTask<Response755> Mediator.IRequestHandler<Request755, Response755>.Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response755> MediatR.IRequestHandler<Request755, Response755>.Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request755StaticHandler
{
	private static ValueTask<Response755> Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request755SealedHandler
{
	private ValueTask<Response755> Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request756(long Id) : Mediator.IRequest<Response756>, MediatR.IRequest<Response756>;

public sealed record Response756(long Id);

public sealed partial class Request756TraditionalHandler
	: Mediator.IRequestHandler<Request756, Response756>,
	MediatR.IRequestHandler<Request756, Response756>
{
	ValueTask<Response756> Mediator.IRequestHandler<Request756, Response756>.Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response756> MediatR.IRequestHandler<Request756, Response756>.Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request756StaticHandler
{
	private static ValueTask<Response756> Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request756SealedHandler
{
	private ValueTask<Response756> Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request757(long Id) : Mediator.IRequest<Response757>, MediatR.IRequest<Response757>;

public sealed record Response757(long Id);

public sealed partial class Request757TraditionalHandler
	: Mediator.IRequestHandler<Request757, Response757>,
	MediatR.IRequestHandler<Request757, Response757>
{
	ValueTask<Response757> Mediator.IRequestHandler<Request757, Response757>.Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response757> MediatR.IRequestHandler<Request757, Response757>.Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request757StaticHandler
{
	private static ValueTask<Response757> Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request757SealedHandler
{
	private ValueTask<Response757> Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request758(long Id) : Mediator.IRequest<Response758>, MediatR.IRequest<Response758>;

public sealed record Response758(long Id);

public sealed partial class Request758TraditionalHandler
	: Mediator.IRequestHandler<Request758, Response758>,
	MediatR.IRequestHandler<Request758, Response758>
{
	ValueTask<Response758> Mediator.IRequestHandler<Request758, Response758>.Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response758> MediatR.IRequestHandler<Request758, Response758>.Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request758StaticHandler
{
	private static ValueTask<Response758> Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request758SealedHandler
{
	private ValueTask<Response758> Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request759(long Id) : Mediator.IRequest<Response759>, MediatR.IRequest<Response759>;

public sealed record Response759(long Id);

public sealed partial class Request759TraditionalHandler
	: Mediator.IRequestHandler<Request759, Response759>,
	MediatR.IRequestHandler<Request759, Response759>
{
	ValueTask<Response759> Mediator.IRequestHandler<Request759, Response759>.Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response759> MediatR.IRequestHandler<Request759, Response759>.Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request759StaticHandler
{
	private static ValueTask<Response759> Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request759SealedHandler
{
	private ValueTask<Response759> Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request760(long Id) : Mediator.IRequest<Response760>, MediatR.IRequest<Response760>;

public sealed record Response760(long Id);

public sealed partial class Request760TraditionalHandler
	: Mediator.IRequestHandler<Request760, Response760>,
	MediatR.IRequestHandler<Request760, Response760>
{
	ValueTask<Response760> Mediator.IRequestHandler<Request760, Response760>.Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response760> MediatR.IRequestHandler<Request760, Response760>.Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request760StaticHandler
{
	private static ValueTask<Response760> Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request760SealedHandler
{
	private ValueTask<Response760> Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request761(long Id) : Mediator.IRequest<Response761>, MediatR.IRequest<Response761>;

public sealed record Response761(long Id);

public sealed partial class Request761TraditionalHandler
	: Mediator.IRequestHandler<Request761, Response761>,
	MediatR.IRequestHandler<Request761, Response761>
{
	ValueTask<Response761> Mediator.IRequestHandler<Request761, Response761>.Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response761> MediatR.IRequestHandler<Request761, Response761>.Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request761StaticHandler
{
	private static ValueTask<Response761> Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request761SealedHandler
{
	private ValueTask<Response761> Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request762(long Id) : Mediator.IRequest<Response762>, MediatR.IRequest<Response762>;

public sealed record Response762(long Id);

public sealed partial class Request762TraditionalHandler
	: Mediator.IRequestHandler<Request762, Response762>,
	MediatR.IRequestHandler<Request762, Response762>
{
	ValueTask<Response762> Mediator.IRequestHandler<Request762, Response762>.Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response762> MediatR.IRequestHandler<Request762, Response762>.Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request762StaticHandler
{
	private static ValueTask<Response762> Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request762SealedHandler
{
	private ValueTask<Response762> Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request763(long Id) : Mediator.IRequest<Response763>, MediatR.IRequest<Response763>;

public sealed record Response763(long Id);

public sealed partial class Request763TraditionalHandler
	: Mediator.IRequestHandler<Request763, Response763>,
	MediatR.IRequestHandler<Request763, Response763>
{
	ValueTask<Response763> Mediator.IRequestHandler<Request763, Response763>.Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response763> MediatR.IRequestHandler<Request763, Response763>.Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request763StaticHandler
{
	private static ValueTask<Response763> Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request763SealedHandler
{
	private ValueTask<Response763> Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request764(long Id) : Mediator.IRequest<Response764>, MediatR.IRequest<Response764>;

public sealed record Response764(long Id);

public sealed partial class Request764TraditionalHandler
	: Mediator.IRequestHandler<Request764, Response764>,
	MediatR.IRequestHandler<Request764, Response764>
{
	ValueTask<Response764> Mediator.IRequestHandler<Request764, Response764>.Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response764> MediatR.IRequestHandler<Request764, Response764>.Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request764StaticHandler
{
	private static ValueTask<Response764> Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request764SealedHandler
{
	private ValueTask<Response764> Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request765(long Id) : Mediator.IRequest<Response765>, MediatR.IRequest<Response765>;

public sealed record Response765(long Id);

public sealed partial class Request765TraditionalHandler
	: Mediator.IRequestHandler<Request765, Response765>,
	MediatR.IRequestHandler<Request765, Response765>
{
	ValueTask<Response765> Mediator.IRequestHandler<Request765, Response765>.Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response765> MediatR.IRequestHandler<Request765, Response765>.Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request765StaticHandler
{
	private static ValueTask<Response765> Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request765SealedHandler
{
	private ValueTask<Response765> Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request766(long Id) : Mediator.IRequest<Response766>, MediatR.IRequest<Response766>;

public sealed record Response766(long Id);

public sealed partial class Request766TraditionalHandler
	: Mediator.IRequestHandler<Request766, Response766>,
	MediatR.IRequestHandler<Request766, Response766>
{
	ValueTask<Response766> Mediator.IRequestHandler<Request766, Response766>.Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response766> MediatR.IRequestHandler<Request766, Response766>.Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request766StaticHandler
{
	private static ValueTask<Response766> Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request766SealedHandler
{
	private ValueTask<Response766> Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request767(long Id) : Mediator.IRequest<Response767>, MediatR.IRequest<Response767>;

public sealed record Response767(long Id);

public sealed partial class Request767TraditionalHandler
	: Mediator.IRequestHandler<Request767, Response767>,
	MediatR.IRequestHandler<Request767, Response767>
{
	ValueTask<Response767> Mediator.IRequestHandler<Request767, Response767>.Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response767> MediatR.IRequestHandler<Request767, Response767>.Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request767StaticHandler
{
	private static ValueTask<Response767> Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request767SealedHandler
{
	private ValueTask<Response767> Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request768(long Id) : Mediator.IRequest<Response768>, MediatR.IRequest<Response768>;

public sealed record Response768(long Id);

public sealed partial class Request768TraditionalHandler
	: Mediator.IRequestHandler<Request768, Response768>,
	MediatR.IRequestHandler<Request768, Response768>
{
	ValueTask<Response768> Mediator.IRequestHandler<Request768, Response768>.Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response768> MediatR.IRequestHandler<Request768, Response768>.Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request768StaticHandler
{
	private static ValueTask<Response768> Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request768SealedHandler
{
	private ValueTask<Response768> Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request769(long Id) : Mediator.IRequest<Response769>, MediatR.IRequest<Response769>;

public sealed record Response769(long Id);

public sealed partial class Request769TraditionalHandler
	: Mediator.IRequestHandler<Request769, Response769>,
	MediatR.IRequestHandler<Request769, Response769>
{
	ValueTask<Response769> Mediator.IRequestHandler<Request769, Response769>.Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response769> MediatR.IRequestHandler<Request769, Response769>.Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request769StaticHandler
{
	private static ValueTask<Response769> Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request769SealedHandler
{
	private ValueTask<Response769> Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request770(long Id) : Mediator.IRequest<Response770>, MediatR.IRequest<Response770>;

public sealed record Response770(long Id);

public sealed partial class Request770TraditionalHandler
	: Mediator.IRequestHandler<Request770, Response770>,
	MediatR.IRequestHandler<Request770, Response770>
{
	ValueTask<Response770> Mediator.IRequestHandler<Request770, Response770>.Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response770> MediatR.IRequestHandler<Request770, Response770>.Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request770StaticHandler
{
	private static ValueTask<Response770> Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request770SealedHandler
{
	private ValueTask<Response770> Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request771(long Id) : Mediator.IRequest<Response771>, MediatR.IRequest<Response771>;

public sealed record Response771(long Id);

public sealed partial class Request771TraditionalHandler
	: Mediator.IRequestHandler<Request771, Response771>,
	MediatR.IRequestHandler<Request771, Response771>
{
	ValueTask<Response771> Mediator.IRequestHandler<Request771, Response771>.Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response771> MediatR.IRequestHandler<Request771, Response771>.Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request771StaticHandler
{
	private static ValueTask<Response771> Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request771SealedHandler
{
	private ValueTask<Response771> Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request772(long Id) : Mediator.IRequest<Response772>, MediatR.IRequest<Response772>;

public sealed record Response772(long Id);

public sealed partial class Request772TraditionalHandler
	: Mediator.IRequestHandler<Request772, Response772>,
	MediatR.IRequestHandler<Request772, Response772>
{
	ValueTask<Response772> Mediator.IRequestHandler<Request772, Response772>.Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response772> MediatR.IRequestHandler<Request772, Response772>.Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request772StaticHandler
{
	private static ValueTask<Response772> Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request772SealedHandler
{
	private ValueTask<Response772> Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request773(long Id) : Mediator.IRequest<Response773>, MediatR.IRequest<Response773>;

public sealed record Response773(long Id);

public sealed partial class Request773TraditionalHandler
	: Mediator.IRequestHandler<Request773, Response773>,
	MediatR.IRequestHandler<Request773, Response773>
{
	ValueTask<Response773> Mediator.IRequestHandler<Request773, Response773>.Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response773> MediatR.IRequestHandler<Request773, Response773>.Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request773StaticHandler
{
	private static ValueTask<Response773> Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request773SealedHandler
{
	private ValueTask<Response773> Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request774(long Id) : Mediator.IRequest<Response774>, MediatR.IRequest<Response774>;

public sealed record Response774(long Id);

public sealed partial class Request774TraditionalHandler
	: Mediator.IRequestHandler<Request774, Response774>,
	MediatR.IRequestHandler<Request774, Response774>
{
	ValueTask<Response774> Mediator.IRequestHandler<Request774, Response774>.Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response774> MediatR.IRequestHandler<Request774, Response774>.Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request774StaticHandler
{
	private static ValueTask<Response774> Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request774SealedHandler
{
	private ValueTask<Response774> Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request775(long Id) : Mediator.IRequest<Response775>, MediatR.IRequest<Response775>;

public sealed record Response775(long Id);

public sealed partial class Request775TraditionalHandler
	: Mediator.IRequestHandler<Request775, Response775>,
	MediatR.IRequestHandler<Request775, Response775>
{
	ValueTask<Response775> Mediator.IRequestHandler<Request775, Response775>.Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response775> MediatR.IRequestHandler<Request775, Response775>.Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request775StaticHandler
{
	private static ValueTask<Response775> Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request775SealedHandler
{
	private ValueTask<Response775> Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request776(long Id) : Mediator.IRequest<Response776>, MediatR.IRequest<Response776>;

public sealed record Response776(long Id);

public sealed partial class Request776TraditionalHandler
	: Mediator.IRequestHandler<Request776, Response776>,
	MediatR.IRequestHandler<Request776, Response776>
{
	ValueTask<Response776> Mediator.IRequestHandler<Request776, Response776>.Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response776> MediatR.IRequestHandler<Request776, Response776>.Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request776StaticHandler
{
	private static ValueTask<Response776> Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request776SealedHandler
{
	private ValueTask<Response776> Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request777(long Id) : Mediator.IRequest<Response777>, MediatR.IRequest<Response777>;

public sealed record Response777(long Id);

public sealed partial class Request777TraditionalHandler
	: Mediator.IRequestHandler<Request777, Response777>,
	MediatR.IRequestHandler<Request777, Response777>
{
	ValueTask<Response777> Mediator.IRequestHandler<Request777, Response777>.Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response777> MediatR.IRequestHandler<Request777, Response777>.Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request777StaticHandler
{
	private static ValueTask<Response777> Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request777SealedHandler
{
	private ValueTask<Response777> Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request778(long Id) : Mediator.IRequest<Response778>, MediatR.IRequest<Response778>;

public sealed record Response778(long Id);

public sealed partial class Request778TraditionalHandler
	: Mediator.IRequestHandler<Request778, Response778>,
	MediatR.IRequestHandler<Request778, Response778>
{
	ValueTask<Response778> Mediator.IRequestHandler<Request778, Response778>.Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response778> MediatR.IRequestHandler<Request778, Response778>.Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request778StaticHandler
{
	private static ValueTask<Response778> Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request778SealedHandler
{
	private ValueTask<Response778> Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request779(long Id) : Mediator.IRequest<Response779>, MediatR.IRequest<Response779>;

public sealed record Response779(long Id);

public sealed partial class Request779TraditionalHandler
	: Mediator.IRequestHandler<Request779, Response779>,
	MediatR.IRequestHandler<Request779, Response779>
{
	ValueTask<Response779> Mediator.IRequestHandler<Request779, Response779>.Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response779> MediatR.IRequestHandler<Request779, Response779>.Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request779StaticHandler
{
	private static ValueTask<Response779> Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request779SealedHandler
{
	private ValueTask<Response779> Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request780(long Id) : Mediator.IRequest<Response780>, MediatR.IRequest<Response780>;

public sealed record Response780(long Id);

public sealed partial class Request780TraditionalHandler
	: Mediator.IRequestHandler<Request780, Response780>,
	MediatR.IRequestHandler<Request780, Response780>
{
	ValueTask<Response780> Mediator.IRequestHandler<Request780, Response780>.Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response780> MediatR.IRequestHandler<Request780, Response780>.Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request780StaticHandler
{
	private static ValueTask<Response780> Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request780SealedHandler
{
	private ValueTask<Response780> Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request781(long Id) : Mediator.IRequest<Response781>, MediatR.IRequest<Response781>;

public sealed record Response781(long Id);

public sealed partial class Request781TraditionalHandler
	: Mediator.IRequestHandler<Request781, Response781>,
	MediatR.IRequestHandler<Request781, Response781>
{
	ValueTask<Response781> Mediator.IRequestHandler<Request781, Response781>.Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response781> MediatR.IRequestHandler<Request781, Response781>.Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request781StaticHandler
{
	private static ValueTask<Response781> Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request781SealedHandler
{
	private ValueTask<Response781> Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request782(long Id) : Mediator.IRequest<Response782>, MediatR.IRequest<Response782>;

public sealed record Response782(long Id);

public sealed partial class Request782TraditionalHandler
	: Mediator.IRequestHandler<Request782, Response782>,
	MediatR.IRequestHandler<Request782, Response782>
{
	ValueTask<Response782> Mediator.IRequestHandler<Request782, Response782>.Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response782> MediatR.IRequestHandler<Request782, Response782>.Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request782StaticHandler
{
	private static ValueTask<Response782> Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request782SealedHandler
{
	private ValueTask<Response782> Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request783(long Id) : Mediator.IRequest<Response783>, MediatR.IRequest<Response783>;

public sealed record Response783(long Id);

public sealed partial class Request783TraditionalHandler
	: Mediator.IRequestHandler<Request783, Response783>,
	MediatR.IRequestHandler<Request783, Response783>
{
	ValueTask<Response783> Mediator.IRequestHandler<Request783, Response783>.Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response783> MediatR.IRequestHandler<Request783, Response783>.Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request783StaticHandler
{
	private static ValueTask<Response783> Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request783SealedHandler
{
	private ValueTask<Response783> Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request784(long Id) : Mediator.IRequest<Response784>, MediatR.IRequest<Response784>;

public sealed record Response784(long Id);

public sealed partial class Request784TraditionalHandler
	: Mediator.IRequestHandler<Request784, Response784>,
	MediatR.IRequestHandler<Request784, Response784>
{
	ValueTask<Response784> Mediator.IRequestHandler<Request784, Response784>.Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response784> MediatR.IRequestHandler<Request784, Response784>.Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request784StaticHandler
{
	private static ValueTask<Response784> Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request784SealedHandler
{
	private ValueTask<Response784> Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request785(long Id) : Mediator.IRequest<Response785>, MediatR.IRequest<Response785>;

public sealed record Response785(long Id);

public sealed partial class Request785TraditionalHandler
	: Mediator.IRequestHandler<Request785, Response785>,
	MediatR.IRequestHandler<Request785, Response785>
{
	ValueTask<Response785> Mediator.IRequestHandler<Request785, Response785>.Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response785> MediatR.IRequestHandler<Request785, Response785>.Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request785StaticHandler
{
	private static ValueTask<Response785> Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request785SealedHandler
{
	private ValueTask<Response785> Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request786(long Id) : Mediator.IRequest<Response786>, MediatR.IRequest<Response786>;

public sealed record Response786(long Id);

public sealed partial class Request786TraditionalHandler
	: Mediator.IRequestHandler<Request786, Response786>,
	MediatR.IRequestHandler<Request786, Response786>
{
	ValueTask<Response786> Mediator.IRequestHandler<Request786, Response786>.Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response786> MediatR.IRequestHandler<Request786, Response786>.Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request786StaticHandler
{
	private static ValueTask<Response786> Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request786SealedHandler
{
	private ValueTask<Response786> Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request787(long Id) : Mediator.IRequest<Response787>, MediatR.IRequest<Response787>;

public sealed record Response787(long Id);

public sealed partial class Request787TraditionalHandler
	: Mediator.IRequestHandler<Request787, Response787>,
	MediatR.IRequestHandler<Request787, Response787>
{
	ValueTask<Response787> Mediator.IRequestHandler<Request787, Response787>.Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response787> MediatR.IRequestHandler<Request787, Response787>.Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request787StaticHandler
{
	private static ValueTask<Response787> Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request787SealedHandler
{
	private ValueTask<Response787> Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request788(long Id) : Mediator.IRequest<Response788>, MediatR.IRequest<Response788>;

public sealed record Response788(long Id);

public sealed partial class Request788TraditionalHandler
	: Mediator.IRequestHandler<Request788, Response788>,
	MediatR.IRequestHandler<Request788, Response788>
{
	ValueTask<Response788> Mediator.IRequestHandler<Request788, Response788>.Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response788> MediatR.IRequestHandler<Request788, Response788>.Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request788StaticHandler
{
	private static ValueTask<Response788> Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request788SealedHandler
{
	private ValueTask<Response788> Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request789(long Id) : Mediator.IRequest<Response789>, MediatR.IRequest<Response789>;

public sealed record Response789(long Id);

public sealed partial class Request789TraditionalHandler
	: Mediator.IRequestHandler<Request789, Response789>,
	MediatR.IRequestHandler<Request789, Response789>
{
	ValueTask<Response789> Mediator.IRequestHandler<Request789, Response789>.Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response789> MediatR.IRequestHandler<Request789, Response789>.Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request789StaticHandler
{
	private static ValueTask<Response789> Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request789SealedHandler
{
	private ValueTask<Response789> Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request790(long Id) : Mediator.IRequest<Response790>, MediatR.IRequest<Response790>;

public sealed record Response790(long Id);

public sealed partial class Request790TraditionalHandler
	: Mediator.IRequestHandler<Request790, Response790>,
	MediatR.IRequestHandler<Request790, Response790>
{
	ValueTask<Response790> Mediator.IRequestHandler<Request790, Response790>.Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response790> MediatR.IRequestHandler<Request790, Response790>.Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request790StaticHandler
{
	private static ValueTask<Response790> Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request790SealedHandler
{
	private ValueTask<Response790> Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request791(long Id) : Mediator.IRequest<Response791>, MediatR.IRequest<Response791>;

public sealed record Response791(long Id);

public sealed partial class Request791TraditionalHandler
	: Mediator.IRequestHandler<Request791, Response791>,
	MediatR.IRequestHandler<Request791, Response791>
{
	ValueTask<Response791> Mediator.IRequestHandler<Request791, Response791>.Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response791> MediatR.IRequestHandler<Request791, Response791>.Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request791StaticHandler
{
	private static ValueTask<Response791> Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request791SealedHandler
{
	private ValueTask<Response791> Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request792(long Id) : Mediator.IRequest<Response792>, MediatR.IRequest<Response792>;

public sealed record Response792(long Id);

public sealed partial class Request792TraditionalHandler
	: Mediator.IRequestHandler<Request792, Response792>,
	MediatR.IRequestHandler<Request792, Response792>
{
	ValueTask<Response792> Mediator.IRequestHandler<Request792, Response792>.Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response792> MediatR.IRequestHandler<Request792, Response792>.Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request792StaticHandler
{
	private static ValueTask<Response792> Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request792SealedHandler
{
	private ValueTask<Response792> Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request793(long Id) : Mediator.IRequest<Response793>, MediatR.IRequest<Response793>;

public sealed record Response793(long Id);

public sealed partial class Request793TraditionalHandler
	: Mediator.IRequestHandler<Request793, Response793>,
	MediatR.IRequestHandler<Request793, Response793>
{
	ValueTask<Response793> Mediator.IRequestHandler<Request793, Response793>.Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response793> MediatR.IRequestHandler<Request793, Response793>.Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request793StaticHandler
{
	private static ValueTask<Response793> Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request793SealedHandler
{
	private ValueTask<Response793> Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request794(long Id) : Mediator.IRequest<Response794>, MediatR.IRequest<Response794>;

public sealed record Response794(long Id);

public sealed partial class Request794TraditionalHandler
	: Mediator.IRequestHandler<Request794, Response794>,
	MediatR.IRequestHandler<Request794, Response794>
{
	ValueTask<Response794> Mediator.IRequestHandler<Request794, Response794>.Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response794> MediatR.IRequestHandler<Request794, Response794>.Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request794StaticHandler
{
	private static ValueTask<Response794> Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request794SealedHandler
{
	private ValueTask<Response794> Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request795(long Id) : Mediator.IRequest<Response795>, MediatR.IRequest<Response795>;

public sealed record Response795(long Id);

public sealed partial class Request795TraditionalHandler
	: Mediator.IRequestHandler<Request795, Response795>,
	MediatR.IRequestHandler<Request795, Response795>
{
	ValueTask<Response795> Mediator.IRequestHandler<Request795, Response795>.Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response795> MediatR.IRequestHandler<Request795, Response795>.Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request795StaticHandler
{
	private static ValueTask<Response795> Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request795SealedHandler
{
	private ValueTask<Response795> Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request796(long Id) : Mediator.IRequest<Response796>, MediatR.IRequest<Response796>;

public sealed record Response796(long Id);

public sealed partial class Request796TraditionalHandler
	: Mediator.IRequestHandler<Request796, Response796>,
	MediatR.IRequestHandler<Request796, Response796>
{
	ValueTask<Response796> Mediator.IRequestHandler<Request796, Response796>.Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response796> MediatR.IRequestHandler<Request796, Response796>.Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request796StaticHandler
{
	private static ValueTask<Response796> Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request796SealedHandler
{
	private ValueTask<Response796> Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request797(long Id) : Mediator.IRequest<Response797>, MediatR.IRequest<Response797>;

public sealed record Response797(long Id);

public sealed partial class Request797TraditionalHandler
	: Mediator.IRequestHandler<Request797, Response797>,
	MediatR.IRequestHandler<Request797, Response797>
{
	ValueTask<Response797> Mediator.IRequestHandler<Request797, Response797>.Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response797> MediatR.IRequestHandler<Request797, Response797>.Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request797StaticHandler
{
	private static ValueTask<Response797> Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request797SealedHandler
{
	private ValueTask<Response797> Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request798(long Id) : Mediator.IRequest<Response798>, MediatR.IRequest<Response798>;

public sealed record Response798(long Id);

public sealed partial class Request798TraditionalHandler
	: Mediator.IRequestHandler<Request798, Response798>,
	MediatR.IRequestHandler<Request798, Response798>
{
	ValueTask<Response798> Mediator.IRequestHandler<Request798, Response798>.Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response798> MediatR.IRequestHandler<Request798, Response798>.Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request798StaticHandler
{
	private static ValueTask<Response798> Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request798SealedHandler
{
	private ValueTask<Response798> Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request799(long Id) : Mediator.IRequest<Response799>, MediatR.IRequest<Response799>;

public sealed record Response799(long Id);

public sealed partial class Request799TraditionalHandler
	: Mediator.IRequestHandler<Request799, Response799>,
	MediatR.IRequestHandler<Request799, Response799>
{
	ValueTask<Response799> Mediator.IRequestHandler<Request799, Response799>.Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response799> MediatR.IRequestHandler<Request799, Response799>.Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request799StaticHandler
{
	private static ValueTask<Response799> Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request799SealedHandler
{
	private ValueTask<Response799> Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request800(long Id) : Mediator.IRequest<Response800>, MediatR.IRequest<Response800>;

public sealed record Response800(long Id);

public sealed partial class Request800TraditionalHandler
	: Mediator.IRequestHandler<Request800, Response800>,
	MediatR.IRequestHandler<Request800, Response800>
{
	ValueTask<Response800> Mediator.IRequestHandler<Request800, Response800>.Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response800> MediatR.IRequestHandler<Request800, Response800>.Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request800StaticHandler
{
	private static ValueTask<Response800> Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request800SealedHandler
{
	private ValueTask<Response800> Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request801(long Id) : Mediator.IRequest<Response801>, MediatR.IRequest<Response801>;

public sealed record Response801(long Id);

public sealed partial class Request801TraditionalHandler
	: Mediator.IRequestHandler<Request801, Response801>,
	MediatR.IRequestHandler<Request801, Response801>
{
	ValueTask<Response801> Mediator.IRequestHandler<Request801, Response801>.Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response801> MediatR.IRequestHandler<Request801, Response801>.Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request801StaticHandler
{
	private static ValueTask<Response801> Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request801SealedHandler
{
	private ValueTask<Response801> Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request802(long Id) : Mediator.IRequest<Response802>, MediatR.IRequest<Response802>;

public sealed record Response802(long Id);

public sealed partial class Request802TraditionalHandler
	: Mediator.IRequestHandler<Request802, Response802>,
	MediatR.IRequestHandler<Request802, Response802>
{
	ValueTask<Response802> Mediator.IRequestHandler<Request802, Response802>.Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response802> MediatR.IRequestHandler<Request802, Response802>.Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request802StaticHandler
{
	private static ValueTask<Response802> Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request802SealedHandler
{
	private ValueTask<Response802> Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request803(long Id) : Mediator.IRequest<Response803>, MediatR.IRequest<Response803>;

public sealed record Response803(long Id);

public sealed partial class Request803TraditionalHandler
	: Mediator.IRequestHandler<Request803, Response803>,
	MediatR.IRequestHandler<Request803, Response803>
{
	ValueTask<Response803> Mediator.IRequestHandler<Request803, Response803>.Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response803> MediatR.IRequestHandler<Request803, Response803>.Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request803StaticHandler
{
	private static ValueTask<Response803> Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request803SealedHandler
{
	private ValueTask<Response803> Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request804(long Id) : Mediator.IRequest<Response804>, MediatR.IRequest<Response804>;

public sealed record Response804(long Id);

public sealed partial class Request804TraditionalHandler
	: Mediator.IRequestHandler<Request804, Response804>,
	MediatR.IRequestHandler<Request804, Response804>
{
	ValueTask<Response804> Mediator.IRequestHandler<Request804, Response804>.Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response804> MediatR.IRequestHandler<Request804, Response804>.Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request804StaticHandler
{
	private static ValueTask<Response804> Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request804SealedHandler
{
	private ValueTask<Response804> Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request805(long Id) : Mediator.IRequest<Response805>, MediatR.IRequest<Response805>;

public sealed record Response805(long Id);

public sealed partial class Request805TraditionalHandler
	: Mediator.IRequestHandler<Request805, Response805>,
	MediatR.IRequestHandler<Request805, Response805>
{
	ValueTask<Response805> Mediator.IRequestHandler<Request805, Response805>.Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response805> MediatR.IRequestHandler<Request805, Response805>.Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request805StaticHandler
{
	private static ValueTask<Response805> Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request805SealedHandler
{
	private ValueTask<Response805> Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request806(long Id) : Mediator.IRequest<Response806>, MediatR.IRequest<Response806>;

public sealed record Response806(long Id);

public sealed partial class Request806TraditionalHandler
	: Mediator.IRequestHandler<Request806, Response806>,
	MediatR.IRequestHandler<Request806, Response806>
{
	ValueTask<Response806> Mediator.IRequestHandler<Request806, Response806>.Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response806> MediatR.IRequestHandler<Request806, Response806>.Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request806StaticHandler
{
	private static ValueTask<Response806> Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request806SealedHandler
{
	private ValueTask<Response806> Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request807(long Id) : Mediator.IRequest<Response807>, MediatR.IRequest<Response807>;

public sealed record Response807(long Id);

public sealed partial class Request807TraditionalHandler
	: Mediator.IRequestHandler<Request807, Response807>,
	MediatR.IRequestHandler<Request807, Response807>
{
	ValueTask<Response807> Mediator.IRequestHandler<Request807, Response807>.Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response807> MediatR.IRequestHandler<Request807, Response807>.Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request807StaticHandler
{
	private static ValueTask<Response807> Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request807SealedHandler
{
	private ValueTask<Response807> Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request808(long Id) : Mediator.IRequest<Response808>, MediatR.IRequest<Response808>;

public sealed record Response808(long Id);

public sealed partial class Request808TraditionalHandler
	: Mediator.IRequestHandler<Request808, Response808>,
	MediatR.IRequestHandler<Request808, Response808>
{
	ValueTask<Response808> Mediator.IRequestHandler<Request808, Response808>.Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response808> MediatR.IRequestHandler<Request808, Response808>.Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request808StaticHandler
{
	private static ValueTask<Response808> Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request808SealedHandler
{
	private ValueTask<Response808> Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request809(long Id) : Mediator.IRequest<Response809>, MediatR.IRequest<Response809>;

public sealed record Response809(long Id);

public sealed partial class Request809TraditionalHandler
	: Mediator.IRequestHandler<Request809, Response809>,
	MediatR.IRequestHandler<Request809, Response809>
{
	ValueTask<Response809> Mediator.IRequestHandler<Request809, Response809>.Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response809> MediatR.IRequestHandler<Request809, Response809>.Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request809StaticHandler
{
	private static ValueTask<Response809> Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request809SealedHandler
{
	private ValueTask<Response809> Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request810(long Id) : Mediator.IRequest<Response810>, MediatR.IRequest<Response810>;

public sealed record Response810(long Id);

public sealed partial class Request810TraditionalHandler
	: Mediator.IRequestHandler<Request810, Response810>,
	MediatR.IRequestHandler<Request810, Response810>
{
	ValueTask<Response810> Mediator.IRequestHandler<Request810, Response810>.Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response810> MediatR.IRequestHandler<Request810, Response810>.Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request810StaticHandler
{
	private static ValueTask<Response810> Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request810SealedHandler
{
	private ValueTask<Response810> Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request811(long Id) : Mediator.IRequest<Response811>, MediatR.IRequest<Response811>;

public sealed record Response811(long Id);

public sealed partial class Request811TraditionalHandler
	: Mediator.IRequestHandler<Request811, Response811>,
	MediatR.IRequestHandler<Request811, Response811>
{
	ValueTask<Response811> Mediator.IRequestHandler<Request811, Response811>.Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response811> MediatR.IRequestHandler<Request811, Response811>.Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request811StaticHandler
{
	private static ValueTask<Response811> Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request811SealedHandler
{
	private ValueTask<Response811> Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request812(long Id) : Mediator.IRequest<Response812>, MediatR.IRequest<Response812>;

public sealed record Response812(long Id);

public sealed partial class Request812TraditionalHandler
	: Mediator.IRequestHandler<Request812, Response812>,
	MediatR.IRequestHandler<Request812, Response812>
{
	ValueTask<Response812> Mediator.IRequestHandler<Request812, Response812>.Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response812> MediatR.IRequestHandler<Request812, Response812>.Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request812StaticHandler
{
	private static ValueTask<Response812> Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request812SealedHandler
{
	private ValueTask<Response812> Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request813(long Id) : Mediator.IRequest<Response813>, MediatR.IRequest<Response813>;

public sealed record Response813(long Id);

public sealed partial class Request813TraditionalHandler
	: Mediator.IRequestHandler<Request813, Response813>,
	MediatR.IRequestHandler<Request813, Response813>
{
	ValueTask<Response813> Mediator.IRequestHandler<Request813, Response813>.Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response813> MediatR.IRequestHandler<Request813, Response813>.Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request813StaticHandler
{
	private static ValueTask<Response813> Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request813SealedHandler
{
	private ValueTask<Response813> Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request814(long Id) : Mediator.IRequest<Response814>, MediatR.IRequest<Response814>;

public sealed record Response814(long Id);

public sealed partial class Request814TraditionalHandler
	: Mediator.IRequestHandler<Request814, Response814>,
	MediatR.IRequestHandler<Request814, Response814>
{
	ValueTask<Response814> Mediator.IRequestHandler<Request814, Response814>.Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response814> MediatR.IRequestHandler<Request814, Response814>.Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request814StaticHandler
{
	private static ValueTask<Response814> Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request814SealedHandler
{
	private ValueTask<Response814> Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request815(long Id) : Mediator.IRequest<Response815>, MediatR.IRequest<Response815>;

public sealed record Response815(long Id);

public sealed partial class Request815TraditionalHandler
	: Mediator.IRequestHandler<Request815, Response815>,
	MediatR.IRequestHandler<Request815, Response815>
{
	ValueTask<Response815> Mediator.IRequestHandler<Request815, Response815>.Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response815> MediatR.IRequestHandler<Request815, Response815>.Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request815StaticHandler
{
	private static ValueTask<Response815> Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request815SealedHandler
{
	private ValueTask<Response815> Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request816(long Id) : Mediator.IRequest<Response816>, MediatR.IRequest<Response816>;

public sealed record Response816(long Id);

public sealed partial class Request816TraditionalHandler
	: Mediator.IRequestHandler<Request816, Response816>,
	MediatR.IRequestHandler<Request816, Response816>
{
	ValueTask<Response816> Mediator.IRequestHandler<Request816, Response816>.Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response816> MediatR.IRequestHandler<Request816, Response816>.Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request816StaticHandler
{
	private static ValueTask<Response816> Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request816SealedHandler
{
	private ValueTask<Response816> Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request817(long Id) : Mediator.IRequest<Response817>, MediatR.IRequest<Response817>;

public sealed record Response817(long Id);

public sealed partial class Request817TraditionalHandler
	: Mediator.IRequestHandler<Request817, Response817>,
	MediatR.IRequestHandler<Request817, Response817>
{
	ValueTask<Response817> Mediator.IRequestHandler<Request817, Response817>.Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response817> MediatR.IRequestHandler<Request817, Response817>.Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request817StaticHandler
{
	private static ValueTask<Response817> Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request817SealedHandler
{
	private ValueTask<Response817> Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request818(long Id) : Mediator.IRequest<Response818>, MediatR.IRequest<Response818>;

public sealed record Response818(long Id);

public sealed partial class Request818TraditionalHandler
	: Mediator.IRequestHandler<Request818, Response818>,
	MediatR.IRequestHandler<Request818, Response818>
{
	ValueTask<Response818> Mediator.IRequestHandler<Request818, Response818>.Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response818> MediatR.IRequestHandler<Request818, Response818>.Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request818StaticHandler
{
	private static ValueTask<Response818> Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request818SealedHandler
{
	private ValueTask<Response818> Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request819(long Id) : Mediator.IRequest<Response819>, MediatR.IRequest<Response819>;

public sealed record Response819(long Id);

public sealed partial class Request819TraditionalHandler
	: Mediator.IRequestHandler<Request819, Response819>,
	MediatR.IRequestHandler<Request819, Response819>
{
	ValueTask<Response819> Mediator.IRequestHandler<Request819, Response819>.Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response819> MediatR.IRequestHandler<Request819, Response819>.Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request819StaticHandler
{
	private static ValueTask<Response819> Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request819SealedHandler
{
	private ValueTask<Response819> Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request820(long Id) : Mediator.IRequest<Response820>, MediatR.IRequest<Response820>;

public sealed record Response820(long Id);

public sealed partial class Request820TraditionalHandler
	: Mediator.IRequestHandler<Request820, Response820>,
	MediatR.IRequestHandler<Request820, Response820>
{
	ValueTask<Response820> Mediator.IRequestHandler<Request820, Response820>.Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response820> MediatR.IRequestHandler<Request820, Response820>.Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request820StaticHandler
{
	private static ValueTask<Response820> Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request820SealedHandler
{
	private ValueTask<Response820> Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request821(long Id) : Mediator.IRequest<Response821>, MediatR.IRequest<Response821>;

public sealed record Response821(long Id);

public sealed partial class Request821TraditionalHandler
	: Mediator.IRequestHandler<Request821, Response821>,
	MediatR.IRequestHandler<Request821, Response821>
{
	ValueTask<Response821> Mediator.IRequestHandler<Request821, Response821>.Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response821> MediatR.IRequestHandler<Request821, Response821>.Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request821StaticHandler
{
	private static ValueTask<Response821> Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request821SealedHandler
{
	private ValueTask<Response821> Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request822(long Id) : Mediator.IRequest<Response822>, MediatR.IRequest<Response822>;

public sealed record Response822(long Id);

public sealed partial class Request822TraditionalHandler
	: Mediator.IRequestHandler<Request822, Response822>,
	MediatR.IRequestHandler<Request822, Response822>
{
	ValueTask<Response822> Mediator.IRequestHandler<Request822, Response822>.Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response822> MediatR.IRequestHandler<Request822, Response822>.Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request822StaticHandler
{
	private static ValueTask<Response822> Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request822SealedHandler
{
	private ValueTask<Response822> Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request823(long Id) : Mediator.IRequest<Response823>, MediatR.IRequest<Response823>;

public sealed record Response823(long Id);

public sealed partial class Request823TraditionalHandler
	: Mediator.IRequestHandler<Request823, Response823>,
	MediatR.IRequestHandler<Request823, Response823>
{
	ValueTask<Response823> Mediator.IRequestHandler<Request823, Response823>.Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response823> MediatR.IRequestHandler<Request823, Response823>.Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request823StaticHandler
{
	private static ValueTask<Response823> Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request823SealedHandler
{
	private ValueTask<Response823> Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request824(long Id) : Mediator.IRequest<Response824>, MediatR.IRequest<Response824>;

public sealed record Response824(long Id);

public sealed partial class Request824TraditionalHandler
	: Mediator.IRequestHandler<Request824, Response824>,
	MediatR.IRequestHandler<Request824, Response824>
{
	ValueTask<Response824> Mediator.IRequestHandler<Request824, Response824>.Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response824> MediatR.IRequestHandler<Request824, Response824>.Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request824StaticHandler
{
	private static ValueTask<Response824> Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request824SealedHandler
{
	private ValueTask<Response824> Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request825(long Id) : Mediator.IRequest<Response825>, MediatR.IRequest<Response825>;

public sealed record Response825(long Id);

public sealed partial class Request825TraditionalHandler
	: Mediator.IRequestHandler<Request825, Response825>,
	MediatR.IRequestHandler<Request825, Response825>
{
	ValueTask<Response825> Mediator.IRequestHandler<Request825, Response825>.Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response825> MediatR.IRequestHandler<Request825, Response825>.Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request825StaticHandler
{
	private static ValueTask<Response825> Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request825SealedHandler
{
	private ValueTask<Response825> Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request826(long Id) : Mediator.IRequest<Response826>, MediatR.IRequest<Response826>;

public sealed record Response826(long Id);

public sealed partial class Request826TraditionalHandler
	: Mediator.IRequestHandler<Request826, Response826>,
	MediatR.IRequestHandler<Request826, Response826>
{
	ValueTask<Response826> Mediator.IRequestHandler<Request826, Response826>.Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response826> MediatR.IRequestHandler<Request826, Response826>.Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request826StaticHandler
{
	private static ValueTask<Response826> Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request826SealedHandler
{
	private ValueTask<Response826> Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request827(long Id) : Mediator.IRequest<Response827>, MediatR.IRequest<Response827>;

public sealed record Response827(long Id);

public sealed partial class Request827TraditionalHandler
	: Mediator.IRequestHandler<Request827, Response827>,
	MediatR.IRequestHandler<Request827, Response827>
{
	ValueTask<Response827> Mediator.IRequestHandler<Request827, Response827>.Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response827> MediatR.IRequestHandler<Request827, Response827>.Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request827StaticHandler
{
	private static ValueTask<Response827> Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request827SealedHandler
{
	private ValueTask<Response827> Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request828(long Id) : Mediator.IRequest<Response828>, MediatR.IRequest<Response828>;

public sealed record Response828(long Id);

public sealed partial class Request828TraditionalHandler
	: Mediator.IRequestHandler<Request828, Response828>,
	MediatR.IRequestHandler<Request828, Response828>
{
	ValueTask<Response828> Mediator.IRequestHandler<Request828, Response828>.Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response828> MediatR.IRequestHandler<Request828, Response828>.Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request828StaticHandler
{
	private static ValueTask<Response828> Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request828SealedHandler
{
	private ValueTask<Response828> Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request829(long Id) : Mediator.IRequest<Response829>, MediatR.IRequest<Response829>;

public sealed record Response829(long Id);

public sealed partial class Request829TraditionalHandler
	: Mediator.IRequestHandler<Request829, Response829>,
	MediatR.IRequestHandler<Request829, Response829>
{
	ValueTask<Response829> Mediator.IRequestHandler<Request829, Response829>.Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response829> MediatR.IRequestHandler<Request829, Response829>.Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request829StaticHandler
{
	private static ValueTask<Response829> Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request829SealedHandler
{
	private ValueTask<Response829> Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request830(long Id) : Mediator.IRequest<Response830>, MediatR.IRequest<Response830>;

public sealed record Response830(long Id);

public sealed partial class Request830TraditionalHandler
	: Mediator.IRequestHandler<Request830, Response830>,
	MediatR.IRequestHandler<Request830, Response830>
{
	ValueTask<Response830> Mediator.IRequestHandler<Request830, Response830>.Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response830> MediatR.IRequestHandler<Request830, Response830>.Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request830StaticHandler
{
	private static ValueTask<Response830> Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request830SealedHandler
{
	private ValueTask<Response830> Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request831(long Id) : Mediator.IRequest<Response831>, MediatR.IRequest<Response831>;

public sealed record Response831(long Id);

public sealed partial class Request831TraditionalHandler
	: Mediator.IRequestHandler<Request831, Response831>,
	MediatR.IRequestHandler<Request831, Response831>
{
	ValueTask<Response831> Mediator.IRequestHandler<Request831, Response831>.Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response831> MediatR.IRequestHandler<Request831, Response831>.Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request831StaticHandler
{
	private static ValueTask<Response831> Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request831SealedHandler
{
	private ValueTask<Response831> Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request832(long Id) : Mediator.IRequest<Response832>, MediatR.IRequest<Response832>;

public sealed record Response832(long Id);

public sealed partial class Request832TraditionalHandler
	: Mediator.IRequestHandler<Request832, Response832>,
	MediatR.IRequestHandler<Request832, Response832>
{
	ValueTask<Response832> Mediator.IRequestHandler<Request832, Response832>.Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response832> MediatR.IRequestHandler<Request832, Response832>.Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request832StaticHandler
{
	private static ValueTask<Response832> Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request832SealedHandler
{
	private ValueTask<Response832> Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request833(long Id) : Mediator.IRequest<Response833>, MediatR.IRequest<Response833>;

public sealed record Response833(long Id);

public sealed partial class Request833TraditionalHandler
	: Mediator.IRequestHandler<Request833, Response833>,
	MediatR.IRequestHandler<Request833, Response833>
{
	ValueTask<Response833> Mediator.IRequestHandler<Request833, Response833>.Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response833> MediatR.IRequestHandler<Request833, Response833>.Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request833StaticHandler
{
	private static ValueTask<Response833> Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request833SealedHandler
{
	private ValueTask<Response833> Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request834(long Id) : Mediator.IRequest<Response834>, MediatR.IRequest<Response834>;

public sealed record Response834(long Id);

public sealed partial class Request834TraditionalHandler
	: Mediator.IRequestHandler<Request834, Response834>,
	MediatR.IRequestHandler<Request834, Response834>
{
	ValueTask<Response834> Mediator.IRequestHandler<Request834, Response834>.Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response834> MediatR.IRequestHandler<Request834, Response834>.Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request834StaticHandler
{
	private static ValueTask<Response834> Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request834SealedHandler
{
	private ValueTask<Response834> Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request835(long Id) : Mediator.IRequest<Response835>, MediatR.IRequest<Response835>;

public sealed record Response835(long Id);

public sealed partial class Request835TraditionalHandler
	: Mediator.IRequestHandler<Request835, Response835>,
	MediatR.IRequestHandler<Request835, Response835>
{
	ValueTask<Response835> Mediator.IRequestHandler<Request835, Response835>.Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response835> MediatR.IRequestHandler<Request835, Response835>.Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request835StaticHandler
{
	private static ValueTask<Response835> Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request835SealedHandler
{
	private ValueTask<Response835> Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request836(long Id) : Mediator.IRequest<Response836>, MediatR.IRequest<Response836>;

public sealed record Response836(long Id);

public sealed partial class Request836TraditionalHandler
	: Mediator.IRequestHandler<Request836, Response836>,
	MediatR.IRequestHandler<Request836, Response836>
{
	ValueTask<Response836> Mediator.IRequestHandler<Request836, Response836>.Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response836> MediatR.IRequestHandler<Request836, Response836>.Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request836StaticHandler
{
	private static ValueTask<Response836> Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request836SealedHandler
{
	private ValueTask<Response836> Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request837(long Id) : Mediator.IRequest<Response837>, MediatR.IRequest<Response837>;

public sealed record Response837(long Id);

public sealed partial class Request837TraditionalHandler
	: Mediator.IRequestHandler<Request837, Response837>,
	MediatR.IRequestHandler<Request837, Response837>
{
	ValueTask<Response837> Mediator.IRequestHandler<Request837, Response837>.Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response837> MediatR.IRequestHandler<Request837, Response837>.Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request837StaticHandler
{
	private static ValueTask<Response837> Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request837SealedHandler
{
	private ValueTask<Response837> Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request838(long Id) : Mediator.IRequest<Response838>, MediatR.IRequest<Response838>;

public sealed record Response838(long Id);

public sealed partial class Request838TraditionalHandler
	: Mediator.IRequestHandler<Request838, Response838>,
	MediatR.IRequestHandler<Request838, Response838>
{
	ValueTask<Response838> Mediator.IRequestHandler<Request838, Response838>.Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response838> MediatR.IRequestHandler<Request838, Response838>.Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request838StaticHandler
{
	private static ValueTask<Response838> Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request838SealedHandler
{
	private ValueTask<Response838> Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request839(long Id) : Mediator.IRequest<Response839>, MediatR.IRequest<Response839>;

public sealed record Response839(long Id);

public sealed partial class Request839TraditionalHandler
	: Mediator.IRequestHandler<Request839, Response839>,
	MediatR.IRequestHandler<Request839, Response839>
{
	ValueTask<Response839> Mediator.IRequestHandler<Request839, Response839>.Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response839> MediatR.IRequestHandler<Request839, Response839>.Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request839StaticHandler
{
	private static ValueTask<Response839> Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request839SealedHandler
{
	private ValueTask<Response839> Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request840(long Id) : Mediator.IRequest<Response840>, MediatR.IRequest<Response840>;

public sealed record Response840(long Id);

public sealed partial class Request840TraditionalHandler
	: Mediator.IRequestHandler<Request840, Response840>,
	MediatR.IRequestHandler<Request840, Response840>
{
	ValueTask<Response840> Mediator.IRequestHandler<Request840, Response840>.Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response840> MediatR.IRequestHandler<Request840, Response840>.Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request840StaticHandler
{
	private static ValueTask<Response840> Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request840SealedHandler
{
	private ValueTask<Response840> Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request841(long Id) : Mediator.IRequest<Response841>, MediatR.IRequest<Response841>;

public sealed record Response841(long Id);

public sealed partial class Request841TraditionalHandler
	: Mediator.IRequestHandler<Request841, Response841>,
	MediatR.IRequestHandler<Request841, Response841>
{
	ValueTask<Response841> Mediator.IRequestHandler<Request841, Response841>.Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response841> MediatR.IRequestHandler<Request841, Response841>.Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request841StaticHandler
{
	private static ValueTask<Response841> Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request841SealedHandler
{
	private ValueTask<Response841> Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request842(long Id) : Mediator.IRequest<Response842>, MediatR.IRequest<Response842>;

public sealed record Response842(long Id);

public sealed partial class Request842TraditionalHandler
	: Mediator.IRequestHandler<Request842, Response842>,
	MediatR.IRequestHandler<Request842, Response842>
{
	ValueTask<Response842> Mediator.IRequestHandler<Request842, Response842>.Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response842> MediatR.IRequestHandler<Request842, Response842>.Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request842StaticHandler
{
	private static ValueTask<Response842> Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request842SealedHandler
{
	private ValueTask<Response842> Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request843(long Id) : Mediator.IRequest<Response843>, MediatR.IRequest<Response843>;

public sealed record Response843(long Id);

public sealed partial class Request843TraditionalHandler
	: Mediator.IRequestHandler<Request843, Response843>,
	MediatR.IRequestHandler<Request843, Response843>
{
	ValueTask<Response843> Mediator.IRequestHandler<Request843, Response843>.Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response843> MediatR.IRequestHandler<Request843, Response843>.Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request843StaticHandler
{
	private static ValueTask<Response843> Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request843SealedHandler
{
	private ValueTask<Response843> Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request844(long Id) : Mediator.IRequest<Response844>, MediatR.IRequest<Response844>;

public sealed record Response844(long Id);

public sealed partial class Request844TraditionalHandler
	: Mediator.IRequestHandler<Request844, Response844>,
	MediatR.IRequestHandler<Request844, Response844>
{
	ValueTask<Response844> Mediator.IRequestHandler<Request844, Response844>.Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response844> MediatR.IRequestHandler<Request844, Response844>.Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request844StaticHandler
{
	private static ValueTask<Response844> Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request844SealedHandler
{
	private ValueTask<Response844> Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request845(long Id) : Mediator.IRequest<Response845>, MediatR.IRequest<Response845>;

public sealed record Response845(long Id);

public sealed partial class Request845TraditionalHandler
	: Mediator.IRequestHandler<Request845, Response845>,
	MediatR.IRequestHandler<Request845, Response845>
{
	ValueTask<Response845> Mediator.IRequestHandler<Request845, Response845>.Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response845> MediatR.IRequestHandler<Request845, Response845>.Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request845StaticHandler
{
	private static ValueTask<Response845> Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request845SealedHandler
{
	private ValueTask<Response845> Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request846(long Id) : Mediator.IRequest<Response846>, MediatR.IRequest<Response846>;

public sealed record Response846(long Id);

public sealed partial class Request846TraditionalHandler
	: Mediator.IRequestHandler<Request846, Response846>,
	MediatR.IRequestHandler<Request846, Response846>
{
	ValueTask<Response846> Mediator.IRequestHandler<Request846, Response846>.Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response846> MediatR.IRequestHandler<Request846, Response846>.Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request846StaticHandler
{
	private static ValueTask<Response846> Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request846SealedHandler
{
	private ValueTask<Response846> Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request847(long Id) : Mediator.IRequest<Response847>, MediatR.IRequest<Response847>;

public sealed record Response847(long Id);

public sealed partial class Request847TraditionalHandler
	: Mediator.IRequestHandler<Request847, Response847>,
	MediatR.IRequestHandler<Request847, Response847>
{
	ValueTask<Response847> Mediator.IRequestHandler<Request847, Response847>.Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response847> MediatR.IRequestHandler<Request847, Response847>.Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request847StaticHandler
{
	private static ValueTask<Response847> Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request847SealedHandler
{
	private ValueTask<Response847> Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request848(long Id) : Mediator.IRequest<Response848>, MediatR.IRequest<Response848>;

public sealed record Response848(long Id);

public sealed partial class Request848TraditionalHandler
	: Mediator.IRequestHandler<Request848, Response848>,
	MediatR.IRequestHandler<Request848, Response848>
{
	ValueTask<Response848> Mediator.IRequestHandler<Request848, Response848>.Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response848> MediatR.IRequestHandler<Request848, Response848>.Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request848StaticHandler
{
	private static ValueTask<Response848> Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request848SealedHandler
{
	private ValueTask<Response848> Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request849(long Id) : Mediator.IRequest<Response849>, MediatR.IRequest<Response849>;

public sealed record Response849(long Id);

public sealed partial class Request849TraditionalHandler
	: Mediator.IRequestHandler<Request849, Response849>,
	MediatR.IRequestHandler<Request849, Response849>
{
	ValueTask<Response849> Mediator.IRequestHandler<Request849, Response849>.Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response849> MediatR.IRequestHandler<Request849, Response849>.Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request849StaticHandler
{
	private static ValueTask<Response849> Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request849SealedHandler
{
	private ValueTask<Response849> Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request850(long Id) : Mediator.IRequest<Response850>, MediatR.IRequest<Response850>;

public sealed record Response850(long Id);

public sealed partial class Request850TraditionalHandler
	: Mediator.IRequestHandler<Request850, Response850>,
	MediatR.IRequestHandler<Request850, Response850>
{
	ValueTask<Response850> Mediator.IRequestHandler<Request850, Response850>.Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response850> MediatR.IRequestHandler<Request850, Response850>.Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request850StaticHandler
{
	private static ValueTask<Response850> Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request850SealedHandler
{
	private ValueTask<Response850> Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request851(long Id) : Mediator.IRequest<Response851>, MediatR.IRequest<Response851>;

public sealed record Response851(long Id);

public sealed partial class Request851TraditionalHandler
	: Mediator.IRequestHandler<Request851, Response851>,
	MediatR.IRequestHandler<Request851, Response851>
{
	ValueTask<Response851> Mediator.IRequestHandler<Request851, Response851>.Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response851> MediatR.IRequestHandler<Request851, Response851>.Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request851StaticHandler
{
	private static ValueTask<Response851> Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request851SealedHandler
{
	private ValueTask<Response851> Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request852(long Id) : Mediator.IRequest<Response852>, MediatR.IRequest<Response852>;

public sealed record Response852(long Id);

public sealed partial class Request852TraditionalHandler
	: Mediator.IRequestHandler<Request852, Response852>,
	MediatR.IRequestHandler<Request852, Response852>
{
	ValueTask<Response852> Mediator.IRequestHandler<Request852, Response852>.Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response852> MediatR.IRequestHandler<Request852, Response852>.Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request852StaticHandler
{
	private static ValueTask<Response852> Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request852SealedHandler
{
	private ValueTask<Response852> Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request853(long Id) : Mediator.IRequest<Response853>, MediatR.IRequest<Response853>;

public sealed record Response853(long Id);

public sealed partial class Request853TraditionalHandler
	: Mediator.IRequestHandler<Request853, Response853>,
	MediatR.IRequestHandler<Request853, Response853>
{
	ValueTask<Response853> Mediator.IRequestHandler<Request853, Response853>.Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response853> MediatR.IRequestHandler<Request853, Response853>.Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request853StaticHandler
{
	private static ValueTask<Response853> Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request853SealedHandler
{
	private ValueTask<Response853> Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request854(long Id) : Mediator.IRequest<Response854>, MediatR.IRequest<Response854>;

public sealed record Response854(long Id);

public sealed partial class Request854TraditionalHandler
	: Mediator.IRequestHandler<Request854, Response854>,
	MediatR.IRequestHandler<Request854, Response854>
{
	ValueTask<Response854> Mediator.IRequestHandler<Request854, Response854>.Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response854> MediatR.IRequestHandler<Request854, Response854>.Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request854StaticHandler
{
	private static ValueTask<Response854> Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request854SealedHandler
{
	private ValueTask<Response854> Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request855(long Id) : Mediator.IRequest<Response855>, MediatR.IRequest<Response855>;

public sealed record Response855(long Id);

public sealed partial class Request855TraditionalHandler
	: Mediator.IRequestHandler<Request855, Response855>,
	MediatR.IRequestHandler<Request855, Response855>
{
	ValueTask<Response855> Mediator.IRequestHandler<Request855, Response855>.Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response855> MediatR.IRequestHandler<Request855, Response855>.Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request855StaticHandler
{
	private static ValueTask<Response855> Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request855SealedHandler
{
	private ValueTask<Response855> Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request856(long Id) : Mediator.IRequest<Response856>, MediatR.IRequest<Response856>;

public sealed record Response856(long Id);

public sealed partial class Request856TraditionalHandler
	: Mediator.IRequestHandler<Request856, Response856>,
	MediatR.IRequestHandler<Request856, Response856>
{
	ValueTask<Response856> Mediator.IRequestHandler<Request856, Response856>.Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response856> MediatR.IRequestHandler<Request856, Response856>.Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request856StaticHandler
{
	private static ValueTask<Response856> Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request856SealedHandler
{
	private ValueTask<Response856> Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request857(long Id) : Mediator.IRequest<Response857>, MediatR.IRequest<Response857>;

public sealed record Response857(long Id);

public sealed partial class Request857TraditionalHandler
	: Mediator.IRequestHandler<Request857, Response857>,
	MediatR.IRequestHandler<Request857, Response857>
{
	ValueTask<Response857> Mediator.IRequestHandler<Request857, Response857>.Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response857> MediatR.IRequestHandler<Request857, Response857>.Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request857StaticHandler
{
	private static ValueTask<Response857> Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request857SealedHandler
{
	private ValueTask<Response857> Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request858(long Id) : Mediator.IRequest<Response858>, MediatR.IRequest<Response858>;

public sealed record Response858(long Id);

public sealed partial class Request858TraditionalHandler
	: Mediator.IRequestHandler<Request858, Response858>,
	MediatR.IRequestHandler<Request858, Response858>
{
	ValueTask<Response858> Mediator.IRequestHandler<Request858, Response858>.Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response858> MediatR.IRequestHandler<Request858, Response858>.Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request858StaticHandler
{
	private static ValueTask<Response858> Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request858SealedHandler
{
	private ValueTask<Response858> Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request859(long Id) : Mediator.IRequest<Response859>, MediatR.IRequest<Response859>;

public sealed record Response859(long Id);

public sealed partial class Request859TraditionalHandler
	: Mediator.IRequestHandler<Request859, Response859>,
	MediatR.IRequestHandler<Request859, Response859>
{
	ValueTask<Response859> Mediator.IRequestHandler<Request859, Response859>.Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response859> MediatR.IRequestHandler<Request859, Response859>.Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request859StaticHandler
{
	private static ValueTask<Response859> Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request859SealedHandler
{
	private ValueTask<Response859> Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request860(long Id) : Mediator.IRequest<Response860>, MediatR.IRequest<Response860>;

public sealed record Response860(long Id);

public sealed partial class Request860TraditionalHandler
	: Mediator.IRequestHandler<Request860, Response860>,
	MediatR.IRequestHandler<Request860, Response860>
{
	ValueTask<Response860> Mediator.IRequestHandler<Request860, Response860>.Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response860> MediatR.IRequestHandler<Request860, Response860>.Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request860StaticHandler
{
	private static ValueTask<Response860> Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request860SealedHandler
{
	private ValueTask<Response860> Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request861(long Id) : Mediator.IRequest<Response861>, MediatR.IRequest<Response861>;

public sealed record Response861(long Id);

public sealed partial class Request861TraditionalHandler
	: Mediator.IRequestHandler<Request861, Response861>,
	MediatR.IRequestHandler<Request861, Response861>
{
	ValueTask<Response861> Mediator.IRequestHandler<Request861, Response861>.Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response861> MediatR.IRequestHandler<Request861, Response861>.Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request861StaticHandler
{
	private static ValueTask<Response861> Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request861SealedHandler
{
	private ValueTask<Response861> Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request862(long Id) : Mediator.IRequest<Response862>, MediatR.IRequest<Response862>;

public sealed record Response862(long Id);

public sealed partial class Request862TraditionalHandler
	: Mediator.IRequestHandler<Request862, Response862>,
	MediatR.IRequestHandler<Request862, Response862>
{
	ValueTask<Response862> Mediator.IRequestHandler<Request862, Response862>.Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response862> MediatR.IRequestHandler<Request862, Response862>.Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request862StaticHandler
{
	private static ValueTask<Response862> Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request862SealedHandler
{
	private ValueTask<Response862> Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request863(long Id) : Mediator.IRequest<Response863>, MediatR.IRequest<Response863>;

public sealed record Response863(long Id);

public sealed partial class Request863TraditionalHandler
	: Mediator.IRequestHandler<Request863, Response863>,
	MediatR.IRequestHandler<Request863, Response863>
{
	ValueTask<Response863> Mediator.IRequestHandler<Request863, Response863>.Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response863> MediatR.IRequestHandler<Request863, Response863>.Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request863StaticHandler
{
	private static ValueTask<Response863> Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request863SealedHandler
{
	private ValueTask<Response863> Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request864(long Id) : Mediator.IRequest<Response864>, MediatR.IRequest<Response864>;

public sealed record Response864(long Id);

public sealed partial class Request864TraditionalHandler
	: Mediator.IRequestHandler<Request864, Response864>,
	MediatR.IRequestHandler<Request864, Response864>
{
	ValueTask<Response864> Mediator.IRequestHandler<Request864, Response864>.Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response864> MediatR.IRequestHandler<Request864, Response864>.Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request864StaticHandler
{
	private static ValueTask<Response864> Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request864SealedHandler
{
	private ValueTask<Response864> Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request865(long Id) : Mediator.IRequest<Response865>, MediatR.IRequest<Response865>;

public sealed record Response865(long Id);

public sealed partial class Request865TraditionalHandler
	: Mediator.IRequestHandler<Request865, Response865>,
	MediatR.IRequestHandler<Request865, Response865>
{
	ValueTask<Response865> Mediator.IRequestHandler<Request865, Response865>.Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response865> MediatR.IRequestHandler<Request865, Response865>.Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request865StaticHandler
{
	private static ValueTask<Response865> Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request865SealedHandler
{
	private ValueTask<Response865> Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request866(long Id) : Mediator.IRequest<Response866>, MediatR.IRequest<Response866>;

public sealed record Response866(long Id);

public sealed partial class Request866TraditionalHandler
	: Mediator.IRequestHandler<Request866, Response866>,
	MediatR.IRequestHandler<Request866, Response866>
{
	ValueTask<Response866> Mediator.IRequestHandler<Request866, Response866>.Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response866> MediatR.IRequestHandler<Request866, Response866>.Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request866StaticHandler
{
	private static ValueTask<Response866> Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request866SealedHandler
{
	private ValueTask<Response866> Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request867(long Id) : Mediator.IRequest<Response867>, MediatR.IRequest<Response867>;

public sealed record Response867(long Id);

public sealed partial class Request867TraditionalHandler
	: Mediator.IRequestHandler<Request867, Response867>,
	MediatR.IRequestHandler<Request867, Response867>
{
	ValueTask<Response867> Mediator.IRequestHandler<Request867, Response867>.Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response867> MediatR.IRequestHandler<Request867, Response867>.Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request867StaticHandler
{
	private static ValueTask<Response867> Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request867SealedHandler
{
	private ValueTask<Response867> Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request868(long Id) : Mediator.IRequest<Response868>, MediatR.IRequest<Response868>;

public sealed record Response868(long Id);

public sealed partial class Request868TraditionalHandler
	: Mediator.IRequestHandler<Request868, Response868>,
	MediatR.IRequestHandler<Request868, Response868>
{
	ValueTask<Response868> Mediator.IRequestHandler<Request868, Response868>.Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response868> MediatR.IRequestHandler<Request868, Response868>.Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request868StaticHandler
{
	private static ValueTask<Response868> Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request868SealedHandler
{
	private ValueTask<Response868> Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request869(long Id) : Mediator.IRequest<Response869>, MediatR.IRequest<Response869>;

public sealed record Response869(long Id);

public sealed partial class Request869TraditionalHandler
	: Mediator.IRequestHandler<Request869, Response869>,
	MediatR.IRequestHandler<Request869, Response869>
{
	ValueTask<Response869> Mediator.IRequestHandler<Request869, Response869>.Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response869> MediatR.IRequestHandler<Request869, Response869>.Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request869StaticHandler
{
	private static ValueTask<Response869> Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request869SealedHandler
{
	private ValueTask<Response869> Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request870(long Id) : Mediator.IRequest<Response870>, MediatR.IRequest<Response870>;

public sealed record Response870(long Id);

public sealed partial class Request870TraditionalHandler
	: Mediator.IRequestHandler<Request870, Response870>,
	MediatR.IRequestHandler<Request870, Response870>
{
	ValueTask<Response870> Mediator.IRequestHandler<Request870, Response870>.Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response870> MediatR.IRequestHandler<Request870, Response870>.Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request870StaticHandler
{
	private static ValueTask<Response870> Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request870SealedHandler
{
	private ValueTask<Response870> Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request871(long Id) : Mediator.IRequest<Response871>, MediatR.IRequest<Response871>;

public sealed record Response871(long Id);

public sealed partial class Request871TraditionalHandler
	: Mediator.IRequestHandler<Request871, Response871>,
	MediatR.IRequestHandler<Request871, Response871>
{
	ValueTask<Response871> Mediator.IRequestHandler<Request871, Response871>.Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response871> MediatR.IRequestHandler<Request871, Response871>.Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request871StaticHandler
{
	private static ValueTask<Response871> Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request871SealedHandler
{
	private ValueTask<Response871> Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request872(long Id) : Mediator.IRequest<Response872>, MediatR.IRequest<Response872>;

public sealed record Response872(long Id);

public sealed partial class Request872TraditionalHandler
	: Mediator.IRequestHandler<Request872, Response872>,
	MediatR.IRequestHandler<Request872, Response872>
{
	ValueTask<Response872> Mediator.IRequestHandler<Request872, Response872>.Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response872> MediatR.IRequestHandler<Request872, Response872>.Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request872StaticHandler
{
	private static ValueTask<Response872> Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request872SealedHandler
{
	private ValueTask<Response872> Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request873(long Id) : Mediator.IRequest<Response873>, MediatR.IRequest<Response873>;

public sealed record Response873(long Id);

public sealed partial class Request873TraditionalHandler
	: Mediator.IRequestHandler<Request873, Response873>,
	MediatR.IRequestHandler<Request873, Response873>
{
	ValueTask<Response873> Mediator.IRequestHandler<Request873, Response873>.Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response873> MediatR.IRequestHandler<Request873, Response873>.Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request873StaticHandler
{
	private static ValueTask<Response873> Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request873SealedHandler
{
	private ValueTask<Response873> Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request874(long Id) : Mediator.IRequest<Response874>, MediatR.IRequest<Response874>;

public sealed record Response874(long Id);

public sealed partial class Request874TraditionalHandler
	: Mediator.IRequestHandler<Request874, Response874>,
	MediatR.IRequestHandler<Request874, Response874>
{
	ValueTask<Response874> Mediator.IRequestHandler<Request874, Response874>.Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response874> MediatR.IRequestHandler<Request874, Response874>.Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request874StaticHandler
{
	private static ValueTask<Response874> Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request874SealedHandler
{
	private ValueTask<Response874> Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request875(long Id) : Mediator.IRequest<Response875>, MediatR.IRequest<Response875>;

public sealed record Response875(long Id);

public sealed partial class Request875TraditionalHandler
	: Mediator.IRequestHandler<Request875, Response875>,
	MediatR.IRequestHandler<Request875, Response875>
{
	ValueTask<Response875> Mediator.IRequestHandler<Request875, Response875>.Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response875> MediatR.IRequestHandler<Request875, Response875>.Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request875StaticHandler
{
	private static ValueTask<Response875> Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request875SealedHandler
{
	private ValueTask<Response875> Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request876(long Id) : Mediator.IRequest<Response876>, MediatR.IRequest<Response876>;

public sealed record Response876(long Id);

public sealed partial class Request876TraditionalHandler
	: Mediator.IRequestHandler<Request876, Response876>,
	MediatR.IRequestHandler<Request876, Response876>
{
	ValueTask<Response876> Mediator.IRequestHandler<Request876, Response876>.Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response876> MediatR.IRequestHandler<Request876, Response876>.Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request876StaticHandler
{
	private static ValueTask<Response876> Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request876SealedHandler
{
	private ValueTask<Response876> Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request877(long Id) : Mediator.IRequest<Response877>, MediatR.IRequest<Response877>;

public sealed record Response877(long Id);

public sealed partial class Request877TraditionalHandler
	: Mediator.IRequestHandler<Request877, Response877>,
	MediatR.IRequestHandler<Request877, Response877>
{
	ValueTask<Response877> Mediator.IRequestHandler<Request877, Response877>.Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response877> MediatR.IRequestHandler<Request877, Response877>.Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request877StaticHandler
{
	private static ValueTask<Response877> Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request877SealedHandler
{
	private ValueTask<Response877> Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request878(long Id) : Mediator.IRequest<Response878>, MediatR.IRequest<Response878>;

public sealed record Response878(long Id);

public sealed partial class Request878TraditionalHandler
	: Mediator.IRequestHandler<Request878, Response878>,
	MediatR.IRequestHandler<Request878, Response878>
{
	ValueTask<Response878> Mediator.IRequestHandler<Request878, Response878>.Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response878> MediatR.IRequestHandler<Request878, Response878>.Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request878StaticHandler
{
	private static ValueTask<Response878> Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request878SealedHandler
{
	private ValueTask<Response878> Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request879(long Id) : Mediator.IRequest<Response879>, MediatR.IRequest<Response879>;

public sealed record Response879(long Id);

public sealed partial class Request879TraditionalHandler
	: Mediator.IRequestHandler<Request879, Response879>,
	MediatR.IRequestHandler<Request879, Response879>
{
	ValueTask<Response879> Mediator.IRequestHandler<Request879, Response879>.Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response879> MediatR.IRequestHandler<Request879, Response879>.Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request879StaticHandler
{
	private static ValueTask<Response879> Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request879SealedHandler
{
	private ValueTask<Response879> Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request880(long Id) : Mediator.IRequest<Response880>, MediatR.IRequest<Response880>;

public sealed record Response880(long Id);

public sealed partial class Request880TraditionalHandler
	: Mediator.IRequestHandler<Request880, Response880>,
	MediatR.IRequestHandler<Request880, Response880>
{
	ValueTask<Response880> Mediator.IRequestHandler<Request880, Response880>.Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response880> MediatR.IRequestHandler<Request880, Response880>.Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request880StaticHandler
{
	private static ValueTask<Response880> Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request880SealedHandler
{
	private ValueTask<Response880> Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request881(long Id) : Mediator.IRequest<Response881>, MediatR.IRequest<Response881>;

public sealed record Response881(long Id);

public sealed partial class Request881TraditionalHandler
	: Mediator.IRequestHandler<Request881, Response881>,
	MediatR.IRequestHandler<Request881, Response881>
{
	ValueTask<Response881> Mediator.IRequestHandler<Request881, Response881>.Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response881> MediatR.IRequestHandler<Request881, Response881>.Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request881StaticHandler
{
	private static ValueTask<Response881> Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request881SealedHandler
{
	private ValueTask<Response881> Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request882(long Id) : Mediator.IRequest<Response882>, MediatR.IRequest<Response882>;

public sealed record Response882(long Id);

public sealed partial class Request882TraditionalHandler
	: Mediator.IRequestHandler<Request882, Response882>,
	MediatR.IRequestHandler<Request882, Response882>
{
	ValueTask<Response882> Mediator.IRequestHandler<Request882, Response882>.Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response882> MediatR.IRequestHandler<Request882, Response882>.Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request882StaticHandler
{
	private static ValueTask<Response882> Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request882SealedHandler
{
	private ValueTask<Response882> Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request883(long Id) : Mediator.IRequest<Response883>, MediatR.IRequest<Response883>;

public sealed record Response883(long Id);

public sealed partial class Request883TraditionalHandler
	: Mediator.IRequestHandler<Request883, Response883>,
	MediatR.IRequestHandler<Request883, Response883>
{
	ValueTask<Response883> Mediator.IRequestHandler<Request883, Response883>.Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response883> MediatR.IRequestHandler<Request883, Response883>.Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request883StaticHandler
{
	private static ValueTask<Response883> Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request883SealedHandler
{
	private ValueTask<Response883> Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request884(long Id) : Mediator.IRequest<Response884>, MediatR.IRequest<Response884>;

public sealed record Response884(long Id);

public sealed partial class Request884TraditionalHandler
	: Mediator.IRequestHandler<Request884, Response884>,
	MediatR.IRequestHandler<Request884, Response884>
{
	ValueTask<Response884> Mediator.IRequestHandler<Request884, Response884>.Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response884> MediatR.IRequestHandler<Request884, Response884>.Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request884StaticHandler
{
	private static ValueTask<Response884> Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request884SealedHandler
{
	private ValueTask<Response884> Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request885(long Id) : Mediator.IRequest<Response885>, MediatR.IRequest<Response885>;

public sealed record Response885(long Id);

public sealed partial class Request885TraditionalHandler
	: Mediator.IRequestHandler<Request885, Response885>,
	MediatR.IRequestHandler<Request885, Response885>
{
	ValueTask<Response885> Mediator.IRequestHandler<Request885, Response885>.Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response885> MediatR.IRequestHandler<Request885, Response885>.Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request885StaticHandler
{
	private static ValueTask<Response885> Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request885SealedHandler
{
	private ValueTask<Response885> Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request886(long Id) : Mediator.IRequest<Response886>, MediatR.IRequest<Response886>;

public sealed record Response886(long Id);

public sealed partial class Request886TraditionalHandler
	: Mediator.IRequestHandler<Request886, Response886>,
	MediatR.IRequestHandler<Request886, Response886>
{
	ValueTask<Response886> Mediator.IRequestHandler<Request886, Response886>.Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response886> MediatR.IRequestHandler<Request886, Response886>.Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request886StaticHandler
{
	private static ValueTask<Response886> Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request886SealedHandler
{
	private ValueTask<Response886> Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request887(long Id) : Mediator.IRequest<Response887>, MediatR.IRequest<Response887>;

public sealed record Response887(long Id);

public sealed partial class Request887TraditionalHandler
	: Mediator.IRequestHandler<Request887, Response887>,
	MediatR.IRequestHandler<Request887, Response887>
{
	ValueTask<Response887> Mediator.IRequestHandler<Request887, Response887>.Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response887> MediatR.IRequestHandler<Request887, Response887>.Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request887StaticHandler
{
	private static ValueTask<Response887> Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request887SealedHandler
{
	private ValueTask<Response887> Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request888(long Id) : Mediator.IRequest<Response888>, MediatR.IRequest<Response888>;

public sealed record Response888(long Id);

public sealed partial class Request888TraditionalHandler
	: Mediator.IRequestHandler<Request888, Response888>,
	MediatR.IRequestHandler<Request888, Response888>
{
	ValueTask<Response888> Mediator.IRequestHandler<Request888, Response888>.Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response888> MediatR.IRequestHandler<Request888, Response888>.Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request888StaticHandler
{
	private static ValueTask<Response888> Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request888SealedHandler
{
	private ValueTask<Response888> Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request889(long Id) : Mediator.IRequest<Response889>, MediatR.IRequest<Response889>;

public sealed record Response889(long Id);

public sealed partial class Request889TraditionalHandler
	: Mediator.IRequestHandler<Request889, Response889>,
	MediatR.IRequestHandler<Request889, Response889>
{
	ValueTask<Response889> Mediator.IRequestHandler<Request889, Response889>.Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response889> MediatR.IRequestHandler<Request889, Response889>.Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request889StaticHandler
{
	private static ValueTask<Response889> Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request889SealedHandler
{
	private ValueTask<Response889> Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request890(long Id) : Mediator.IRequest<Response890>, MediatR.IRequest<Response890>;

public sealed record Response890(long Id);

public sealed partial class Request890TraditionalHandler
	: Mediator.IRequestHandler<Request890, Response890>,
	MediatR.IRequestHandler<Request890, Response890>
{
	ValueTask<Response890> Mediator.IRequestHandler<Request890, Response890>.Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response890> MediatR.IRequestHandler<Request890, Response890>.Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request890StaticHandler
{
	private static ValueTask<Response890> Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request890SealedHandler
{
	private ValueTask<Response890> Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request891(long Id) : Mediator.IRequest<Response891>, MediatR.IRequest<Response891>;

public sealed record Response891(long Id);

public sealed partial class Request891TraditionalHandler
	: Mediator.IRequestHandler<Request891, Response891>,
	MediatR.IRequestHandler<Request891, Response891>
{
	ValueTask<Response891> Mediator.IRequestHandler<Request891, Response891>.Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response891> MediatR.IRequestHandler<Request891, Response891>.Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request891StaticHandler
{
	private static ValueTask<Response891> Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request891SealedHandler
{
	private ValueTask<Response891> Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request892(long Id) : Mediator.IRequest<Response892>, MediatR.IRequest<Response892>;

public sealed record Response892(long Id);

public sealed partial class Request892TraditionalHandler
	: Mediator.IRequestHandler<Request892, Response892>,
	MediatR.IRequestHandler<Request892, Response892>
{
	ValueTask<Response892> Mediator.IRequestHandler<Request892, Response892>.Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response892> MediatR.IRequestHandler<Request892, Response892>.Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request892StaticHandler
{
	private static ValueTask<Response892> Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request892SealedHandler
{
	private ValueTask<Response892> Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request893(long Id) : Mediator.IRequest<Response893>, MediatR.IRequest<Response893>;

public sealed record Response893(long Id);

public sealed partial class Request893TraditionalHandler
	: Mediator.IRequestHandler<Request893, Response893>,
	MediatR.IRequestHandler<Request893, Response893>
{
	ValueTask<Response893> Mediator.IRequestHandler<Request893, Response893>.Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response893> MediatR.IRequestHandler<Request893, Response893>.Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request893StaticHandler
{
	private static ValueTask<Response893> Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request893SealedHandler
{
	private ValueTask<Response893> Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request894(long Id) : Mediator.IRequest<Response894>, MediatR.IRequest<Response894>;

public sealed record Response894(long Id);

public sealed partial class Request894TraditionalHandler
	: Mediator.IRequestHandler<Request894, Response894>,
	MediatR.IRequestHandler<Request894, Response894>
{
	ValueTask<Response894> Mediator.IRequestHandler<Request894, Response894>.Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response894> MediatR.IRequestHandler<Request894, Response894>.Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request894StaticHandler
{
	private static ValueTask<Response894> Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request894SealedHandler
{
	private ValueTask<Response894> Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request895(long Id) : Mediator.IRequest<Response895>, MediatR.IRequest<Response895>;

public sealed record Response895(long Id);

public sealed partial class Request895TraditionalHandler
	: Mediator.IRequestHandler<Request895, Response895>,
	MediatR.IRequestHandler<Request895, Response895>
{
	ValueTask<Response895> Mediator.IRequestHandler<Request895, Response895>.Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response895> MediatR.IRequestHandler<Request895, Response895>.Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request895StaticHandler
{
	private static ValueTask<Response895> Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request895SealedHandler
{
	private ValueTask<Response895> Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request896(long Id) : Mediator.IRequest<Response896>, MediatR.IRequest<Response896>;

public sealed record Response896(long Id);

public sealed partial class Request896TraditionalHandler
	: Mediator.IRequestHandler<Request896, Response896>,
	MediatR.IRequestHandler<Request896, Response896>
{
	ValueTask<Response896> Mediator.IRequestHandler<Request896, Response896>.Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response896> MediatR.IRequestHandler<Request896, Response896>.Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request896StaticHandler
{
	private static ValueTask<Response896> Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request896SealedHandler
{
	private ValueTask<Response896> Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request897(long Id) : Mediator.IRequest<Response897>, MediatR.IRequest<Response897>;

public sealed record Response897(long Id);

public sealed partial class Request897TraditionalHandler
	: Mediator.IRequestHandler<Request897, Response897>,
	MediatR.IRequestHandler<Request897, Response897>
{
	ValueTask<Response897> Mediator.IRequestHandler<Request897, Response897>.Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response897> MediatR.IRequestHandler<Request897, Response897>.Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request897StaticHandler
{
	private static ValueTask<Response897> Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request897SealedHandler
{
	private ValueTask<Response897> Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request898(long Id) : Mediator.IRequest<Response898>, MediatR.IRequest<Response898>;

public sealed record Response898(long Id);

public sealed partial class Request898TraditionalHandler
	: Mediator.IRequestHandler<Request898, Response898>,
	MediatR.IRequestHandler<Request898, Response898>
{
	ValueTask<Response898> Mediator.IRequestHandler<Request898, Response898>.Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response898> MediatR.IRequestHandler<Request898, Response898>.Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request898StaticHandler
{
	private static ValueTask<Response898> Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request898SealedHandler
{
	private ValueTask<Response898> Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request899(long Id) : Mediator.IRequest<Response899>, MediatR.IRequest<Response899>;

public sealed record Response899(long Id);

public sealed partial class Request899TraditionalHandler
	: Mediator.IRequestHandler<Request899, Response899>,
	MediatR.IRequestHandler<Request899, Response899>
{
	ValueTask<Response899> Mediator.IRequestHandler<Request899, Response899>.Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response899> MediatR.IRequestHandler<Request899, Response899>.Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request899StaticHandler
{
	private static ValueTask<Response899> Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request899SealedHandler
{
	private ValueTask<Response899> Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request900(long Id) : Mediator.IRequest<Response900>, MediatR.IRequest<Response900>;

public sealed record Response900(long Id);

public sealed partial class Request900TraditionalHandler
	: Mediator.IRequestHandler<Request900, Response900>,
	MediatR.IRequestHandler<Request900, Response900>
{
	ValueTask<Response900> Mediator.IRequestHandler<Request900, Response900>.Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response900> MediatR.IRequestHandler<Request900, Response900>.Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request900StaticHandler
{
	private static ValueTask<Response900> Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request900SealedHandler
{
	private ValueTask<Response900> Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request901(long Id) : Mediator.IRequest<Response901>, MediatR.IRequest<Response901>;

public sealed record Response901(long Id);

public sealed partial class Request901TraditionalHandler
	: Mediator.IRequestHandler<Request901, Response901>,
	MediatR.IRequestHandler<Request901, Response901>
{
	ValueTask<Response901> Mediator.IRequestHandler<Request901, Response901>.Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response901> MediatR.IRequestHandler<Request901, Response901>.Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request901StaticHandler
{
	private static ValueTask<Response901> Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request901SealedHandler
{
	private ValueTask<Response901> Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request902(long Id) : Mediator.IRequest<Response902>, MediatR.IRequest<Response902>;

public sealed record Response902(long Id);

public sealed partial class Request902TraditionalHandler
	: Mediator.IRequestHandler<Request902, Response902>,
	MediatR.IRequestHandler<Request902, Response902>
{
	ValueTask<Response902> Mediator.IRequestHandler<Request902, Response902>.Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response902> MediatR.IRequestHandler<Request902, Response902>.Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request902StaticHandler
{
	private static ValueTask<Response902> Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request902SealedHandler
{
	private ValueTask<Response902> Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request903(long Id) : Mediator.IRequest<Response903>, MediatR.IRequest<Response903>;

public sealed record Response903(long Id);

public sealed partial class Request903TraditionalHandler
	: Mediator.IRequestHandler<Request903, Response903>,
	MediatR.IRequestHandler<Request903, Response903>
{
	ValueTask<Response903> Mediator.IRequestHandler<Request903, Response903>.Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response903> MediatR.IRequestHandler<Request903, Response903>.Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request903StaticHandler
{
	private static ValueTask<Response903> Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request903SealedHandler
{
	private ValueTask<Response903> Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request904(long Id) : Mediator.IRequest<Response904>, MediatR.IRequest<Response904>;

public sealed record Response904(long Id);

public sealed partial class Request904TraditionalHandler
	: Mediator.IRequestHandler<Request904, Response904>,
	MediatR.IRequestHandler<Request904, Response904>
{
	ValueTask<Response904> Mediator.IRequestHandler<Request904, Response904>.Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response904> MediatR.IRequestHandler<Request904, Response904>.Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request904StaticHandler
{
	private static ValueTask<Response904> Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request904SealedHandler
{
	private ValueTask<Response904> Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request905(long Id) : Mediator.IRequest<Response905>, MediatR.IRequest<Response905>;

public sealed record Response905(long Id);

public sealed partial class Request905TraditionalHandler
	: Mediator.IRequestHandler<Request905, Response905>,
	MediatR.IRequestHandler<Request905, Response905>
{
	ValueTask<Response905> Mediator.IRequestHandler<Request905, Response905>.Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response905> MediatR.IRequestHandler<Request905, Response905>.Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request905StaticHandler
{
	private static ValueTask<Response905> Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request905SealedHandler
{
	private ValueTask<Response905> Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request906(long Id) : Mediator.IRequest<Response906>, MediatR.IRequest<Response906>;

public sealed record Response906(long Id);

public sealed partial class Request906TraditionalHandler
	: Mediator.IRequestHandler<Request906, Response906>,
	MediatR.IRequestHandler<Request906, Response906>
{
	ValueTask<Response906> Mediator.IRequestHandler<Request906, Response906>.Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response906> MediatR.IRequestHandler<Request906, Response906>.Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request906StaticHandler
{
	private static ValueTask<Response906> Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request906SealedHandler
{
	private ValueTask<Response906> Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request907(long Id) : Mediator.IRequest<Response907>, MediatR.IRequest<Response907>;

public sealed record Response907(long Id);

public sealed partial class Request907TraditionalHandler
	: Mediator.IRequestHandler<Request907, Response907>,
	MediatR.IRequestHandler<Request907, Response907>
{
	ValueTask<Response907> Mediator.IRequestHandler<Request907, Response907>.Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response907> MediatR.IRequestHandler<Request907, Response907>.Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request907StaticHandler
{
	private static ValueTask<Response907> Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request907SealedHandler
{
	private ValueTask<Response907> Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request908(long Id) : Mediator.IRequest<Response908>, MediatR.IRequest<Response908>;

public sealed record Response908(long Id);

public sealed partial class Request908TraditionalHandler
	: Mediator.IRequestHandler<Request908, Response908>,
	MediatR.IRequestHandler<Request908, Response908>
{
	ValueTask<Response908> Mediator.IRequestHandler<Request908, Response908>.Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response908> MediatR.IRequestHandler<Request908, Response908>.Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request908StaticHandler
{
	private static ValueTask<Response908> Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request908SealedHandler
{
	private ValueTask<Response908> Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request909(long Id) : Mediator.IRequest<Response909>, MediatR.IRequest<Response909>;

public sealed record Response909(long Id);

public sealed partial class Request909TraditionalHandler
	: Mediator.IRequestHandler<Request909, Response909>,
	MediatR.IRequestHandler<Request909, Response909>
{
	ValueTask<Response909> Mediator.IRequestHandler<Request909, Response909>.Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response909> MediatR.IRequestHandler<Request909, Response909>.Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request909StaticHandler
{
	private static ValueTask<Response909> Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request909SealedHandler
{
	private ValueTask<Response909> Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request910(long Id) : Mediator.IRequest<Response910>, MediatR.IRequest<Response910>;

public sealed record Response910(long Id);

public sealed partial class Request910TraditionalHandler
	: Mediator.IRequestHandler<Request910, Response910>,
	MediatR.IRequestHandler<Request910, Response910>
{
	ValueTask<Response910> Mediator.IRequestHandler<Request910, Response910>.Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response910> MediatR.IRequestHandler<Request910, Response910>.Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request910StaticHandler
{
	private static ValueTask<Response910> Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request910SealedHandler
{
	private ValueTask<Response910> Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request911(long Id) : Mediator.IRequest<Response911>, MediatR.IRequest<Response911>;

public sealed record Response911(long Id);

public sealed partial class Request911TraditionalHandler
	: Mediator.IRequestHandler<Request911, Response911>,
	MediatR.IRequestHandler<Request911, Response911>
{
	ValueTask<Response911> Mediator.IRequestHandler<Request911, Response911>.Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response911> MediatR.IRequestHandler<Request911, Response911>.Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request911StaticHandler
{
	private static ValueTask<Response911> Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request911SealedHandler
{
	private ValueTask<Response911> Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request912(long Id) : Mediator.IRequest<Response912>, MediatR.IRequest<Response912>;

public sealed record Response912(long Id);

public sealed partial class Request912TraditionalHandler
	: Mediator.IRequestHandler<Request912, Response912>,
	MediatR.IRequestHandler<Request912, Response912>
{
	ValueTask<Response912> Mediator.IRequestHandler<Request912, Response912>.Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response912> MediatR.IRequestHandler<Request912, Response912>.Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request912StaticHandler
{
	private static ValueTask<Response912> Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request912SealedHandler
{
	private ValueTask<Response912> Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request913(long Id) : Mediator.IRequest<Response913>, MediatR.IRequest<Response913>;

public sealed record Response913(long Id);

public sealed partial class Request913TraditionalHandler
	: Mediator.IRequestHandler<Request913, Response913>,
	MediatR.IRequestHandler<Request913, Response913>
{
	ValueTask<Response913> Mediator.IRequestHandler<Request913, Response913>.Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response913> MediatR.IRequestHandler<Request913, Response913>.Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request913StaticHandler
{
	private static ValueTask<Response913> Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request913SealedHandler
{
	private ValueTask<Response913> Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request914(long Id) : Mediator.IRequest<Response914>, MediatR.IRequest<Response914>;

public sealed record Response914(long Id);

public sealed partial class Request914TraditionalHandler
	: Mediator.IRequestHandler<Request914, Response914>,
	MediatR.IRequestHandler<Request914, Response914>
{
	ValueTask<Response914> Mediator.IRequestHandler<Request914, Response914>.Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response914> MediatR.IRequestHandler<Request914, Response914>.Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request914StaticHandler
{
	private static ValueTask<Response914> Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request914SealedHandler
{
	private ValueTask<Response914> Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request915(long Id) : Mediator.IRequest<Response915>, MediatR.IRequest<Response915>;

public sealed record Response915(long Id);

public sealed partial class Request915TraditionalHandler
	: Mediator.IRequestHandler<Request915, Response915>,
	MediatR.IRequestHandler<Request915, Response915>
{
	ValueTask<Response915> Mediator.IRequestHandler<Request915, Response915>.Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response915> MediatR.IRequestHandler<Request915, Response915>.Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request915StaticHandler
{
	private static ValueTask<Response915> Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request915SealedHandler
{
	private ValueTask<Response915> Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request916(long Id) : Mediator.IRequest<Response916>, MediatR.IRequest<Response916>;

public sealed record Response916(long Id);

public sealed partial class Request916TraditionalHandler
	: Mediator.IRequestHandler<Request916, Response916>,
	MediatR.IRequestHandler<Request916, Response916>
{
	ValueTask<Response916> Mediator.IRequestHandler<Request916, Response916>.Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response916> MediatR.IRequestHandler<Request916, Response916>.Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request916StaticHandler
{
	private static ValueTask<Response916> Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request916SealedHandler
{
	private ValueTask<Response916> Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request917(long Id) : Mediator.IRequest<Response917>, MediatR.IRequest<Response917>;

public sealed record Response917(long Id);

public sealed partial class Request917TraditionalHandler
	: Mediator.IRequestHandler<Request917, Response917>,
	MediatR.IRequestHandler<Request917, Response917>
{
	ValueTask<Response917> Mediator.IRequestHandler<Request917, Response917>.Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response917> MediatR.IRequestHandler<Request917, Response917>.Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request917StaticHandler
{
	private static ValueTask<Response917> Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request917SealedHandler
{
	private ValueTask<Response917> Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request918(long Id) : Mediator.IRequest<Response918>, MediatR.IRequest<Response918>;

public sealed record Response918(long Id);

public sealed partial class Request918TraditionalHandler
	: Mediator.IRequestHandler<Request918, Response918>,
	MediatR.IRequestHandler<Request918, Response918>
{
	ValueTask<Response918> Mediator.IRequestHandler<Request918, Response918>.Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response918> MediatR.IRequestHandler<Request918, Response918>.Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request918StaticHandler
{
	private static ValueTask<Response918> Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request918SealedHandler
{
	private ValueTask<Response918> Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request919(long Id) : Mediator.IRequest<Response919>, MediatR.IRequest<Response919>;

public sealed record Response919(long Id);

public sealed partial class Request919TraditionalHandler
	: Mediator.IRequestHandler<Request919, Response919>,
	MediatR.IRequestHandler<Request919, Response919>
{
	ValueTask<Response919> Mediator.IRequestHandler<Request919, Response919>.Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response919> MediatR.IRequestHandler<Request919, Response919>.Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request919StaticHandler
{
	private static ValueTask<Response919> Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request919SealedHandler
{
	private ValueTask<Response919> Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request920(long Id) : Mediator.IRequest<Response920>, MediatR.IRequest<Response920>;

public sealed record Response920(long Id);

public sealed partial class Request920TraditionalHandler
	: Mediator.IRequestHandler<Request920, Response920>,
	MediatR.IRequestHandler<Request920, Response920>
{
	ValueTask<Response920> Mediator.IRequestHandler<Request920, Response920>.Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response920> MediatR.IRequestHandler<Request920, Response920>.Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request920StaticHandler
{
	private static ValueTask<Response920> Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request920SealedHandler
{
	private ValueTask<Response920> Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request921(long Id) : Mediator.IRequest<Response921>, MediatR.IRequest<Response921>;

public sealed record Response921(long Id);

public sealed partial class Request921TraditionalHandler
	: Mediator.IRequestHandler<Request921, Response921>,
	MediatR.IRequestHandler<Request921, Response921>
{
	ValueTask<Response921> Mediator.IRequestHandler<Request921, Response921>.Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response921> MediatR.IRequestHandler<Request921, Response921>.Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request921StaticHandler
{
	private static ValueTask<Response921> Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request921SealedHandler
{
	private ValueTask<Response921> Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request922(long Id) : Mediator.IRequest<Response922>, MediatR.IRequest<Response922>;

public sealed record Response922(long Id);

public sealed partial class Request922TraditionalHandler
	: Mediator.IRequestHandler<Request922, Response922>,
	MediatR.IRequestHandler<Request922, Response922>
{
	ValueTask<Response922> Mediator.IRequestHandler<Request922, Response922>.Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response922> MediatR.IRequestHandler<Request922, Response922>.Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request922StaticHandler
{
	private static ValueTask<Response922> Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request922SealedHandler
{
	private ValueTask<Response922> Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request923(long Id) : Mediator.IRequest<Response923>, MediatR.IRequest<Response923>;

public sealed record Response923(long Id);

public sealed partial class Request923TraditionalHandler
	: Mediator.IRequestHandler<Request923, Response923>,
	MediatR.IRequestHandler<Request923, Response923>
{
	ValueTask<Response923> Mediator.IRequestHandler<Request923, Response923>.Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response923> MediatR.IRequestHandler<Request923, Response923>.Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request923StaticHandler
{
	private static ValueTask<Response923> Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request923SealedHandler
{
	private ValueTask<Response923> Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request924(long Id) : Mediator.IRequest<Response924>, MediatR.IRequest<Response924>;

public sealed record Response924(long Id);

public sealed partial class Request924TraditionalHandler
	: Mediator.IRequestHandler<Request924, Response924>,
	MediatR.IRequestHandler<Request924, Response924>
{
	ValueTask<Response924> Mediator.IRequestHandler<Request924, Response924>.Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response924> MediatR.IRequestHandler<Request924, Response924>.Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request924StaticHandler
{
	private static ValueTask<Response924> Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request924SealedHandler
{
	private ValueTask<Response924> Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request925(long Id) : Mediator.IRequest<Response925>, MediatR.IRequest<Response925>;

public sealed record Response925(long Id);

public sealed partial class Request925TraditionalHandler
	: Mediator.IRequestHandler<Request925, Response925>,
	MediatR.IRequestHandler<Request925, Response925>
{
	ValueTask<Response925> Mediator.IRequestHandler<Request925, Response925>.Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response925> MediatR.IRequestHandler<Request925, Response925>.Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request925StaticHandler
{
	private static ValueTask<Response925> Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request925SealedHandler
{
	private ValueTask<Response925> Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request926(long Id) : Mediator.IRequest<Response926>, MediatR.IRequest<Response926>;

public sealed record Response926(long Id);

public sealed partial class Request926TraditionalHandler
	: Mediator.IRequestHandler<Request926, Response926>,
	MediatR.IRequestHandler<Request926, Response926>
{
	ValueTask<Response926> Mediator.IRequestHandler<Request926, Response926>.Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response926> MediatR.IRequestHandler<Request926, Response926>.Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request926StaticHandler
{
	private static ValueTask<Response926> Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request926SealedHandler
{
	private ValueTask<Response926> Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request927(long Id) : Mediator.IRequest<Response927>, MediatR.IRequest<Response927>;

public sealed record Response927(long Id);

public sealed partial class Request927TraditionalHandler
	: Mediator.IRequestHandler<Request927, Response927>,
	MediatR.IRequestHandler<Request927, Response927>
{
	ValueTask<Response927> Mediator.IRequestHandler<Request927, Response927>.Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response927> MediatR.IRequestHandler<Request927, Response927>.Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request927StaticHandler
{
	private static ValueTask<Response927> Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request927SealedHandler
{
	private ValueTask<Response927> Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request928(long Id) : Mediator.IRequest<Response928>, MediatR.IRequest<Response928>;

public sealed record Response928(long Id);

public sealed partial class Request928TraditionalHandler
	: Mediator.IRequestHandler<Request928, Response928>,
	MediatR.IRequestHandler<Request928, Response928>
{
	ValueTask<Response928> Mediator.IRequestHandler<Request928, Response928>.Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response928> MediatR.IRequestHandler<Request928, Response928>.Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request928StaticHandler
{
	private static ValueTask<Response928> Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request928SealedHandler
{
	private ValueTask<Response928> Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request929(long Id) : Mediator.IRequest<Response929>, MediatR.IRequest<Response929>;

public sealed record Response929(long Id);

public sealed partial class Request929TraditionalHandler
	: Mediator.IRequestHandler<Request929, Response929>,
	MediatR.IRequestHandler<Request929, Response929>
{
	ValueTask<Response929> Mediator.IRequestHandler<Request929, Response929>.Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response929> MediatR.IRequestHandler<Request929, Response929>.Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request929StaticHandler
{
	private static ValueTask<Response929> Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request929SealedHandler
{
	private ValueTask<Response929> Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request930(long Id) : Mediator.IRequest<Response930>, MediatR.IRequest<Response930>;

public sealed record Response930(long Id);

public sealed partial class Request930TraditionalHandler
	: Mediator.IRequestHandler<Request930, Response930>,
	MediatR.IRequestHandler<Request930, Response930>
{
	ValueTask<Response930> Mediator.IRequestHandler<Request930, Response930>.Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response930> MediatR.IRequestHandler<Request930, Response930>.Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request930StaticHandler
{
	private static ValueTask<Response930> Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request930SealedHandler
{
	private ValueTask<Response930> Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request931(long Id) : Mediator.IRequest<Response931>, MediatR.IRequest<Response931>;

public sealed record Response931(long Id);

public sealed partial class Request931TraditionalHandler
	: Mediator.IRequestHandler<Request931, Response931>,
	MediatR.IRequestHandler<Request931, Response931>
{
	ValueTask<Response931> Mediator.IRequestHandler<Request931, Response931>.Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response931> MediatR.IRequestHandler<Request931, Response931>.Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request931StaticHandler
{
	private static ValueTask<Response931> Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request931SealedHandler
{
	private ValueTask<Response931> Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request932(long Id) : Mediator.IRequest<Response932>, MediatR.IRequest<Response932>;

public sealed record Response932(long Id);

public sealed partial class Request932TraditionalHandler
	: Mediator.IRequestHandler<Request932, Response932>,
	MediatR.IRequestHandler<Request932, Response932>
{
	ValueTask<Response932> Mediator.IRequestHandler<Request932, Response932>.Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response932> MediatR.IRequestHandler<Request932, Response932>.Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request932StaticHandler
{
	private static ValueTask<Response932> Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request932SealedHandler
{
	private ValueTask<Response932> Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request933(long Id) : Mediator.IRequest<Response933>, MediatR.IRequest<Response933>;

public sealed record Response933(long Id);

public sealed partial class Request933TraditionalHandler
	: Mediator.IRequestHandler<Request933, Response933>,
	MediatR.IRequestHandler<Request933, Response933>
{
	ValueTask<Response933> Mediator.IRequestHandler<Request933, Response933>.Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response933> MediatR.IRequestHandler<Request933, Response933>.Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request933StaticHandler
{
	private static ValueTask<Response933> Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request933SealedHandler
{
	private ValueTask<Response933> Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request934(long Id) : Mediator.IRequest<Response934>, MediatR.IRequest<Response934>;

public sealed record Response934(long Id);

public sealed partial class Request934TraditionalHandler
	: Mediator.IRequestHandler<Request934, Response934>,
	MediatR.IRequestHandler<Request934, Response934>
{
	ValueTask<Response934> Mediator.IRequestHandler<Request934, Response934>.Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response934> MediatR.IRequestHandler<Request934, Response934>.Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request934StaticHandler
{
	private static ValueTask<Response934> Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request934SealedHandler
{
	private ValueTask<Response934> Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request935(long Id) : Mediator.IRequest<Response935>, MediatR.IRequest<Response935>;

public sealed record Response935(long Id);

public sealed partial class Request935TraditionalHandler
	: Mediator.IRequestHandler<Request935, Response935>,
	MediatR.IRequestHandler<Request935, Response935>
{
	ValueTask<Response935> Mediator.IRequestHandler<Request935, Response935>.Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response935> MediatR.IRequestHandler<Request935, Response935>.Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request935StaticHandler
{
	private static ValueTask<Response935> Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request935SealedHandler
{
	private ValueTask<Response935> Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request936(long Id) : Mediator.IRequest<Response936>, MediatR.IRequest<Response936>;

public sealed record Response936(long Id);

public sealed partial class Request936TraditionalHandler
	: Mediator.IRequestHandler<Request936, Response936>,
	MediatR.IRequestHandler<Request936, Response936>
{
	ValueTask<Response936> Mediator.IRequestHandler<Request936, Response936>.Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response936> MediatR.IRequestHandler<Request936, Response936>.Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request936StaticHandler
{
	private static ValueTask<Response936> Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request936SealedHandler
{
	private ValueTask<Response936> Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request937(long Id) : Mediator.IRequest<Response937>, MediatR.IRequest<Response937>;

public sealed record Response937(long Id);

public sealed partial class Request937TraditionalHandler
	: Mediator.IRequestHandler<Request937, Response937>,
	MediatR.IRequestHandler<Request937, Response937>
{
	ValueTask<Response937> Mediator.IRequestHandler<Request937, Response937>.Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response937> MediatR.IRequestHandler<Request937, Response937>.Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request937StaticHandler
{
	private static ValueTask<Response937> Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request937SealedHandler
{
	private ValueTask<Response937> Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request938(long Id) : Mediator.IRequest<Response938>, MediatR.IRequest<Response938>;

public sealed record Response938(long Id);

public sealed partial class Request938TraditionalHandler
	: Mediator.IRequestHandler<Request938, Response938>,
	MediatR.IRequestHandler<Request938, Response938>
{
	ValueTask<Response938> Mediator.IRequestHandler<Request938, Response938>.Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response938> MediatR.IRequestHandler<Request938, Response938>.Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request938StaticHandler
{
	private static ValueTask<Response938> Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request938SealedHandler
{
	private ValueTask<Response938> Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request939(long Id) : Mediator.IRequest<Response939>, MediatR.IRequest<Response939>;

public sealed record Response939(long Id);

public sealed partial class Request939TraditionalHandler
	: Mediator.IRequestHandler<Request939, Response939>,
	MediatR.IRequestHandler<Request939, Response939>
{
	ValueTask<Response939> Mediator.IRequestHandler<Request939, Response939>.Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response939> MediatR.IRequestHandler<Request939, Response939>.Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request939StaticHandler
{
	private static ValueTask<Response939> Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request939SealedHandler
{
	private ValueTask<Response939> Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request940(long Id) : Mediator.IRequest<Response940>, MediatR.IRequest<Response940>;

public sealed record Response940(long Id);

public sealed partial class Request940TraditionalHandler
	: Mediator.IRequestHandler<Request940, Response940>,
	MediatR.IRequestHandler<Request940, Response940>
{
	ValueTask<Response940> Mediator.IRequestHandler<Request940, Response940>.Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response940> MediatR.IRequestHandler<Request940, Response940>.Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request940StaticHandler
{
	private static ValueTask<Response940> Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request940SealedHandler
{
	private ValueTask<Response940> Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request941(long Id) : Mediator.IRequest<Response941>, MediatR.IRequest<Response941>;

public sealed record Response941(long Id);

public sealed partial class Request941TraditionalHandler
	: Mediator.IRequestHandler<Request941, Response941>,
	MediatR.IRequestHandler<Request941, Response941>
{
	ValueTask<Response941> Mediator.IRequestHandler<Request941, Response941>.Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response941> MediatR.IRequestHandler<Request941, Response941>.Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request941StaticHandler
{
	private static ValueTask<Response941> Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request941SealedHandler
{
	private ValueTask<Response941> Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request942(long Id) : Mediator.IRequest<Response942>, MediatR.IRequest<Response942>;

public sealed record Response942(long Id);

public sealed partial class Request942TraditionalHandler
	: Mediator.IRequestHandler<Request942, Response942>,
	MediatR.IRequestHandler<Request942, Response942>
{
	ValueTask<Response942> Mediator.IRequestHandler<Request942, Response942>.Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response942> MediatR.IRequestHandler<Request942, Response942>.Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request942StaticHandler
{
	private static ValueTask<Response942> Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request942SealedHandler
{
	private ValueTask<Response942> Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request943(long Id) : Mediator.IRequest<Response943>, MediatR.IRequest<Response943>;

public sealed record Response943(long Id);

public sealed partial class Request943TraditionalHandler
	: Mediator.IRequestHandler<Request943, Response943>,
	MediatR.IRequestHandler<Request943, Response943>
{
	ValueTask<Response943> Mediator.IRequestHandler<Request943, Response943>.Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response943> MediatR.IRequestHandler<Request943, Response943>.Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request943StaticHandler
{
	private static ValueTask<Response943> Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request943SealedHandler
{
	private ValueTask<Response943> Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request944(long Id) : Mediator.IRequest<Response944>, MediatR.IRequest<Response944>;

public sealed record Response944(long Id);

public sealed partial class Request944TraditionalHandler
	: Mediator.IRequestHandler<Request944, Response944>,
	MediatR.IRequestHandler<Request944, Response944>
{
	ValueTask<Response944> Mediator.IRequestHandler<Request944, Response944>.Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response944> MediatR.IRequestHandler<Request944, Response944>.Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request944StaticHandler
{
	private static ValueTask<Response944> Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request944SealedHandler
{
	private ValueTask<Response944> Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request945(long Id) : Mediator.IRequest<Response945>, MediatR.IRequest<Response945>;

public sealed record Response945(long Id);

public sealed partial class Request945TraditionalHandler
	: Mediator.IRequestHandler<Request945, Response945>,
	MediatR.IRequestHandler<Request945, Response945>
{
	ValueTask<Response945> Mediator.IRequestHandler<Request945, Response945>.Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response945> MediatR.IRequestHandler<Request945, Response945>.Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request945StaticHandler
{
	private static ValueTask<Response945> Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request945SealedHandler
{
	private ValueTask<Response945> Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request946(long Id) : Mediator.IRequest<Response946>, MediatR.IRequest<Response946>;

public sealed record Response946(long Id);

public sealed partial class Request946TraditionalHandler
	: Mediator.IRequestHandler<Request946, Response946>,
	MediatR.IRequestHandler<Request946, Response946>
{
	ValueTask<Response946> Mediator.IRequestHandler<Request946, Response946>.Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response946> MediatR.IRequestHandler<Request946, Response946>.Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request946StaticHandler
{
	private static ValueTask<Response946> Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request946SealedHandler
{
	private ValueTask<Response946> Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request947(long Id) : Mediator.IRequest<Response947>, MediatR.IRequest<Response947>;

public sealed record Response947(long Id);

public sealed partial class Request947TraditionalHandler
	: Mediator.IRequestHandler<Request947, Response947>,
	MediatR.IRequestHandler<Request947, Response947>
{
	ValueTask<Response947> Mediator.IRequestHandler<Request947, Response947>.Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response947> MediatR.IRequestHandler<Request947, Response947>.Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request947StaticHandler
{
	private static ValueTask<Response947> Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request947SealedHandler
{
	private ValueTask<Response947> Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request948(long Id) : Mediator.IRequest<Response948>, MediatR.IRequest<Response948>;

public sealed record Response948(long Id);

public sealed partial class Request948TraditionalHandler
	: Mediator.IRequestHandler<Request948, Response948>,
	MediatR.IRequestHandler<Request948, Response948>
{
	ValueTask<Response948> Mediator.IRequestHandler<Request948, Response948>.Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response948> MediatR.IRequestHandler<Request948, Response948>.Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request948StaticHandler
{
	private static ValueTask<Response948> Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request948SealedHandler
{
	private ValueTask<Response948> Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request949(long Id) : Mediator.IRequest<Response949>, MediatR.IRequest<Response949>;

public sealed record Response949(long Id);

public sealed partial class Request949TraditionalHandler
	: Mediator.IRequestHandler<Request949, Response949>,
	MediatR.IRequestHandler<Request949, Response949>
{
	ValueTask<Response949> Mediator.IRequestHandler<Request949, Response949>.Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response949> MediatR.IRequestHandler<Request949, Response949>.Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request949StaticHandler
{
	private static ValueTask<Response949> Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request949SealedHandler
{
	private ValueTask<Response949> Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request950(long Id) : Mediator.IRequest<Response950>, MediatR.IRequest<Response950>;

public sealed record Response950(long Id);

public sealed partial class Request950TraditionalHandler
	: Mediator.IRequestHandler<Request950, Response950>,
	MediatR.IRequestHandler<Request950, Response950>
{
	ValueTask<Response950> Mediator.IRequestHandler<Request950, Response950>.Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response950> MediatR.IRequestHandler<Request950, Response950>.Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request950StaticHandler
{
	private static ValueTask<Response950> Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request950SealedHandler
{
	private ValueTask<Response950> Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request951(long Id) : Mediator.IRequest<Response951>, MediatR.IRequest<Response951>;

public sealed record Response951(long Id);

public sealed partial class Request951TraditionalHandler
	: Mediator.IRequestHandler<Request951, Response951>,
	MediatR.IRequestHandler<Request951, Response951>
{
	ValueTask<Response951> Mediator.IRequestHandler<Request951, Response951>.Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response951> MediatR.IRequestHandler<Request951, Response951>.Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request951StaticHandler
{
	private static ValueTask<Response951> Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request951SealedHandler
{
	private ValueTask<Response951> Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request952(long Id) : Mediator.IRequest<Response952>, MediatR.IRequest<Response952>;

public sealed record Response952(long Id);

public sealed partial class Request952TraditionalHandler
	: Mediator.IRequestHandler<Request952, Response952>,
	MediatR.IRequestHandler<Request952, Response952>
{
	ValueTask<Response952> Mediator.IRequestHandler<Request952, Response952>.Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response952> MediatR.IRequestHandler<Request952, Response952>.Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request952StaticHandler
{
	private static ValueTask<Response952> Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request952SealedHandler
{
	private ValueTask<Response952> Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request953(long Id) : Mediator.IRequest<Response953>, MediatR.IRequest<Response953>;

public sealed record Response953(long Id);

public sealed partial class Request953TraditionalHandler
	: Mediator.IRequestHandler<Request953, Response953>,
	MediatR.IRequestHandler<Request953, Response953>
{
	ValueTask<Response953> Mediator.IRequestHandler<Request953, Response953>.Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response953> MediatR.IRequestHandler<Request953, Response953>.Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request953StaticHandler
{
	private static ValueTask<Response953> Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request953SealedHandler
{
	private ValueTask<Response953> Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request954(long Id) : Mediator.IRequest<Response954>, MediatR.IRequest<Response954>;

public sealed record Response954(long Id);

public sealed partial class Request954TraditionalHandler
	: Mediator.IRequestHandler<Request954, Response954>,
	MediatR.IRequestHandler<Request954, Response954>
{
	ValueTask<Response954> Mediator.IRequestHandler<Request954, Response954>.Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response954> MediatR.IRequestHandler<Request954, Response954>.Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request954StaticHandler
{
	private static ValueTask<Response954> Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request954SealedHandler
{
	private ValueTask<Response954> Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request955(long Id) : Mediator.IRequest<Response955>, MediatR.IRequest<Response955>;

public sealed record Response955(long Id);

public sealed partial class Request955TraditionalHandler
	: Mediator.IRequestHandler<Request955, Response955>,
	MediatR.IRequestHandler<Request955, Response955>
{
	ValueTask<Response955> Mediator.IRequestHandler<Request955, Response955>.Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response955> MediatR.IRequestHandler<Request955, Response955>.Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request955StaticHandler
{
	private static ValueTask<Response955> Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request955SealedHandler
{
	private ValueTask<Response955> Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request956(long Id) : Mediator.IRequest<Response956>, MediatR.IRequest<Response956>;

public sealed record Response956(long Id);

public sealed partial class Request956TraditionalHandler
	: Mediator.IRequestHandler<Request956, Response956>,
	MediatR.IRequestHandler<Request956, Response956>
{
	ValueTask<Response956> Mediator.IRequestHandler<Request956, Response956>.Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response956> MediatR.IRequestHandler<Request956, Response956>.Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request956StaticHandler
{
	private static ValueTask<Response956> Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request956SealedHandler
{
	private ValueTask<Response956> Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request957(long Id) : Mediator.IRequest<Response957>, MediatR.IRequest<Response957>;

public sealed record Response957(long Id);

public sealed partial class Request957TraditionalHandler
	: Mediator.IRequestHandler<Request957, Response957>,
	MediatR.IRequestHandler<Request957, Response957>
{
	ValueTask<Response957> Mediator.IRequestHandler<Request957, Response957>.Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response957> MediatR.IRequestHandler<Request957, Response957>.Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request957StaticHandler
{
	private static ValueTask<Response957> Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request957SealedHandler
{
	private ValueTask<Response957> Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request958(long Id) : Mediator.IRequest<Response958>, MediatR.IRequest<Response958>;

public sealed record Response958(long Id);

public sealed partial class Request958TraditionalHandler
	: Mediator.IRequestHandler<Request958, Response958>,
	MediatR.IRequestHandler<Request958, Response958>
{
	ValueTask<Response958> Mediator.IRequestHandler<Request958, Response958>.Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response958> MediatR.IRequestHandler<Request958, Response958>.Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request958StaticHandler
{
	private static ValueTask<Response958> Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request958SealedHandler
{
	private ValueTask<Response958> Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request959(long Id) : Mediator.IRequest<Response959>, MediatR.IRequest<Response959>;

public sealed record Response959(long Id);

public sealed partial class Request959TraditionalHandler
	: Mediator.IRequestHandler<Request959, Response959>,
	MediatR.IRequestHandler<Request959, Response959>
{
	ValueTask<Response959> Mediator.IRequestHandler<Request959, Response959>.Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response959> MediatR.IRequestHandler<Request959, Response959>.Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request959StaticHandler
{
	private static ValueTask<Response959> Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request959SealedHandler
{
	private ValueTask<Response959> Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request960(long Id) : Mediator.IRequest<Response960>, MediatR.IRequest<Response960>;

public sealed record Response960(long Id);

public sealed partial class Request960TraditionalHandler
	: Mediator.IRequestHandler<Request960, Response960>,
	MediatR.IRequestHandler<Request960, Response960>
{
	ValueTask<Response960> Mediator.IRequestHandler<Request960, Response960>.Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response960> MediatR.IRequestHandler<Request960, Response960>.Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request960StaticHandler
{
	private static ValueTask<Response960> Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request960SealedHandler
{
	private ValueTask<Response960> Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request961(long Id) : Mediator.IRequest<Response961>, MediatR.IRequest<Response961>;

public sealed record Response961(long Id);

public sealed partial class Request961TraditionalHandler
	: Mediator.IRequestHandler<Request961, Response961>,
	MediatR.IRequestHandler<Request961, Response961>
{
	ValueTask<Response961> Mediator.IRequestHandler<Request961, Response961>.Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response961> MediatR.IRequestHandler<Request961, Response961>.Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request961StaticHandler
{
	private static ValueTask<Response961> Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request961SealedHandler
{
	private ValueTask<Response961> Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request962(long Id) : Mediator.IRequest<Response962>, MediatR.IRequest<Response962>;

public sealed record Response962(long Id);

public sealed partial class Request962TraditionalHandler
	: Mediator.IRequestHandler<Request962, Response962>,
	MediatR.IRequestHandler<Request962, Response962>
{
	ValueTask<Response962> Mediator.IRequestHandler<Request962, Response962>.Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response962> MediatR.IRequestHandler<Request962, Response962>.Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request962StaticHandler
{
	private static ValueTask<Response962> Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request962SealedHandler
{
	private ValueTask<Response962> Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request963(long Id) : Mediator.IRequest<Response963>, MediatR.IRequest<Response963>;

public sealed record Response963(long Id);

public sealed partial class Request963TraditionalHandler
	: Mediator.IRequestHandler<Request963, Response963>,
	MediatR.IRequestHandler<Request963, Response963>
{
	ValueTask<Response963> Mediator.IRequestHandler<Request963, Response963>.Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response963> MediatR.IRequestHandler<Request963, Response963>.Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request963StaticHandler
{
	private static ValueTask<Response963> Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request963SealedHandler
{
	private ValueTask<Response963> Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request964(long Id) : Mediator.IRequest<Response964>, MediatR.IRequest<Response964>;

public sealed record Response964(long Id);

public sealed partial class Request964TraditionalHandler
	: Mediator.IRequestHandler<Request964, Response964>,
	MediatR.IRequestHandler<Request964, Response964>
{
	ValueTask<Response964> Mediator.IRequestHandler<Request964, Response964>.Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response964> MediatR.IRequestHandler<Request964, Response964>.Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request964StaticHandler
{
	private static ValueTask<Response964> Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request964SealedHandler
{
	private ValueTask<Response964> Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request965(long Id) : Mediator.IRequest<Response965>, MediatR.IRequest<Response965>;

public sealed record Response965(long Id);

public sealed partial class Request965TraditionalHandler
	: Mediator.IRequestHandler<Request965, Response965>,
	MediatR.IRequestHandler<Request965, Response965>
{
	ValueTask<Response965> Mediator.IRequestHandler<Request965, Response965>.Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response965> MediatR.IRequestHandler<Request965, Response965>.Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request965StaticHandler
{
	private static ValueTask<Response965> Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request965SealedHandler
{
	private ValueTask<Response965> Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request966(long Id) : Mediator.IRequest<Response966>, MediatR.IRequest<Response966>;

public sealed record Response966(long Id);

public sealed partial class Request966TraditionalHandler
	: Mediator.IRequestHandler<Request966, Response966>,
	MediatR.IRequestHandler<Request966, Response966>
{
	ValueTask<Response966> Mediator.IRequestHandler<Request966, Response966>.Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response966> MediatR.IRequestHandler<Request966, Response966>.Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request966StaticHandler
{
	private static ValueTask<Response966> Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request966SealedHandler
{
	private ValueTask<Response966> Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request967(long Id) : Mediator.IRequest<Response967>, MediatR.IRequest<Response967>;

public sealed record Response967(long Id);

public sealed partial class Request967TraditionalHandler
	: Mediator.IRequestHandler<Request967, Response967>,
	MediatR.IRequestHandler<Request967, Response967>
{
	ValueTask<Response967> Mediator.IRequestHandler<Request967, Response967>.Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response967> MediatR.IRequestHandler<Request967, Response967>.Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request967StaticHandler
{
	private static ValueTask<Response967> Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request967SealedHandler
{
	private ValueTask<Response967> Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request968(long Id) : Mediator.IRequest<Response968>, MediatR.IRequest<Response968>;

public sealed record Response968(long Id);

public sealed partial class Request968TraditionalHandler
	: Mediator.IRequestHandler<Request968, Response968>,
	MediatR.IRequestHandler<Request968, Response968>
{
	ValueTask<Response968> Mediator.IRequestHandler<Request968, Response968>.Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response968> MediatR.IRequestHandler<Request968, Response968>.Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request968StaticHandler
{
	private static ValueTask<Response968> Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request968SealedHandler
{
	private ValueTask<Response968> Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request969(long Id) : Mediator.IRequest<Response969>, MediatR.IRequest<Response969>;

public sealed record Response969(long Id);

public sealed partial class Request969TraditionalHandler
	: Mediator.IRequestHandler<Request969, Response969>,
	MediatR.IRequestHandler<Request969, Response969>
{
	ValueTask<Response969> Mediator.IRequestHandler<Request969, Response969>.Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response969> MediatR.IRequestHandler<Request969, Response969>.Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request969StaticHandler
{
	private static ValueTask<Response969> Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request969SealedHandler
{
	private ValueTask<Response969> Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request970(long Id) : Mediator.IRequest<Response970>, MediatR.IRequest<Response970>;

public sealed record Response970(long Id);

public sealed partial class Request970TraditionalHandler
	: Mediator.IRequestHandler<Request970, Response970>,
	MediatR.IRequestHandler<Request970, Response970>
{
	ValueTask<Response970> Mediator.IRequestHandler<Request970, Response970>.Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response970> MediatR.IRequestHandler<Request970, Response970>.Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request970StaticHandler
{
	private static ValueTask<Response970> Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request970SealedHandler
{
	private ValueTask<Response970> Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request971(long Id) : Mediator.IRequest<Response971>, MediatR.IRequest<Response971>;

public sealed record Response971(long Id);

public sealed partial class Request971TraditionalHandler
	: Mediator.IRequestHandler<Request971, Response971>,
	MediatR.IRequestHandler<Request971, Response971>
{
	ValueTask<Response971> Mediator.IRequestHandler<Request971, Response971>.Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response971> MediatR.IRequestHandler<Request971, Response971>.Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request971StaticHandler
{
	private static ValueTask<Response971> Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request971SealedHandler
{
	private ValueTask<Response971> Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request972(long Id) : Mediator.IRequest<Response972>, MediatR.IRequest<Response972>;

public sealed record Response972(long Id);

public sealed partial class Request972TraditionalHandler
	: Mediator.IRequestHandler<Request972, Response972>,
	MediatR.IRequestHandler<Request972, Response972>
{
	ValueTask<Response972> Mediator.IRequestHandler<Request972, Response972>.Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response972> MediatR.IRequestHandler<Request972, Response972>.Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request972StaticHandler
{
	private static ValueTask<Response972> Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request972SealedHandler
{
	private ValueTask<Response972> Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request973(long Id) : Mediator.IRequest<Response973>, MediatR.IRequest<Response973>;

public sealed record Response973(long Id);

public sealed partial class Request973TraditionalHandler
	: Mediator.IRequestHandler<Request973, Response973>,
	MediatR.IRequestHandler<Request973, Response973>
{
	ValueTask<Response973> Mediator.IRequestHandler<Request973, Response973>.Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response973> MediatR.IRequestHandler<Request973, Response973>.Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request973StaticHandler
{
	private static ValueTask<Response973> Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request973SealedHandler
{
	private ValueTask<Response973> Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request974(long Id) : Mediator.IRequest<Response974>, MediatR.IRequest<Response974>;

public sealed record Response974(long Id);

public sealed partial class Request974TraditionalHandler
	: Mediator.IRequestHandler<Request974, Response974>,
	MediatR.IRequestHandler<Request974, Response974>
{
	ValueTask<Response974> Mediator.IRequestHandler<Request974, Response974>.Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response974> MediatR.IRequestHandler<Request974, Response974>.Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request974StaticHandler
{
	private static ValueTask<Response974> Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request974SealedHandler
{
	private ValueTask<Response974> Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request975(long Id) : Mediator.IRequest<Response975>, MediatR.IRequest<Response975>;

public sealed record Response975(long Id);

public sealed partial class Request975TraditionalHandler
	: Mediator.IRequestHandler<Request975, Response975>,
	MediatR.IRequestHandler<Request975, Response975>
{
	ValueTask<Response975> Mediator.IRequestHandler<Request975, Response975>.Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response975> MediatR.IRequestHandler<Request975, Response975>.Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request975StaticHandler
{
	private static ValueTask<Response975> Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request975SealedHandler
{
	private ValueTask<Response975> Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request976(long Id) : Mediator.IRequest<Response976>, MediatR.IRequest<Response976>;

public sealed record Response976(long Id);

public sealed partial class Request976TraditionalHandler
	: Mediator.IRequestHandler<Request976, Response976>,
	MediatR.IRequestHandler<Request976, Response976>
{
	ValueTask<Response976> Mediator.IRequestHandler<Request976, Response976>.Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response976> MediatR.IRequestHandler<Request976, Response976>.Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request976StaticHandler
{
	private static ValueTask<Response976> Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request976SealedHandler
{
	private ValueTask<Response976> Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request977(long Id) : Mediator.IRequest<Response977>, MediatR.IRequest<Response977>;

public sealed record Response977(long Id);

public sealed partial class Request977TraditionalHandler
	: Mediator.IRequestHandler<Request977, Response977>,
	MediatR.IRequestHandler<Request977, Response977>
{
	ValueTask<Response977> Mediator.IRequestHandler<Request977, Response977>.Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response977> MediatR.IRequestHandler<Request977, Response977>.Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request977StaticHandler
{
	private static ValueTask<Response977> Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request977SealedHandler
{
	private ValueTask<Response977> Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request978(long Id) : Mediator.IRequest<Response978>, MediatR.IRequest<Response978>;

public sealed record Response978(long Id);

public sealed partial class Request978TraditionalHandler
	: Mediator.IRequestHandler<Request978, Response978>,
	MediatR.IRequestHandler<Request978, Response978>
{
	ValueTask<Response978> Mediator.IRequestHandler<Request978, Response978>.Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response978> MediatR.IRequestHandler<Request978, Response978>.Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request978StaticHandler
{
	private static ValueTask<Response978> Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request978SealedHandler
{
	private ValueTask<Response978> Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request979(long Id) : Mediator.IRequest<Response979>, MediatR.IRequest<Response979>;

public sealed record Response979(long Id);

public sealed partial class Request979TraditionalHandler
	: Mediator.IRequestHandler<Request979, Response979>,
	MediatR.IRequestHandler<Request979, Response979>
{
	ValueTask<Response979> Mediator.IRequestHandler<Request979, Response979>.Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response979> MediatR.IRequestHandler<Request979, Response979>.Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request979StaticHandler
{
	private static ValueTask<Response979> Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request979SealedHandler
{
	private ValueTask<Response979> Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request980(long Id) : Mediator.IRequest<Response980>, MediatR.IRequest<Response980>;

public sealed record Response980(long Id);

public sealed partial class Request980TraditionalHandler
	: Mediator.IRequestHandler<Request980, Response980>,
	MediatR.IRequestHandler<Request980, Response980>
{
	ValueTask<Response980> Mediator.IRequestHandler<Request980, Response980>.Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response980> MediatR.IRequestHandler<Request980, Response980>.Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request980StaticHandler
{
	private static ValueTask<Response980> Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request980SealedHandler
{
	private ValueTask<Response980> Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request981(long Id) : Mediator.IRequest<Response981>, MediatR.IRequest<Response981>;

public sealed record Response981(long Id);

public sealed partial class Request981TraditionalHandler
	: Mediator.IRequestHandler<Request981, Response981>,
	MediatR.IRequestHandler<Request981, Response981>
{
	ValueTask<Response981> Mediator.IRequestHandler<Request981, Response981>.Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response981> MediatR.IRequestHandler<Request981, Response981>.Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request981StaticHandler
{
	private static ValueTask<Response981> Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request981SealedHandler
{
	private ValueTask<Response981> Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request982(long Id) : Mediator.IRequest<Response982>, MediatR.IRequest<Response982>;

public sealed record Response982(long Id);

public sealed partial class Request982TraditionalHandler
	: Mediator.IRequestHandler<Request982, Response982>,
	MediatR.IRequestHandler<Request982, Response982>
{
	ValueTask<Response982> Mediator.IRequestHandler<Request982, Response982>.Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response982> MediatR.IRequestHandler<Request982, Response982>.Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request982StaticHandler
{
	private static ValueTask<Response982> Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request982SealedHandler
{
	private ValueTask<Response982> Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request983(long Id) : Mediator.IRequest<Response983>, MediatR.IRequest<Response983>;

public sealed record Response983(long Id);

public sealed partial class Request983TraditionalHandler
	: Mediator.IRequestHandler<Request983, Response983>,
	MediatR.IRequestHandler<Request983, Response983>
{
	ValueTask<Response983> Mediator.IRequestHandler<Request983, Response983>.Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response983> MediatR.IRequestHandler<Request983, Response983>.Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request983StaticHandler
{
	private static ValueTask<Response983> Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request983SealedHandler
{
	private ValueTask<Response983> Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request984(long Id) : Mediator.IRequest<Response984>, MediatR.IRequest<Response984>;

public sealed record Response984(long Id);

public sealed partial class Request984TraditionalHandler
	: Mediator.IRequestHandler<Request984, Response984>,
	MediatR.IRequestHandler<Request984, Response984>
{
	ValueTask<Response984> Mediator.IRequestHandler<Request984, Response984>.Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response984> MediatR.IRequestHandler<Request984, Response984>.Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request984StaticHandler
{
	private static ValueTask<Response984> Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request984SealedHandler
{
	private ValueTask<Response984> Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request985(long Id) : Mediator.IRequest<Response985>, MediatR.IRequest<Response985>;

public sealed record Response985(long Id);

public sealed partial class Request985TraditionalHandler
	: Mediator.IRequestHandler<Request985, Response985>,
	MediatR.IRequestHandler<Request985, Response985>
{
	ValueTask<Response985> Mediator.IRequestHandler<Request985, Response985>.Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response985> MediatR.IRequestHandler<Request985, Response985>.Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request985StaticHandler
{
	private static ValueTask<Response985> Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request985SealedHandler
{
	private ValueTask<Response985> Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request986(long Id) : Mediator.IRequest<Response986>, MediatR.IRequest<Response986>;

public sealed record Response986(long Id);

public sealed partial class Request986TraditionalHandler
	: Mediator.IRequestHandler<Request986, Response986>,
	MediatR.IRequestHandler<Request986, Response986>
{
	ValueTask<Response986> Mediator.IRequestHandler<Request986, Response986>.Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response986> MediatR.IRequestHandler<Request986, Response986>.Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request986StaticHandler
{
	private static ValueTask<Response986> Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request986SealedHandler
{
	private ValueTask<Response986> Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request987(long Id) : Mediator.IRequest<Response987>, MediatR.IRequest<Response987>;

public sealed record Response987(long Id);

public sealed partial class Request987TraditionalHandler
	: Mediator.IRequestHandler<Request987, Response987>,
	MediatR.IRequestHandler<Request987, Response987>
{
	ValueTask<Response987> Mediator.IRequestHandler<Request987, Response987>.Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response987> MediatR.IRequestHandler<Request987, Response987>.Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request987StaticHandler
{
	private static ValueTask<Response987> Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request987SealedHandler
{
	private ValueTask<Response987> Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request988(long Id) : Mediator.IRequest<Response988>, MediatR.IRequest<Response988>;

public sealed record Response988(long Id);

public sealed partial class Request988TraditionalHandler
	: Mediator.IRequestHandler<Request988, Response988>,
	MediatR.IRequestHandler<Request988, Response988>
{
	ValueTask<Response988> Mediator.IRequestHandler<Request988, Response988>.Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response988> MediatR.IRequestHandler<Request988, Response988>.Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request988StaticHandler
{
	private static ValueTask<Response988> Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request988SealedHandler
{
	private ValueTask<Response988> Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request989(long Id) : Mediator.IRequest<Response989>, MediatR.IRequest<Response989>;

public sealed record Response989(long Id);

public sealed partial class Request989TraditionalHandler
	: Mediator.IRequestHandler<Request989, Response989>,
	MediatR.IRequestHandler<Request989, Response989>
{
	ValueTask<Response989> Mediator.IRequestHandler<Request989, Response989>.Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response989> MediatR.IRequestHandler<Request989, Response989>.Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request989StaticHandler
{
	private static ValueTask<Response989> Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request989SealedHandler
{
	private ValueTask<Response989> Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request990(long Id) : Mediator.IRequest<Response990>, MediatR.IRequest<Response990>;

public sealed record Response990(long Id);

public sealed partial class Request990TraditionalHandler
	: Mediator.IRequestHandler<Request990, Response990>,
	MediatR.IRequestHandler<Request990, Response990>
{
	ValueTask<Response990> Mediator.IRequestHandler<Request990, Response990>.Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response990> MediatR.IRequestHandler<Request990, Response990>.Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request990StaticHandler
{
	private static ValueTask<Response990> Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request990SealedHandler
{
	private ValueTask<Response990> Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request991(long Id) : Mediator.IRequest<Response991>, MediatR.IRequest<Response991>;

public sealed record Response991(long Id);

public sealed partial class Request991TraditionalHandler
	: Mediator.IRequestHandler<Request991, Response991>,
	MediatR.IRequestHandler<Request991, Response991>
{
	ValueTask<Response991> Mediator.IRequestHandler<Request991, Response991>.Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response991> MediatR.IRequestHandler<Request991, Response991>.Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request991StaticHandler
{
	private static ValueTask<Response991> Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request991SealedHandler
{
	private ValueTask<Response991> Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request992(long Id) : Mediator.IRequest<Response992>, MediatR.IRequest<Response992>;

public sealed record Response992(long Id);

public sealed partial class Request992TraditionalHandler
	: Mediator.IRequestHandler<Request992, Response992>,
	MediatR.IRequestHandler<Request992, Response992>
{
	ValueTask<Response992> Mediator.IRequestHandler<Request992, Response992>.Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response992> MediatR.IRequestHandler<Request992, Response992>.Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request992StaticHandler
{
	private static ValueTask<Response992> Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request992SealedHandler
{
	private ValueTask<Response992> Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request993(long Id) : Mediator.IRequest<Response993>, MediatR.IRequest<Response993>;

public sealed record Response993(long Id);

public sealed partial class Request993TraditionalHandler
	: Mediator.IRequestHandler<Request993, Response993>,
	MediatR.IRequestHandler<Request993, Response993>
{
	ValueTask<Response993> Mediator.IRequestHandler<Request993, Response993>.Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response993> MediatR.IRequestHandler<Request993, Response993>.Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request993StaticHandler
{
	private static ValueTask<Response993> Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request993SealedHandler
{
	private ValueTask<Response993> Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request994(long Id) : Mediator.IRequest<Response994>, MediatR.IRequest<Response994>;

public sealed record Response994(long Id);

public sealed partial class Request994TraditionalHandler
	: Mediator.IRequestHandler<Request994, Response994>,
	MediatR.IRequestHandler<Request994, Response994>
{
	ValueTask<Response994> Mediator.IRequestHandler<Request994, Response994>.Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response994> MediatR.IRequestHandler<Request994, Response994>.Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request994StaticHandler
{
	private static ValueTask<Response994> Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request994SealedHandler
{
	private ValueTask<Response994> Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request995(long Id) : Mediator.IRequest<Response995>, MediatR.IRequest<Response995>;

public sealed record Response995(long Id);

public sealed partial class Request995TraditionalHandler
	: Mediator.IRequestHandler<Request995, Response995>,
	MediatR.IRequestHandler<Request995, Response995>
{
	ValueTask<Response995> Mediator.IRequestHandler<Request995, Response995>.Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response995> MediatR.IRequestHandler<Request995, Response995>.Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request995StaticHandler
{
	private static ValueTask<Response995> Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request995SealedHandler
{
	private ValueTask<Response995> Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request996(long Id) : Mediator.IRequest<Response996>, MediatR.IRequest<Response996>;

public sealed record Response996(long Id);

public sealed partial class Request996TraditionalHandler
	: Mediator.IRequestHandler<Request996, Response996>,
	MediatR.IRequestHandler<Request996, Response996>
{
	ValueTask<Response996> Mediator.IRequestHandler<Request996, Response996>.Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response996> MediatR.IRequestHandler<Request996, Response996>.Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request996StaticHandler
{
	private static ValueTask<Response996> Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request996SealedHandler
{
	private ValueTask<Response996> Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request997(long Id) : Mediator.IRequest<Response997>, MediatR.IRequest<Response997>;

public sealed record Response997(long Id);

public sealed partial class Request997TraditionalHandler
	: Mediator.IRequestHandler<Request997, Response997>,
	MediatR.IRequestHandler<Request997, Response997>
{
	ValueTask<Response997> Mediator.IRequestHandler<Request997, Response997>.Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response997> MediatR.IRequestHandler<Request997, Response997>.Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request997StaticHandler
{
	private static ValueTask<Response997> Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request997SealedHandler
{
	private ValueTask<Response997> Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request998(long Id) : Mediator.IRequest<Response998>, MediatR.IRequest<Response998>;

public sealed record Response998(long Id);

public sealed partial class Request998TraditionalHandler
	: Mediator.IRequestHandler<Request998, Response998>,
	MediatR.IRequestHandler<Request998, Response998>
{
	ValueTask<Response998> Mediator.IRequestHandler<Request998, Response998>.Handle(
		Request998 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response998> MediatR.IRequestHandler<Request998, Response998>.Handle(
		Request998 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request998StaticHandler
{
	private static ValueTask<Response998> Handle(
		Request998 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request998SealedHandler
{
	private ValueTask<Response998> Handle(
		Request998 request,
		CancellationToken cancellationToken
	) => default;
}

public sealed record Request999(long Id) : Mediator.IRequest<Response999>, MediatR.IRequest<Response999>;

public sealed record Response999(long Id);

public sealed partial class Request999TraditionalHandler
	: Mediator.IRequestHandler<Request999, Response999>,
	MediatR.IRequestHandler<Request999, Response999>
{
	ValueTask<Response999> Mediator.IRequestHandler<Request999, Response999>.Handle(
		Request999 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response999> MediatR.IRequestHandler<Request999, Response999>.Handle(
		Request999 request,
		CancellationToken cancellationToken
	) => default!;
}

[Handler]
public static partial class Request999StaticHandler
{
	private static ValueTask<Response999> Handle(
		Request999 request,
		CancellationToken cancellationToken
	) => default;
}

[Handler]
public sealed partial class Request999SealedHandler
{
	private ValueTask<Response999> Handle(
		Request999 request,
		CancellationToken cancellationToken
	) => default;
}
