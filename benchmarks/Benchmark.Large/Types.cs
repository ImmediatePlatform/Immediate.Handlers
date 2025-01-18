using Immediate.Handlers.Shared;

#pragma warning disable IDE0060
#pragma warning disable MA0022

namespace Immediate.Handlers.Benchmarks;

public sealed record Request0(long Id) : Mediator.IRequest<Response0>, MediatR.IRequest<Response0>;

public record struct Response0(long Id);

[Handler]
public sealed partial class Request0Handler
	: Mediator.IRequestHandler<Request0, Response0>,
	MediatR.IRequestHandler<Request0, Response0>
{
	private static ValueTask<Response0> Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response0> Mediator.IRequestHandler<Request0, Response0>.Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response0> MediatR.IRequestHandler<Request0, Response0>.Handle(
		Request0 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request1(long Id) : Mediator.IRequest<Response1>, MediatR.IRequest<Response1>;

public record struct Response1(long Id);

[Handler]
public sealed partial class Request1Handler
	: Mediator.IRequestHandler<Request1, Response1>,
	MediatR.IRequestHandler<Request1, Response1>
{
	private static ValueTask<Response1> Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response1> Mediator.IRequestHandler<Request1, Response1>.Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response1> MediatR.IRequestHandler<Request1, Response1>.Handle(
		Request1 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request2(long Id) : Mediator.IRequest<Response2>, MediatR.IRequest<Response2>;

public record struct Response2(long Id);

[Handler]
public sealed partial class Request2Handler
	: Mediator.IRequestHandler<Request2, Response2>,
	MediatR.IRequestHandler<Request2, Response2>
{
	private static ValueTask<Response2> Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response2> Mediator.IRequestHandler<Request2, Response2>.Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response2> MediatR.IRequestHandler<Request2, Response2>.Handle(
		Request2 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request3(long Id) : Mediator.IRequest<Response3>, MediatR.IRequest<Response3>;

public record struct Response3(long Id);

[Handler]
public sealed partial class Request3Handler
	: Mediator.IRequestHandler<Request3, Response3>,
	MediatR.IRequestHandler<Request3, Response3>
{
	private static ValueTask<Response3> Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response3> Mediator.IRequestHandler<Request3, Response3>.Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response3> MediatR.IRequestHandler<Request3, Response3>.Handle(
		Request3 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request4(long Id) : Mediator.IRequest<Response4>, MediatR.IRequest<Response4>;

public record struct Response4(long Id);

[Handler]
public sealed partial class Request4Handler
	: Mediator.IRequestHandler<Request4, Response4>,
	MediatR.IRequestHandler<Request4, Response4>
{
	private static ValueTask<Response4> Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response4> Mediator.IRequestHandler<Request4, Response4>.Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response4> MediatR.IRequestHandler<Request4, Response4>.Handle(
		Request4 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request5(long Id) : Mediator.IRequest<Response5>, MediatR.IRequest<Response5>;

public record struct Response5(long Id);

[Handler]
public sealed partial class Request5Handler
	: Mediator.IRequestHandler<Request5, Response5>,
	MediatR.IRequestHandler<Request5, Response5>
{
	private static ValueTask<Response5> Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response5> Mediator.IRequestHandler<Request5, Response5>.Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response5> MediatR.IRequestHandler<Request5, Response5>.Handle(
		Request5 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request6(long Id) : Mediator.IRequest<Response6>, MediatR.IRequest<Response6>;

public record struct Response6(long Id);

[Handler]
public sealed partial class Request6Handler
	: Mediator.IRequestHandler<Request6, Response6>,
	MediatR.IRequestHandler<Request6, Response6>
{
	private static ValueTask<Response6> Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response6> Mediator.IRequestHandler<Request6, Response6>.Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response6> MediatR.IRequestHandler<Request6, Response6>.Handle(
		Request6 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request7(long Id) : Mediator.IRequest<Response7>, MediatR.IRequest<Response7>;

public record struct Response7(long Id);

[Handler]
public sealed partial class Request7Handler
	: Mediator.IRequestHandler<Request7, Response7>,
	MediatR.IRequestHandler<Request7, Response7>
{
	private static ValueTask<Response7> Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response7> Mediator.IRequestHandler<Request7, Response7>.Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response7> MediatR.IRequestHandler<Request7, Response7>.Handle(
		Request7 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request8(long Id) : Mediator.IRequest<Response8>, MediatR.IRequest<Response8>;

public record struct Response8(long Id);

[Handler]
public sealed partial class Request8Handler
	: Mediator.IRequestHandler<Request8, Response8>,
	MediatR.IRequestHandler<Request8, Response8>
{
	private static ValueTask<Response8> Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response8> Mediator.IRequestHandler<Request8, Response8>.Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response8> MediatR.IRequestHandler<Request8, Response8>.Handle(
		Request8 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request9(long Id) : Mediator.IRequest<Response9>, MediatR.IRequest<Response9>;

public record struct Response9(long Id);

[Handler]
public sealed partial class Request9Handler
	: Mediator.IRequestHandler<Request9, Response9>,
	MediatR.IRequestHandler<Request9, Response9>
{
	private static ValueTask<Response9> Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response9> Mediator.IRequestHandler<Request9, Response9>.Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response9> MediatR.IRequestHandler<Request9, Response9>.Handle(
		Request9 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request10(long Id) : Mediator.IRequest<Response10>, MediatR.IRequest<Response10>;

public record struct Response10(long Id);

[Handler]
public sealed partial class Request10Handler
	: Mediator.IRequestHandler<Request10, Response10>,
	MediatR.IRequestHandler<Request10, Response10>
{
	private static ValueTask<Response10> Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response10> Mediator.IRequestHandler<Request10, Response10>.Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response10> MediatR.IRequestHandler<Request10, Response10>.Handle(
		Request10 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request11(long Id) : Mediator.IRequest<Response11>, MediatR.IRequest<Response11>;

public record struct Response11(long Id);

[Handler]
public sealed partial class Request11Handler
	: Mediator.IRequestHandler<Request11, Response11>,
	MediatR.IRequestHandler<Request11, Response11>
{
	private static ValueTask<Response11> Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response11> Mediator.IRequestHandler<Request11, Response11>.Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response11> MediatR.IRequestHandler<Request11, Response11>.Handle(
		Request11 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request12(long Id) : Mediator.IRequest<Response12>, MediatR.IRequest<Response12>;

public record struct Response12(long Id);

[Handler]
public sealed partial class Request12Handler
	: Mediator.IRequestHandler<Request12, Response12>,
	MediatR.IRequestHandler<Request12, Response12>
{
	private static ValueTask<Response12> Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response12> Mediator.IRequestHandler<Request12, Response12>.Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response12> MediatR.IRequestHandler<Request12, Response12>.Handle(
		Request12 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request13(long Id) : Mediator.IRequest<Response13>, MediatR.IRequest<Response13>;

public record struct Response13(long Id);

[Handler]
public sealed partial class Request13Handler
	: Mediator.IRequestHandler<Request13, Response13>,
	MediatR.IRequestHandler<Request13, Response13>
{
	private static ValueTask<Response13> Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response13> Mediator.IRequestHandler<Request13, Response13>.Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response13> MediatR.IRequestHandler<Request13, Response13>.Handle(
		Request13 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request14(long Id) : Mediator.IRequest<Response14>, MediatR.IRequest<Response14>;

public record struct Response14(long Id);

[Handler]
public sealed partial class Request14Handler
	: Mediator.IRequestHandler<Request14, Response14>,
	MediatR.IRequestHandler<Request14, Response14>
{
	private static ValueTask<Response14> Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response14> Mediator.IRequestHandler<Request14, Response14>.Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response14> MediatR.IRequestHandler<Request14, Response14>.Handle(
		Request14 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request15(long Id) : Mediator.IRequest<Response15>, MediatR.IRequest<Response15>;

public record struct Response15(long Id);

[Handler]
public sealed partial class Request15Handler
	: Mediator.IRequestHandler<Request15, Response15>,
	MediatR.IRequestHandler<Request15, Response15>
{
	private static ValueTask<Response15> Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response15> Mediator.IRequestHandler<Request15, Response15>.Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response15> MediatR.IRequestHandler<Request15, Response15>.Handle(
		Request15 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request16(long Id) : Mediator.IRequest<Response16>, MediatR.IRequest<Response16>;

public record struct Response16(long Id);

[Handler]
public sealed partial class Request16Handler
	: Mediator.IRequestHandler<Request16, Response16>,
	MediatR.IRequestHandler<Request16, Response16>
{
	private static ValueTask<Response16> Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response16> Mediator.IRequestHandler<Request16, Response16>.Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response16> MediatR.IRequestHandler<Request16, Response16>.Handle(
		Request16 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request17(long Id) : Mediator.IRequest<Response17>, MediatR.IRequest<Response17>;

public record struct Response17(long Id);

[Handler]
public sealed partial class Request17Handler
	: Mediator.IRequestHandler<Request17, Response17>,
	MediatR.IRequestHandler<Request17, Response17>
{
	private static ValueTask<Response17> Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response17> Mediator.IRequestHandler<Request17, Response17>.Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response17> MediatR.IRequestHandler<Request17, Response17>.Handle(
		Request17 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request18(long Id) : Mediator.IRequest<Response18>, MediatR.IRequest<Response18>;

public record struct Response18(long Id);

[Handler]
public sealed partial class Request18Handler
	: Mediator.IRequestHandler<Request18, Response18>,
	MediatR.IRequestHandler<Request18, Response18>
{
	private static ValueTask<Response18> Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response18> Mediator.IRequestHandler<Request18, Response18>.Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response18> MediatR.IRequestHandler<Request18, Response18>.Handle(
		Request18 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request19(long Id) : Mediator.IRequest<Response19>, MediatR.IRequest<Response19>;

public record struct Response19(long Id);

[Handler]
public sealed partial class Request19Handler
	: Mediator.IRequestHandler<Request19, Response19>,
	MediatR.IRequestHandler<Request19, Response19>
{
	private static ValueTask<Response19> Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response19> Mediator.IRequestHandler<Request19, Response19>.Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response19> MediatR.IRequestHandler<Request19, Response19>.Handle(
		Request19 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request20(long Id) : Mediator.IRequest<Response20>, MediatR.IRequest<Response20>;

public record struct Response20(long Id);

[Handler]
public sealed partial class Request20Handler
	: Mediator.IRequestHandler<Request20, Response20>,
	MediatR.IRequestHandler<Request20, Response20>
{
	private static ValueTask<Response20> Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response20> Mediator.IRequestHandler<Request20, Response20>.Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response20> MediatR.IRequestHandler<Request20, Response20>.Handle(
		Request20 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request21(long Id) : Mediator.IRequest<Response21>, MediatR.IRequest<Response21>;

public record struct Response21(long Id);

[Handler]
public sealed partial class Request21Handler
	: Mediator.IRequestHandler<Request21, Response21>,
	MediatR.IRequestHandler<Request21, Response21>
{
	private static ValueTask<Response21> Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response21> Mediator.IRequestHandler<Request21, Response21>.Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response21> MediatR.IRequestHandler<Request21, Response21>.Handle(
		Request21 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request22(long Id) : Mediator.IRequest<Response22>, MediatR.IRequest<Response22>;

public record struct Response22(long Id);

[Handler]
public sealed partial class Request22Handler
	: Mediator.IRequestHandler<Request22, Response22>,
	MediatR.IRequestHandler<Request22, Response22>
{
	private static ValueTask<Response22> Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response22> Mediator.IRequestHandler<Request22, Response22>.Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response22> MediatR.IRequestHandler<Request22, Response22>.Handle(
		Request22 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request23(long Id) : Mediator.IRequest<Response23>, MediatR.IRequest<Response23>;

public record struct Response23(long Id);

[Handler]
public sealed partial class Request23Handler
	: Mediator.IRequestHandler<Request23, Response23>,
	MediatR.IRequestHandler<Request23, Response23>
{
	private static ValueTask<Response23> Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response23> Mediator.IRequestHandler<Request23, Response23>.Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response23> MediatR.IRequestHandler<Request23, Response23>.Handle(
		Request23 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request24(long Id) : Mediator.IRequest<Response24>, MediatR.IRequest<Response24>;

public record struct Response24(long Id);

[Handler]
public sealed partial class Request24Handler
	: Mediator.IRequestHandler<Request24, Response24>,
	MediatR.IRequestHandler<Request24, Response24>
{
	private static ValueTask<Response24> Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response24> Mediator.IRequestHandler<Request24, Response24>.Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response24> MediatR.IRequestHandler<Request24, Response24>.Handle(
		Request24 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request25(long Id) : Mediator.IRequest<Response25>, MediatR.IRequest<Response25>;

public record struct Response25(long Id);

[Handler]
public sealed partial class Request25Handler
	: Mediator.IRequestHandler<Request25, Response25>,
	MediatR.IRequestHandler<Request25, Response25>
{
	private static ValueTask<Response25> Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response25> Mediator.IRequestHandler<Request25, Response25>.Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response25> MediatR.IRequestHandler<Request25, Response25>.Handle(
		Request25 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request26(long Id) : Mediator.IRequest<Response26>, MediatR.IRequest<Response26>;

public record struct Response26(long Id);

[Handler]
public sealed partial class Request26Handler
	: Mediator.IRequestHandler<Request26, Response26>,
	MediatR.IRequestHandler<Request26, Response26>
{
	private static ValueTask<Response26> Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response26> Mediator.IRequestHandler<Request26, Response26>.Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response26> MediatR.IRequestHandler<Request26, Response26>.Handle(
		Request26 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request27(long Id) : Mediator.IRequest<Response27>, MediatR.IRequest<Response27>;

public record struct Response27(long Id);

[Handler]
public sealed partial class Request27Handler
	: Mediator.IRequestHandler<Request27, Response27>,
	MediatR.IRequestHandler<Request27, Response27>
{
	private static ValueTask<Response27> Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response27> Mediator.IRequestHandler<Request27, Response27>.Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response27> MediatR.IRequestHandler<Request27, Response27>.Handle(
		Request27 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request28(long Id) : Mediator.IRequest<Response28>, MediatR.IRequest<Response28>;

public record struct Response28(long Id);

[Handler]
public sealed partial class Request28Handler
	: Mediator.IRequestHandler<Request28, Response28>,
	MediatR.IRequestHandler<Request28, Response28>
{
	private static ValueTask<Response28> Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response28> Mediator.IRequestHandler<Request28, Response28>.Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response28> MediatR.IRequestHandler<Request28, Response28>.Handle(
		Request28 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request29(long Id) : Mediator.IRequest<Response29>, MediatR.IRequest<Response29>;

public record struct Response29(long Id);

[Handler]
public sealed partial class Request29Handler
	: Mediator.IRequestHandler<Request29, Response29>,
	MediatR.IRequestHandler<Request29, Response29>
{
	private static ValueTask<Response29> Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response29> Mediator.IRequestHandler<Request29, Response29>.Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response29> MediatR.IRequestHandler<Request29, Response29>.Handle(
		Request29 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request30(long Id) : Mediator.IRequest<Response30>, MediatR.IRequest<Response30>;

public record struct Response30(long Id);

[Handler]
public sealed partial class Request30Handler
	: Mediator.IRequestHandler<Request30, Response30>,
	MediatR.IRequestHandler<Request30, Response30>
{
	private static ValueTask<Response30> Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response30> Mediator.IRequestHandler<Request30, Response30>.Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response30> MediatR.IRequestHandler<Request30, Response30>.Handle(
		Request30 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request31(long Id) : Mediator.IRequest<Response31>, MediatR.IRequest<Response31>;

public record struct Response31(long Id);

[Handler]
public sealed partial class Request31Handler
	: Mediator.IRequestHandler<Request31, Response31>,
	MediatR.IRequestHandler<Request31, Response31>
{
	private static ValueTask<Response31> Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response31> Mediator.IRequestHandler<Request31, Response31>.Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response31> MediatR.IRequestHandler<Request31, Response31>.Handle(
		Request31 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request32(long Id) : Mediator.IRequest<Response32>, MediatR.IRequest<Response32>;

public record struct Response32(long Id);

[Handler]
public sealed partial class Request32Handler
	: Mediator.IRequestHandler<Request32, Response32>,
	MediatR.IRequestHandler<Request32, Response32>
{
	private static ValueTask<Response32> Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response32> Mediator.IRequestHandler<Request32, Response32>.Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response32> MediatR.IRequestHandler<Request32, Response32>.Handle(
		Request32 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request33(long Id) : Mediator.IRequest<Response33>, MediatR.IRequest<Response33>;

public record struct Response33(long Id);

[Handler]
public sealed partial class Request33Handler
	: Mediator.IRequestHandler<Request33, Response33>,
	MediatR.IRequestHandler<Request33, Response33>
{
	private static ValueTask<Response33> Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response33> Mediator.IRequestHandler<Request33, Response33>.Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response33> MediatR.IRequestHandler<Request33, Response33>.Handle(
		Request33 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request34(long Id) : Mediator.IRequest<Response34>, MediatR.IRequest<Response34>;

public record struct Response34(long Id);

[Handler]
public sealed partial class Request34Handler
	: Mediator.IRequestHandler<Request34, Response34>,
	MediatR.IRequestHandler<Request34, Response34>
{
	private static ValueTask<Response34> Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response34> Mediator.IRequestHandler<Request34, Response34>.Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response34> MediatR.IRequestHandler<Request34, Response34>.Handle(
		Request34 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request35(long Id) : Mediator.IRequest<Response35>, MediatR.IRequest<Response35>;

public record struct Response35(long Id);

[Handler]
public sealed partial class Request35Handler
	: Mediator.IRequestHandler<Request35, Response35>,
	MediatR.IRequestHandler<Request35, Response35>
{
	private static ValueTask<Response35> Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response35> Mediator.IRequestHandler<Request35, Response35>.Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response35> MediatR.IRequestHandler<Request35, Response35>.Handle(
		Request35 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request36(long Id) : Mediator.IRequest<Response36>, MediatR.IRequest<Response36>;

public record struct Response36(long Id);

[Handler]
public sealed partial class Request36Handler
	: Mediator.IRequestHandler<Request36, Response36>,
	MediatR.IRequestHandler<Request36, Response36>
{
	private static ValueTask<Response36> Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response36> Mediator.IRequestHandler<Request36, Response36>.Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response36> MediatR.IRequestHandler<Request36, Response36>.Handle(
		Request36 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request37(long Id) : Mediator.IRequest<Response37>, MediatR.IRequest<Response37>;

public record struct Response37(long Id);

[Handler]
public sealed partial class Request37Handler
	: Mediator.IRequestHandler<Request37, Response37>,
	MediatR.IRequestHandler<Request37, Response37>
{
	private static ValueTask<Response37> Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response37> Mediator.IRequestHandler<Request37, Response37>.Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response37> MediatR.IRequestHandler<Request37, Response37>.Handle(
		Request37 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request38(long Id) : Mediator.IRequest<Response38>, MediatR.IRequest<Response38>;

public record struct Response38(long Id);

[Handler]
public sealed partial class Request38Handler
	: Mediator.IRequestHandler<Request38, Response38>,
	MediatR.IRequestHandler<Request38, Response38>
{
	private static ValueTask<Response38> Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response38> Mediator.IRequestHandler<Request38, Response38>.Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response38> MediatR.IRequestHandler<Request38, Response38>.Handle(
		Request38 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request39(long Id) : Mediator.IRequest<Response39>, MediatR.IRequest<Response39>;

public record struct Response39(long Id);

[Handler]
public sealed partial class Request39Handler
	: Mediator.IRequestHandler<Request39, Response39>,
	MediatR.IRequestHandler<Request39, Response39>
{
	private static ValueTask<Response39> Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response39> Mediator.IRequestHandler<Request39, Response39>.Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response39> MediatR.IRequestHandler<Request39, Response39>.Handle(
		Request39 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request40(long Id) : Mediator.IRequest<Response40>, MediatR.IRequest<Response40>;

public record struct Response40(long Id);

[Handler]
public sealed partial class Request40Handler
	: Mediator.IRequestHandler<Request40, Response40>,
	MediatR.IRequestHandler<Request40, Response40>
{
	private static ValueTask<Response40> Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response40> Mediator.IRequestHandler<Request40, Response40>.Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response40> MediatR.IRequestHandler<Request40, Response40>.Handle(
		Request40 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request41(long Id) : Mediator.IRequest<Response41>, MediatR.IRequest<Response41>;

public record struct Response41(long Id);

[Handler]
public sealed partial class Request41Handler
	: Mediator.IRequestHandler<Request41, Response41>,
	MediatR.IRequestHandler<Request41, Response41>
{
	private static ValueTask<Response41> Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response41> Mediator.IRequestHandler<Request41, Response41>.Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response41> MediatR.IRequestHandler<Request41, Response41>.Handle(
		Request41 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request42(long Id) : Mediator.IRequest<Response42>, MediatR.IRequest<Response42>;

public record struct Response42(long Id);

[Handler]
public sealed partial class Request42Handler
	: Mediator.IRequestHandler<Request42, Response42>,
	MediatR.IRequestHandler<Request42, Response42>
{
	private static ValueTask<Response42> Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response42> Mediator.IRequestHandler<Request42, Response42>.Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response42> MediatR.IRequestHandler<Request42, Response42>.Handle(
		Request42 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request43(long Id) : Mediator.IRequest<Response43>, MediatR.IRequest<Response43>;

public record struct Response43(long Id);

[Handler]
public sealed partial class Request43Handler
	: Mediator.IRequestHandler<Request43, Response43>,
	MediatR.IRequestHandler<Request43, Response43>
{
	private static ValueTask<Response43> Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response43> Mediator.IRequestHandler<Request43, Response43>.Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response43> MediatR.IRequestHandler<Request43, Response43>.Handle(
		Request43 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request44(long Id) : Mediator.IRequest<Response44>, MediatR.IRequest<Response44>;

public record struct Response44(long Id);

[Handler]
public sealed partial class Request44Handler
	: Mediator.IRequestHandler<Request44, Response44>,
	MediatR.IRequestHandler<Request44, Response44>
{
	private static ValueTask<Response44> Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response44> Mediator.IRequestHandler<Request44, Response44>.Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response44> MediatR.IRequestHandler<Request44, Response44>.Handle(
		Request44 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request45(long Id) : Mediator.IRequest<Response45>, MediatR.IRequest<Response45>;

public record struct Response45(long Id);

[Handler]
public sealed partial class Request45Handler
	: Mediator.IRequestHandler<Request45, Response45>,
	MediatR.IRequestHandler<Request45, Response45>
{
	private static ValueTask<Response45> Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response45> Mediator.IRequestHandler<Request45, Response45>.Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response45> MediatR.IRequestHandler<Request45, Response45>.Handle(
		Request45 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request46(long Id) : Mediator.IRequest<Response46>, MediatR.IRequest<Response46>;

public record struct Response46(long Id);

[Handler]
public sealed partial class Request46Handler
	: Mediator.IRequestHandler<Request46, Response46>,
	MediatR.IRequestHandler<Request46, Response46>
{
	private static ValueTask<Response46> Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response46> Mediator.IRequestHandler<Request46, Response46>.Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response46> MediatR.IRequestHandler<Request46, Response46>.Handle(
		Request46 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request47(long Id) : Mediator.IRequest<Response47>, MediatR.IRequest<Response47>;

public record struct Response47(long Id);

[Handler]
public sealed partial class Request47Handler
	: Mediator.IRequestHandler<Request47, Response47>,
	MediatR.IRequestHandler<Request47, Response47>
{
	private static ValueTask<Response47> Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response47> Mediator.IRequestHandler<Request47, Response47>.Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response47> MediatR.IRequestHandler<Request47, Response47>.Handle(
		Request47 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request48(long Id) : Mediator.IRequest<Response48>, MediatR.IRequest<Response48>;

public record struct Response48(long Id);

[Handler]
public sealed partial class Request48Handler
	: Mediator.IRequestHandler<Request48, Response48>,
	MediatR.IRequestHandler<Request48, Response48>
{
	private static ValueTask<Response48> Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response48> Mediator.IRequestHandler<Request48, Response48>.Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response48> MediatR.IRequestHandler<Request48, Response48>.Handle(
		Request48 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request49(long Id) : Mediator.IRequest<Response49>, MediatR.IRequest<Response49>;

public record struct Response49(long Id);

[Handler]
public sealed partial class Request49Handler
	: Mediator.IRequestHandler<Request49, Response49>,
	MediatR.IRequestHandler<Request49, Response49>
{
	private static ValueTask<Response49> Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response49> Mediator.IRequestHandler<Request49, Response49>.Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response49> MediatR.IRequestHandler<Request49, Response49>.Handle(
		Request49 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request50(long Id) : Mediator.IRequest<Response50>, MediatR.IRequest<Response50>;

public record struct Response50(long Id);

[Handler]
public sealed partial class Request50Handler
	: Mediator.IRequestHandler<Request50, Response50>,
	MediatR.IRequestHandler<Request50, Response50>
{
	private static ValueTask<Response50> Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response50> Mediator.IRequestHandler<Request50, Response50>.Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response50> MediatR.IRequestHandler<Request50, Response50>.Handle(
		Request50 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request51(long Id) : Mediator.IRequest<Response51>, MediatR.IRequest<Response51>;

public record struct Response51(long Id);

[Handler]
public sealed partial class Request51Handler
	: Mediator.IRequestHandler<Request51, Response51>,
	MediatR.IRequestHandler<Request51, Response51>
{
	private static ValueTask<Response51> Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response51> Mediator.IRequestHandler<Request51, Response51>.Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response51> MediatR.IRequestHandler<Request51, Response51>.Handle(
		Request51 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request52(long Id) : Mediator.IRequest<Response52>, MediatR.IRequest<Response52>;

public record struct Response52(long Id);

[Handler]
public sealed partial class Request52Handler
	: Mediator.IRequestHandler<Request52, Response52>,
	MediatR.IRequestHandler<Request52, Response52>
{
	private static ValueTask<Response52> Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response52> Mediator.IRequestHandler<Request52, Response52>.Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response52> MediatR.IRequestHandler<Request52, Response52>.Handle(
		Request52 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request53(long Id) : Mediator.IRequest<Response53>, MediatR.IRequest<Response53>;

public record struct Response53(long Id);

[Handler]
public sealed partial class Request53Handler
	: Mediator.IRequestHandler<Request53, Response53>,
	MediatR.IRequestHandler<Request53, Response53>
{
	private static ValueTask<Response53> Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response53> Mediator.IRequestHandler<Request53, Response53>.Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response53> MediatR.IRequestHandler<Request53, Response53>.Handle(
		Request53 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request54(long Id) : Mediator.IRequest<Response54>, MediatR.IRequest<Response54>;

public record struct Response54(long Id);

[Handler]
public sealed partial class Request54Handler
	: Mediator.IRequestHandler<Request54, Response54>,
	MediatR.IRequestHandler<Request54, Response54>
{
	private static ValueTask<Response54> Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response54> Mediator.IRequestHandler<Request54, Response54>.Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response54> MediatR.IRequestHandler<Request54, Response54>.Handle(
		Request54 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request55(long Id) : Mediator.IRequest<Response55>, MediatR.IRequest<Response55>;

public record struct Response55(long Id);

[Handler]
public sealed partial class Request55Handler
	: Mediator.IRequestHandler<Request55, Response55>,
	MediatR.IRequestHandler<Request55, Response55>
{
	private static ValueTask<Response55> Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response55> Mediator.IRequestHandler<Request55, Response55>.Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response55> MediatR.IRequestHandler<Request55, Response55>.Handle(
		Request55 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request56(long Id) : Mediator.IRequest<Response56>, MediatR.IRequest<Response56>;

public record struct Response56(long Id);

[Handler]
public sealed partial class Request56Handler
	: Mediator.IRequestHandler<Request56, Response56>,
	MediatR.IRequestHandler<Request56, Response56>
{
	private static ValueTask<Response56> Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response56> Mediator.IRequestHandler<Request56, Response56>.Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response56> MediatR.IRequestHandler<Request56, Response56>.Handle(
		Request56 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request57(long Id) : Mediator.IRequest<Response57>, MediatR.IRequest<Response57>;

public record struct Response57(long Id);

[Handler]
public sealed partial class Request57Handler
	: Mediator.IRequestHandler<Request57, Response57>,
	MediatR.IRequestHandler<Request57, Response57>
{
	private static ValueTask<Response57> Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response57> Mediator.IRequestHandler<Request57, Response57>.Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response57> MediatR.IRequestHandler<Request57, Response57>.Handle(
		Request57 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request58(long Id) : Mediator.IRequest<Response58>, MediatR.IRequest<Response58>;

public record struct Response58(long Id);

[Handler]
public sealed partial class Request58Handler
	: Mediator.IRequestHandler<Request58, Response58>,
	MediatR.IRequestHandler<Request58, Response58>
{
	private static ValueTask<Response58> Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response58> Mediator.IRequestHandler<Request58, Response58>.Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response58> MediatR.IRequestHandler<Request58, Response58>.Handle(
		Request58 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request59(long Id) : Mediator.IRequest<Response59>, MediatR.IRequest<Response59>;

public record struct Response59(long Id);

[Handler]
public sealed partial class Request59Handler
	: Mediator.IRequestHandler<Request59, Response59>,
	MediatR.IRequestHandler<Request59, Response59>
{
	private static ValueTask<Response59> Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response59> Mediator.IRequestHandler<Request59, Response59>.Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response59> MediatR.IRequestHandler<Request59, Response59>.Handle(
		Request59 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request60(long Id) : Mediator.IRequest<Response60>, MediatR.IRequest<Response60>;

public record struct Response60(long Id);

[Handler]
public sealed partial class Request60Handler
	: Mediator.IRequestHandler<Request60, Response60>,
	MediatR.IRequestHandler<Request60, Response60>
{
	private static ValueTask<Response60> Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response60> Mediator.IRequestHandler<Request60, Response60>.Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response60> MediatR.IRequestHandler<Request60, Response60>.Handle(
		Request60 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request61(long Id) : Mediator.IRequest<Response61>, MediatR.IRequest<Response61>;

public record struct Response61(long Id);

[Handler]
public sealed partial class Request61Handler
	: Mediator.IRequestHandler<Request61, Response61>,
	MediatR.IRequestHandler<Request61, Response61>
{
	private static ValueTask<Response61> Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response61> Mediator.IRequestHandler<Request61, Response61>.Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response61> MediatR.IRequestHandler<Request61, Response61>.Handle(
		Request61 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request62(long Id) : Mediator.IRequest<Response62>, MediatR.IRequest<Response62>;

public record struct Response62(long Id);

[Handler]
public sealed partial class Request62Handler
	: Mediator.IRequestHandler<Request62, Response62>,
	MediatR.IRequestHandler<Request62, Response62>
{
	private static ValueTask<Response62> Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response62> Mediator.IRequestHandler<Request62, Response62>.Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response62> MediatR.IRequestHandler<Request62, Response62>.Handle(
		Request62 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request63(long Id) : Mediator.IRequest<Response63>, MediatR.IRequest<Response63>;

public record struct Response63(long Id);

[Handler]
public sealed partial class Request63Handler
	: Mediator.IRequestHandler<Request63, Response63>,
	MediatR.IRequestHandler<Request63, Response63>
{
	private static ValueTask<Response63> Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response63> Mediator.IRequestHandler<Request63, Response63>.Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response63> MediatR.IRequestHandler<Request63, Response63>.Handle(
		Request63 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request64(long Id) : Mediator.IRequest<Response64>, MediatR.IRequest<Response64>;

public record struct Response64(long Id);

[Handler]
public sealed partial class Request64Handler
	: Mediator.IRequestHandler<Request64, Response64>,
	MediatR.IRequestHandler<Request64, Response64>
{
	private static ValueTask<Response64> Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response64> Mediator.IRequestHandler<Request64, Response64>.Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response64> MediatR.IRequestHandler<Request64, Response64>.Handle(
		Request64 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request65(long Id) : Mediator.IRequest<Response65>, MediatR.IRequest<Response65>;

public record struct Response65(long Id);

[Handler]
public sealed partial class Request65Handler
	: Mediator.IRequestHandler<Request65, Response65>,
	MediatR.IRequestHandler<Request65, Response65>
{
	private static ValueTask<Response65> Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response65> Mediator.IRequestHandler<Request65, Response65>.Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response65> MediatR.IRequestHandler<Request65, Response65>.Handle(
		Request65 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request66(long Id) : Mediator.IRequest<Response66>, MediatR.IRequest<Response66>;

public record struct Response66(long Id);

[Handler]
public sealed partial class Request66Handler
	: Mediator.IRequestHandler<Request66, Response66>,
	MediatR.IRequestHandler<Request66, Response66>
{
	private static ValueTask<Response66> Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response66> Mediator.IRequestHandler<Request66, Response66>.Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response66> MediatR.IRequestHandler<Request66, Response66>.Handle(
		Request66 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request67(long Id) : Mediator.IRequest<Response67>, MediatR.IRequest<Response67>;

public record struct Response67(long Id);

[Handler]
public sealed partial class Request67Handler
	: Mediator.IRequestHandler<Request67, Response67>,
	MediatR.IRequestHandler<Request67, Response67>
{
	private static ValueTask<Response67> Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response67> Mediator.IRequestHandler<Request67, Response67>.Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response67> MediatR.IRequestHandler<Request67, Response67>.Handle(
		Request67 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request68(long Id) : Mediator.IRequest<Response68>, MediatR.IRequest<Response68>;

public record struct Response68(long Id);

[Handler]
public sealed partial class Request68Handler
	: Mediator.IRequestHandler<Request68, Response68>,
	MediatR.IRequestHandler<Request68, Response68>
{
	private static ValueTask<Response68> Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response68> Mediator.IRequestHandler<Request68, Response68>.Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response68> MediatR.IRequestHandler<Request68, Response68>.Handle(
		Request68 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request69(long Id) : Mediator.IRequest<Response69>, MediatR.IRequest<Response69>;

public record struct Response69(long Id);

[Handler]
public sealed partial class Request69Handler
	: Mediator.IRequestHandler<Request69, Response69>,
	MediatR.IRequestHandler<Request69, Response69>
{
	private static ValueTask<Response69> Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response69> Mediator.IRequestHandler<Request69, Response69>.Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response69> MediatR.IRequestHandler<Request69, Response69>.Handle(
		Request69 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request70(long Id) : Mediator.IRequest<Response70>, MediatR.IRequest<Response70>;

public record struct Response70(long Id);

[Handler]
public sealed partial class Request70Handler
	: Mediator.IRequestHandler<Request70, Response70>,
	MediatR.IRequestHandler<Request70, Response70>
{
	private static ValueTask<Response70> Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response70> Mediator.IRequestHandler<Request70, Response70>.Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response70> MediatR.IRequestHandler<Request70, Response70>.Handle(
		Request70 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request71(long Id) : Mediator.IRequest<Response71>, MediatR.IRequest<Response71>;

public record struct Response71(long Id);

[Handler]
public sealed partial class Request71Handler
	: Mediator.IRequestHandler<Request71, Response71>,
	MediatR.IRequestHandler<Request71, Response71>
{
	private static ValueTask<Response71> Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response71> Mediator.IRequestHandler<Request71, Response71>.Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response71> MediatR.IRequestHandler<Request71, Response71>.Handle(
		Request71 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request72(long Id) : Mediator.IRequest<Response72>, MediatR.IRequest<Response72>;

public record struct Response72(long Id);

[Handler]
public sealed partial class Request72Handler
	: Mediator.IRequestHandler<Request72, Response72>,
	MediatR.IRequestHandler<Request72, Response72>
{
	private static ValueTask<Response72> Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response72> Mediator.IRequestHandler<Request72, Response72>.Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response72> MediatR.IRequestHandler<Request72, Response72>.Handle(
		Request72 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request73(long Id) : Mediator.IRequest<Response73>, MediatR.IRequest<Response73>;

public record struct Response73(long Id);

[Handler]
public sealed partial class Request73Handler
	: Mediator.IRequestHandler<Request73, Response73>,
	MediatR.IRequestHandler<Request73, Response73>
{
	private static ValueTask<Response73> Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response73> Mediator.IRequestHandler<Request73, Response73>.Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response73> MediatR.IRequestHandler<Request73, Response73>.Handle(
		Request73 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request74(long Id) : Mediator.IRequest<Response74>, MediatR.IRequest<Response74>;

public record struct Response74(long Id);

[Handler]
public sealed partial class Request74Handler
	: Mediator.IRequestHandler<Request74, Response74>,
	MediatR.IRequestHandler<Request74, Response74>
{
	private static ValueTask<Response74> Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response74> Mediator.IRequestHandler<Request74, Response74>.Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response74> MediatR.IRequestHandler<Request74, Response74>.Handle(
		Request74 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request75(long Id) : Mediator.IRequest<Response75>, MediatR.IRequest<Response75>;

public record struct Response75(long Id);

[Handler]
public sealed partial class Request75Handler
	: Mediator.IRequestHandler<Request75, Response75>,
	MediatR.IRequestHandler<Request75, Response75>
{
	private static ValueTask<Response75> Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response75> Mediator.IRequestHandler<Request75, Response75>.Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response75> MediatR.IRequestHandler<Request75, Response75>.Handle(
		Request75 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request76(long Id) : Mediator.IRequest<Response76>, MediatR.IRequest<Response76>;

public record struct Response76(long Id);

[Handler]
public sealed partial class Request76Handler
	: Mediator.IRequestHandler<Request76, Response76>,
	MediatR.IRequestHandler<Request76, Response76>
{
	private static ValueTask<Response76> Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response76> Mediator.IRequestHandler<Request76, Response76>.Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response76> MediatR.IRequestHandler<Request76, Response76>.Handle(
		Request76 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request77(long Id) : Mediator.IRequest<Response77>, MediatR.IRequest<Response77>;

public record struct Response77(long Id);

[Handler]
public sealed partial class Request77Handler
	: Mediator.IRequestHandler<Request77, Response77>,
	MediatR.IRequestHandler<Request77, Response77>
{
	private static ValueTask<Response77> Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response77> Mediator.IRequestHandler<Request77, Response77>.Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response77> MediatR.IRequestHandler<Request77, Response77>.Handle(
		Request77 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request78(long Id) : Mediator.IRequest<Response78>, MediatR.IRequest<Response78>;

public record struct Response78(long Id);

[Handler]
public sealed partial class Request78Handler
	: Mediator.IRequestHandler<Request78, Response78>,
	MediatR.IRequestHandler<Request78, Response78>
{
	private static ValueTask<Response78> Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response78> Mediator.IRequestHandler<Request78, Response78>.Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response78> MediatR.IRequestHandler<Request78, Response78>.Handle(
		Request78 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request79(long Id) : Mediator.IRequest<Response79>, MediatR.IRequest<Response79>;

public record struct Response79(long Id);

[Handler]
public sealed partial class Request79Handler
	: Mediator.IRequestHandler<Request79, Response79>,
	MediatR.IRequestHandler<Request79, Response79>
{
	private static ValueTask<Response79> Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response79> Mediator.IRequestHandler<Request79, Response79>.Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response79> MediatR.IRequestHandler<Request79, Response79>.Handle(
		Request79 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request80(long Id) : Mediator.IRequest<Response80>, MediatR.IRequest<Response80>;

public record struct Response80(long Id);

[Handler]
public sealed partial class Request80Handler
	: Mediator.IRequestHandler<Request80, Response80>,
	MediatR.IRequestHandler<Request80, Response80>
{
	private static ValueTask<Response80> Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response80> Mediator.IRequestHandler<Request80, Response80>.Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response80> MediatR.IRequestHandler<Request80, Response80>.Handle(
		Request80 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request81(long Id) : Mediator.IRequest<Response81>, MediatR.IRequest<Response81>;

public record struct Response81(long Id);

[Handler]
public sealed partial class Request81Handler
	: Mediator.IRequestHandler<Request81, Response81>,
	MediatR.IRequestHandler<Request81, Response81>
{
	private static ValueTask<Response81> Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response81> Mediator.IRequestHandler<Request81, Response81>.Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response81> MediatR.IRequestHandler<Request81, Response81>.Handle(
		Request81 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request82(long Id) : Mediator.IRequest<Response82>, MediatR.IRequest<Response82>;

public record struct Response82(long Id);

[Handler]
public sealed partial class Request82Handler
	: Mediator.IRequestHandler<Request82, Response82>,
	MediatR.IRequestHandler<Request82, Response82>
{
	private static ValueTask<Response82> Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response82> Mediator.IRequestHandler<Request82, Response82>.Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response82> MediatR.IRequestHandler<Request82, Response82>.Handle(
		Request82 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request83(long Id) : Mediator.IRequest<Response83>, MediatR.IRequest<Response83>;

public record struct Response83(long Id);

[Handler]
public sealed partial class Request83Handler
	: Mediator.IRequestHandler<Request83, Response83>,
	MediatR.IRequestHandler<Request83, Response83>
{
	private static ValueTask<Response83> Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response83> Mediator.IRequestHandler<Request83, Response83>.Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response83> MediatR.IRequestHandler<Request83, Response83>.Handle(
		Request83 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request84(long Id) : Mediator.IRequest<Response84>, MediatR.IRequest<Response84>;

public record struct Response84(long Id);

[Handler]
public sealed partial class Request84Handler
	: Mediator.IRequestHandler<Request84, Response84>,
	MediatR.IRequestHandler<Request84, Response84>
{
	private static ValueTask<Response84> Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response84> Mediator.IRequestHandler<Request84, Response84>.Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response84> MediatR.IRequestHandler<Request84, Response84>.Handle(
		Request84 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request85(long Id) : Mediator.IRequest<Response85>, MediatR.IRequest<Response85>;

public record struct Response85(long Id);

[Handler]
public sealed partial class Request85Handler
	: Mediator.IRequestHandler<Request85, Response85>,
	MediatR.IRequestHandler<Request85, Response85>
{
	private static ValueTask<Response85> Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response85> Mediator.IRequestHandler<Request85, Response85>.Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response85> MediatR.IRequestHandler<Request85, Response85>.Handle(
		Request85 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request86(long Id) : Mediator.IRequest<Response86>, MediatR.IRequest<Response86>;

public record struct Response86(long Id);

[Handler]
public sealed partial class Request86Handler
	: Mediator.IRequestHandler<Request86, Response86>,
	MediatR.IRequestHandler<Request86, Response86>
{
	private static ValueTask<Response86> Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response86> Mediator.IRequestHandler<Request86, Response86>.Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response86> MediatR.IRequestHandler<Request86, Response86>.Handle(
		Request86 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request87(long Id) : Mediator.IRequest<Response87>, MediatR.IRequest<Response87>;

public record struct Response87(long Id);

[Handler]
public sealed partial class Request87Handler
	: Mediator.IRequestHandler<Request87, Response87>,
	MediatR.IRequestHandler<Request87, Response87>
{
	private static ValueTask<Response87> Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response87> Mediator.IRequestHandler<Request87, Response87>.Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response87> MediatR.IRequestHandler<Request87, Response87>.Handle(
		Request87 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request88(long Id) : Mediator.IRequest<Response88>, MediatR.IRequest<Response88>;

public record struct Response88(long Id);

[Handler]
public sealed partial class Request88Handler
	: Mediator.IRequestHandler<Request88, Response88>,
	MediatR.IRequestHandler<Request88, Response88>
{
	private static ValueTask<Response88> Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response88> Mediator.IRequestHandler<Request88, Response88>.Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response88> MediatR.IRequestHandler<Request88, Response88>.Handle(
		Request88 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request89(long Id) : Mediator.IRequest<Response89>, MediatR.IRequest<Response89>;

public record struct Response89(long Id);

[Handler]
public sealed partial class Request89Handler
	: Mediator.IRequestHandler<Request89, Response89>,
	MediatR.IRequestHandler<Request89, Response89>
{
	private static ValueTask<Response89> Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response89> Mediator.IRequestHandler<Request89, Response89>.Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response89> MediatR.IRequestHandler<Request89, Response89>.Handle(
		Request89 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request90(long Id) : Mediator.IRequest<Response90>, MediatR.IRequest<Response90>;

public record struct Response90(long Id);

[Handler]
public sealed partial class Request90Handler
	: Mediator.IRequestHandler<Request90, Response90>,
	MediatR.IRequestHandler<Request90, Response90>
{
	private static ValueTask<Response90> Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response90> Mediator.IRequestHandler<Request90, Response90>.Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response90> MediatR.IRequestHandler<Request90, Response90>.Handle(
		Request90 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request91(long Id) : Mediator.IRequest<Response91>, MediatR.IRequest<Response91>;

public record struct Response91(long Id);

[Handler]
public sealed partial class Request91Handler
	: Mediator.IRequestHandler<Request91, Response91>,
	MediatR.IRequestHandler<Request91, Response91>
{
	private static ValueTask<Response91> Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response91> Mediator.IRequestHandler<Request91, Response91>.Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response91> MediatR.IRequestHandler<Request91, Response91>.Handle(
		Request91 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request92(long Id) : Mediator.IRequest<Response92>, MediatR.IRequest<Response92>;

public record struct Response92(long Id);

[Handler]
public sealed partial class Request92Handler
	: Mediator.IRequestHandler<Request92, Response92>,
	MediatR.IRequestHandler<Request92, Response92>
{
	private static ValueTask<Response92> Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response92> Mediator.IRequestHandler<Request92, Response92>.Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response92> MediatR.IRequestHandler<Request92, Response92>.Handle(
		Request92 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request93(long Id) : Mediator.IRequest<Response93>, MediatR.IRequest<Response93>;

public record struct Response93(long Id);

[Handler]
public sealed partial class Request93Handler
	: Mediator.IRequestHandler<Request93, Response93>,
	MediatR.IRequestHandler<Request93, Response93>
{
	private static ValueTask<Response93> Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response93> Mediator.IRequestHandler<Request93, Response93>.Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response93> MediatR.IRequestHandler<Request93, Response93>.Handle(
		Request93 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request94(long Id) : Mediator.IRequest<Response94>, MediatR.IRequest<Response94>;

public record struct Response94(long Id);

[Handler]
public sealed partial class Request94Handler
	: Mediator.IRequestHandler<Request94, Response94>,
	MediatR.IRequestHandler<Request94, Response94>
{
	private static ValueTask<Response94> Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response94> Mediator.IRequestHandler<Request94, Response94>.Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response94> MediatR.IRequestHandler<Request94, Response94>.Handle(
		Request94 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request95(long Id) : Mediator.IRequest<Response95>, MediatR.IRequest<Response95>;

public record struct Response95(long Id);

[Handler]
public sealed partial class Request95Handler
	: Mediator.IRequestHandler<Request95, Response95>,
	MediatR.IRequestHandler<Request95, Response95>
{
	private static ValueTask<Response95> Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response95> Mediator.IRequestHandler<Request95, Response95>.Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response95> MediatR.IRequestHandler<Request95, Response95>.Handle(
		Request95 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request96(long Id) : Mediator.IRequest<Response96>, MediatR.IRequest<Response96>;

public record struct Response96(long Id);

[Handler]
public sealed partial class Request96Handler
	: Mediator.IRequestHandler<Request96, Response96>,
	MediatR.IRequestHandler<Request96, Response96>
{
	private static ValueTask<Response96> Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response96> Mediator.IRequestHandler<Request96, Response96>.Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response96> MediatR.IRequestHandler<Request96, Response96>.Handle(
		Request96 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request97(long Id) : Mediator.IRequest<Response97>, MediatR.IRequest<Response97>;

public record struct Response97(long Id);

[Handler]
public sealed partial class Request97Handler
	: Mediator.IRequestHandler<Request97, Response97>,
	MediatR.IRequestHandler<Request97, Response97>
{
	private static ValueTask<Response97> Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response97> Mediator.IRequestHandler<Request97, Response97>.Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response97> MediatR.IRequestHandler<Request97, Response97>.Handle(
		Request97 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request98(long Id) : Mediator.IRequest<Response98>, MediatR.IRequest<Response98>;

public record struct Response98(long Id);

[Handler]
public sealed partial class Request98Handler
	: Mediator.IRequestHandler<Request98, Response98>,
	MediatR.IRequestHandler<Request98, Response98>
{
	private static ValueTask<Response98> Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response98> Mediator.IRequestHandler<Request98, Response98>.Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response98> MediatR.IRequestHandler<Request98, Response98>.Handle(
		Request98 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request99(long Id) : Mediator.IRequest<Response99>, MediatR.IRequest<Response99>;

public record struct Response99(long Id);

[Handler]
public sealed partial class Request99Handler
	: Mediator.IRequestHandler<Request99, Response99>,
	MediatR.IRequestHandler<Request99, Response99>
{
	private static ValueTask<Response99> Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response99> Mediator.IRequestHandler<Request99, Response99>.Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response99> MediatR.IRequestHandler<Request99, Response99>.Handle(
		Request99 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request100(long Id) : Mediator.IRequest<Response100>, MediatR.IRequest<Response100>;

public record struct Response100(long Id);

[Handler]
public sealed partial class Request100Handler
	: Mediator.IRequestHandler<Request100, Response100>,
	MediatR.IRequestHandler<Request100, Response100>
{
	private static ValueTask<Response100> Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response100> Mediator.IRequestHandler<Request100, Response100>.Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response100> MediatR.IRequestHandler<Request100, Response100>.Handle(
		Request100 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request101(long Id) : Mediator.IRequest<Response101>, MediatR.IRequest<Response101>;

public record struct Response101(long Id);

[Handler]
public sealed partial class Request101Handler
	: Mediator.IRequestHandler<Request101, Response101>,
	MediatR.IRequestHandler<Request101, Response101>
{
	private static ValueTask<Response101> Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response101> Mediator.IRequestHandler<Request101, Response101>.Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response101> MediatR.IRequestHandler<Request101, Response101>.Handle(
		Request101 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request102(long Id) : Mediator.IRequest<Response102>, MediatR.IRequest<Response102>;

public record struct Response102(long Id);

[Handler]
public sealed partial class Request102Handler
	: Mediator.IRequestHandler<Request102, Response102>,
	MediatR.IRequestHandler<Request102, Response102>
{
	private static ValueTask<Response102> Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response102> Mediator.IRequestHandler<Request102, Response102>.Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response102> MediatR.IRequestHandler<Request102, Response102>.Handle(
		Request102 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request103(long Id) : Mediator.IRequest<Response103>, MediatR.IRequest<Response103>;

public record struct Response103(long Id);

[Handler]
public sealed partial class Request103Handler
	: Mediator.IRequestHandler<Request103, Response103>,
	MediatR.IRequestHandler<Request103, Response103>
{
	private static ValueTask<Response103> Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response103> Mediator.IRequestHandler<Request103, Response103>.Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response103> MediatR.IRequestHandler<Request103, Response103>.Handle(
		Request103 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request104(long Id) : Mediator.IRequest<Response104>, MediatR.IRequest<Response104>;

public record struct Response104(long Id);

[Handler]
public sealed partial class Request104Handler
	: Mediator.IRequestHandler<Request104, Response104>,
	MediatR.IRequestHandler<Request104, Response104>
{
	private static ValueTask<Response104> Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response104> Mediator.IRequestHandler<Request104, Response104>.Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response104> MediatR.IRequestHandler<Request104, Response104>.Handle(
		Request104 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request105(long Id) : Mediator.IRequest<Response105>, MediatR.IRequest<Response105>;

public record struct Response105(long Id);

[Handler]
public sealed partial class Request105Handler
	: Mediator.IRequestHandler<Request105, Response105>,
	MediatR.IRequestHandler<Request105, Response105>
{
	private static ValueTask<Response105> Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response105> Mediator.IRequestHandler<Request105, Response105>.Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response105> MediatR.IRequestHandler<Request105, Response105>.Handle(
		Request105 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request106(long Id) : Mediator.IRequest<Response106>, MediatR.IRequest<Response106>;

public record struct Response106(long Id);

[Handler]
public sealed partial class Request106Handler
	: Mediator.IRequestHandler<Request106, Response106>,
	MediatR.IRequestHandler<Request106, Response106>
{
	private static ValueTask<Response106> Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response106> Mediator.IRequestHandler<Request106, Response106>.Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response106> MediatR.IRequestHandler<Request106, Response106>.Handle(
		Request106 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request107(long Id) : Mediator.IRequest<Response107>, MediatR.IRequest<Response107>;

public record struct Response107(long Id);

[Handler]
public sealed partial class Request107Handler
	: Mediator.IRequestHandler<Request107, Response107>,
	MediatR.IRequestHandler<Request107, Response107>
{
	private static ValueTask<Response107> Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response107> Mediator.IRequestHandler<Request107, Response107>.Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response107> MediatR.IRequestHandler<Request107, Response107>.Handle(
		Request107 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request108(long Id) : Mediator.IRequest<Response108>, MediatR.IRequest<Response108>;

public record struct Response108(long Id);

[Handler]
public sealed partial class Request108Handler
	: Mediator.IRequestHandler<Request108, Response108>,
	MediatR.IRequestHandler<Request108, Response108>
{
	private static ValueTask<Response108> Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response108> Mediator.IRequestHandler<Request108, Response108>.Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response108> MediatR.IRequestHandler<Request108, Response108>.Handle(
		Request108 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request109(long Id) : Mediator.IRequest<Response109>, MediatR.IRequest<Response109>;

public record struct Response109(long Id);

[Handler]
public sealed partial class Request109Handler
	: Mediator.IRequestHandler<Request109, Response109>,
	MediatR.IRequestHandler<Request109, Response109>
{
	private static ValueTask<Response109> Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response109> Mediator.IRequestHandler<Request109, Response109>.Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response109> MediatR.IRequestHandler<Request109, Response109>.Handle(
		Request109 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request110(long Id) : Mediator.IRequest<Response110>, MediatR.IRequest<Response110>;

public record struct Response110(long Id);

[Handler]
public sealed partial class Request110Handler
	: Mediator.IRequestHandler<Request110, Response110>,
	MediatR.IRequestHandler<Request110, Response110>
{
	private static ValueTask<Response110> Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response110> Mediator.IRequestHandler<Request110, Response110>.Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response110> MediatR.IRequestHandler<Request110, Response110>.Handle(
		Request110 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request111(long Id) : Mediator.IRequest<Response111>, MediatR.IRequest<Response111>;

public record struct Response111(long Id);

[Handler]
public sealed partial class Request111Handler
	: Mediator.IRequestHandler<Request111, Response111>,
	MediatR.IRequestHandler<Request111, Response111>
{
	private static ValueTask<Response111> Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response111> Mediator.IRequestHandler<Request111, Response111>.Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response111> MediatR.IRequestHandler<Request111, Response111>.Handle(
		Request111 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request112(long Id) : Mediator.IRequest<Response112>, MediatR.IRequest<Response112>;

public record struct Response112(long Id);

[Handler]
public sealed partial class Request112Handler
	: Mediator.IRequestHandler<Request112, Response112>,
	MediatR.IRequestHandler<Request112, Response112>
{
	private static ValueTask<Response112> Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response112> Mediator.IRequestHandler<Request112, Response112>.Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response112> MediatR.IRequestHandler<Request112, Response112>.Handle(
		Request112 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request113(long Id) : Mediator.IRequest<Response113>, MediatR.IRequest<Response113>;

public record struct Response113(long Id);

[Handler]
public sealed partial class Request113Handler
	: Mediator.IRequestHandler<Request113, Response113>,
	MediatR.IRequestHandler<Request113, Response113>
{
	private static ValueTask<Response113> Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response113> Mediator.IRequestHandler<Request113, Response113>.Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response113> MediatR.IRequestHandler<Request113, Response113>.Handle(
		Request113 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request114(long Id) : Mediator.IRequest<Response114>, MediatR.IRequest<Response114>;

public record struct Response114(long Id);

[Handler]
public sealed partial class Request114Handler
	: Mediator.IRequestHandler<Request114, Response114>,
	MediatR.IRequestHandler<Request114, Response114>
{
	private static ValueTask<Response114> Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response114> Mediator.IRequestHandler<Request114, Response114>.Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response114> MediatR.IRequestHandler<Request114, Response114>.Handle(
		Request114 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request115(long Id) : Mediator.IRequest<Response115>, MediatR.IRequest<Response115>;

public record struct Response115(long Id);

[Handler]
public sealed partial class Request115Handler
	: Mediator.IRequestHandler<Request115, Response115>,
	MediatR.IRequestHandler<Request115, Response115>
{
	private static ValueTask<Response115> Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response115> Mediator.IRequestHandler<Request115, Response115>.Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response115> MediatR.IRequestHandler<Request115, Response115>.Handle(
		Request115 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request116(long Id) : Mediator.IRequest<Response116>, MediatR.IRequest<Response116>;

public record struct Response116(long Id);

[Handler]
public sealed partial class Request116Handler
	: Mediator.IRequestHandler<Request116, Response116>,
	MediatR.IRequestHandler<Request116, Response116>
{
	private static ValueTask<Response116> Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response116> Mediator.IRequestHandler<Request116, Response116>.Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response116> MediatR.IRequestHandler<Request116, Response116>.Handle(
		Request116 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request117(long Id) : Mediator.IRequest<Response117>, MediatR.IRequest<Response117>;

public record struct Response117(long Id);

[Handler]
public sealed partial class Request117Handler
	: Mediator.IRequestHandler<Request117, Response117>,
	MediatR.IRequestHandler<Request117, Response117>
{
	private static ValueTask<Response117> Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response117> Mediator.IRequestHandler<Request117, Response117>.Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response117> MediatR.IRequestHandler<Request117, Response117>.Handle(
		Request117 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request118(long Id) : Mediator.IRequest<Response118>, MediatR.IRequest<Response118>;

public record struct Response118(long Id);

[Handler]
public sealed partial class Request118Handler
	: Mediator.IRequestHandler<Request118, Response118>,
	MediatR.IRequestHandler<Request118, Response118>
{
	private static ValueTask<Response118> Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response118> Mediator.IRequestHandler<Request118, Response118>.Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response118> MediatR.IRequestHandler<Request118, Response118>.Handle(
		Request118 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request119(long Id) : Mediator.IRequest<Response119>, MediatR.IRequest<Response119>;

public record struct Response119(long Id);

[Handler]
public sealed partial class Request119Handler
	: Mediator.IRequestHandler<Request119, Response119>,
	MediatR.IRequestHandler<Request119, Response119>
{
	private static ValueTask<Response119> Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response119> Mediator.IRequestHandler<Request119, Response119>.Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response119> MediatR.IRequestHandler<Request119, Response119>.Handle(
		Request119 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request120(long Id) : Mediator.IRequest<Response120>, MediatR.IRequest<Response120>;

public record struct Response120(long Id);

[Handler]
public sealed partial class Request120Handler
	: Mediator.IRequestHandler<Request120, Response120>,
	MediatR.IRequestHandler<Request120, Response120>
{
	private static ValueTask<Response120> Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response120> Mediator.IRequestHandler<Request120, Response120>.Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response120> MediatR.IRequestHandler<Request120, Response120>.Handle(
		Request120 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request121(long Id) : Mediator.IRequest<Response121>, MediatR.IRequest<Response121>;

public record struct Response121(long Id);

[Handler]
public sealed partial class Request121Handler
	: Mediator.IRequestHandler<Request121, Response121>,
	MediatR.IRequestHandler<Request121, Response121>
{
	private static ValueTask<Response121> Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response121> Mediator.IRequestHandler<Request121, Response121>.Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response121> MediatR.IRequestHandler<Request121, Response121>.Handle(
		Request121 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request122(long Id) : Mediator.IRequest<Response122>, MediatR.IRequest<Response122>;

public record struct Response122(long Id);

[Handler]
public sealed partial class Request122Handler
	: Mediator.IRequestHandler<Request122, Response122>,
	MediatR.IRequestHandler<Request122, Response122>
{
	private static ValueTask<Response122> Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response122> Mediator.IRequestHandler<Request122, Response122>.Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response122> MediatR.IRequestHandler<Request122, Response122>.Handle(
		Request122 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request123(long Id) : Mediator.IRequest<Response123>, MediatR.IRequest<Response123>;

public record struct Response123(long Id);

[Handler]
public sealed partial class Request123Handler
	: Mediator.IRequestHandler<Request123, Response123>,
	MediatR.IRequestHandler<Request123, Response123>
{
	private static ValueTask<Response123> Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response123> Mediator.IRequestHandler<Request123, Response123>.Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response123> MediatR.IRequestHandler<Request123, Response123>.Handle(
		Request123 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request124(long Id) : Mediator.IRequest<Response124>, MediatR.IRequest<Response124>;

public record struct Response124(long Id);

[Handler]
public sealed partial class Request124Handler
	: Mediator.IRequestHandler<Request124, Response124>,
	MediatR.IRequestHandler<Request124, Response124>
{
	private static ValueTask<Response124> Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response124> Mediator.IRequestHandler<Request124, Response124>.Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response124> MediatR.IRequestHandler<Request124, Response124>.Handle(
		Request124 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request125(long Id) : Mediator.IRequest<Response125>, MediatR.IRequest<Response125>;

public record struct Response125(long Id);

[Handler]
public sealed partial class Request125Handler
	: Mediator.IRequestHandler<Request125, Response125>,
	MediatR.IRequestHandler<Request125, Response125>
{
	private static ValueTask<Response125> Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response125> Mediator.IRequestHandler<Request125, Response125>.Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response125> MediatR.IRequestHandler<Request125, Response125>.Handle(
		Request125 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request126(long Id) : Mediator.IRequest<Response126>, MediatR.IRequest<Response126>;

public record struct Response126(long Id);

[Handler]
public sealed partial class Request126Handler
	: Mediator.IRequestHandler<Request126, Response126>,
	MediatR.IRequestHandler<Request126, Response126>
{
	private static ValueTask<Response126> Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response126> Mediator.IRequestHandler<Request126, Response126>.Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response126> MediatR.IRequestHandler<Request126, Response126>.Handle(
		Request126 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request127(long Id) : Mediator.IRequest<Response127>, MediatR.IRequest<Response127>;

public record struct Response127(long Id);

[Handler]
public sealed partial class Request127Handler
	: Mediator.IRequestHandler<Request127, Response127>,
	MediatR.IRequestHandler<Request127, Response127>
{
	private static ValueTask<Response127> Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response127> Mediator.IRequestHandler<Request127, Response127>.Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response127> MediatR.IRequestHandler<Request127, Response127>.Handle(
		Request127 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request128(long Id) : Mediator.IRequest<Response128>, MediatR.IRequest<Response128>;

public record struct Response128(long Id);

[Handler]
public sealed partial class Request128Handler
	: Mediator.IRequestHandler<Request128, Response128>,
	MediatR.IRequestHandler<Request128, Response128>
{
	private static ValueTask<Response128> Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response128> Mediator.IRequestHandler<Request128, Response128>.Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response128> MediatR.IRequestHandler<Request128, Response128>.Handle(
		Request128 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request129(long Id) : Mediator.IRequest<Response129>, MediatR.IRequest<Response129>;

public record struct Response129(long Id);

[Handler]
public sealed partial class Request129Handler
	: Mediator.IRequestHandler<Request129, Response129>,
	MediatR.IRequestHandler<Request129, Response129>
{
	private static ValueTask<Response129> Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response129> Mediator.IRequestHandler<Request129, Response129>.Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response129> MediatR.IRequestHandler<Request129, Response129>.Handle(
		Request129 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request130(long Id) : Mediator.IRequest<Response130>, MediatR.IRequest<Response130>;

public record struct Response130(long Id);

[Handler]
public sealed partial class Request130Handler
	: Mediator.IRequestHandler<Request130, Response130>,
	MediatR.IRequestHandler<Request130, Response130>
{
	private static ValueTask<Response130> Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response130> Mediator.IRequestHandler<Request130, Response130>.Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response130> MediatR.IRequestHandler<Request130, Response130>.Handle(
		Request130 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request131(long Id) : Mediator.IRequest<Response131>, MediatR.IRequest<Response131>;

public record struct Response131(long Id);

[Handler]
public sealed partial class Request131Handler
	: Mediator.IRequestHandler<Request131, Response131>,
	MediatR.IRequestHandler<Request131, Response131>
{
	private static ValueTask<Response131> Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response131> Mediator.IRequestHandler<Request131, Response131>.Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response131> MediatR.IRequestHandler<Request131, Response131>.Handle(
		Request131 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request132(long Id) : Mediator.IRequest<Response132>, MediatR.IRequest<Response132>;

public record struct Response132(long Id);

[Handler]
public sealed partial class Request132Handler
	: Mediator.IRequestHandler<Request132, Response132>,
	MediatR.IRequestHandler<Request132, Response132>
{
	private static ValueTask<Response132> Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response132> Mediator.IRequestHandler<Request132, Response132>.Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response132> MediatR.IRequestHandler<Request132, Response132>.Handle(
		Request132 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request133(long Id) : Mediator.IRequest<Response133>, MediatR.IRequest<Response133>;

public record struct Response133(long Id);

[Handler]
public sealed partial class Request133Handler
	: Mediator.IRequestHandler<Request133, Response133>,
	MediatR.IRequestHandler<Request133, Response133>
{
	private static ValueTask<Response133> Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response133> Mediator.IRequestHandler<Request133, Response133>.Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response133> MediatR.IRequestHandler<Request133, Response133>.Handle(
		Request133 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request134(long Id) : Mediator.IRequest<Response134>, MediatR.IRequest<Response134>;

public record struct Response134(long Id);

[Handler]
public sealed partial class Request134Handler
	: Mediator.IRequestHandler<Request134, Response134>,
	MediatR.IRequestHandler<Request134, Response134>
{
	private static ValueTask<Response134> Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response134> Mediator.IRequestHandler<Request134, Response134>.Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response134> MediatR.IRequestHandler<Request134, Response134>.Handle(
		Request134 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request135(long Id) : Mediator.IRequest<Response135>, MediatR.IRequest<Response135>;

public record struct Response135(long Id);

[Handler]
public sealed partial class Request135Handler
	: Mediator.IRequestHandler<Request135, Response135>,
	MediatR.IRequestHandler<Request135, Response135>
{
	private static ValueTask<Response135> Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response135> Mediator.IRequestHandler<Request135, Response135>.Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response135> MediatR.IRequestHandler<Request135, Response135>.Handle(
		Request135 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request136(long Id) : Mediator.IRequest<Response136>, MediatR.IRequest<Response136>;

public record struct Response136(long Id);

[Handler]
public sealed partial class Request136Handler
	: Mediator.IRequestHandler<Request136, Response136>,
	MediatR.IRequestHandler<Request136, Response136>
{
	private static ValueTask<Response136> Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response136> Mediator.IRequestHandler<Request136, Response136>.Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response136> MediatR.IRequestHandler<Request136, Response136>.Handle(
		Request136 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request137(long Id) : Mediator.IRequest<Response137>, MediatR.IRequest<Response137>;

public record struct Response137(long Id);

[Handler]
public sealed partial class Request137Handler
	: Mediator.IRequestHandler<Request137, Response137>,
	MediatR.IRequestHandler<Request137, Response137>
{
	private static ValueTask<Response137> Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response137> Mediator.IRequestHandler<Request137, Response137>.Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response137> MediatR.IRequestHandler<Request137, Response137>.Handle(
		Request137 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request138(long Id) : Mediator.IRequest<Response138>, MediatR.IRequest<Response138>;

public record struct Response138(long Id);

[Handler]
public sealed partial class Request138Handler
	: Mediator.IRequestHandler<Request138, Response138>,
	MediatR.IRequestHandler<Request138, Response138>
{
	private static ValueTask<Response138> Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response138> Mediator.IRequestHandler<Request138, Response138>.Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response138> MediatR.IRequestHandler<Request138, Response138>.Handle(
		Request138 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request139(long Id) : Mediator.IRequest<Response139>, MediatR.IRequest<Response139>;

public record struct Response139(long Id);

[Handler]
public sealed partial class Request139Handler
	: Mediator.IRequestHandler<Request139, Response139>,
	MediatR.IRequestHandler<Request139, Response139>
{
	private static ValueTask<Response139> Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response139> Mediator.IRequestHandler<Request139, Response139>.Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response139> MediatR.IRequestHandler<Request139, Response139>.Handle(
		Request139 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request140(long Id) : Mediator.IRequest<Response140>, MediatR.IRequest<Response140>;

public record struct Response140(long Id);

[Handler]
public sealed partial class Request140Handler
	: Mediator.IRequestHandler<Request140, Response140>,
	MediatR.IRequestHandler<Request140, Response140>
{
	private static ValueTask<Response140> Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response140> Mediator.IRequestHandler<Request140, Response140>.Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response140> MediatR.IRequestHandler<Request140, Response140>.Handle(
		Request140 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request141(long Id) : Mediator.IRequest<Response141>, MediatR.IRequest<Response141>;

public record struct Response141(long Id);

[Handler]
public sealed partial class Request141Handler
	: Mediator.IRequestHandler<Request141, Response141>,
	MediatR.IRequestHandler<Request141, Response141>
{
	private static ValueTask<Response141> Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response141> Mediator.IRequestHandler<Request141, Response141>.Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response141> MediatR.IRequestHandler<Request141, Response141>.Handle(
		Request141 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request142(long Id) : Mediator.IRequest<Response142>, MediatR.IRequest<Response142>;

public record struct Response142(long Id);

[Handler]
public sealed partial class Request142Handler
	: Mediator.IRequestHandler<Request142, Response142>,
	MediatR.IRequestHandler<Request142, Response142>
{
	private static ValueTask<Response142> Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response142> Mediator.IRequestHandler<Request142, Response142>.Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response142> MediatR.IRequestHandler<Request142, Response142>.Handle(
		Request142 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request143(long Id) : Mediator.IRequest<Response143>, MediatR.IRequest<Response143>;

public record struct Response143(long Id);

[Handler]
public sealed partial class Request143Handler
	: Mediator.IRequestHandler<Request143, Response143>,
	MediatR.IRequestHandler<Request143, Response143>
{
	private static ValueTask<Response143> Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response143> Mediator.IRequestHandler<Request143, Response143>.Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response143> MediatR.IRequestHandler<Request143, Response143>.Handle(
		Request143 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request144(long Id) : Mediator.IRequest<Response144>, MediatR.IRequest<Response144>;

public record struct Response144(long Id);

[Handler]
public sealed partial class Request144Handler
	: Mediator.IRequestHandler<Request144, Response144>,
	MediatR.IRequestHandler<Request144, Response144>
{
	private static ValueTask<Response144> Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response144> Mediator.IRequestHandler<Request144, Response144>.Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response144> MediatR.IRequestHandler<Request144, Response144>.Handle(
		Request144 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request145(long Id) : Mediator.IRequest<Response145>, MediatR.IRequest<Response145>;

public record struct Response145(long Id);

[Handler]
public sealed partial class Request145Handler
	: Mediator.IRequestHandler<Request145, Response145>,
	MediatR.IRequestHandler<Request145, Response145>
{
	private static ValueTask<Response145> Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response145> Mediator.IRequestHandler<Request145, Response145>.Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response145> MediatR.IRequestHandler<Request145, Response145>.Handle(
		Request145 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request146(long Id) : Mediator.IRequest<Response146>, MediatR.IRequest<Response146>;

public record struct Response146(long Id);

[Handler]
public sealed partial class Request146Handler
	: Mediator.IRequestHandler<Request146, Response146>,
	MediatR.IRequestHandler<Request146, Response146>
{
	private static ValueTask<Response146> Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response146> Mediator.IRequestHandler<Request146, Response146>.Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response146> MediatR.IRequestHandler<Request146, Response146>.Handle(
		Request146 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request147(long Id) : Mediator.IRequest<Response147>, MediatR.IRequest<Response147>;

public record struct Response147(long Id);

[Handler]
public sealed partial class Request147Handler
	: Mediator.IRequestHandler<Request147, Response147>,
	MediatR.IRequestHandler<Request147, Response147>
{
	private static ValueTask<Response147> Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response147> Mediator.IRequestHandler<Request147, Response147>.Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response147> MediatR.IRequestHandler<Request147, Response147>.Handle(
		Request147 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request148(long Id) : Mediator.IRequest<Response148>, MediatR.IRequest<Response148>;

public record struct Response148(long Id);

[Handler]
public sealed partial class Request148Handler
	: Mediator.IRequestHandler<Request148, Response148>,
	MediatR.IRequestHandler<Request148, Response148>
{
	private static ValueTask<Response148> Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response148> Mediator.IRequestHandler<Request148, Response148>.Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response148> MediatR.IRequestHandler<Request148, Response148>.Handle(
		Request148 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request149(long Id) : Mediator.IRequest<Response149>, MediatR.IRequest<Response149>;

public record struct Response149(long Id);

[Handler]
public sealed partial class Request149Handler
	: Mediator.IRequestHandler<Request149, Response149>,
	MediatR.IRequestHandler<Request149, Response149>
{
	private static ValueTask<Response149> Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response149> Mediator.IRequestHandler<Request149, Response149>.Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response149> MediatR.IRequestHandler<Request149, Response149>.Handle(
		Request149 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request150(long Id) : Mediator.IRequest<Response150>, MediatR.IRequest<Response150>;

public record struct Response150(long Id);

[Handler]
public sealed partial class Request150Handler
	: Mediator.IRequestHandler<Request150, Response150>,
	MediatR.IRequestHandler<Request150, Response150>
{
	private static ValueTask<Response150> Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response150> Mediator.IRequestHandler<Request150, Response150>.Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response150> MediatR.IRequestHandler<Request150, Response150>.Handle(
		Request150 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request151(long Id) : Mediator.IRequest<Response151>, MediatR.IRequest<Response151>;

public record struct Response151(long Id);

[Handler]
public sealed partial class Request151Handler
	: Mediator.IRequestHandler<Request151, Response151>,
	MediatR.IRequestHandler<Request151, Response151>
{
	private static ValueTask<Response151> Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response151> Mediator.IRequestHandler<Request151, Response151>.Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response151> MediatR.IRequestHandler<Request151, Response151>.Handle(
		Request151 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request152(long Id) : Mediator.IRequest<Response152>, MediatR.IRequest<Response152>;

public record struct Response152(long Id);

[Handler]
public sealed partial class Request152Handler
	: Mediator.IRequestHandler<Request152, Response152>,
	MediatR.IRequestHandler<Request152, Response152>
{
	private static ValueTask<Response152> Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response152> Mediator.IRequestHandler<Request152, Response152>.Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response152> MediatR.IRequestHandler<Request152, Response152>.Handle(
		Request152 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request153(long Id) : Mediator.IRequest<Response153>, MediatR.IRequest<Response153>;

public record struct Response153(long Id);

[Handler]
public sealed partial class Request153Handler
	: Mediator.IRequestHandler<Request153, Response153>,
	MediatR.IRequestHandler<Request153, Response153>
{
	private static ValueTask<Response153> Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response153> Mediator.IRequestHandler<Request153, Response153>.Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response153> MediatR.IRequestHandler<Request153, Response153>.Handle(
		Request153 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request154(long Id) : Mediator.IRequest<Response154>, MediatR.IRequest<Response154>;

public record struct Response154(long Id);

[Handler]
public sealed partial class Request154Handler
	: Mediator.IRequestHandler<Request154, Response154>,
	MediatR.IRequestHandler<Request154, Response154>
{
	private static ValueTask<Response154> Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response154> Mediator.IRequestHandler<Request154, Response154>.Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response154> MediatR.IRequestHandler<Request154, Response154>.Handle(
		Request154 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request155(long Id) : Mediator.IRequest<Response155>, MediatR.IRequest<Response155>;

public record struct Response155(long Id);

[Handler]
public sealed partial class Request155Handler
	: Mediator.IRequestHandler<Request155, Response155>,
	MediatR.IRequestHandler<Request155, Response155>
{
	private static ValueTask<Response155> Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response155> Mediator.IRequestHandler<Request155, Response155>.Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response155> MediatR.IRequestHandler<Request155, Response155>.Handle(
		Request155 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request156(long Id) : Mediator.IRequest<Response156>, MediatR.IRequest<Response156>;

public record struct Response156(long Id);

[Handler]
public sealed partial class Request156Handler
	: Mediator.IRequestHandler<Request156, Response156>,
	MediatR.IRequestHandler<Request156, Response156>
{
	private static ValueTask<Response156> Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response156> Mediator.IRequestHandler<Request156, Response156>.Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response156> MediatR.IRequestHandler<Request156, Response156>.Handle(
		Request156 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request157(long Id) : Mediator.IRequest<Response157>, MediatR.IRequest<Response157>;

public record struct Response157(long Id);

[Handler]
public sealed partial class Request157Handler
	: Mediator.IRequestHandler<Request157, Response157>,
	MediatR.IRequestHandler<Request157, Response157>
{
	private static ValueTask<Response157> Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response157> Mediator.IRequestHandler<Request157, Response157>.Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response157> MediatR.IRequestHandler<Request157, Response157>.Handle(
		Request157 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request158(long Id) : Mediator.IRequest<Response158>, MediatR.IRequest<Response158>;

public record struct Response158(long Id);

[Handler]
public sealed partial class Request158Handler
	: Mediator.IRequestHandler<Request158, Response158>,
	MediatR.IRequestHandler<Request158, Response158>
{
	private static ValueTask<Response158> Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response158> Mediator.IRequestHandler<Request158, Response158>.Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response158> MediatR.IRequestHandler<Request158, Response158>.Handle(
		Request158 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request159(long Id) : Mediator.IRequest<Response159>, MediatR.IRequest<Response159>;

public record struct Response159(long Id);

[Handler]
public sealed partial class Request159Handler
	: Mediator.IRequestHandler<Request159, Response159>,
	MediatR.IRequestHandler<Request159, Response159>
{
	private static ValueTask<Response159> Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response159> Mediator.IRequestHandler<Request159, Response159>.Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response159> MediatR.IRequestHandler<Request159, Response159>.Handle(
		Request159 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request160(long Id) : Mediator.IRequest<Response160>, MediatR.IRequest<Response160>;

public record struct Response160(long Id);

[Handler]
public sealed partial class Request160Handler
	: Mediator.IRequestHandler<Request160, Response160>,
	MediatR.IRequestHandler<Request160, Response160>
{
	private static ValueTask<Response160> Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response160> Mediator.IRequestHandler<Request160, Response160>.Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response160> MediatR.IRequestHandler<Request160, Response160>.Handle(
		Request160 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request161(long Id) : Mediator.IRequest<Response161>, MediatR.IRequest<Response161>;

public record struct Response161(long Id);

[Handler]
public sealed partial class Request161Handler
	: Mediator.IRequestHandler<Request161, Response161>,
	MediatR.IRequestHandler<Request161, Response161>
{
	private static ValueTask<Response161> Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response161> Mediator.IRequestHandler<Request161, Response161>.Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response161> MediatR.IRequestHandler<Request161, Response161>.Handle(
		Request161 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request162(long Id) : Mediator.IRequest<Response162>, MediatR.IRequest<Response162>;

public record struct Response162(long Id);

[Handler]
public sealed partial class Request162Handler
	: Mediator.IRequestHandler<Request162, Response162>,
	MediatR.IRequestHandler<Request162, Response162>
{
	private static ValueTask<Response162> Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response162> Mediator.IRequestHandler<Request162, Response162>.Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response162> MediatR.IRequestHandler<Request162, Response162>.Handle(
		Request162 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request163(long Id) : Mediator.IRequest<Response163>, MediatR.IRequest<Response163>;

public record struct Response163(long Id);

[Handler]
public sealed partial class Request163Handler
	: Mediator.IRequestHandler<Request163, Response163>,
	MediatR.IRequestHandler<Request163, Response163>
{
	private static ValueTask<Response163> Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response163> Mediator.IRequestHandler<Request163, Response163>.Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response163> MediatR.IRequestHandler<Request163, Response163>.Handle(
		Request163 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request164(long Id) : Mediator.IRequest<Response164>, MediatR.IRequest<Response164>;

public record struct Response164(long Id);

[Handler]
public sealed partial class Request164Handler
	: Mediator.IRequestHandler<Request164, Response164>,
	MediatR.IRequestHandler<Request164, Response164>
{
	private static ValueTask<Response164> Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response164> Mediator.IRequestHandler<Request164, Response164>.Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response164> MediatR.IRequestHandler<Request164, Response164>.Handle(
		Request164 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request165(long Id) : Mediator.IRequest<Response165>, MediatR.IRequest<Response165>;

public record struct Response165(long Id);

[Handler]
public sealed partial class Request165Handler
	: Mediator.IRequestHandler<Request165, Response165>,
	MediatR.IRequestHandler<Request165, Response165>
{
	private static ValueTask<Response165> Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response165> Mediator.IRequestHandler<Request165, Response165>.Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response165> MediatR.IRequestHandler<Request165, Response165>.Handle(
		Request165 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request166(long Id) : Mediator.IRequest<Response166>, MediatR.IRequest<Response166>;

public record struct Response166(long Id);

[Handler]
public sealed partial class Request166Handler
	: Mediator.IRequestHandler<Request166, Response166>,
	MediatR.IRequestHandler<Request166, Response166>
{
	private static ValueTask<Response166> Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response166> Mediator.IRequestHandler<Request166, Response166>.Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response166> MediatR.IRequestHandler<Request166, Response166>.Handle(
		Request166 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request167(long Id) : Mediator.IRequest<Response167>, MediatR.IRequest<Response167>;

public record struct Response167(long Id);

[Handler]
public sealed partial class Request167Handler
	: Mediator.IRequestHandler<Request167, Response167>,
	MediatR.IRequestHandler<Request167, Response167>
{
	private static ValueTask<Response167> Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response167> Mediator.IRequestHandler<Request167, Response167>.Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response167> MediatR.IRequestHandler<Request167, Response167>.Handle(
		Request167 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request168(long Id) : Mediator.IRequest<Response168>, MediatR.IRequest<Response168>;

public record struct Response168(long Id);

[Handler]
public sealed partial class Request168Handler
	: Mediator.IRequestHandler<Request168, Response168>,
	MediatR.IRequestHandler<Request168, Response168>
{
	private static ValueTask<Response168> Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response168> Mediator.IRequestHandler<Request168, Response168>.Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response168> MediatR.IRequestHandler<Request168, Response168>.Handle(
		Request168 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request169(long Id) : Mediator.IRequest<Response169>, MediatR.IRequest<Response169>;

public record struct Response169(long Id);

[Handler]
public sealed partial class Request169Handler
	: Mediator.IRequestHandler<Request169, Response169>,
	MediatR.IRequestHandler<Request169, Response169>
{
	private static ValueTask<Response169> Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response169> Mediator.IRequestHandler<Request169, Response169>.Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response169> MediatR.IRequestHandler<Request169, Response169>.Handle(
		Request169 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request170(long Id) : Mediator.IRequest<Response170>, MediatR.IRequest<Response170>;

public record struct Response170(long Id);

[Handler]
public sealed partial class Request170Handler
	: Mediator.IRequestHandler<Request170, Response170>,
	MediatR.IRequestHandler<Request170, Response170>
{
	private static ValueTask<Response170> Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response170> Mediator.IRequestHandler<Request170, Response170>.Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response170> MediatR.IRequestHandler<Request170, Response170>.Handle(
		Request170 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request171(long Id) : Mediator.IRequest<Response171>, MediatR.IRequest<Response171>;

public record struct Response171(long Id);

[Handler]
public sealed partial class Request171Handler
	: Mediator.IRequestHandler<Request171, Response171>,
	MediatR.IRequestHandler<Request171, Response171>
{
	private static ValueTask<Response171> Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response171> Mediator.IRequestHandler<Request171, Response171>.Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response171> MediatR.IRequestHandler<Request171, Response171>.Handle(
		Request171 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request172(long Id) : Mediator.IRequest<Response172>, MediatR.IRequest<Response172>;

public record struct Response172(long Id);

[Handler]
public sealed partial class Request172Handler
	: Mediator.IRequestHandler<Request172, Response172>,
	MediatR.IRequestHandler<Request172, Response172>
{
	private static ValueTask<Response172> Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response172> Mediator.IRequestHandler<Request172, Response172>.Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response172> MediatR.IRequestHandler<Request172, Response172>.Handle(
		Request172 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request173(long Id) : Mediator.IRequest<Response173>, MediatR.IRequest<Response173>;

public record struct Response173(long Id);

[Handler]
public sealed partial class Request173Handler
	: Mediator.IRequestHandler<Request173, Response173>,
	MediatR.IRequestHandler<Request173, Response173>
{
	private static ValueTask<Response173> Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response173> Mediator.IRequestHandler<Request173, Response173>.Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response173> MediatR.IRequestHandler<Request173, Response173>.Handle(
		Request173 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request174(long Id) : Mediator.IRequest<Response174>, MediatR.IRequest<Response174>;

public record struct Response174(long Id);

[Handler]
public sealed partial class Request174Handler
	: Mediator.IRequestHandler<Request174, Response174>,
	MediatR.IRequestHandler<Request174, Response174>
{
	private static ValueTask<Response174> Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response174> Mediator.IRequestHandler<Request174, Response174>.Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response174> MediatR.IRequestHandler<Request174, Response174>.Handle(
		Request174 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request175(long Id) : Mediator.IRequest<Response175>, MediatR.IRequest<Response175>;

public record struct Response175(long Id);

[Handler]
public sealed partial class Request175Handler
	: Mediator.IRequestHandler<Request175, Response175>,
	MediatR.IRequestHandler<Request175, Response175>
{
	private static ValueTask<Response175> Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response175> Mediator.IRequestHandler<Request175, Response175>.Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response175> MediatR.IRequestHandler<Request175, Response175>.Handle(
		Request175 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request176(long Id) : Mediator.IRequest<Response176>, MediatR.IRequest<Response176>;

public record struct Response176(long Id);

[Handler]
public sealed partial class Request176Handler
	: Mediator.IRequestHandler<Request176, Response176>,
	MediatR.IRequestHandler<Request176, Response176>
{
	private static ValueTask<Response176> Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response176> Mediator.IRequestHandler<Request176, Response176>.Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response176> MediatR.IRequestHandler<Request176, Response176>.Handle(
		Request176 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request177(long Id) : Mediator.IRequest<Response177>, MediatR.IRequest<Response177>;

public record struct Response177(long Id);

[Handler]
public sealed partial class Request177Handler
	: Mediator.IRequestHandler<Request177, Response177>,
	MediatR.IRequestHandler<Request177, Response177>
{
	private static ValueTask<Response177> Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response177> Mediator.IRequestHandler<Request177, Response177>.Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response177> MediatR.IRequestHandler<Request177, Response177>.Handle(
		Request177 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request178(long Id) : Mediator.IRequest<Response178>, MediatR.IRequest<Response178>;

public record struct Response178(long Id);

[Handler]
public sealed partial class Request178Handler
	: Mediator.IRequestHandler<Request178, Response178>,
	MediatR.IRequestHandler<Request178, Response178>
{
	private static ValueTask<Response178> Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response178> Mediator.IRequestHandler<Request178, Response178>.Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response178> MediatR.IRequestHandler<Request178, Response178>.Handle(
		Request178 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request179(long Id) : Mediator.IRequest<Response179>, MediatR.IRequest<Response179>;

public record struct Response179(long Id);

[Handler]
public sealed partial class Request179Handler
	: Mediator.IRequestHandler<Request179, Response179>,
	MediatR.IRequestHandler<Request179, Response179>
{
	private static ValueTask<Response179> Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response179> Mediator.IRequestHandler<Request179, Response179>.Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response179> MediatR.IRequestHandler<Request179, Response179>.Handle(
		Request179 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request180(long Id) : Mediator.IRequest<Response180>, MediatR.IRequest<Response180>;

public record struct Response180(long Id);

[Handler]
public sealed partial class Request180Handler
	: Mediator.IRequestHandler<Request180, Response180>,
	MediatR.IRequestHandler<Request180, Response180>
{
	private static ValueTask<Response180> Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response180> Mediator.IRequestHandler<Request180, Response180>.Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response180> MediatR.IRequestHandler<Request180, Response180>.Handle(
		Request180 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request181(long Id) : Mediator.IRequest<Response181>, MediatR.IRequest<Response181>;

public record struct Response181(long Id);

[Handler]
public sealed partial class Request181Handler
	: Mediator.IRequestHandler<Request181, Response181>,
	MediatR.IRequestHandler<Request181, Response181>
{
	private static ValueTask<Response181> Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response181> Mediator.IRequestHandler<Request181, Response181>.Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response181> MediatR.IRequestHandler<Request181, Response181>.Handle(
		Request181 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request182(long Id) : Mediator.IRequest<Response182>, MediatR.IRequest<Response182>;

public record struct Response182(long Id);

[Handler]
public sealed partial class Request182Handler
	: Mediator.IRequestHandler<Request182, Response182>,
	MediatR.IRequestHandler<Request182, Response182>
{
	private static ValueTask<Response182> Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response182> Mediator.IRequestHandler<Request182, Response182>.Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response182> MediatR.IRequestHandler<Request182, Response182>.Handle(
		Request182 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request183(long Id) : Mediator.IRequest<Response183>, MediatR.IRequest<Response183>;

public record struct Response183(long Id);

[Handler]
public sealed partial class Request183Handler
	: Mediator.IRequestHandler<Request183, Response183>,
	MediatR.IRequestHandler<Request183, Response183>
{
	private static ValueTask<Response183> Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response183> Mediator.IRequestHandler<Request183, Response183>.Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response183> MediatR.IRequestHandler<Request183, Response183>.Handle(
		Request183 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request184(long Id) : Mediator.IRequest<Response184>, MediatR.IRequest<Response184>;

public record struct Response184(long Id);

[Handler]
public sealed partial class Request184Handler
	: Mediator.IRequestHandler<Request184, Response184>,
	MediatR.IRequestHandler<Request184, Response184>
{
	private static ValueTask<Response184> Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response184> Mediator.IRequestHandler<Request184, Response184>.Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response184> MediatR.IRequestHandler<Request184, Response184>.Handle(
		Request184 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request185(long Id) : Mediator.IRequest<Response185>, MediatR.IRequest<Response185>;

public record struct Response185(long Id);

[Handler]
public sealed partial class Request185Handler
	: Mediator.IRequestHandler<Request185, Response185>,
	MediatR.IRequestHandler<Request185, Response185>
{
	private static ValueTask<Response185> Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response185> Mediator.IRequestHandler<Request185, Response185>.Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response185> MediatR.IRequestHandler<Request185, Response185>.Handle(
		Request185 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request186(long Id) : Mediator.IRequest<Response186>, MediatR.IRequest<Response186>;

public record struct Response186(long Id);

[Handler]
public sealed partial class Request186Handler
	: Mediator.IRequestHandler<Request186, Response186>,
	MediatR.IRequestHandler<Request186, Response186>
{
	private static ValueTask<Response186> Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response186> Mediator.IRequestHandler<Request186, Response186>.Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response186> MediatR.IRequestHandler<Request186, Response186>.Handle(
		Request186 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request187(long Id) : Mediator.IRequest<Response187>, MediatR.IRequest<Response187>;

public record struct Response187(long Id);

[Handler]
public sealed partial class Request187Handler
	: Mediator.IRequestHandler<Request187, Response187>,
	MediatR.IRequestHandler<Request187, Response187>
{
	private static ValueTask<Response187> Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response187> Mediator.IRequestHandler<Request187, Response187>.Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response187> MediatR.IRequestHandler<Request187, Response187>.Handle(
		Request187 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request188(long Id) : Mediator.IRequest<Response188>, MediatR.IRequest<Response188>;

public record struct Response188(long Id);

[Handler]
public sealed partial class Request188Handler
	: Mediator.IRequestHandler<Request188, Response188>,
	MediatR.IRequestHandler<Request188, Response188>
{
	private static ValueTask<Response188> Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response188> Mediator.IRequestHandler<Request188, Response188>.Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response188> MediatR.IRequestHandler<Request188, Response188>.Handle(
		Request188 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request189(long Id) : Mediator.IRequest<Response189>, MediatR.IRequest<Response189>;

public record struct Response189(long Id);

[Handler]
public sealed partial class Request189Handler
	: Mediator.IRequestHandler<Request189, Response189>,
	MediatR.IRequestHandler<Request189, Response189>
{
	private static ValueTask<Response189> Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response189> Mediator.IRequestHandler<Request189, Response189>.Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response189> MediatR.IRequestHandler<Request189, Response189>.Handle(
		Request189 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request190(long Id) : Mediator.IRequest<Response190>, MediatR.IRequest<Response190>;

public record struct Response190(long Id);

[Handler]
public sealed partial class Request190Handler
	: Mediator.IRequestHandler<Request190, Response190>,
	MediatR.IRequestHandler<Request190, Response190>
{
	private static ValueTask<Response190> Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response190> Mediator.IRequestHandler<Request190, Response190>.Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response190> MediatR.IRequestHandler<Request190, Response190>.Handle(
		Request190 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request191(long Id) : Mediator.IRequest<Response191>, MediatR.IRequest<Response191>;

public record struct Response191(long Id);

[Handler]
public sealed partial class Request191Handler
	: Mediator.IRequestHandler<Request191, Response191>,
	MediatR.IRequestHandler<Request191, Response191>
{
	private static ValueTask<Response191> Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response191> Mediator.IRequestHandler<Request191, Response191>.Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response191> MediatR.IRequestHandler<Request191, Response191>.Handle(
		Request191 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request192(long Id) : Mediator.IRequest<Response192>, MediatR.IRequest<Response192>;

public record struct Response192(long Id);

[Handler]
public sealed partial class Request192Handler
	: Mediator.IRequestHandler<Request192, Response192>,
	MediatR.IRequestHandler<Request192, Response192>
{
	private static ValueTask<Response192> Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response192> Mediator.IRequestHandler<Request192, Response192>.Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response192> MediatR.IRequestHandler<Request192, Response192>.Handle(
		Request192 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request193(long Id) : Mediator.IRequest<Response193>, MediatR.IRequest<Response193>;

public record struct Response193(long Id);

[Handler]
public sealed partial class Request193Handler
	: Mediator.IRequestHandler<Request193, Response193>,
	MediatR.IRequestHandler<Request193, Response193>
{
	private static ValueTask<Response193> Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response193> Mediator.IRequestHandler<Request193, Response193>.Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response193> MediatR.IRequestHandler<Request193, Response193>.Handle(
		Request193 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request194(long Id) : Mediator.IRequest<Response194>, MediatR.IRequest<Response194>;

public record struct Response194(long Id);

[Handler]
public sealed partial class Request194Handler
	: Mediator.IRequestHandler<Request194, Response194>,
	MediatR.IRequestHandler<Request194, Response194>
{
	private static ValueTask<Response194> Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response194> Mediator.IRequestHandler<Request194, Response194>.Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response194> MediatR.IRequestHandler<Request194, Response194>.Handle(
		Request194 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request195(long Id) : Mediator.IRequest<Response195>, MediatR.IRequest<Response195>;

public record struct Response195(long Id);

[Handler]
public sealed partial class Request195Handler
	: Mediator.IRequestHandler<Request195, Response195>,
	MediatR.IRequestHandler<Request195, Response195>
{
	private static ValueTask<Response195> Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response195> Mediator.IRequestHandler<Request195, Response195>.Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response195> MediatR.IRequestHandler<Request195, Response195>.Handle(
		Request195 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request196(long Id) : Mediator.IRequest<Response196>, MediatR.IRequest<Response196>;

public record struct Response196(long Id);

[Handler]
public sealed partial class Request196Handler
	: Mediator.IRequestHandler<Request196, Response196>,
	MediatR.IRequestHandler<Request196, Response196>
{
	private static ValueTask<Response196> Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response196> Mediator.IRequestHandler<Request196, Response196>.Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response196> MediatR.IRequestHandler<Request196, Response196>.Handle(
		Request196 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request197(long Id) : Mediator.IRequest<Response197>, MediatR.IRequest<Response197>;

public record struct Response197(long Id);

[Handler]
public sealed partial class Request197Handler
	: Mediator.IRequestHandler<Request197, Response197>,
	MediatR.IRequestHandler<Request197, Response197>
{
	private static ValueTask<Response197> Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response197> Mediator.IRequestHandler<Request197, Response197>.Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response197> MediatR.IRequestHandler<Request197, Response197>.Handle(
		Request197 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request198(long Id) : Mediator.IRequest<Response198>, MediatR.IRequest<Response198>;

public record struct Response198(long Id);

[Handler]
public sealed partial class Request198Handler
	: Mediator.IRequestHandler<Request198, Response198>,
	MediatR.IRequestHandler<Request198, Response198>
{
	private static ValueTask<Response198> Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response198> Mediator.IRequestHandler<Request198, Response198>.Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response198> MediatR.IRequestHandler<Request198, Response198>.Handle(
		Request198 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request199(long Id) : Mediator.IRequest<Response199>, MediatR.IRequest<Response199>;

public record struct Response199(long Id);

[Handler]
public sealed partial class Request199Handler
	: Mediator.IRequestHandler<Request199, Response199>,
	MediatR.IRequestHandler<Request199, Response199>
{
	private static ValueTask<Response199> Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response199> Mediator.IRequestHandler<Request199, Response199>.Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response199> MediatR.IRequestHandler<Request199, Response199>.Handle(
		Request199 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request200(long Id) : Mediator.IRequest<Response200>, MediatR.IRequest<Response200>;

public record struct Response200(long Id);

[Handler]
public sealed partial class Request200Handler
	: Mediator.IRequestHandler<Request200, Response200>,
	MediatR.IRequestHandler<Request200, Response200>
{
	private static ValueTask<Response200> Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response200> Mediator.IRequestHandler<Request200, Response200>.Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response200> MediatR.IRequestHandler<Request200, Response200>.Handle(
		Request200 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request201(long Id) : Mediator.IRequest<Response201>, MediatR.IRequest<Response201>;

public record struct Response201(long Id);

[Handler]
public sealed partial class Request201Handler
	: Mediator.IRequestHandler<Request201, Response201>,
	MediatR.IRequestHandler<Request201, Response201>
{
	private static ValueTask<Response201> Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response201> Mediator.IRequestHandler<Request201, Response201>.Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response201> MediatR.IRequestHandler<Request201, Response201>.Handle(
		Request201 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request202(long Id) : Mediator.IRequest<Response202>, MediatR.IRequest<Response202>;

public record struct Response202(long Id);

[Handler]
public sealed partial class Request202Handler
	: Mediator.IRequestHandler<Request202, Response202>,
	MediatR.IRequestHandler<Request202, Response202>
{
	private static ValueTask<Response202> Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response202> Mediator.IRequestHandler<Request202, Response202>.Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response202> MediatR.IRequestHandler<Request202, Response202>.Handle(
		Request202 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request203(long Id) : Mediator.IRequest<Response203>, MediatR.IRequest<Response203>;

public record struct Response203(long Id);

[Handler]
public sealed partial class Request203Handler
	: Mediator.IRequestHandler<Request203, Response203>,
	MediatR.IRequestHandler<Request203, Response203>
{
	private static ValueTask<Response203> Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response203> Mediator.IRequestHandler<Request203, Response203>.Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response203> MediatR.IRequestHandler<Request203, Response203>.Handle(
		Request203 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request204(long Id) : Mediator.IRequest<Response204>, MediatR.IRequest<Response204>;

public record struct Response204(long Id);

[Handler]
public sealed partial class Request204Handler
	: Mediator.IRequestHandler<Request204, Response204>,
	MediatR.IRequestHandler<Request204, Response204>
{
	private static ValueTask<Response204> Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response204> Mediator.IRequestHandler<Request204, Response204>.Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response204> MediatR.IRequestHandler<Request204, Response204>.Handle(
		Request204 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request205(long Id) : Mediator.IRequest<Response205>, MediatR.IRequest<Response205>;

public record struct Response205(long Id);

[Handler]
public sealed partial class Request205Handler
	: Mediator.IRequestHandler<Request205, Response205>,
	MediatR.IRequestHandler<Request205, Response205>
{
	private static ValueTask<Response205> Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response205> Mediator.IRequestHandler<Request205, Response205>.Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response205> MediatR.IRequestHandler<Request205, Response205>.Handle(
		Request205 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request206(long Id) : Mediator.IRequest<Response206>, MediatR.IRequest<Response206>;

public record struct Response206(long Id);

[Handler]
public sealed partial class Request206Handler
	: Mediator.IRequestHandler<Request206, Response206>,
	MediatR.IRequestHandler<Request206, Response206>
{
	private static ValueTask<Response206> Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response206> Mediator.IRequestHandler<Request206, Response206>.Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response206> MediatR.IRequestHandler<Request206, Response206>.Handle(
		Request206 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request207(long Id) : Mediator.IRequest<Response207>, MediatR.IRequest<Response207>;

public record struct Response207(long Id);

[Handler]
public sealed partial class Request207Handler
	: Mediator.IRequestHandler<Request207, Response207>,
	MediatR.IRequestHandler<Request207, Response207>
{
	private static ValueTask<Response207> Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response207> Mediator.IRequestHandler<Request207, Response207>.Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response207> MediatR.IRequestHandler<Request207, Response207>.Handle(
		Request207 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request208(long Id) : Mediator.IRequest<Response208>, MediatR.IRequest<Response208>;

public record struct Response208(long Id);

[Handler]
public sealed partial class Request208Handler
	: Mediator.IRequestHandler<Request208, Response208>,
	MediatR.IRequestHandler<Request208, Response208>
{
	private static ValueTask<Response208> Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response208> Mediator.IRequestHandler<Request208, Response208>.Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response208> MediatR.IRequestHandler<Request208, Response208>.Handle(
		Request208 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request209(long Id) : Mediator.IRequest<Response209>, MediatR.IRequest<Response209>;

public record struct Response209(long Id);

[Handler]
public sealed partial class Request209Handler
	: Mediator.IRequestHandler<Request209, Response209>,
	MediatR.IRequestHandler<Request209, Response209>
{
	private static ValueTask<Response209> Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response209> Mediator.IRequestHandler<Request209, Response209>.Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response209> MediatR.IRequestHandler<Request209, Response209>.Handle(
		Request209 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request210(long Id) : Mediator.IRequest<Response210>, MediatR.IRequest<Response210>;

public record struct Response210(long Id);

[Handler]
public sealed partial class Request210Handler
	: Mediator.IRequestHandler<Request210, Response210>,
	MediatR.IRequestHandler<Request210, Response210>
{
	private static ValueTask<Response210> Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response210> Mediator.IRequestHandler<Request210, Response210>.Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response210> MediatR.IRequestHandler<Request210, Response210>.Handle(
		Request210 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request211(long Id) : Mediator.IRequest<Response211>, MediatR.IRequest<Response211>;

public record struct Response211(long Id);

[Handler]
public sealed partial class Request211Handler
	: Mediator.IRequestHandler<Request211, Response211>,
	MediatR.IRequestHandler<Request211, Response211>
{
	private static ValueTask<Response211> Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response211> Mediator.IRequestHandler<Request211, Response211>.Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response211> MediatR.IRequestHandler<Request211, Response211>.Handle(
		Request211 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request212(long Id) : Mediator.IRequest<Response212>, MediatR.IRequest<Response212>;

public record struct Response212(long Id);

[Handler]
public sealed partial class Request212Handler
	: Mediator.IRequestHandler<Request212, Response212>,
	MediatR.IRequestHandler<Request212, Response212>
{
	private static ValueTask<Response212> Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response212> Mediator.IRequestHandler<Request212, Response212>.Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response212> MediatR.IRequestHandler<Request212, Response212>.Handle(
		Request212 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request213(long Id) : Mediator.IRequest<Response213>, MediatR.IRequest<Response213>;

public record struct Response213(long Id);

[Handler]
public sealed partial class Request213Handler
	: Mediator.IRequestHandler<Request213, Response213>,
	MediatR.IRequestHandler<Request213, Response213>
{
	private static ValueTask<Response213> Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response213> Mediator.IRequestHandler<Request213, Response213>.Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response213> MediatR.IRequestHandler<Request213, Response213>.Handle(
		Request213 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request214(long Id) : Mediator.IRequest<Response214>, MediatR.IRequest<Response214>;

public record struct Response214(long Id);

[Handler]
public sealed partial class Request214Handler
	: Mediator.IRequestHandler<Request214, Response214>,
	MediatR.IRequestHandler<Request214, Response214>
{
	private static ValueTask<Response214> Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response214> Mediator.IRequestHandler<Request214, Response214>.Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response214> MediatR.IRequestHandler<Request214, Response214>.Handle(
		Request214 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request215(long Id) : Mediator.IRequest<Response215>, MediatR.IRequest<Response215>;

public record struct Response215(long Id);

[Handler]
public sealed partial class Request215Handler
	: Mediator.IRequestHandler<Request215, Response215>,
	MediatR.IRequestHandler<Request215, Response215>
{
	private static ValueTask<Response215> Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response215> Mediator.IRequestHandler<Request215, Response215>.Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response215> MediatR.IRequestHandler<Request215, Response215>.Handle(
		Request215 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request216(long Id) : Mediator.IRequest<Response216>, MediatR.IRequest<Response216>;

public record struct Response216(long Id);

[Handler]
public sealed partial class Request216Handler
	: Mediator.IRequestHandler<Request216, Response216>,
	MediatR.IRequestHandler<Request216, Response216>
{
	private static ValueTask<Response216> Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response216> Mediator.IRequestHandler<Request216, Response216>.Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response216> MediatR.IRequestHandler<Request216, Response216>.Handle(
		Request216 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request217(long Id) : Mediator.IRequest<Response217>, MediatR.IRequest<Response217>;

public record struct Response217(long Id);

[Handler]
public sealed partial class Request217Handler
	: Mediator.IRequestHandler<Request217, Response217>,
	MediatR.IRequestHandler<Request217, Response217>
{
	private static ValueTask<Response217> Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response217> Mediator.IRequestHandler<Request217, Response217>.Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response217> MediatR.IRequestHandler<Request217, Response217>.Handle(
		Request217 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request218(long Id) : Mediator.IRequest<Response218>, MediatR.IRequest<Response218>;

public record struct Response218(long Id);

[Handler]
public sealed partial class Request218Handler
	: Mediator.IRequestHandler<Request218, Response218>,
	MediatR.IRequestHandler<Request218, Response218>
{
	private static ValueTask<Response218> Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response218> Mediator.IRequestHandler<Request218, Response218>.Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response218> MediatR.IRequestHandler<Request218, Response218>.Handle(
		Request218 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request219(long Id) : Mediator.IRequest<Response219>, MediatR.IRequest<Response219>;

public record struct Response219(long Id);

[Handler]
public sealed partial class Request219Handler
	: Mediator.IRequestHandler<Request219, Response219>,
	MediatR.IRequestHandler<Request219, Response219>
{
	private static ValueTask<Response219> Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response219> Mediator.IRequestHandler<Request219, Response219>.Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response219> MediatR.IRequestHandler<Request219, Response219>.Handle(
		Request219 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request220(long Id) : Mediator.IRequest<Response220>, MediatR.IRequest<Response220>;

public record struct Response220(long Id);

[Handler]
public sealed partial class Request220Handler
	: Mediator.IRequestHandler<Request220, Response220>,
	MediatR.IRequestHandler<Request220, Response220>
{
	private static ValueTask<Response220> Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response220> Mediator.IRequestHandler<Request220, Response220>.Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response220> MediatR.IRequestHandler<Request220, Response220>.Handle(
		Request220 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request221(long Id) : Mediator.IRequest<Response221>, MediatR.IRequest<Response221>;

public record struct Response221(long Id);

[Handler]
public sealed partial class Request221Handler
	: Mediator.IRequestHandler<Request221, Response221>,
	MediatR.IRequestHandler<Request221, Response221>
{
	private static ValueTask<Response221> Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response221> Mediator.IRequestHandler<Request221, Response221>.Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response221> MediatR.IRequestHandler<Request221, Response221>.Handle(
		Request221 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request222(long Id) : Mediator.IRequest<Response222>, MediatR.IRequest<Response222>;

public record struct Response222(long Id);

[Handler]
public sealed partial class Request222Handler
	: Mediator.IRequestHandler<Request222, Response222>,
	MediatR.IRequestHandler<Request222, Response222>
{
	private static ValueTask<Response222> Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response222> Mediator.IRequestHandler<Request222, Response222>.Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response222> MediatR.IRequestHandler<Request222, Response222>.Handle(
		Request222 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request223(long Id) : Mediator.IRequest<Response223>, MediatR.IRequest<Response223>;

public record struct Response223(long Id);

[Handler]
public sealed partial class Request223Handler
	: Mediator.IRequestHandler<Request223, Response223>,
	MediatR.IRequestHandler<Request223, Response223>
{
	private static ValueTask<Response223> Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response223> Mediator.IRequestHandler<Request223, Response223>.Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response223> MediatR.IRequestHandler<Request223, Response223>.Handle(
		Request223 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request224(long Id) : Mediator.IRequest<Response224>, MediatR.IRequest<Response224>;

public record struct Response224(long Id);

[Handler]
public sealed partial class Request224Handler
	: Mediator.IRequestHandler<Request224, Response224>,
	MediatR.IRequestHandler<Request224, Response224>
{
	private static ValueTask<Response224> Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response224> Mediator.IRequestHandler<Request224, Response224>.Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response224> MediatR.IRequestHandler<Request224, Response224>.Handle(
		Request224 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request225(long Id) : Mediator.IRequest<Response225>, MediatR.IRequest<Response225>;

public record struct Response225(long Id);

[Handler]
public sealed partial class Request225Handler
	: Mediator.IRequestHandler<Request225, Response225>,
	MediatR.IRequestHandler<Request225, Response225>
{
	private static ValueTask<Response225> Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response225> Mediator.IRequestHandler<Request225, Response225>.Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response225> MediatR.IRequestHandler<Request225, Response225>.Handle(
		Request225 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request226(long Id) : Mediator.IRequest<Response226>, MediatR.IRequest<Response226>;

public record struct Response226(long Id);

[Handler]
public sealed partial class Request226Handler
	: Mediator.IRequestHandler<Request226, Response226>,
	MediatR.IRequestHandler<Request226, Response226>
{
	private static ValueTask<Response226> Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response226> Mediator.IRequestHandler<Request226, Response226>.Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response226> MediatR.IRequestHandler<Request226, Response226>.Handle(
		Request226 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request227(long Id) : Mediator.IRequest<Response227>, MediatR.IRequest<Response227>;

public record struct Response227(long Id);

[Handler]
public sealed partial class Request227Handler
	: Mediator.IRequestHandler<Request227, Response227>,
	MediatR.IRequestHandler<Request227, Response227>
{
	private static ValueTask<Response227> Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response227> Mediator.IRequestHandler<Request227, Response227>.Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response227> MediatR.IRequestHandler<Request227, Response227>.Handle(
		Request227 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request228(long Id) : Mediator.IRequest<Response228>, MediatR.IRequest<Response228>;

public record struct Response228(long Id);

[Handler]
public sealed partial class Request228Handler
	: Mediator.IRequestHandler<Request228, Response228>,
	MediatR.IRequestHandler<Request228, Response228>
{
	private static ValueTask<Response228> Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response228> Mediator.IRequestHandler<Request228, Response228>.Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response228> MediatR.IRequestHandler<Request228, Response228>.Handle(
		Request228 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request229(long Id) : Mediator.IRequest<Response229>, MediatR.IRequest<Response229>;

public record struct Response229(long Id);

[Handler]
public sealed partial class Request229Handler
	: Mediator.IRequestHandler<Request229, Response229>,
	MediatR.IRequestHandler<Request229, Response229>
{
	private static ValueTask<Response229> Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response229> Mediator.IRequestHandler<Request229, Response229>.Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response229> MediatR.IRequestHandler<Request229, Response229>.Handle(
		Request229 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request230(long Id) : Mediator.IRequest<Response230>, MediatR.IRequest<Response230>;

public record struct Response230(long Id);

[Handler]
public sealed partial class Request230Handler
	: Mediator.IRequestHandler<Request230, Response230>,
	MediatR.IRequestHandler<Request230, Response230>
{
	private static ValueTask<Response230> Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response230> Mediator.IRequestHandler<Request230, Response230>.Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response230> MediatR.IRequestHandler<Request230, Response230>.Handle(
		Request230 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request231(long Id) : Mediator.IRequest<Response231>, MediatR.IRequest<Response231>;

public record struct Response231(long Id);

[Handler]
public sealed partial class Request231Handler
	: Mediator.IRequestHandler<Request231, Response231>,
	MediatR.IRequestHandler<Request231, Response231>
{
	private static ValueTask<Response231> Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response231> Mediator.IRequestHandler<Request231, Response231>.Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response231> MediatR.IRequestHandler<Request231, Response231>.Handle(
		Request231 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request232(long Id) : Mediator.IRequest<Response232>, MediatR.IRequest<Response232>;

public record struct Response232(long Id);

[Handler]
public sealed partial class Request232Handler
	: Mediator.IRequestHandler<Request232, Response232>,
	MediatR.IRequestHandler<Request232, Response232>
{
	private static ValueTask<Response232> Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response232> Mediator.IRequestHandler<Request232, Response232>.Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response232> MediatR.IRequestHandler<Request232, Response232>.Handle(
		Request232 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request233(long Id) : Mediator.IRequest<Response233>, MediatR.IRequest<Response233>;

public record struct Response233(long Id);

[Handler]
public sealed partial class Request233Handler
	: Mediator.IRequestHandler<Request233, Response233>,
	MediatR.IRequestHandler<Request233, Response233>
{
	private static ValueTask<Response233> Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response233> Mediator.IRequestHandler<Request233, Response233>.Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response233> MediatR.IRequestHandler<Request233, Response233>.Handle(
		Request233 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request234(long Id) : Mediator.IRequest<Response234>, MediatR.IRequest<Response234>;

public record struct Response234(long Id);

[Handler]
public sealed partial class Request234Handler
	: Mediator.IRequestHandler<Request234, Response234>,
	MediatR.IRequestHandler<Request234, Response234>
{
	private static ValueTask<Response234> Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response234> Mediator.IRequestHandler<Request234, Response234>.Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response234> MediatR.IRequestHandler<Request234, Response234>.Handle(
		Request234 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request235(long Id) : Mediator.IRequest<Response235>, MediatR.IRequest<Response235>;

public record struct Response235(long Id);

[Handler]
public sealed partial class Request235Handler
	: Mediator.IRequestHandler<Request235, Response235>,
	MediatR.IRequestHandler<Request235, Response235>
{
	private static ValueTask<Response235> Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response235> Mediator.IRequestHandler<Request235, Response235>.Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response235> MediatR.IRequestHandler<Request235, Response235>.Handle(
		Request235 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request236(long Id) : Mediator.IRequest<Response236>, MediatR.IRequest<Response236>;

public record struct Response236(long Id);

[Handler]
public sealed partial class Request236Handler
	: Mediator.IRequestHandler<Request236, Response236>,
	MediatR.IRequestHandler<Request236, Response236>
{
	private static ValueTask<Response236> Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response236> Mediator.IRequestHandler<Request236, Response236>.Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response236> MediatR.IRequestHandler<Request236, Response236>.Handle(
		Request236 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request237(long Id) : Mediator.IRequest<Response237>, MediatR.IRequest<Response237>;

public record struct Response237(long Id);

[Handler]
public sealed partial class Request237Handler
	: Mediator.IRequestHandler<Request237, Response237>,
	MediatR.IRequestHandler<Request237, Response237>
{
	private static ValueTask<Response237> Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response237> Mediator.IRequestHandler<Request237, Response237>.Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response237> MediatR.IRequestHandler<Request237, Response237>.Handle(
		Request237 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request238(long Id) : Mediator.IRequest<Response238>, MediatR.IRequest<Response238>;

public record struct Response238(long Id);

[Handler]
public sealed partial class Request238Handler
	: Mediator.IRequestHandler<Request238, Response238>,
	MediatR.IRequestHandler<Request238, Response238>
{
	private static ValueTask<Response238> Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response238> Mediator.IRequestHandler<Request238, Response238>.Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response238> MediatR.IRequestHandler<Request238, Response238>.Handle(
		Request238 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request239(long Id) : Mediator.IRequest<Response239>, MediatR.IRequest<Response239>;

public record struct Response239(long Id);

[Handler]
public sealed partial class Request239Handler
	: Mediator.IRequestHandler<Request239, Response239>,
	MediatR.IRequestHandler<Request239, Response239>
{
	private static ValueTask<Response239> Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response239> Mediator.IRequestHandler<Request239, Response239>.Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response239> MediatR.IRequestHandler<Request239, Response239>.Handle(
		Request239 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request240(long Id) : Mediator.IRequest<Response240>, MediatR.IRequest<Response240>;

public record struct Response240(long Id);

[Handler]
public sealed partial class Request240Handler
	: Mediator.IRequestHandler<Request240, Response240>,
	MediatR.IRequestHandler<Request240, Response240>
{
	private static ValueTask<Response240> Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response240> Mediator.IRequestHandler<Request240, Response240>.Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response240> MediatR.IRequestHandler<Request240, Response240>.Handle(
		Request240 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request241(long Id) : Mediator.IRequest<Response241>, MediatR.IRequest<Response241>;

public record struct Response241(long Id);

[Handler]
public sealed partial class Request241Handler
	: Mediator.IRequestHandler<Request241, Response241>,
	MediatR.IRequestHandler<Request241, Response241>
{
	private static ValueTask<Response241> Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response241> Mediator.IRequestHandler<Request241, Response241>.Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response241> MediatR.IRequestHandler<Request241, Response241>.Handle(
		Request241 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request242(long Id) : Mediator.IRequest<Response242>, MediatR.IRequest<Response242>;

public record struct Response242(long Id);

[Handler]
public sealed partial class Request242Handler
	: Mediator.IRequestHandler<Request242, Response242>,
	MediatR.IRequestHandler<Request242, Response242>
{
	private static ValueTask<Response242> Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response242> Mediator.IRequestHandler<Request242, Response242>.Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response242> MediatR.IRequestHandler<Request242, Response242>.Handle(
		Request242 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request243(long Id) : Mediator.IRequest<Response243>, MediatR.IRequest<Response243>;

public record struct Response243(long Id);

[Handler]
public sealed partial class Request243Handler
	: Mediator.IRequestHandler<Request243, Response243>,
	MediatR.IRequestHandler<Request243, Response243>
{
	private static ValueTask<Response243> Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response243> Mediator.IRequestHandler<Request243, Response243>.Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response243> MediatR.IRequestHandler<Request243, Response243>.Handle(
		Request243 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request244(long Id) : Mediator.IRequest<Response244>, MediatR.IRequest<Response244>;

public record struct Response244(long Id);

[Handler]
public sealed partial class Request244Handler
	: Mediator.IRequestHandler<Request244, Response244>,
	MediatR.IRequestHandler<Request244, Response244>
{
	private static ValueTask<Response244> Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response244> Mediator.IRequestHandler<Request244, Response244>.Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response244> MediatR.IRequestHandler<Request244, Response244>.Handle(
		Request244 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request245(long Id) : Mediator.IRequest<Response245>, MediatR.IRequest<Response245>;

public record struct Response245(long Id);

[Handler]
public sealed partial class Request245Handler
	: Mediator.IRequestHandler<Request245, Response245>,
	MediatR.IRequestHandler<Request245, Response245>
{
	private static ValueTask<Response245> Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response245> Mediator.IRequestHandler<Request245, Response245>.Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response245> MediatR.IRequestHandler<Request245, Response245>.Handle(
		Request245 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request246(long Id) : Mediator.IRequest<Response246>, MediatR.IRequest<Response246>;

public record struct Response246(long Id);

[Handler]
public sealed partial class Request246Handler
	: Mediator.IRequestHandler<Request246, Response246>,
	MediatR.IRequestHandler<Request246, Response246>
{
	private static ValueTask<Response246> Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response246> Mediator.IRequestHandler<Request246, Response246>.Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response246> MediatR.IRequestHandler<Request246, Response246>.Handle(
		Request246 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request247(long Id) : Mediator.IRequest<Response247>, MediatR.IRequest<Response247>;

public record struct Response247(long Id);

[Handler]
public sealed partial class Request247Handler
	: Mediator.IRequestHandler<Request247, Response247>,
	MediatR.IRequestHandler<Request247, Response247>
{
	private static ValueTask<Response247> Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response247> Mediator.IRequestHandler<Request247, Response247>.Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response247> MediatR.IRequestHandler<Request247, Response247>.Handle(
		Request247 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request248(long Id) : Mediator.IRequest<Response248>, MediatR.IRequest<Response248>;

public record struct Response248(long Id);

[Handler]
public sealed partial class Request248Handler
	: Mediator.IRequestHandler<Request248, Response248>,
	MediatR.IRequestHandler<Request248, Response248>
{
	private static ValueTask<Response248> Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response248> Mediator.IRequestHandler<Request248, Response248>.Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response248> MediatR.IRequestHandler<Request248, Response248>.Handle(
		Request248 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request249(long Id) : Mediator.IRequest<Response249>, MediatR.IRequest<Response249>;

public record struct Response249(long Id);

[Handler]
public sealed partial class Request249Handler
	: Mediator.IRequestHandler<Request249, Response249>,
	MediatR.IRequestHandler<Request249, Response249>
{
	private static ValueTask<Response249> Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response249> Mediator.IRequestHandler<Request249, Response249>.Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response249> MediatR.IRequestHandler<Request249, Response249>.Handle(
		Request249 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request250(long Id) : Mediator.IRequest<Response250>, MediatR.IRequest<Response250>;

public record struct Response250(long Id);

[Handler]
public sealed partial class Request250Handler
	: Mediator.IRequestHandler<Request250, Response250>,
	MediatR.IRequestHandler<Request250, Response250>
{
	private static ValueTask<Response250> Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response250> Mediator.IRequestHandler<Request250, Response250>.Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response250> MediatR.IRequestHandler<Request250, Response250>.Handle(
		Request250 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request251(long Id) : Mediator.IRequest<Response251>, MediatR.IRequest<Response251>;

public record struct Response251(long Id);

[Handler]
public sealed partial class Request251Handler
	: Mediator.IRequestHandler<Request251, Response251>,
	MediatR.IRequestHandler<Request251, Response251>
{
	private static ValueTask<Response251> Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response251> Mediator.IRequestHandler<Request251, Response251>.Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response251> MediatR.IRequestHandler<Request251, Response251>.Handle(
		Request251 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request252(long Id) : Mediator.IRequest<Response252>, MediatR.IRequest<Response252>;

public record struct Response252(long Id);

[Handler]
public sealed partial class Request252Handler
	: Mediator.IRequestHandler<Request252, Response252>,
	MediatR.IRequestHandler<Request252, Response252>
{
	private static ValueTask<Response252> Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response252> Mediator.IRequestHandler<Request252, Response252>.Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response252> MediatR.IRequestHandler<Request252, Response252>.Handle(
		Request252 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request253(long Id) : Mediator.IRequest<Response253>, MediatR.IRequest<Response253>;

public record struct Response253(long Id);

[Handler]
public sealed partial class Request253Handler
	: Mediator.IRequestHandler<Request253, Response253>,
	MediatR.IRequestHandler<Request253, Response253>
{
	private static ValueTask<Response253> Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response253> Mediator.IRequestHandler<Request253, Response253>.Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response253> MediatR.IRequestHandler<Request253, Response253>.Handle(
		Request253 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request254(long Id) : Mediator.IRequest<Response254>, MediatR.IRequest<Response254>;

public record struct Response254(long Id);

[Handler]
public sealed partial class Request254Handler
	: Mediator.IRequestHandler<Request254, Response254>,
	MediatR.IRequestHandler<Request254, Response254>
{
	private static ValueTask<Response254> Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response254> Mediator.IRequestHandler<Request254, Response254>.Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response254> MediatR.IRequestHandler<Request254, Response254>.Handle(
		Request254 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request255(long Id) : Mediator.IRequest<Response255>, MediatR.IRequest<Response255>;

public record struct Response255(long Id);

[Handler]
public sealed partial class Request255Handler
	: Mediator.IRequestHandler<Request255, Response255>,
	MediatR.IRequestHandler<Request255, Response255>
{
	private static ValueTask<Response255> Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response255> Mediator.IRequestHandler<Request255, Response255>.Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response255> MediatR.IRequestHandler<Request255, Response255>.Handle(
		Request255 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request256(long Id) : Mediator.IRequest<Response256>, MediatR.IRequest<Response256>;

public record struct Response256(long Id);

[Handler]
public sealed partial class Request256Handler
	: Mediator.IRequestHandler<Request256, Response256>,
	MediatR.IRequestHandler<Request256, Response256>
{
	private static ValueTask<Response256> Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response256> Mediator.IRequestHandler<Request256, Response256>.Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response256> MediatR.IRequestHandler<Request256, Response256>.Handle(
		Request256 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request257(long Id) : Mediator.IRequest<Response257>, MediatR.IRequest<Response257>;

public record struct Response257(long Id);

[Handler]
public sealed partial class Request257Handler
	: Mediator.IRequestHandler<Request257, Response257>,
	MediatR.IRequestHandler<Request257, Response257>
{
	private static ValueTask<Response257> Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response257> Mediator.IRequestHandler<Request257, Response257>.Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response257> MediatR.IRequestHandler<Request257, Response257>.Handle(
		Request257 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request258(long Id) : Mediator.IRequest<Response258>, MediatR.IRequest<Response258>;

public record struct Response258(long Id);

[Handler]
public sealed partial class Request258Handler
	: Mediator.IRequestHandler<Request258, Response258>,
	MediatR.IRequestHandler<Request258, Response258>
{
	private static ValueTask<Response258> Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response258> Mediator.IRequestHandler<Request258, Response258>.Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response258> MediatR.IRequestHandler<Request258, Response258>.Handle(
		Request258 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request259(long Id) : Mediator.IRequest<Response259>, MediatR.IRequest<Response259>;

public record struct Response259(long Id);

[Handler]
public sealed partial class Request259Handler
	: Mediator.IRequestHandler<Request259, Response259>,
	MediatR.IRequestHandler<Request259, Response259>
{
	private static ValueTask<Response259> Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response259> Mediator.IRequestHandler<Request259, Response259>.Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response259> MediatR.IRequestHandler<Request259, Response259>.Handle(
		Request259 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request260(long Id) : Mediator.IRequest<Response260>, MediatR.IRequest<Response260>;

public record struct Response260(long Id);

[Handler]
public sealed partial class Request260Handler
	: Mediator.IRequestHandler<Request260, Response260>,
	MediatR.IRequestHandler<Request260, Response260>
{
	private static ValueTask<Response260> Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response260> Mediator.IRequestHandler<Request260, Response260>.Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response260> MediatR.IRequestHandler<Request260, Response260>.Handle(
		Request260 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request261(long Id) : Mediator.IRequest<Response261>, MediatR.IRequest<Response261>;

public record struct Response261(long Id);

[Handler]
public sealed partial class Request261Handler
	: Mediator.IRequestHandler<Request261, Response261>,
	MediatR.IRequestHandler<Request261, Response261>
{
	private static ValueTask<Response261> Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response261> Mediator.IRequestHandler<Request261, Response261>.Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response261> MediatR.IRequestHandler<Request261, Response261>.Handle(
		Request261 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request262(long Id) : Mediator.IRequest<Response262>, MediatR.IRequest<Response262>;

public record struct Response262(long Id);

[Handler]
public sealed partial class Request262Handler
	: Mediator.IRequestHandler<Request262, Response262>,
	MediatR.IRequestHandler<Request262, Response262>
{
	private static ValueTask<Response262> Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response262> Mediator.IRequestHandler<Request262, Response262>.Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response262> MediatR.IRequestHandler<Request262, Response262>.Handle(
		Request262 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request263(long Id) : Mediator.IRequest<Response263>, MediatR.IRequest<Response263>;

public record struct Response263(long Id);

[Handler]
public sealed partial class Request263Handler
	: Mediator.IRequestHandler<Request263, Response263>,
	MediatR.IRequestHandler<Request263, Response263>
{
	private static ValueTask<Response263> Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response263> Mediator.IRequestHandler<Request263, Response263>.Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response263> MediatR.IRequestHandler<Request263, Response263>.Handle(
		Request263 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request264(long Id) : Mediator.IRequest<Response264>, MediatR.IRequest<Response264>;

public record struct Response264(long Id);

[Handler]
public sealed partial class Request264Handler
	: Mediator.IRequestHandler<Request264, Response264>,
	MediatR.IRequestHandler<Request264, Response264>
{
	private static ValueTask<Response264> Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response264> Mediator.IRequestHandler<Request264, Response264>.Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response264> MediatR.IRequestHandler<Request264, Response264>.Handle(
		Request264 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request265(long Id) : Mediator.IRequest<Response265>, MediatR.IRequest<Response265>;

public record struct Response265(long Id);

[Handler]
public sealed partial class Request265Handler
	: Mediator.IRequestHandler<Request265, Response265>,
	MediatR.IRequestHandler<Request265, Response265>
{
	private static ValueTask<Response265> Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response265> Mediator.IRequestHandler<Request265, Response265>.Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response265> MediatR.IRequestHandler<Request265, Response265>.Handle(
		Request265 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request266(long Id) : Mediator.IRequest<Response266>, MediatR.IRequest<Response266>;

public record struct Response266(long Id);

[Handler]
public sealed partial class Request266Handler
	: Mediator.IRequestHandler<Request266, Response266>,
	MediatR.IRequestHandler<Request266, Response266>
{
	private static ValueTask<Response266> Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response266> Mediator.IRequestHandler<Request266, Response266>.Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response266> MediatR.IRequestHandler<Request266, Response266>.Handle(
		Request266 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request267(long Id) : Mediator.IRequest<Response267>, MediatR.IRequest<Response267>;

public record struct Response267(long Id);

[Handler]
public sealed partial class Request267Handler
	: Mediator.IRequestHandler<Request267, Response267>,
	MediatR.IRequestHandler<Request267, Response267>
{
	private static ValueTask<Response267> Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response267> Mediator.IRequestHandler<Request267, Response267>.Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response267> MediatR.IRequestHandler<Request267, Response267>.Handle(
		Request267 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request268(long Id) : Mediator.IRequest<Response268>, MediatR.IRequest<Response268>;

public record struct Response268(long Id);

[Handler]
public sealed partial class Request268Handler
	: Mediator.IRequestHandler<Request268, Response268>,
	MediatR.IRequestHandler<Request268, Response268>
{
	private static ValueTask<Response268> Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response268> Mediator.IRequestHandler<Request268, Response268>.Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response268> MediatR.IRequestHandler<Request268, Response268>.Handle(
		Request268 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request269(long Id) : Mediator.IRequest<Response269>, MediatR.IRequest<Response269>;

public record struct Response269(long Id);

[Handler]
public sealed partial class Request269Handler
	: Mediator.IRequestHandler<Request269, Response269>,
	MediatR.IRequestHandler<Request269, Response269>
{
	private static ValueTask<Response269> Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response269> Mediator.IRequestHandler<Request269, Response269>.Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response269> MediatR.IRequestHandler<Request269, Response269>.Handle(
		Request269 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request270(long Id) : Mediator.IRequest<Response270>, MediatR.IRequest<Response270>;

public record struct Response270(long Id);

[Handler]
public sealed partial class Request270Handler
	: Mediator.IRequestHandler<Request270, Response270>,
	MediatR.IRequestHandler<Request270, Response270>
{
	private static ValueTask<Response270> Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response270> Mediator.IRequestHandler<Request270, Response270>.Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response270> MediatR.IRequestHandler<Request270, Response270>.Handle(
		Request270 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request271(long Id) : Mediator.IRequest<Response271>, MediatR.IRequest<Response271>;

public record struct Response271(long Id);

[Handler]
public sealed partial class Request271Handler
	: Mediator.IRequestHandler<Request271, Response271>,
	MediatR.IRequestHandler<Request271, Response271>
{
	private static ValueTask<Response271> Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response271> Mediator.IRequestHandler<Request271, Response271>.Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response271> MediatR.IRequestHandler<Request271, Response271>.Handle(
		Request271 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request272(long Id) : Mediator.IRequest<Response272>, MediatR.IRequest<Response272>;

public record struct Response272(long Id);

[Handler]
public sealed partial class Request272Handler
	: Mediator.IRequestHandler<Request272, Response272>,
	MediatR.IRequestHandler<Request272, Response272>
{
	private static ValueTask<Response272> Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response272> Mediator.IRequestHandler<Request272, Response272>.Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response272> MediatR.IRequestHandler<Request272, Response272>.Handle(
		Request272 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request273(long Id) : Mediator.IRequest<Response273>, MediatR.IRequest<Response273>;

public record struct Response273(long Id);

[Handler]
public sealed partial class Request273Handler
	: Mediator.IRequestHandler<Request273, Response273>,
	MediatR.IRequestHandler<Request273, Response273>
{
	private static ValueTask<Response273> Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response273> Mediator.IRequestHandler<Request273, Response273>.Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response273> MediatR.IRequestHandler<Request273, Response273>.Handle(
		Request273 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request274(long Id) : Mediator.IRequest<Response274>, MediatR.IRequest<Response274>;

public record struct Response274(long Id);

[Handler]
public sealed partial class Request274Handler
	: Mediator.IRequestHandler<Request274, Response274>,
	MediatR.IRequestHandler<Request274, Response274>
{
	private static ValueTask<Response274> Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response274> Mediator.IRequestHandler<Request274, Response274>.Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response274> MediatR.IRequestHandler<Request274, Response274>.Handle(
		Request274 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request275(long Id) : Mediator.IRequest<Response275>, MediatR.IRequest<Response275>;

public record struct Response275(long Id);

[Handler]
public sealed partial class Request275Handler
	: Mediator.IRequestHandler<Request275, Response275>,
	MediatR.IRequestHandler<Request275, Response275>
{
	private static ValueTask<Response275> Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response275> Mediator.IRequestHandler<Request275, Response275>.Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response275> MediatR.IRequestHandler<Request275, Response275>.Handle(
		Request275 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request276(long Id) : Mediator.IRequest<Response276>, MediatR.IRequest<Response276>;

public record struct Response276(long Id);

[Handler]
public sealed partial class Request276Handler
	: Mediator.IRequestHandler<Request276, Response276>,
	MediatR.IRequestHandler<Request276, Response276>
{
	private static ValueTask<Response276> Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response276> Mediator.IRequestHandler<Request276, Response276>.Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response276> MediatR.IRequestHandler<Request276, Response276>.Handle(
		Request276 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request277(long Id) : Mediator.IRequest<Response277>, MediatR.IRequest<Response277>;

public record struct Response277(long Id);

[Handler]
public sealed partial class Request277Handler
	: Mediator.IRequestHandler<Request277, Response277>,
	MediatR.IRequestHandler<Request277, Response277>
{
	private static ValueTask<Response277> Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response277> Mediator.IRequestHandler<Request277, Response277>.Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response277> MediatR.IRequestHandler<Request277, Response277>.Handle(
		Request277 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request278(long Id) : Mediator.IRequest<Response278>, MediatR.IRequest<Response278>;

public record struct Response278(long Id);

[Handler]
public sealed partial class Request278Handler
	: Mediator.IRequestHandler<Request278, Response278>,
	MediatR.IRequestHandler<Request278, Response278>
{
	private static ValueTask<Response278> Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response278> Mediator.IRequestHandler<Request278, Response278>.Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response278> MediatR.IRequestHandler<Request278, Response278>.Handle(
		Request278 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request279(long Id) : Mediator.IRequest<Response279>, MediatR.IRequest<Response279>;

public record struct Response279(long Id);

[Handler]
public sealed partial class Request279Handler
	: Mediator.IRequestHandler<Request279, Response279>,
	MediatR.IRequestHandler<Request279, Response279>
{
	private static ValueTask<Response279> Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response279> Mediator.IRequestHandler<Request279, Response279>.Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response279> MediatR.IRequestHandler<Request279, Response279>.Handle(
		Request279 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request280(long Id) : Mediator.IRequest<Response280>, MediatR.IRequest<Response280>;

public record struct Response280(long Id);

[Handler]
public sealed partial class Request280Handler
	: Mediator.IRequestHandler<Request280, Response280>,
	MediatR.IRequestHandler<Request280, Response280>
{
	private static ValueTask<Response280> Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response280> Mediator.IRequestHandler<Request280, Response280>.Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response280> MediatR.IRequestHandler<Request280, Response280>.Handle(
		Request280 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request281(long Id) : Mediator.IRequest<Response281>, MediatR.IRequest<Response281>;

public record struct Response281(long Id);

[Handler]
public sealed partial class Request281Handler
	: Mediator.IRequestHandler<Request281, Response281>,
	MediatR.IRequestHandler<Request281, Response281>
{
	private static ValueTask<Response281> Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response281> Mediator.IRequestHandler<Request281, Response281>.Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response281> MediatR.IRequestHandler<Request281, Response281>.Handle(
		Request281 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request282(long Id) : Mediator.IRequest<Response282>, MediatR.IRequest<Response282>;

public record struct Response282(long Id);

[Handler]
public sealed partial class Request282Handler
	: Mediator.IRequestHandler<Request282, Response282>,
	MediatR.IRequestHandler<Request282, Response282>
{
	private static ValueTask<Response282> Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response282> Mediator.IRequestHandler<Request282, Response282>.Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response282> MediatR.IRequestHandler<Request282, Response282>.Handle(
		Request282 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request283(long Id) : Mediator.IRequest<Response283>, MediatR.IRequest<Response283>;

public record struct Response283(long Id);

[Handler]
public sealed partial class Request283Handler
	: Mediator.IRequestHandler<Request283, Response283>,
	MediatR.IRequestHandler<Request283, Response283>
{
	private static ValueTask<Response283> Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response283> Mediator.IRequestHandler<Request283, Response283>.Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response283> MediatR.IRequestHandler<Request283, Response283>.Handle(
		Request283 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request284(long Id) : Mediator.IRequest<Response284>, MediatR.IRequest<Response284>;

public record struct Response284(long Id);

[Handler]
public sealed partial class Request284Handler
	: Mediator.IRequestHandler<Request284, Response284>,
	MediatR.IRequestHandler<Request284, Response284>
{
	private static ValueTask<Response284> Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response284> Mediator.IRequestHandler<Request284, Response284>.Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response284> MediatR.IRequestHandler<Request284, Response284>.Handle(
		Request284 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request285(long Id) : Mediator.IRequest<Response285>, MediatR.IRequest<Response285>;

public record struct Response285(long Id);

[Handler]
public sealed partial class Request285Handler
	: Mediator.IRequestHandler<Request285, Response285>,
	MediatR.IRequestHandler<Request285, Response285>
{
	private static ValueTask<Response285> Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response285> Mediator.IRequestHandler<Request285, Response285>.Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response285> MediatR.IRequestHandler<Request285, Response285>.Handle(
		Request285 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request286(long Id) : Mediator.IRequest<Response286>, MediatR.IRequest<Response286>;

public record struct Response286(long Id);

[Handler]
public sealed partial class Request286Handler
	: Mediator.IRequestHandler<Request286, Response286>,
	MediatR.IRequestHandler<Request286, Response286>
{
	private static ValueTask<Response286> Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response286> Mediator.IRequestHandler<Request286, Response286>.Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response286> MediatR.IRequestHandler<Request286, Response286>.Handle(
		Request286 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request287(long Id) : Mediator.IRequest<Response287>, MediatR.IRequest<Response287>;

public record struct Response287(long Id);

[Handler]
public sealed partial class Request287Handler
	: Mediator.IRequestHandler<Request287, Response287>,
	MediatR.IRequestHandler<Request287, Response287>
{
	private static ValueTask<Response287> Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response287> Mediator.IRequestHandler<Request287, Response287>.Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response287> MediatR.IRequestHandler<Request287, Response287>.Handle(
		Request287 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request288(long Id) : Mediator.IRequest<Response288>, MediatR.IRequest<Response288>;

public record struct Response288(long Id);

[Handler]
public sealed partial class Request288Handler
	: Mediator.IRequestHandler<Request288, Response288>,
	MediatR.IRequestHandler<Request288, Response288>
{
	private static ValueTask<Response288> Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response288> Mediator.IRequestHandler<Request288, Response288>.Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response288> MediatR.IRequestHandler<Request288, Response288>.Handle(
		Request288 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request289(long Id) : Mediator.IRequest<Response289>, MediatR.IRequest<Response289>;

public record struct Response289(long Id);

[Handler]
public sealed partial class Request289Handler
	: Mediator.IRequestHandler<Request289, Response289>,
	MediatR.IRequestHandler<Request289, Response289>
{
	private static ValueTask<Response289> Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response289> Mediator.IRequestHandler<Request289, Response289>.Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response289> MediatR.IRequestHandler<Request289, Response289>.Handle(
		Request289 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request290(long Id) : Mediator.IRequest<Response290>, MediatR.IRequest<Response290>;

public record struct Response290(long Id);

[Handler]
public sealed partial class Request290Handler
	: Mediator.IRequestHandler<Request290, Response290>,
	MediatR.IRequestHandler<Request290, Response290>
{
	private static ValueTask<Response290> Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response290> Mediator.IRequestHandler<Request290, Response290>.Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response290> MediatR.IRequestHandler<Request290, Response290>.Handle(
		Request290 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request291(long Id) : Mediator.IRequest<Response291>, MediatR.IRequest<Response291>;

public record struct Response291(long Id);

[Handler]
public sealed partial class Request291Handler
	: Mediator.IRequestHandler<Request291, Response291>,
	MediatR.IRequestHandler<Request291, Response291>
{
	private static ValueTask<Response291> Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response291> Mediator.IRequestHandler<Request291, Response291>.Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response291> MediatR.IRequestHandler<Request291, Response291>.Handle(
		Request291 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request292(long Id) : Mediator.IRequest<Response292>, MediatR.IRequest<Response292>;

public record struct Response292(long Id);

[Handler]
public sealed partial class Request292Handler
	: Mediator.IRequestHandler<Request292, Response292>,
	MediatR.IRequestHandler<Request292, Response292>
{
	private static ValueTask<Response292> Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response292> Mediator.IRequestHandler<Request292, Response292>.Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response292> MediatR.IRequestHandler<Request292, Response292>.Handle(
		Request292 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request293(long Id) : Mediator.IRequest<Response293>, MediatR.IRequest<Response293>;

public record struct Response293(long Id);

[Handler]
public sealed partial class Request293Handler
	: Mediator.IRequestHandler<Request293, Response293>,
	MediatR.IRequestHandler<Request293, Response293>
{
	private static ValueTask<Response293> Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response293> Mediator.IRequestHandler<Request293, Response293>.Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response293> MediatR.IRequestHandler<Request293, Response293>.Handle(
		Request293 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request294(long Id) : Mediator.IRequest<Response294>, MediatR.IRequest<Response294>;

public record struct Response294(long Id);

[Handler]
public sealed partial class Request294Handler
	: Mediator.IRequestHandler<Request294, Response294>,
	MediatR.IRequestHandler<Request294, Response294>
{
	private static ValueTask<Response294> Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response294> Mediator.IRequestHandler<Request294, Response294>.Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response294> MediatR.IRequestHandler<Request294, Response294>.Handle(
		Request294 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request295(long Id) : Mediator.IRequest<Response295>, MediatR.IRequest<Response295>;

public record struct Response295(long Id);

[Handler]
public sealed partial class Request295Handler
	: Mediator.IRequestHandler<Request295, Response295>,
	MediatR.IRequestHandler<Request295, Response295>
{
	private static ValueTask<Response295> Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response295> Mediator.IRequestHandler<Request295, Response295>.Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response295> MediatR.IRequestHandler<Request295, Response295>.Handle(
		Request295 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request296(long Id) : Mediator.IRequest<Response296>, MediatR.IRequest<Response296>;

public record struct Response296(long Id);

[Handler]
public sealed partial class Request296Handler
	: Mediator.IRequestHandler<Request296, Response296>,
	MediatR.IRequestHandler<Request296, Response296>
{
	private static ValueTask<Response296> Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response296> Mediator.IRequestHandler<Request296, Response296>.Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response296> MediatR.IRequestHandler<Request296, Response296>.Handle(
		Request296 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request297(long Id) : Mediator.IRequest<Response297>, MediatR.IRequest<Response297>;

public record struct Response297(long Id);

[Handler]
public sealed partial class Request297Handler
	: Mediator.IRequestHandler<Request297, Response297>,
	MediatR.IRequestHandler<Request297, Response297>
{
	private static ValueTask<Response297> Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response297> Mediator.IRequestHandler<Request297, Response297>.Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response297> MediatR.IRequestHandler<Request297, Response297>.Handle(
		Request297 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request298(long Id) : Mediator.IRequest<Response298>, MediatR.IRequest<Response298>;

public record struct Response298(long Id);

[Handler]
public sealed partial class Request298Handler
	: Mediator.IRequestHandler<Request298, Response298>,
	MediatR.IRequestHandler<Request298, Response298>
{
	private static ValueTask<Response298> Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response298> Mediator.IRequestHandler<Request298, Response298>.Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response298> MediatR.IRequestHandler<Request298, Response298>.Handle(
		Request298 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request299(long Id) : Mediator.IRequest<Response299>, MediatR.IRequest<Response299>;

public record struct Response299(long Id);

[Handler]
public sealed partial class Request299Handler
	: Mediator.IRequestHandler<Request299, Response299>,
	MediatR.IRequestHandler<Request299, Response299>
{
	private static ValueTask<Response299> Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response299> Mediator.IRequestHandler<Request299, Response299>.Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response299> MediatR.IRequestHandler<Request299, Response299>.Handle(
		Request299 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request300(long Id) : Mediator.IRequest<Response300>, MediatR.IRequest<Response300>;

public record struct Response300(long Id);

[Handler]
public sealed partial class Request300Handler
	: Mediator.IRequestHandler<Request300, Response300>,
	MediatR.IRequestHandler<Request300, Response300>
{
	private static ValueTask<Response300> Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response300> Mediator.IRequestHandler<Request300, Response300>.Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response300> MediatR.IRequestHandler<Request300, Response300>.Handle(
		Request300 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request301(long Id) : Mediator.IRequest<Response301>, MediatR.IRequest<Response301>;

public record struct Response301(long Id);

[Handler]
public sealed partial class Request301Handler
	: Mediator.IRequestHandler<Request301, Response301>,
	MediatR.IRequestHandler<Request301, Response301>
{
	private static ValueTask<Response301> Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response301> Mediator.IRequestHandler<Request301, Response301>.Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response301> MediatR.IRequestHandler<Request301, Response301>.Handle(
		Request301 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request302(long Id) : Mediator.IRequest<Response302>, MediatR.IRequest<Response302>;

public record struct Response302(long Id);

[Handler]
public sealed partial class Request302Handler
	: Mediator.IRequestHandler<Request302, Response302>,
	MediatR.IRequestHandler<Request302, Response302>
{
	private static ValueTask<Response302> Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response302> Mediator.IRequestHandler<Request302, Response302>.Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response302> MediatR.IRequestHandler<Request302, Response302>.Handle(
		Request302 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request303(long Id) : Mediator.IRequest<Response303>, MediatR.IRequest<Response303>;

public record struct Response303(long Id);

[Handler]
public sealed partial class Request303Handler
	: Mediator.IRequestHandler<Request303, Response303>,
	MediatR.IRequestHandler<Request303, Response303>
{
	private static ValueTask<Response303> Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response303> Mediator.IRequestHandler<Request303, Response303>.Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response303> MediatR.IRequestHandler<Request303, Response303>.Handle(
		Request303 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request304(long Id) : Mediator.IRequest<Response304>, MediatR.IRequest<Response304>;

public record struct Response304(long Id);

[Handler]
public sealed partial class Request304Handler
	: Mediator.IRequestHandler<Request304, Response304>,
	MediatR.IRequestHandler<Request304, Response304>
{
	private static ValueTask<Response304> Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response304> Mediator.IRequestHandler<Request304, Response304>.Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response304> MediatR.IRequestHandler<Request304, Response304>.Handle(
		Request304 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request305(long Id) : Mediator.IRequest<Response305>, MediatR.IRequest<Response305>;

public record struct Response305(long Id);

[Handler]
public sealed partial class Request305Handler
	: Mediator.IRequestHandler<Request305, Response305>,
	MediatR.IRequestHandler<Request305, Response305>
{
	private static ValueTask<Response305> Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response305> Mediator.IRequestHandler<Request305, Response305>.Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response305> MediatR.IRequestHandler<Request305, Response305>.Handle(
		Request305 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request306(long Id) : Mediator.IRequest<Response306>, MediatR.IRequest<Response306>;

public record struct Response306(long Id);

[Handler]
public sealed partial class Request306Handler
	: Mediator.IRequestHandler<Request306, Response306>,
	MediatR.IRequestHandler<Request306, Response306>
{
	private static ValueTask<Response306> Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response306> Mediator.IRequestHandler<Request306, Response306>.Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response306> MediatR.IRequestHandler<Request306, Response306>.Handle(
		Request306 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request307(long Id) : Mediator.IRequest<Response307>, MediatR.IRequest<Response307>;

public record struct Response307(long Id);

[Handler]
public sealed partial class Request307Handler
	: Mediator.IRequestHandler<Request307, Response307>,
	MediatR.IRequestHandler<Request307, Response307>
{
	private static ValueTask<Response307> Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response307> Mediator.IRequestHandler<Request307, Response307>.Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response307> MediatR.IRequestHandler<Request307, Response307>.Handle(
		Request307 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request308(long Id) : Mediator.IRequest<Response308>, MediatR.IRequest<Response308>;

public record struct Response308(long Id);

[Handler]
public sealed partial class Request308Handler
	: Mediator.IRequestHandler<Request308, Response308>,
	MediatR.IRequestHandler<Request308, Response308>
{
	private static ValueTask<Response308> Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response308> Mediator.IRequestHandler<Request308, Response308>.Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response308> MediatR.IRequestHandler<Request308, Response308>.Handle(
		Request308 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request309(long Id) : Mediator.IRequest<Response309>, MediatR.IRequest<Response309>;

public record struct Response309(long Id);

[Handler]
public sealed partial class Request309Handler
	: Mediator.IRequestHandler<Request309, Response309>,
	MediatR.IRequestHandler<Request309, Response309>
{
	private static ValueTask<Response309> Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response309> Mediator.IRequestHandler<Request309, Response309>.Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response309> MediatR.IRequestHandler<Request309, Response309>.Handle(
		Request309 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request310(long Id) : Mediator.IRequest<Response310>, MediatR.IRequest<Response310>;

public record struct Response310(long Id);

[Handler]
public sealed partial class Request310Handler
	: Mediator.IRequestHandler<Request310, Response310>,
	MediatR.IRequestHandler<Request310, Response310>
{
	private static ValueTask<Response310> Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response310> Mediator.IRequestHandler<Request310, Response310>.Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response310> MediatR.IRequestHandler<Request310, Response310>.Handle(
		Request310 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request311(long Id) : Mediator.IRequest<Response311>, MediatR.IRequest<Response311>;

public record struct Response311(long Id);

[Handler]
public sealed partial class Request311Handler
	: Mediator.IRequestHandler<Request311, Response311>,
	MediatR.IRequestHandler<Request311, Response311>
{
	private static ValueTask<Response311> Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response311> Mediator.IRequestHandler<Request311, Response311>.Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response311> MediatR.IRequestHandler<Request311, Response311>.Handle(
		Request311 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request312(long Id) : Mediator.IRequest<Response312>, MediatR.IRequest<Response312>;

public record struct Response312(long Id);

[Handler]
public sealed partial class Request312Handler
	: Mediator.IRequestHandler<Request312, Response312>,
	MediatR.IRequestHandler<Request312, Response312>
{
	private static ValueTask<Response312> Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response312> Mediator.IRequestHandler<Request312, Response312>.Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response312> MediatR.IRequestHandler<Request312, Response312>.Handle(
		Request312 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request313(long Id) : Mediator.IRequest<Response313>, MediatR.IRequest<Response313>;

public record struct Response313(long Id);

[Handler]
public sealed partial class Request313Handler
	: Mediator.IRequestHandler<Request313, Response313>,
	MediatR.IRequestHandler<Request313, Response313>
{
	private static ValueTask<Response313> Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response313> Mediator.IRequestHandler<Request313, Response313>.Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response313> MediatR.IRequestHandler<Request313, Response313>.Handle(
		Request313 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request314(long Id) : Mediator.IRequest<Response314>, MediatR.IRequest<Response314>;

public record struct Response314(long Id);

[Handler]
public sealed partial class Request314Handler
	: Mediator.IRequestHandler<Request314, Response314>,
	MediatR.IRequestHandler<Request314, Response314>
{
	private static ValueTask<Response314> Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response314> Mediator.IRequestHandler<Request314, Response314>.Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response314> MediatR.IRequestHandler<Request314, Response314>.Handle(
		Request314 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request315(long Id) : Mediator.IRequest<Response315>, MediatR.IRequest<Response315>;

public record struct Response315(long Id);

[Handler]
public sealed partial class Request315Handler
	: Mediator.IRequestHandler<Request315, Response315>,
	MediatR.IRequestHandler<Request315, Response315>
{
	private static ValueTask<Response315> Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response315> Mediator.IRequestHandler<Request315, Response315>.Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response315> MediatR.IRequestHandler<Request315, Response315>.Handle(
		Request315 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request316(long Id) : Mediator.IRequest<Response316>, MediatR.IRequest<Response316>;

public record struct Response316(long Id);

[Handler]
public sealed partial class Request316Handler
	: Mediator.IRequestHandler<Request316, Response316>,
	MediatR.IRequestHandler<Request316, Response316>
{
	private static ValueTask<Response316> Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response316> Mediator.IRequestHandler<Request316, Response316>.Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response316> MediatR.IRequestHandler<Request316, Response316>.Handle(
		Request316 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request317(long Id) : Mediator.IRequest<Response317>, MediatR.IRequest<Response317>;

public record struct Response317(long Id);

[Handler]
public sealed partial class Request317Handler
	: Mediator.IRequestHandler<Request317, Response317>,
	MediatR.IRequestHandler<Request317, Response317>
{
	private static ValueTask<Response317> Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response317> Mediator.IRequestHandler<Request317, Response317>.Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response317> MediatR.IRequestHandler<Request317, Response317>.Handle(
		Request317 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request318(long Id) : Mediator.IRequest<Response318>, MediatR.IRequest<Response318>;

public record struct Response318(long Id);

[Handler]
public sealed partial class Request318Handler
	: Mediator.IRequestHandler<Request318, Response318>,
	MediatR.IRequestHandler<Request318, Response318>
{
	private static ValueTask<Response318> Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response318> Mediator.IRequestHandler<Request318, Response318>.Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response318> MediatR.IRequestHandler<Request318, Response318>.Handle(
		Request318 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request319(long Id) : Mediator.IRequest<Response319>, MediatR.IRequest<Response319>;

public record struct Response319(long Id);

[Handler]
public sealed partial class Request319Handler
	: Mediator.IRequestHandler<Request319, Response319>,
	MediatR.IRequestHandler<Request319, Response319>
{
	private static ValueTask<Response319> Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response319> Mediator.IRequestHandler<Request319, Response319>.Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response319> MediatR.IRequestHandler<Request319, Response319>.Handle(
		Request319 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request320(long Id) : Mediator.IRequest<Response320>, MediatR.IRequest<Response320>;

public record struct Response320(long Id);

[Handler]
public sealed partial class Request320Handler
	: Mediator.IRequestHandler<Request320, Response320>,
	MediatR.IRequestHandler<Request320, Response320>
{
	private static ValueTask<Response320> Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response320> Mediator.IRequestHandler<Request320, Response320>.Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response320> MediatR.IRequestHandler<Request320, Response320>.Handle(
		Request320 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request321(long Id) : Mediator.IRequest<Response321>, MediatR.IRequest<Response321>;

public record struct Response321(long Id);

[Handler]
public sealed partial class Request321Handler
	: Mediator.IRequestHandler<Request321, Response321>,
	MediatR.IRequestHandler<Request321, Response321>
{
	private static ValueTask<Response321> Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response321> Mediator.IRequestHandler<Request321, Response321>.Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response321> MediatR.IRequestHandler<Request321, Response321>.Handle(
		Request321 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request322(long Id) : Mediator.IRequest<Response322>, MediatR.IRequest<Response322>;

public record struct Response322(long Id);

[Handler]
public sealed partial class Request322Handler
	: Mediator.IRequestHandler<Request322, Response322>,
	MediatR.IRequestHandler<Request322, Response322>
{
	private static ValueTask<Response322> Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response322> Mediator.IRequestHandler<Request322, Response322>.Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response322> MediatR.IRequestHandler<Request322, Response322>.Handle(
		Request322 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request323(long Id) : Mediator.IRequest<Response323>, MediatR.IRequest<Response323>;

public record struct Response323(long Id);

[Handler]
public sealed partial class Request323Handler
	: Mediator.IRequestHandler<Request323, Response323>,
	MediatR.IRequestHandler<Request323, Response323>
{
	private static ValueTask<Response323> Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response323> Mediator.IRequestHandler<Request323, Response323>.Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response323> MediatR.IRequestHandler<Request323, Response323>.Handle(
		Request323 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request324(long Id) : Mediator.IRequest<Response324>, MediatR.IRequest<Response324>;

public record struct Response324(long Id);

[Handler]
public sealed partial class Request324Handler
	: Mediator.IRequestHandler<Request324, Response324>,
	MediatR.IRequestHandler<Request324, Response324>
{
	private static ValueTask<Response324> Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response324> Mediator.IRequestHandler<Request324, Response324>.Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response324> MediatR.IRequestHandler<Request324, Response324>.Handle(
		Request324 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request325(long Id) : Mediator.IRequest<Response325>, MediatR.IRequest<Response325>;

public record struct Response325(long Id);

[Handler]
public sealed partial class Request325Handler
	: Mediator.IRequestHandler<Request325, Response325>,
	MediatR.IRequestHandler<Request325, Response325>
{
	private static ValueTask<Response325> Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response325> Mediator.IRequestHandler<Request325, Response325>.Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response325> MediatR.IRequestHandler<Request325, Response325>.Handle(
		Request325 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request326(long Id) : Mediator.IRequest<Response326>, MediatR.IRequest<Response326>;

public record struct Response326(long Id);

[Handler]
public sealed partial class Request326Handler
	: Mediator.IRequestHandler<Request326, Response326>,
	MediatR.IRequestHandler<Request326, Response326>
{
	private static ValueTask<Response326> Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response326> Mediator.IRequestHandler<Request326, Response326>.Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response326> MediatR.IRequestHandler<Request326, Response326>.Handle(
		Request326 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request327(long Id) : Mediator.IRequest<Response327>, MediatR.IRequest<Response327>;

public record struct Response327(long Id);

[Handler]
public sealed partial class Request327Handler
	: Mediator.IRequestHandler<Request327, Response327>,
	MediatR.IRequestHandler<Request327, Response327>
{
	private static ValueTask<Response327> Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response327> Mediator.IRequestHandler<Request327, Response327>.Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response327> MediatR.IRequestHandler<Request327, Response327>.Handle(
		Request327 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request328(long Id) : Mediator.IRequest<Response328>, MediatR.IRequest<Response328>;

public record struct Response328(long Id);

[Handler]
public sealed partial class Request328Handler
	: Mediator.IRequestHandler<Request328, Response328>,
	MediatR.IRequestHandler<Request328, Response328>
{
	private static ValueTask<Response328> Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response328> Mediator.IRequestHandler<Request328, Response328>.Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response328> MediatR.IRequestHandler<Request328, Response328>.Handle(
		Request328 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request329(long Id) : Mediator.IRequest<Response329>, MediatR.IRequest<Response329>;

public record struct Response329(long Id);

[Handler]
public sealed partial class Request329Handler
	: Mediator.IRequestHandler<Request329, Response329>,
	MediatR.IRequestHandler<Request329, Response329>
{
	private static ValueTask<Response329> Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response329> Mediator.IRequestHandler<Request329, Response329>.Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response329> MediatR.IRequestHandler<Request329, Response329>.Handle(
		Request329 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request330(long Id) : Mediator.IRequest<Response330>, MediatR.IRequest<Response330>;

public record struct Response330(long Id);

[Handler]
public sealed partial class Request330Handler
	: Mediator.IRequestHandler<Request330, Response330>,
	MediatR.IRequestHandler<Request330, Response330>
{
	private static ValueTask<Response330> Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response330> Mediator.IRequestHandler<Request330, Response330>.Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response330> MediatR.IRequestHandler<Request330, Response330>.Handle(
		Request330 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request331(long Id) : Mediator.IRequest<Response331>, MediatR.IRequest<Response331>;

public record struct Response331(long Id);

[Handler]
public sealed partial class Request331Handler
	: Mediator.IRequestHandler<Request331, Response331>,
	MediatR.IRequestHandler<Request331, Response331>
{
	private static ValueTask<Response331> Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response331> Mediator.IRequestHandler<Request331, Response331>.Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response331> MediatR.IRequestHandler<Request331, Response331>.Handle(
		Request331 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request332(long Id) : Mediator.IRequest<Response332>, MediatR.IRequest<Response332>;

public record struct Response332(long Id);

[Handler]
public sealed partial class Request332Handler
	: Mediator.IRequestHandler<Request332, Response332>,
	MediatR.IRequestHandler<Request332, Response332>
{
	private static ValueTask<Response332> Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response332> Mediator.IRequestHandler<Request332, Response332>.Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response332> MediatR.IRequestHandler<Request332, Response332>.Handle(
		Request332 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request333(long Id) : Mediator.IRequest<Response333>, MediatR.IRequest<Response333>;

public record struct Response333(long Id);

[Handler]
public sealed partial class Request333Handler
	: Mediator.IRequestHandler<Request333, Response333>,
	MediatR.IRequestHandler<Request333, Response333>
{
	private static ValueTask<Response333> Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response333> Mediator.IRequestHandler<Request333, Response333>.Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response333> MediatR.IRequestHandler<Request333, Response333>.Handle(
		Request333 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request334(long Id) : Mediator.IRequest<Response334>, MediatR.IRequest<Response334>;

public record struct Response334(long Id);

[Handler]
public sealed partial class Request334Handler
	: Mediator.IRequestHandler<Request334, Response334>,
	MediatR.IRequestHandler<Request334, Response334>
{
	private static ValueTask<Response334> Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response334> Mediator.IRequestHandler<Request334, Response334>.Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response334> MediatR.IRequestHandler<Request334, Response334>.Handle(
		Request334 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request335(long Id) : Mediator.IRequest<Response335>, MediatR.IRequest<Response335>;

public record struct Response335(long Id);

[Handler]
public sealed partial class Request335Handler
	: Mediator.IRequestHandler<Request335, Response335>,
	MediatR.IRequestHandler<Request335, Response335>
{
	private static ValueTask<Response335> Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response335> Mediator.IRequestHandler<Request335, Response335>.Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response335> MediatR.IRequestHandler<Request335, Response335>.Handle(
		Request335 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request336(long Id) : Mediator.IRequest<Response336>, MediatR.IRequest<Response336>;

public record struct Response336(long Id);

[Handler]
public sealed partial class Request336Handler
	: Mediator.IRequestHandler<Request336, Response336>,
	MediatR.IRequestHandler<Request336, Response336>
{
	private static ValueTask<Response336> Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response336> Mediator.IRequestHandler<Request336, Response336>.Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response336> MediatR.IRequestHandler<Request336, Response336>.Handle(
		Request336 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request337(long Id) : Mediator.IRequest<Response337>, MediatR.IRequest<Response337>;

public record struct Response337(long Id);

[Handler]
public sealed partial class Request337Handler
	: Mediator.IRequestHandler<Request337, Response337>,
	MediatR.IRequestHandler<Request337, Response337>
{
	private static ValueTask<Response337> Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response337> Mediator.IRequestHandler<Request337, Response337>.Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response337> MediatR.IRequestHandler<Request337, Response337>.Handle(
		Request337 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request338(long Id) : Mediator.IRequest<Response338>, MediatR.IRequest<Response338>;

public record struct Response338(long Id);

[Handler]
public sealed partial class Request338Handler
	: Mediator.IRequestHandler<Request338, Response338>,
	MediatR.IRequestHandler<Request338, Response338>
{
	private static ValueTask<Response338> Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response338> Mediator.IRequestHandler<Request338, Response338>.Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response338> MediatR.IRequestHandler<Request338, Response338>.Handle(
		Request338 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request339(long Id) : Mediator.IRequest<Response339>, MediatR.IRequest<Response339>;

public record struct Response339(long Id);

[Handler]
public sealed partial class Request339Handler
	: Mediator.IRequestHandler<Request339, Response339>,
	MediatR.IRequestHandler<Request339, Response339>
{
	private static ValueTask<Response339> Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response339> Mediator.IRequestHandler<Request339, Response339>.Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response339> MediatR.IRequestHandler<Request339, Response339>.Handle(
		Request339 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request340(long Id) : Mediator.IRequest<Response340>, MediatR.IRequest<Response340>;

public record struct Response340(long Id);

[Handler]
public sealed partial class Request340Handler
	: Mediator.IRequestHandler<Request340, Response340>,
	MediatR.IRequestHandler<Request340, Response340>
{
	private static ValueTask<Response340> Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response340> Mediator.IRequestHandler<Request340, Response340>.Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response340> MediatR.IRequestHandler<Request340, Response340>.Handle(
		Request340 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request341(long Id) : Mediator.IRequest<Response341>, MediatR.IRequest<Response341>;

public record struct Response341(long Id);

[Handler]
public sealed partial class Request341Handler
	: Mediator.IRequestHandler<Request341, Response341>,
	MediatR.IRequestHandler<Request341, Response341>
{
	private static ValueTask<Response341> Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response341> Mediator.IRequestHandler<Request341, Response341>.Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response341> MediatR.IRequestHandler<Request341, Response341>.Handle(
		Request341 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request342(long Id) : Mediator.IRequest<Response342>, MediatR.IRequest<Response342>;

public record struct Response342(long Id);

[Handler]
public sealed partial class Request342Handler
	: Mediator.IRequestHandler<Request342, Response342>,
	MediatR.IRequestHandler<Request342, Response342>
{
	private static ValueTask<Response342> Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response342> Mediator.IRequestHandler<Request342, Response342>.Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response342> MediatR.IRequestHandler<Request342, Response342>.Handle(
		Request342 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request343(long Id) : Mediator.IRequest<Response343>, MediatR.IRequest<Response343>;

public record struct Response343(long Id);

[Handler]
public sealed partial class Request343Handler
	: Mediator.IRequestHandler<Request343, Response343>,
	MediatR.IRequestHandler<Request343, Response343>
{
	private static ValueTask<Response343> Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response343> Mediator.IRequestHandler<Request343, Response343>.Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response343> MediatR.IRequestHandler<Request343, Response343>.Handle(
		Request343 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request344(long Id) : Mediator.IRequest<Response344>, MediatR.IRequest<Response344>;

public record struct Response344(long Id);

[Handler]
public sealed partial class Request344Handler
	: Mediator.IRequestHandler<Request344, Response344>,
	MediatR.IRequestHandler<Request344, Response344>
{
	private static ValueTask<Response344> Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response344> Mediator.IRequestHandler<Request344, Response344>.Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response344> MediatR.IRequestHandler<Request344, Response344>.Handle(
		Request344 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request345(long Id) : Mediator.IRequest<Response345>, MediatR.IRequest<Response345>;

public record struct Response345(long Id);

[Handler]
public sealed partial class Request345Handler
	: Mediator.IRequestHandler<Request345, Response345>,
	MediatR.IRequestHandler<Request345, Response345>
{
	private static ValueTask<Response345> Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response345> Mediator.IRequestHandler<Request345, Response345>.Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response345> MediatR.IRequestHandler<Request345, Response345>.Handle(
		Request345 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request346(long Id) : Mediator.IRequest<Response346>, MediatR.IRequest<Response346>;

public record struct Response346(long Id);

[Handler]
public sealed partial class Request346Handler
	: Mediator.IRequestHandler<Request346, Response346>,
	MediatR.IRequestHandler<Request346, Response346>
{
	private static ValueTask<Response346> Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response346> Mediator.IRequestHandler<Request346, Response346>.Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response346> MediatR.IRequestHandler<Request346, Response346>.Handle(
		Request346 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request347(long Id) : Mediator.IRequest<Response347>, MediatR.IRequest<Response347>;

public record struct Response347(long Id);

[Handler]
public sealed partial class Request347Handler
	: Mediator.IRequestHandler<Request347, Response347>,
	MediatR.IRequestHandler<Request347, Response347>
{
	private static ValueTask<Response347> Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response347> Mediator.IRequestHandler<Request347, Response347>.Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response347> MediatR.IRequestHandler<Request347, Response347>.Handle(
		Request347 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request348(long Id) : Mediator.IRequest<Response348>, MediatR.IRequest<Response348>;

public record struct Response348(long Id);

[Handler]
public sealed partial class Request348Handler
	: Mediator.IRequestHandler<Request348, Response348>,
	MediatR.IRequestHandler<Request348, Response348>
{
	private static ValueTask<Response348> Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response348> Mediator.IRequestHandler<Request348, Response348>.Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response348> MediatR.IRequestHandler<Request348, Response348>.Handle(
		Request348 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request349(long Id) : Mediator.IRequest<Response349>, MediatR.IRequest<Response349>;

public record struct Response349(long Id);

[Handler]
public sealed partial class Request349Handler
	: Mediator.IRequestHandler<Request349, Response349>,
	MediatR.IRequestHandler<Request349, Response349>
{
	private static ValueTask<Response349> Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response349> Mediator.IRequestHandler<Request349, Response349>.Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response349> MediatR.IRequestHandler<Request349, Response349>.Handle(
		Request349 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request350(long Id) : Mediator.IRequest<Response350>, MediatR.IRequest<Response350>;

public record struct Response350(long Id);

[Handler]
public sealed partial class Request350Handler
	: Mediator.IRequestHandler<Request350, Response350>,
	MediatR.IRequestHandler<Request350, Response350>
{
	private static ValueTask<Response350> Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response350> Mediator.IRequestHandler<Request350, Response350>.Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response350> MediatR.IRequestHandler<Request350, Response350>.Handle(
		Request350 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request351(long Id) : Mediator.IRequest<Response351>, MediatR.IRequest<Response351>;

public record struct Response351(long Id);

[Handler]
public sealed partial class Request351Handler
	: Mediator.IRequestHandler<Request351, Response351>,
	MediatR.IRequestHandler<Request351, Response351>
{
	private static ValueTask<Response351> Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response351> Mediator.IRequestHandler<Request351, Response351>.Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response351> MediatR.IRequestHandler<Request351, Response351>.Handle(
		Request351 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request352(long Id) : Mediator.IRequest<Response352>, MediatR.IRequest<Response352>;

public record struct Response352(long Id);

[Handler]
public sealed partial class Request352Handler
	: Mediator.IRequestHandler<Request352, Response352>,
	MediatR.IRequestHandler<Request352, Response352>
{
	private static ValueTask<Response352> Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response352> Mediator.IRequestHandler<Request352, Response352>.Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response352> MediatR.IRequestHandler<Request352, Response352>.Handle(
		Request352 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request353(long Id) : Mediator.IRequest<Response353>, MediatR.IRequest<Response353>;

public record struct Response353(long Id);

[Handler]
public sealed partial class Request353Handler
	: Mediator.IRequestHandler<Request353, Response353>,
	MediatR.IRequestHandler<Request353, Response353>
{
	private static ValueTask<Response353> Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response353> Mediator.IRequestHandler<Request353, Response353>.Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response353> MediatR.IRequestHandler<Request353, Response353>.Handle(
		Request353 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request354(long Id) : Mediator.IRequest<Response354>, MediatR.IRequest<Response354>;

public record struct Response354(long Id);

[Handler]
public sealed partial class Request354Handler
	: Mediator.IRequestHandler<Request354, Response354>,
	MediatR.IRequestHandler<Request354, Response354>
{
	private static ValueTask<Response354> Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response354> Mediator.IRequestHandler<Request354, Response354>.Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response354> MediatR.IRequestHandler<Request354, Response354>.Handle(
		Request354 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request355(long Id) : Mediator.IRequest<Response355>, MediatR.IRequest<Response355>;

public record struct Response355(long Id);

[Handler]
public sealed partial class Request355Handler
	: Mediator.IRequestHandler<Request355, Response355>,
	MediatR.IRequestHandler<Request355, Response355>
{
	private static ValueTask<Response355> Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response355> Mediator.IRequestHandler<Request355, Response355>.Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response355> MediatR.IRequestHandler<Request355, Response355>.Handle(
		Request355 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request356(long Id) : Mediator.IRequest<Response356>, MediatR.IRequest<Response356>;

public record struct Response356(long Id);

[Handler]
public sealed partial class Request356Handler
	: Mediator.IRequestHandler<Request356, Response356>,
	MediatR.IRequestHandler<Request356, Response356>
{
	private static ValueTask<Response356> Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response356> Mediator.IRequestHandler<Request356, Response356>.Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response356> MediatR.IRequestHandler<Request356, Response356>.Handle(
		Request356 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request357(long Id) : Mediator.IRequest<Response357>, MediatR.IRequest<Response357>;

public record struct Response357(long Id);

[Handler]
public sealed partial class Request357Handler
	: Mediator.IRequestHandler<Request357, Response357>,
	MediatR.IRequestHandler<Request357, Response357>
{
	private static ValueTask<Response357> Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response357> Mediator.IRequestHandler<Request357, Response357>.Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response357> MediatR.IRequestHandler<Request357, Response357>.Handle(
		Request357 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request358(long Id) : Mediator.IRequest<Response358>, MediatR.IRequest<Response358>;

public record struct Response358(long Id);

[Handler]
public sealed partial class Request358Handler
	: Mediator.IRequestHandler<Request358, Response358>,
	MediatR.IRequestHandler<Request358, Response358>
{
	private static ValueTask<Response358> Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response358> Mediator.IRequestHandler<Request358, Response358>.Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response358> MediatR.IRequestHandler<Request358, Response358>.Handle(
		Request358 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request359(long Id) : Mediator.IRequest<Response359>, MediatR.IRequest<Response359>;

public record struct Response359(long Id);

[Handler]
public sealed partial class Request359Handler
	: Mediator.IRequestHandler<Request359, Response359>,
	MediatR.IRequestHandler<Request359, Response359>
{
	private static ValueTask<Response359> Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response359> Mediator.IRequestHandler<Request359, Response359>.Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response359> MediatR.IRequestHandler<Request359, Response359>.Handle(
		Request359 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request360(long Id) : Mediator.IRequest<Response360>, MediatR.IRequest<Response360>;

public record struct Response360(long Id);

[Handler]
public sealed partial class Request360Handler
	: Mediator.IRequestHandler<Request360, Response360>,
	MediatR.IRequestHandler<Request360, Response360>
{
	private static ValueTask<Response360> Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response360> Mediator.IRequestHandler<Request360, Response360>.Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response360> MediatR.IRequestHandler<Request360, Response360>.Handle(
		Request360 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request361(long Id) : Mediator.IRequest<Response361>, MediatR.IRequest<Response361>;

public record struct Response361(long Id);

[Handler]
public sealed partial class Request361Handler
	: Mediator.IRequestHandler<Request361, Response361>,
	MediatR.IRequestHandler<Request361, Response361>
{
	private static ValueTask<Response361> Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response361> Mediator.IRequestHandler<Request361, Response361>.Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response361> MediatR.IRequestHandler<Request361, Response361>.Handle(
		Request361 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request362(long Id) : Mediator.IRequest<Response362>, MediatR.IRequest<Response362>;

public record struct Response362(long Id);

[Handler]
public sealed partial class Request362Handler
	: Mediator.IRequestHandler<Request362, Response362>,
	MediatR.IRequestHandler<Request362, Response362>
{
	private static ValueTask<Response362> Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response362> Mediator.IRequestHandler<Request362, Response362>.Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response362> MediatR.IRequestHandler<Request362, Response362>.Handle(
		Request362 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request363(long Id) : Mediator.IRequest<Response363>, MediatR.IRequest<Response363>;

public record struct Response363(long Id);

[Handler]
public sealed partial class Request363Handler
	: Mediator.IRequestHandler<Request363, Response363>,
	MediatR.IRequestHandler<Request363, Response363>
{
	private static ValueTask<Response363> Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response363> Mediator.IRequestHandler<Request363, Response363>.Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response363> MediatR.IRequestHandler<Request363, Response363>.Handle(
		Request363 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request364(long Id) : Mediator.IRequest<Response364>, MediatR.IRequest<Response364>;

public record struct Response364(long Id);

[Handler]
public sealed partial class Request364Handler
	: Mediator.IRequestHandler<Request364, Response364>,
	MediatR.IRequestHandler<Request364, Response364>
{
	private static ValueTask<Response364> Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response364> Mediator.IRequestHandler<Request364, Response364>.Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response364> MediatR.IRequestHandler<Request364, Response364>.Handle(
		Request364 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request365(long Id) : Mediator.IRequest<Response365>, MediatR.IRequest<Response365>;

public record struct Response365(long Id);

[Handler]
public sealed partial class Request365Handler
	: Mediator.IRequestHandler<Request365, Response365>,
	MediatR.IRequestHandler<Request365, Response365>
{
	private static ValueTask<Response365> Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response365> Mediator.IRequestHandler<Request365, Response365>.Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response365> MediatR.IRequestHandler<Request365, Response365>.Handle(
		Request365 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request366(long Id) : Mediator.IRequest<Response366>, MediatR.IRequest<Response366>;

public record struct Response366(long Id);

[Handler]
public sealed partial class Request366Handler
	: Mediator.IRequestHandler<Request366, Response366>,
	MediatR.IRequestHandler<Request366, Response366>
{
	private static ValueTask<Response366> Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response366> Mediator.IRequestHandler<Request366, Response366>.Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response366> MediatR.IRequestHandler<Request366, Response366>.Handle(
		Request366 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request367(long Id) : Mediator.IRequest<Response367>, MediatR.IRequest<Response367>;

public record struct Response367(long Id);

[Handler]
public sealed partial class Request367Handler
	: Mediator.IRequestHandler<Request367, Response367>,
	MediatR.IRequestHandler<Request367, Response367>
{
	private static ValueTask<Response367> Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response367> Mediator.IRequestHandler<Request367, Response367>.Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response367> MediatR.IRequestHandler<Request367, Response367>.Handle(
		Request367 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request368(long Id) : Mediator.IRequest<Response368>, MediatR.IRequest<Response368>;

public record struct Response368(long Id);

[Handler]
public sealed partial class Request368Handler
	: Mediator.IRequestHandler<Request368, Response368>,
	MediatR.IRequestHandler<Request368, Response368>
{
	private static ValueTask<Response368> Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response368> Mediator.IRequestHandler<Request368, Response368>.Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response368> MediatR.IRequestHandler<Request368, Response368>.Handle(
		Request368 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request369(long Id) : Mediator.IRequest<Response369>, MediatR.IRequest<Response369>;

public record struct Response369(long Id);

[Handler]
public sealed partial class Request369Handler
	: Mediator.IRequestHandler<Request369, Response369>,
	MediatR.IRequestHandler<Request369, Response369>
{
	private static ValueTask<Response369> Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response369> Mediator.IRequestHandler<Request369, Response369>.Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response369> MediatR.IRequestHandler<Request369, Response369>.Handle(
		Request369 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request370(long Id) : Mediator.IRequest<Response370>, MediatR.IRequest<Response370>;

public record struct Response370(long Id);

[Handler]
public sealed partial class Request370Handler
	: Mediator.IRequestHandler<Request370, Response370>,
	MediatR.IRequestHandler<Request370, Response370>
{
	private static ValueTask<Response370> Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response370> Mediator.IRequestHandler<Request370, Response370>.Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response370> MediatR.IRequestHandler<Request370, Response370>.Handle(
		Request370 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request371(long Id) : Mediator.IRequest<Response371>, MediatR.IRequest<Response371>;

public record struct Response371(long Id);

[Handler]
public sealed partial class Request371Handler
	: Mediator.IRequestHandler<Request371, Response371>,
	MediatR.IRequestHandler<Request371, Response371>
{
	private static ValueTask<Response371> Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response371> Mediator.IRequestHandler<Request371, Response371>.Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response371> MediatR.IRequestHandler<Request371, Response371>.Handle(
		Request371 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request372(long Id) : Mediator.IRequest<Response372>, MediatR.IRequest<Response372>;

public record struct Response372(long Id);

[Handler]
public sealed partial class Request372Handler
	: Mediator.IRequestHandler<Request372, Response372>,
	MediatR.IRequestHandler<Request372, Response372>
{
	private static ValueTask<Response372> Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response372> Mediator.IRequestHandler<Request372, Response372>.Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response372> MediatR.IRequestHandler<Request372, Response372>.Handle(
		Request372 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request373(long Id) : Mediator.IRequest<Response373>, MediatR.IRequest<Response373>;

public record struct Response373(long Id);

[Handler]
public sealed partial class Request373Handler
	: Mediator.IRequestHandler<Request373, Response373>,
	MediatR.IRequestHandler<Request373, Response373>
{
	private static ValueTask<Response373> Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response373> Mediator.IRequestHandler<Request373, Response373>.Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response373> MediatR.IRequestHandler<Request373, Response373>.Handle(
		Request373 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request374(long Id) : Mediator.IRequest<Response374>, MediatR.IRequest<Response374>;

public record struct Response374(long Id);

[Handler]
public sealed partial class Request374Handler
	: Mediator.IRequestHandler<Request374, Response374>,
	MediatR.IRequestHandler<Request374, Response374>
{
	private static ValueTask<Response374> Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response374> Mediator.IRequestHandler<Request374, Response374>.Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response374> MediatR.IRequestHandler<Request374, Response374>.Handle(
		Request374 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request375(long Id) : Mediator.IRequest<Response375>, MediatR.IRequest<Response375>;

public record struct Response375(long Id);

[Handler]
public sealed partial class Request375Handler
	: Mediator.IRequestHandler<Request375, Response375>,
	MediatR.IRequestHandler<Request375, Response375>
{
	private static ValueTask<Response375> Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response375> Mediator.IRequestHandler<Request375, Response375>.Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response375> MediatR.IRequestHandler<Request375, Response375>.Handle(
		Request375 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request376(long Id) : Mediator.IRequest<Response376>, MediatR.IRequest<Response376>;

public record struct Response376(long Id);

[Handler]
public sealed partial class Request376Handler
	: Mediator.IRequestHandler<Request376, Response376>,
	MediatR.IRequestHandler<Request376, Response376>
{
	private static ValueTask<Response376> Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response376> Mediator.IRequestHandler<Request376, Response376>.Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response376> MediatR.IRequestHandler<Request376, Response376>.Handle(
		Request376 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request377(long Id) : Mediator.IRequest<Response377>, MediatR.IRequest<Response377>;

public record struct Response377(long Id);

[Handler]
public sealed partial class Request377Handler
	: Mediator.IRequestHandler<Request377, Response377>,
	MediatR.IRequestHandler<Request377, Response377>
{
	private static ValueTask<Response377> Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response377> Mediator.IRequestHandler<Request377, Response377>.Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response377> MediatR.IRequestHandler<Request377, Response377>.Handle(
		Request377 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request378(long Id) : Mediator.IRequest<Response378>, MediatR.IRequest<Response378>;

public record struct Response378(long Id);

[Handler]
public sealed partial class Request378Handler
	: Mediator.IRequestHandler<Request378, Response378>,
	MediatR.IRequestHandler<Request378, Response378>
{
	private static ValueTask<Response378> Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response378> Mediator.IRequestHandler<Request378, Response378>.Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response378> MediatR.IRequestHandler<Request378, Response378>.Handle(
		Request378 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request379(long Id) : Mediator.IRequest<Response379>, MediatR.IRequest<Response379>;

public record struct Response379(long Id);

[Handler]
public sealed partial class Request379Handler
	: Mediator.IRequestHandler<Request379, Response379>,
	MediatR.IRequestHandler<Request379, Response379>
{
	private static ValueTask<Response379> Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response379> Mediator.IRequestHandler<Request379, Response379>.Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response379> MediatR.IRequestHandler<Request379, Response379>.Handle(
		Request379 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request380(long Id) : Mediator.IRequest<Response380>, MediatR.IRequest<Response380>;

public record struct Response380(long Id);

[Handler]
public sealed partial class Request380Handler
	: Mediator.IRequestHandler<Request380, Response380>,
	MediatR.IRequestHandler<Request380, Response380>
{
	private static ValueTask<Response380> Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response380> Mediator.IRequestHandler<Request380, Response380>.Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response380> MediatR.IRequestHandler<Request380, Response380>.Handle(
		Request380 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request381(long Id) : Mediator.IRequest<Response381>, MediatR.IRequest<Response381>;

public record struct Response381(long Id);

[Handler]
public sealed partial class Request381Handler
	: Mediator.IRequestHandler<Request381, Response381>,
	MediatR.IRequestHandler<Request381, Response381>
{
	private static ValueTask<Response381> Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response381> Mediator.IRequestHandler<Request381, Response381>.Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response381> MediatR.IRequestHandler<Request381, Response381>.Handle(
		Request381 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request382(long Id) : Mediator.IRequest<Response382>, MediatR.IRequest<Response382>;

public record struct Response382(long Id);

[Handler]
public sealed partial class Request382Handler
	: Mediator.IRequestHandler<Request382, Response382>,
	MediatR.IRequestHandler<Request382, Response382>
{
	private static ValueTask<Response382> Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response382> Mediator.IRequestHandler<Request382, Response382>.Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response382> MediatR.IRequestHandler<Request382, Response382>.Handle(
		Request382 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request383(long Id) : Mediator.IRequest<Response383>, MediatR.IRequest<Response383>;

public record struct Response383(long Id);

[Handler]
public sealed partial class Request383Handler
	: Mediator.IRequestHandler<Request383, Response383>,
	MediatR.IRequestHandler<Request383, Response383>
{
	private static ValueTask<Response383> Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response383> Mediator.IRequestHandler<Request383, Response383>.Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response383> MediatR.IRequestHandler<Request383, Response383>.Handle(
		Request383 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request384(long Id) : Mediator.IRequest<Response384>, MediatR.IRequest<Response384>;

public record struct Response384(long Id);

[Handler]
public sealed partial class Request384Handler
	: Mediator.IRequestHandler<Request384, Response384>,
	MediatR.IRequestHandler<Request384, Response384>
{
	private static ValueTask<Response384> Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response384> Mediator.IRequestHandler<Request384, Response384>.Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response384> MediatR.IRequestHandler<Request384, Response384>.Handle(
		Request384 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request385(long Id) : Mediator.IRequest<Response385>, MediatR.IRequest<Response385>;

public record struct Response385(long Id);

[Handler]
public sealed partial class Request385Handler
	: Mediator.IRequestHandler<Request385, Response385>,
	MediatR.IRequestHandler<Request385, Response385>
{
	private static ValueTask<Response385> Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response385> Mediator.IRequestHandler<Request385, Response385>.Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response385> MediatR.IRequestHandler<Request385, Response385>.Handle(
		Request385 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request386(long Id) : Mediator.IRequest<Response386>, MediatR.IRequest<Response386>;

public record struct Response386(long Id);

[Handler]
public sealed partial class Request386Handler
	: Mediator.IRequestHandler<Request386, Response386>,
	MediatR.IRequestHandler<Request386, Response386>
{
	private static ValueTask<Response386> Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response386> Mediator.IRequestHandler<Request386, Response386>.Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response386> MediatR.IRequestHandler<Request386, Response386>.Handle(
		Request386 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request387(long Id) : Mediator.IRequest<Response387>, MediatR.IRequest<Response387>;

public record struct Response387(long Id);

[Handler]
public sealed partial class Request387Handler
	: Mediator.IRequestHandler<Request387, Response387>,
	MediatR.IRequestHandler<Request387, Response387>
{
	private static ValueTask<Response387> Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response387> Mediator.IRequestHandler<Request387, Response387>.Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response387> MediatR.IRequestHandler<Request387, Response387>.Handle(
		Request387 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request388(long Id) : Mediator.IRequest<Response388>, MediatR.IRequest<Response388>;

public record struct Response388(long Id);

[Handler]
public sealed partial class Request388Handler
	: Mediator.IRequestHandler<Request388, Response388>,
	MediatR.IRequestHandler<Request388, Response388>
{
	private static ValueTask<Response388> Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response388> Mediator.IRequestHandler<Request388, Response388>.Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response388> MediatR.IRequestHandler<Request388, Response388>.Handle(
		Request388 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request389(long Id) : Mediator.IRequest<Response389>, MediatR.IRequest<Response389>;

public record struct Response389(long Id);

[Handler]
public sealed partial class Request389Handler
	: Mediator.IRequestHandler<Request389, Response389>,
	MediatR.IRequestHandler<Request389, Response389>
{
	private static ValueTask<Response389> Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response389> Mediator.IRequestHandler<Request389, Response389>.Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response389> MediatR.IRequestHandler<Request389, Response389>.Handle(
		Request389 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request390(long Id) : Mediator.IRequest<Response390>, MediatR.IRequest<Response390>;

public record struct Response390(long Id);

[Handler]
public sealed partial class Request390Handler
	: Mediator.IRequestHandler<Request390, Response390>,
	MediatR.IRequestHandler<Request390, Response390>
{
	private static ValueTask<Response390> Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response390> Mediator.IRequestHandler<Request390, Response390>.Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response390> MediatR.IRequestHandler<Request390, Response390>.Handle(
		Request390 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request391(long Id) : Mediator.IRequest<Response391>, MediatR.IRequest<Response391>;

public record struct Response391(long Id);

[Handler]
public sealed partial class Request391Handler
	: Mediator.IRequestHandler<Request391, Response391>,
	MediatR.IRequestHandler<Request391, Response391>
{
	private static ValueTask<Response391> Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response391> Mediator.IRequestHandler<Request391, Response391>.Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response391> MediatR.IRequestHandler<Request391, Response391>.Handle(
		Request391 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request392(long Id) : Mediator.IRequest<Response392>, MediatR.IRequest<Response392>;

public record struct Response392(long Id);

[Handler]
public sealed partial class Request392Handler
	: Mediator.IRequestHandler<Request392, Response392>,
	MediatR.IRequestHandler<Request392, Response392>
{
	private static ValueTask<Response392> Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response392> Mediator.IRequestHandler<Request392, Response392>.Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response392> MediatR.IRequestHandler<Request392, Response392>.Handle(
		Request392 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request393(long Id) : Mediator.IRequest<Response393>, MediatR.IRequest<Response393>;

public record struct Response393(long Id);

[Handler]
public sealed partial class Request393Handler
	: Mediator.IRequestHandler<Request393, Response393>,
	MediatR.IRequestHandler<Request393, Response393>
{
	private static ValueTask<Response393> Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response393> Mediator.IRequestHandler<Request393, Response393>.Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response393> MediatR.IRequestHandler<Request393, Response393>.Handle(
		Request393 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request394(long Id) : Mediator.IRequest<Response394>, MediatR.IRequest<Response394>;

public record struct Response394(long Id);

[Handler]
public sealed partial class Request394Handler
	: Mediator.IRequestHandler<Request394, Response394>,
	MediatR.IRequestHandler<Request394, Response394>
{
	private static ValueTask<Response394> Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response394> Mediator.IRequestHandler<Request394, Response394>.Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response394> MediatR.IRequestHandler<Request394, Response394>.Handle(
		Request394 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request395(long Id) : Mediator.IRequest<Response395>, MediatR.IRequest<Response395>;

public record struct Response395(long Id);

[Handler]
public sealed partial class Request395Handler
	: Mediator.IRequestHandler<Request395, Response395>,
	MediatR.IRequestHandler<Request395, Response395>
{
	private static ValueTask<Response395> Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response395> Mediator.IRequestHandler<Request395, Response395>.Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response395> MediatR.IRequestHandler<Request395, Response395>.Handle(
		Request395 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request396(long Id) : Mediator.IRequest<Response396>, MediatR.IRequest<Response396>;

public record struct Response396(long Id);

[Handler]
public sealed partial class Request396Handler
	: Mediator.IRequestHandler<Request396, Response396>,
	MediatR.IRequestHandler<Request396, Response396>
{
	private static ValueTask<Response396> Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response396> Mediator.IRequestHandler<Request396, Response396>.Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response396> MediatR.IRequestHandler<Request396, Response396>.Handle(
		Request396 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request397(long Id) : Mediator.IRequest<Response397>, MediatR.IRequest<Response397>;

public record struct Response397(long Id);

[Handler]
public sealed partial class Request397Handler
	: Mediator.IRequestHandler<Request397, Response397>,
	MediatR.IRequestHandler<Request397, Response397>
{
	private static ValueTask<Response397> Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response397> Mediator.IRequestHandler<Request397, Response397>.Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response397> MediatR.IRequestHandler<Request397, Response397>.Handle(
		Request397 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request398(long Id) : Mediator.IRequest<Response398>, MediatR.IRequest<Response398>;

public record struct Response398(long Id);

[Handler]
public sealed partial class Request398Handler
	: Mediator.IRequestHandler<Request398, Response398>,
	MediatR.IRequestHandler<Request398, Response398>
{
	private static ValueTask<Response398> Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response398> Mediator.IRequestHandler<Request398, Response398>.Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response398> MediatR.IRequestHandler<Request398, Response398>.Handle(
		Request398 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request399(long Id) : Mediator.IRequest<Response399>, MediatR.IRequest<Response399>;

public record struct Response399(long Id);

[Handler]
public sealed partial class Request399Handler
	: Mediator.IRequestHandler<Request399, Response399>,
	MediatR.IRequestHandler<Request399, Response399>
{
	private static ValueTask<Response399> Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response399> Mediator.IRequestHandler<Request399, Response399>.Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response399> MediatR.IRequestHandler<Request399, Response399>.Handle(
		Request399 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request400(long Id) : Mediator.IRequest<Response400>, MediatR.IRequest<Response400>;

public record struct Response400(long Id);

[Handler]
public sealed partial class Request400Handler
	: Mediator.IRequestHandler<Request400, Response400>,
	MediatR.IRequestHandler<Request400, Response400>
{
	private static ValueTask<Response400> Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response400> Mediator.IRequestHandler<Request400, Response400>.Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response400> MediatR.IRequestHandler<Request400, Response400>.Handle(
		Request400 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request401(long Id) : Mediator.IRequest<Response401>, MediatR.IRequest<Response401>;

public record struct Response401(long Id);

[Handler]
public sealed partial class Request401Handler
	: Mediator.IRequestHandler<Request401, Response401>,
	MediatR.IRequestHandler<Request401, Response401>
{
	private static ValueTask<Response401> Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response401> Mediator.IRequestHandler<Request401, Response401>.Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response401> MediatR.IRequestHandler<Request401, Response401>.Handle(
		Request401 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request402(long Id) : Mediator.IRequest<Response402>, MediatR.IRequest<Response402>;

public record struct Response402(long Id);

[Handler]
public sealed partial class Request402Handler
	: Mediator.IRequestHandler<Request402, Response402>,
	MediatR.IRequestHandler<Request402, Response402>
{
	private static ValueTask<Response402> Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response402> Mediator.IRequestHandler<Request402, Response402>.Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response402> MediatR.IRequestHandler<Request402, Response402>.Handle(
		Request402 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request403(long Id) : Mediator.IRequest<Response403>, MediatR.IRequest<Response403>;

public record struct Response403(long Id);

[Handler]
public sealed partial class Request403Handler
	: Mediator.IRequestHandler<Request403, Response403>,
	MediatR.IRequestHandler<Request403, Response403>
{
	private static ValueTask<Response403> Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response403> Mediator.IRequestHandler<Request403, Response403>.Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response403> MediatR.IRequestHandler<Request403, Response403>.Handle(
		Request403 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request404(long Id) : Mediator.IRequest<Response404>, MediatR.IRequest<Response404>;

public record struct Response404(long Id);

[Handler]
public sealed partial class Request404Handler
	: Mediator.IRequestHandler<Request404, Response404>,
	MediatR.IRequestHandler<Request404, Response404>
{
	private static ValueTask<Response404> Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response404> Mediator.IRequestHandler<Request404, Response404>.Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response404> MediatR.IRequestHandler<Request404, Response404>.Handle(
		Request404 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request405(long Id) : Mediator.IRequest<Response405>, MediatR.IRequest<Response405>;

public record struct Response405(long Id);

[Handler]
public sealed partial class Request405Handler
	: Mediator.IRequestHandler<Request405, Response405>,
	MediatR.IRequestHandler<Request405, Response405>
{
	private static ValueTask<Response405> Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response405> Mediator.IRequestHandler<Request405, Response405>.Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response405> MediatR.IRequestHandler<Request405, Response405>.Handle(
		Request405 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request406(long Id) : Mediator.IRequest<Response406>, MediatR.IRequest<Response406>;

public record struct Response406(long Id);

[Handler]
public sealed partial class Request406Handler
	: Mediator.IRequestHandler<Request406, Response406>,
	MediatR.IRequestHandler<Request406, Response406>
{
	private static ValueTask<Response406> Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response406> Mediator.IRequestHandler<Request406, Response406>.Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response406> MediatR.IRequestHandler<Request406, Response406>.Handle(
		Request406 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request407(long Id) : Mediator.IRequest<Response407>, MediatR.IRequest<Response407>;

public record struct Response407(long Id);

[Handler]
public sealed partial class Request407Handler
	: Mediator.IRequestHandler<Request407, Response407>,
	MediatR.IRequestHandler<Request407, Response407>
{
	private static ValueTask<Response407> Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response407> Mediator.IRequestHandler<Request407, Response407>.Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response407> MediatR.IRequestHandler<Request407, Response407>.Handle(
		Request407 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request408(long Id) : Mediator.IRequest<Response408>, MediatR.IRequest<Response408>;

public record struct Response408(long Id);

[Handler]
public sealed partial class Request408Handler
	: Mediator.IRequestHandler<Request408, Response408>,
	MediatR.IRequestHandler<Request408, Response408>
{
	private static ValueTask<Response408> Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response408> Mediator.IRequestHandler<Request408, Response408>.Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response408> MediatR.IRequestHandler<Request408, Response408>.Handle(
		Request408 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request409(long Id) : Mediator.IRequest<Response409>, MediatR.IRequest<Response409>;

public record struct Response409(long Id);

[Handler]
public sealed partial class Request409Handler
	: Mediator.IRequestHandler<Request409, Response409>,
	MediatR.IRequestHandler<Request409, Response409>
{
	private static ValueTask<Response409> Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response409> Mediator.IRequestHandler<Request409, Response409>.Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response409> MediatR.IRequestHandler<Request409, Response409>.Handle(
		Request409 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request410(long Id) : Mediator.IRequest<Response410>, MediatR.IRequest<Response410>;

public record struct Response410(long Id);

[Handler]
public sealed partial class Request410Handler
	: Mediator.IRequestHandler<Request410, Response410>,
	MediatR.IRequestHandler<Request410, Response410>
{
	private static ValueTask<Response410> Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response410> Mediator.IRequestHandler<Request410, Response410>.Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response410> MediatR.IRequestHandler<Request410, Response410>.Handle(
		Request410 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request411(long Id) : Mediator.IRequest<Response411>, MediatR.IRequest<Response411>;

public record struct Response411(long Id);

[Handler]
public sealed partial class Request411Handler
	: Mediator.IRequestHandler<Request411, Response411>,
	MediatR.IRequestHandler<Request411, Response411>
{
	private static ValueTask<Response411> Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response411> Mediator.IRequestHandler<Request411, Response411>.Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response411> MediatR.IRequestHandler<Request411, Response411>.Handle(
		Request411 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request412(long Id) : Mediator.IRequest<Response412>, MediatR.IRequest<Response412>;

public record struct Response412(long Id);

[Handler]
public sealed partial class Request412Handler
	: Mediator.IRequestHandler<Request412, Response412>,
	MediatR.IRequestHandler<Request412, Response412>
{
	private static ValueTask<Response412> Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response412> Mediator.IRequestHandler<Request412, Response412>.Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response412> MediatR.IRequestHandler<Request412, Response412>.Handle(
		Request412 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request413(long Id) : Mediator.IRequest<Response413>, MediatR.IRequest<Response413>;

public record struct Response413(long Id);

[Handler]
public sealed partial class Request413Handler
	: Mediator.IRequestHandler<Request413, Response413>,
	MediatR.IRequestHandler<Request413, Response413>
{
	private static ValueTask<Response413> Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response413> Mediator.IRequestHandler<Request413, Response413>.Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response413> MediatR.IRequestHandler<Request413, Response413>.Handle(
		Request413 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request414(long Id) : Mediator.IRequest<Response414>, MediatR.IRequest<Response414>;

public record struct Response414(long Id);

[Handler]
public sealed partial class Request414Handler
	: Mediator.IRequestHandler<Request414, Response414>,
	MediatR.IRequestHandler<Request414, Response414>
{
	private static ValueTask<Response414> Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response414> Mediator.IRequestHandler<Request414, Response414>.Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response414> MediatR.IRequestHandler<Request414, Response414>.Handle(
		Request414 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request415(long Id) : Mediator.IRequest<Response415>, MediatR.IRequest<Response415>;

public record struct Response415(long Id);

[Handler]
public sealed partial class Request415Handler
	: Mediator.IRequestHandler<Request415, Response415>,
	MediatR.IRequestHandler<Request415, Response415>
{
	private static ValueTask<Response415> Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response415> Mediator.IRequestHandler<Request415, Response415>.Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response415> MediatR.IRequestHandler<Request415, Response415>.Handle(
		Request415 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request416(long Id) : Mediator.IRequest<Response416>, MediatR.IRequest<Response416>;

public record struct Response416(long Id);

[Handler]
public sealed partial class Request416Handler
	: Mediator.IRequestHandler<Request416, Response416>,
	MediatR.IRequestHandler<Request416, Response416>
{
	private static ValueTask<Response416> Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response416> Mediator.IRequestHandler<Request416, Response416>.Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response416> MediatR.IRequestHandler<Request416, Response416>.Handle(
		Request416 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request417(long Id) : Mediator.IRequest<Response417>, MediatR.IRequest<Response417>;

public record struct Response417(long Id);

[Handler]
public sealed partial class Request417Handler
	: Mediator.IRequestHandler<Request417, Response417>,
	MediatR.IRequestHandler<Request417, Response417>
{
	private static ValueTask<Response417> Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response417> Mediator.IRequestHandler<Request417, Response417>.Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response417> MediatR.IRequestHandler<Request417, Response417>.Handle(
		Request417 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request418(long Id) : Mediator.IRequest<Response418>, MediatR.IRequest<Response418>;

public record struct Response418(long Id);

[Handler]
public sealed partial class Request418Handler
	: Mediator.IRequestHandler<Request418, Response418>,
	MediatR.IRequestHandler<Request418, Response418>
{
	private static ValueTask<Response418> Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response418> Mediator.IRequestHandler<Request418, Response418>.Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response418> MediatR.IRequestHandler<Request418, Response418>.Handle(
		Request418 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request419(long Id) : Mediator.IRequest<Response419>, MediatR.IRequest<Response419>;

public record struct Response419(long Id);

[Handler]
public sealed partial class Request419Handler
	: Mediator.IRequestHandler<Request419, Response419>,
	MediatR.IRequestHandler<Request419, Response419>
{
	private static ValueTask<Response419> Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response419> Mediator.IRequestHandler<Request419, Response419>.Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response419> MediatR.IRequestHandler<Request419, Response419>.Handle(
		Request419 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request420(long Id) : Mediator.IRequest<Response420>, MediatR.IRequest<Response420>;

public record struct Response420(long Id);

[Handler]
public sealed partial class Request420Handler
	: Mediator.IRequestHandler<Request420, Response420>,
	MediatR.IRequestHandler<Request420, Response420>
{
	private static ValueTask<Response420> Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response420> Mediator.IRequestHandler<Request420, Response420>.Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response420> MediatR.IRequestHandler<Request420, Response420>.Handle(
		Request420 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request421(long Id) : Mediator.IRequest<Response421>, MediatR.IRequest<Response421>;

public record struct Response421(long Id);

[Handler]
public sealed partial class Request421Handler
	: Mediator.IRequestHandler<Request421, Response421>,
	MediatR.IRequestHandler<Request421, Response421>
{
	private static ValueTask<Response421> Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response421> Mediator.IRequestHandler<Request421, Response421>.Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response421> MediatR.IRequestHandler<Request421, Response421>.Handle(
		Request421 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request422(long Id) : Mediator.IRequest<Response422>, MediatR.IRequest<Response422>;

public record struct Response422(long Id);

[Handler]
public sealed partial class Request422Handler
	: Mediator.IRequestHandler<Request422, Response422>,
	MediatR.IRequestHandler<Request422, Response422>
{
	private static ValueTask<Response422> Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response422> Mediator.IRequestHandler<Request422, Response422>.Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response422> MediatR.IRequestHandler<Request422, Response422>.Handle(
		Request422 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request423(long Id) : Mediator.IRequest<Response423>, MediatR.IRequest<Response423>;

public record struct Response423(long Id);

[Handler]
public sealed partial class Request423Handler
	: Mediator.IRequestHandler<Request423, Response423>,
	MediatR.IRequestHandler<Request423, Response423>
{
	private static ValueTask<Response423> Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response423> Mediator.IRequestHandler<Request423, Response423>.Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response423> MediatR.IRequestHandler<Request423, Response423>.Handle(
		Request423 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request424(long Id) : Mediator.IRequest<Response424>, MediatR.IRequest<Response424>;

public record struct Response424(long Id);

[Handler]
public sealed partial class Request424Handler
	: Mediator.IRequestHandler<Request424, Response424>,
	MediatR.IRequestHandler<Request424, Response424>
{
	private static ValueTask<Response424> Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response424> Mediator.IRequestHandler<Request424, Response424>.Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response424> MediatR.IRequestHandler<Request424, Response424>.Handle(
		Request424 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request425(long Id) : Mediator.IRequest<Response425>, MediatR.IRequest<Response425>;

public record struct Response425(long Id);

[Handler]
public sealed partial class Request425Handler
	: Mediator.IRequestHandler<Request425, Response425>,
	MediatR.IRequestHandler<Request425, Response425>
{
	private static ValueTask<Response425> Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response425> Mediator.IRequestHandler<Request425, Response425>.Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response425> MediatR.IRequestHandler<Request425, Response425>.Handle(
		Request425 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request426(long Id) : Mediator.IRequest<Response426>, MediatR.IRequest<Response426>;

public record struct Response426(long Id);

[Handler]
public sealed partial class Request426Handler
	: Mediator.IRequestHandler<Request426, Response426>,
	MediatR.IRequestHandler<Request426, Response426>
{
	private static ValueTask<Response426> Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response426> Mediator.IRequestHandler<Request426, Response426>.Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response426> MediatR.IRequestHandler<Request426, Response426>.Handle(
		Request426 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request427(long Id) : Mediator.IRequest<Response427>, MediatR.IRequest<Response427>;

public record struct Response427(long Id);

[Handler]
public sealed partial class Request427Handler
	: Mediator.IRequestHandler<Request427, Response427>,
	MediatR.IRequestHandler<Request427, Response427>
{
	private static ValueTask<Response427> Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response427> Mediator.IRequestHandler<Request427, Response427>.Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response427> MediatR.IRequestHandler<Request427, Response427>.Handle(
		Request427 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request428(long Id) : Mediator.IRequest<Response428>, MediatR.IRequest<Response428>;

public record struct Response428(long Id);

[Handler]
public sealed partial class Request428Handler
	: Mediator.IRequestHandler<Request428, Response428>,
	MediatR.IRequestHandler<Request428, Response428>
{
	private static ValueTask<Response428> Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response428> Mediator.IRequestHandler<Request428, Response428>.Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response428> MediatR.IRequestHandler<Request428, Response428>.Handle(
		Request428 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request429(long Id) : Mediator.IRequest<Response429>, MediatR.IRequest<Response429>;

public record struct Response429(long Id);

[Handler]
public sealed partial class Request429Handler
	: Mediator.IRequestHandler<Request429, Response429>,
	MediatR.IRequestHandler<Request429, Response429>
{
	private static ValueTask<Response429> Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response429> Mediator.IRequestHandler<Request429, Response429>.Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response429> MediatR.IRequestHandler<Request429, Response429>.Handle(
		Request429 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request430(long Id) : Mediator.IRequest<Response430>, MediatR.IRequest<Response430>;

public record struct Response430(long Id);

[Handler]
public sealed partial class Request430Handler
	: Mediator.IRequestHandler<Request430, Response430>,
	MediatR.IRequestHandler<Request430, Response430>
{
	private static ValueTask<Response430> Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response430> Mediator.IRequestHandler<Request430, Response430>.Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response430> MediatR.IRequestHandler<Request430, Response430>.Handle(
		Request430 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request431(long Id) : Mediator.IRequest<Response431>, MediatR.IRequest<Response431>;

public record struct Response431(long Id);

[Handler]
public sealed partial class Request431Handler
	: Mediator.IRequestHandler<Request431, Response431>,
	MediatR.IRequestHandler<Request431, Response431>
{
	private static ValueTask<Response431> Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response431> Mediator.IRequestHandler<Request431, Response431>.Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response431> MediatR.IRequestHandler<Request431, Response431>.Handle(
		Request431 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request432(long Id) : Mediator.IRequest<Response432>, MediatR.IRequest<Response432>;

public record struct Response432(long Id);

[Handler]
public sealed partial class Request432Handler
	: Mediator.IRequestHandler<Request432, Response432>,
	MediatR.IRequestHandler<Request432, Response432>
{
	private static ValueTask<Response432> Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response432> Mediator.IRequestHandler<Request432, Response432>.Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response432> MediatR.IRequestHandler<Request432, Response432>.Handle(
		Request432 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request433(long Id) : Mediator.IRequest<Response433>, MediatR.IRequest<Response433>;

public record struct Response433(long Id);

[Handler]
public sealed partial class Request433Handler
	: Mediator.IRequestHandler<Request433, Response433>,
	MediatR.IRequestHandler<Request433, Response433>
{
	private static ValueTask<Response433> Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response433> Mediator.IRequestHandler<Request433, Response433>.Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response433> MediatR.IRequestHandler<Request433, Response433>.Handle(
		Request433 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request434(long Id) : Mediator.IRequest<Response434>, MediatR.IRequest<Response434>;

public record struct Response434(long Id);

[Handler]
public sealed partial class Request434Handler
	: Mediator.IRequestHandler<Request434, Response434>,
	MediatR.IRequestHandler<Request434, Response434>
{
	private static ValueTask<Response434> Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response434> Mediator.IRequestHandler<Request434, Response434>.Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response434> MediatR.IRequestHandler<Request434, Response434>.Handle(
		Request434 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request435(long Id) : Mediator.IRequest<Response435>, MediatR.IRequest<Response435>;

public record struct Response435(long Id);

[Handler]
public sealed partial class Request435Handler
	: Mediator.IRequestHandler<Request435, Response435>,
	MediatR.IRequestHandler<Request435, Response435>
{
	private static ValueTask<Response435> Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response435> Mediator.IRequestHandler<Request435, Response435>.Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response435> MediatR.IRequestHandler<Request435, Response435>.Handle(
		Request435 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request436(long Id) : Mediator.IRequest<Response436>, MediatR.IRequest<Response436>;

public record struct Response436(long Id);

[Handler]
public sealed partial class Request436Handler
	: Mediator.IRequestHandler<Request436, Response436>,
	MediatR.IRequestHandler<Request436, Response436>
{
	private static ValueTask<Response436> Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response436> Mediator.IRequestHandler<Request436, Response436>.Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response436> MediatR.IRequestHandler<Request436, Response436>.Handle(
		Request436 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request437(long Id) : Mediator.IRequest<Response437>, MediatR.IRequest<Response437>;

public record struct Response437(long Id);

[Handler]
public sealed partial class Request437Handler
	: Mediator.IRequestHandler<Request437, Response437>,
	MediatR.IRequestHandler<Request437, Response437>
{
	private static ValueTask<Response437> Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response437> Mediator.IRequestHandler<Request437, Response437>.Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response437> MediatR.IRequestHandler<Request437, Response437>.Handle(
		Request437 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request438(long Id) : Mediator.IRequest<Response438>, MediatR.IRequest<Response438>;

public record struct Response438(long Id);

[Handler]
public sealed partial class Request438Handler
	: Mediator.IRequestHandler<Request438, Response438>,
	MediatR.IRequestHandler<Request438, Response438>
{
	private static ValueTask<Response438> Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response438> Mediator.IRequestHandler<Request438, Response438>.Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response438> MediatR.IRequestHandler<Request438, Response438>.Handle(
		Request438 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request439(long Id) : Mediator.IRequest<Response439>, MediatR.IRequest<Response439>;

public record struct Response439(long Id);

[Handler]
public sealed partial class Request439Handler
	: Mediator.IRequestHandler<Request439, Response439>,
	MediatR.IRequestHandler<Request439, Response439>
{
	private static ValueTask<Response439> Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response439> Mediator.IRequestHandler<Request439, Response439>.Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response439> MediatR.IRequestHandler<Request439, Response439>.Handle(
		Request439 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request440(long Id) : Mediator.IRequest<Response440>, MediatR.IRequest<Response440>;

public record struct Response440(long Id);

[Handler]
public sealed partial class Request440Handler
	: Mediator.IRequestHandler<Request440, Response440>,
	MediatR.IRequestHandler<Request440, Response440>
{
	private static ValueTask<Response440> Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response440> Mediator.IRequestHandler<Request440, Response440>.Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response440> MediatR.IRequestHandler<Request440, Response440>.Handle(
		Request440 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request441(long Id) : Mediator.IRequest<Response441>, MediatR.IRequest<Response441>;

public record struct Response441(long Id);

[Handler]
public sealed partial class Request441Handler
	: Mediator.IRequestHandler<Request441, Response441>,
	MediatR.IRequestHandler<Request441, Response441>
{
	private static ValueTask<Response441> Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response441> Mediator.IRequestHandler<Request441, Response441>.Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response441> MediatR.IRequestHandler<Request441, Response441>.Handle(
		Request441 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request442(long Id) : Mediator.IRequest<Response442>, MediatR.IRequest<Response442>;

public record struct Response442(long Id);

[Handler]
public sealed partial class Request442Handler
	: Mediator.IRequestHandler<Request442, Response442>,
	MediatR.IRequestHandler<Request442, Response442>
{
	private static ValueTask<Response442> Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response442> Mediator.IRequestHandler<Request442, Response442>.Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response442> MediatR.IRequestHandler<Request442, Response442>.Handle(
		Request442 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request443(long Id) : Mediator.IRequest<Response443>, MediatR.IRequest<Response443>;

public record struct Response443(long Id);

[Handler]
public sealed partial class Request443Handler
	: Mediator.IRequestHandler<Request443, Response443>,
	MediatR.IRequestHandler<Request443, Response443>
{
	private static ValueTask<Response443> Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response443> Mediator.IRequestHandler<Request443, Response443>.Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response443> MediatR.IRequestHandler<Request443, Response443>.Handle(
		Request443 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request444(long Id) : Mediator.IRequest<Response444>, MediatR.IRequest<Response444>;

public record struct Response444(long Id);

[Handler]
public sealed partial class Request444Handler
	: Mediator.IRequestHandler<Request444, Response444>,
	MediatR.IRequestHandler<Request444, Response444>
{
	private static ValueTask<Response444> Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response444> Mediator.IRequestHandler<Request444, Response444>.Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response444> MediatR.IRequestHandler<Request444, Response444>.Handle(
		Request444 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request445(long Id) : Mediator.IRequest<Response445>, MediatR.IRequest<Response445>;

public record struct Response445(long Id);

[Handler]
public sealed partial class Request445Handler
	: Mediator.IRequestHandler<Request445, Response445>,
	MediatR.IRequestHandler<Request445, Response445>
{
	private static ValueTask<Response445> Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response445> Mediator.IRequestHandler<Request445, Response445>.Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response445> MediatR.IRequestHandler<Request445, Response445>.Handle(
		Request445 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request446(long Id) : Mediator.IRequest<Response446>, MediatR.IRequest<Response446>;

public record struct Response446(long Id);

[Handler]
public sealed partial class Request446Handler
	: Mediator.IRequestHandler<Request446, Response446>,
	MediatR.IRequestHandler<Request446, Response446>
{
	private static ValueTask<Response446> Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response446> Mediator.IRequestHandler<Request446, Response446>.Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response446> MediatR.IRequestHandler<Request446, Response446>.Handle(
		Request446 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request447(long Id) : Mediator.IRequest<Response447>, MediatR.IRequest<Response447>;

public record struct Response447(long Id);

[Handler]
public sealed partial class Request447Handler
	: Mediator.IRequestHandler<Request447, Response447>,
	MediatR.IRequestHandler<Request447, Response447>
{
	private static ValueTask<Response447> Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response447> Mediator.IRequestHandler<Request447, Response447>.Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response447> MediatR.IRequestHandler<Request447, Response447>.Handle(
		Request447 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request448(long Id) : Mediator.IRequest<Response448>, MediatR.IRequest<Response448>;

public record struct Response448(long Id);

[Handler]
public sealed partial class Request448Handler
	: Mediator.IRequestHandler<Request448, Response448>,
	MediatR.IRequestHandler<Request448, Response448>
{
	private static ValueTask<Response448> Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response448> Mediator.IRequestHandler<Request448, Response448>.Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response448> MediatR.IRequestHandler<Request448, Response448>.Handle(
		Request448 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request449(long Id) : Mediator.IRequest<Response449>, MediatR.IRequest<Response449>;

public record struct Response449(long Id);

[Handler]
public sealed partial class Request449Handler
	: Mediator.IRequestHandler<Request449, Response449>,
	MediatR.IRequestHandler<Request449, Response449>
{
	private static ValueTask<Response449> Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response449> Mediator.IRequestHandler<Request449, Response449>.Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response449> MediatR.IRequestHandler<Request449, Response449>.Handle(
		Request449 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request450(long Id) : Mediator.IRequest<Response450>, MediatR.IRequest<Response450>;

public record struct Response450(long Id);

[Handler]
public sealed partial class Request450Handler
	: Mediator.IRequestHandler<Request450, Response450>,
	MediatR.IRequestHandler<Request450, Response450>
{
	private static ValueTask<Response450> Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response450> Mediator.IRequestHandler<Request450, Response450>.Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response450> MediatR.IRequestHandler<Request450, Response450>.Handle(
		Request450 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request451(long Id) : Mediator.IRequest<Response451>, MediatR.IRequest<Response451>;

public record struct Response451(long Id);

[Handler]
public sealed partial class Request451Handler
	: Mediator.IRequestHandler<Request451, Response451>,
	MediatR.IRequestHandler<Request451, Response451>
{
	private static ValueTask<Response451> Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response451> Mediator.IRequestHandler<Request451, Response451>.Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response451> MediatR.IRequestHandler<Request451, Response451>.Handle(
		Request451 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request452(long Id) : Mediator.IRequest<Response452>, MediatR.IRequest<Response452>;

public record struct Response452(long Id);

[Handler]
public sealed partial class Request452Handler
	: Mediator.IRequestHandler<Request452, Response452>,
	MediatR.IRequestHandler<Request452, Response452>
{
	private static ValueTask<Response452> Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response452> Mediator.IRequestHandler<Request452, Response452>.Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response452> MediatR.IRequestHandler<Request452, Response452>.Handle(
		Request452 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request453(long Id) : Mediator.IRequest<Response453>, MediatR.IRequest<Response453>;

public record struct Response453(long Id);

[Handler]
public sealed partial class Request453Handler
	: Mediator.IRequestHandler<Request453, Response453>,
	MediatR.IRequestHandler<Request453, Response453>
{
	private static ValueTask<Response453> Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response453> Mediator.IRequestHandler<Request453, Response453>.Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response453> MediatR.IRequestHandler<Request453, Response453>.Handle(
		Request453 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request454(long Id) : Mediator.IRequest<Response454>, MediatR.IRequest<Response454>;

public record struct Response454(long Id);

[Handler]
public sealed partial class Request454Handler
	: Mediator.IRequestHandler<Request454, Response454>,
	MediatR.IRequestHandler<Request454, Response454>
{
	private static ValueTask<Response454> Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response454> Mediator.IRequestHandler<Request454, Response454>.Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response454> MediatR.IRequestHandler<Request454, Response454>.Handle(
		Request454 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request455(long Id) : Mediator.IRequest<Response455>, MediatR.IRequest<Response455>;

public record struct Response455(long Id);

[Handler]
public sealed partial class Request455Handler
	: Mediator.IRequestHandler<Request455, Response455>,
	MediatR.IRequestHandler<Request455, Response455>
{
	private static ValueTask<Response455> Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response455> Mediator.IRequestHandler<Request455, Response455>.Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response455> MediatR.IRequestHandler<Request455, Response455>.Handle(
		Request455 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request456(long Id) : Mediator.IRequest<Response456>, MediatR.IRequest<Response456>;

public record struct Response456(long Id);

[Handler]
public sealed partial class Request456Handler
	: Mediator.IRequestHandler<Request456, Response456>,
	MediatR.IRequestHandler<Request456, Response456>
{
	private static ValueTask<Response456> Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response456> Mediator.IRequestHandler<Request456, Response456>.Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response456> MediatR.IRequestHandler<Request456, Response456>.Handle(
		Request456 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request457(long Id) : Mediator.IRequest<Response457>, MediatR.IRequest<Response457>;

public record struct Response457(long Id);

[Handler]
public sealed partial class Request457Handler
	: Mediator.IRequestHandler<Request457, Response457>,
	MediatR.IRequestHandler<Request457, Response457>
{
	private static ValueTask<Response457> Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response457> Mediator.IRequestHandler<Request457, Response457>.Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response457> MediatR.IRequestHandler<Request457, Response457>.Handle(
		Request457 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request458(long Id) : Mediator.IRequest<Response458>, MediatR.IRequest<Response458>;

public record struct Response458(long Id);

[Handler]
public sealed partial class Request458Handler
	: Mediator.IRequestHandler<Request458, Response458>,
	MediatR.IRequestHandler<Request458, Response458>
{
	private static ValueTask<Response458> Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response458> Mediator.IRequestHandler<Request458, Response458>.Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response458> MediatR.IRequestHandler<Request458, Response458>.Handle(
		Request458 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request459(long Id) : Mediator.IRequest<Response459>, MediatR.IRequest<Response459>;

public record struct Response459(long Id);

[Handler]
public sealed partial class Request459Handler
	: Mediator.IRequestHandler<Request459, Response459>,
	MediatR.IRequestHandler<Request459, Response459>
{
	private static ValueTask<Response459> Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response459> Mediator.IRequestHandler<Request459, Response459>.Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response459> MediatR.IRequestHandler<Request459, Response459>.Handle(
		Request459 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request460(long Id) : Mediator.IRequest<Response460>, MediatR.IRequest<Response460>;

public record struct Response460(long Id);

[Handler]
public sealed partial class Request460Handler
	: Mediator.IRequestHandler<Request460, Response460>,
	MediatR.IRequestHandler<Request460, Response460>
{
	private static ValueTask<Response460> Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response460> Mediator.IRequestHandler<Request460, Response460>.Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response460> MediatR.IRequestHandler<Request460, Response460>.Handle(
		Request460 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request461(long Id) : Mediator.IRequest<Response461>, MediatR.IRequest<Response461>;

public record struct Response461(long Id);

[Handler]
public sealed partial class Request461Handler
	: Mediator.IRequestHandler<Request461, Response461>,
	MediatR.IRequestHandler<Request461, Response461>
{
	private static ValueTask<Response461> Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response461> Mediator.IRequestHandler<Request461, Response461>.Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response461> MediatR.IRequestHandler<Request461, Response461>.Handle(
		Request461 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request462(long Id) : Mediator.IRequest<Response462>, MediatR.IRequest<Response462>;

public record struct Response462(long Id);

[Handler]
public sealed partial class Request462Handler
	: Mediator.IRequestHandler<Request462, Response462>,
	MediatR.IRequestHandler<Request462, Response462>
{
	private static ValueTask<Response462> Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response462> Mediator.IRequestHandler<Request462, Response462>.Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response462> MediatR.IRequestHandler<Request462, Response462>.Handle(
		Request462 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request463(long Id) : Mediator.IRequest<Response463>, MediatR.IRequest<Response463>;

public record struct Response463(long Id);

[Handler]
public sealed partial class Request463Handler
	: Mediator.IRequestHandler<Request463, Response463>,
	MediatR.IRequestHandler<Request463, Response463>
{
	private static ValueTask<Response463> Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response463> Mediator.IRequestHandler<Request463, Response463>.Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response463> MediatR.IRequestHandler<Request463, Response463>.Handle(
		Request463 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request464(long Id) : Mediator.IRequest<Response464>, MediatR.IRequest<Response464>;

public record struct Response464(long Id);

[Handler]
public sealed partial class Request464Handler
	: Mediator.IRequestHandler<Request464, Response464>,
	MediatR.IRequestHandler<Request464, Response464>
{
	private static ValueTask<Response464> Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response464> Mediator.IRequestHandler<Request464, Response464>.Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response464> MediatR.IRequestHandler<Request464, Response464>.Handle(
		Request464 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request465(long Id) : Mediator.IRequest<Response465>, MediatR.IRequest<Response465>;

public record struct Response465(long Id);

[Handler]
public sealed partial class Request465Handler
	: Mediator.IRequestHandler<Request465, Response465>,
	MediatR.IRequestHandler<Request465, Response465>
{
	private static ValueTask<Response465> Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response465> Mediator.IRequestHandler<Request465, Response465>.Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response465> MediatR.IRequestHandler<Request465, Response465>.Handle(
		Request465 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request466(long Id) : Mediator.IRequest<Response466>, MediatR.IRequest<Response466>;

public record struct Response466(long Id);

[Handler]
public sealed partial class Request466Handler
	: Mediator.IRequestHandler<Request466, Response466>,
	MediatR.IRequestHandler<Request466, Response466>
{
	private static ValueTask<Response466> Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response466> Mediator.IRequestHandler<Request466, Response466>.Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response466> MediatR.IRequestHandler<Request466, Response466>.Handle(
		Request466 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request467(long Id) : Mediator.IRequest<Response467>, MediatR.IRequest<Response467>;

public record struct Response467(long Id);

[Handler]
public sealed partial class Request467Handler
	: Mediator.IRequestHandler<Request467, Response467>,
	MediatR.IRequestHandler<Request467, Response467>
{
	private static ValueTask<Response467> Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response467> Mediator.IRequestHandler<Request467, Response467>.Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response467> MediatR.IRequestHandler<Request467, Response467>.Handle(
		Request467 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request468(long Id) : Mediator.IRequest<Response468>, MediatR.IRequest<Response468>;

public record struct Response468(long Id);

[Handler]
public sealed partial class Request468Handler
	: Mediator.IRequestHandler<Request468, Response468>,
	MediatR.IRequestHandler<Request468, Response468>
{
	private static ValueTask<Response468> Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response468> Mediator.IRequestHandler<Request468, Response468>.Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response468> MediatR.IRequestHandler<Request468, Response468>.Handle(
		Request468 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request469(long Id) : Mediator.IRequest<Response469>, MediatR.IRequest<Response469>;

public record struct Response469(long Id);

[Handler]
public sealed partial class Request469Handler
	: Mediator.IRequestHandler<Request469, Response469>,
	MediatR.IRequestHandler<Request469, Response469>
{
	private static ValueTask<Response469> Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response469> Mediator.IRequestHandler<Request469, Response469>.Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response469> MediatR.IRequestHandler<Request469, Response469>.Handle(
		Request469 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request470(long Id) : Mediator.IRequest<Response470>, MediatR.IRequest<Response470>;

public record struct Response470(long Id);

[Handler]
public sealed partial class Request470Handler
	: Mediator.IRequestHandler<Request470, Response470>,
	MediatR.IRequestHandler<Request470, Response470>
{
	private static ValueTask<Response470> Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response470> Mediator.IRequestHandler<Request470, Response470>.Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response470> MediatR.IRequestHandler<Request470, Response470>.Handle(
		Request470 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request471(long Id) : Mediator.IRequest<Response471>, MediatR.IRequest<Response471>;

public record struct Response471(long Id);

[Handler]
public sealed partial class Request471Handler
	: Mediator.IRequestHandler<Request471, Response471>,
	MediatR.IRequestHandler<Request471, Response471>
{
	private static ValueTask<Response471> Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response471> Mediator.IRequestHandler<Request471, Response471>.Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response471> MediatR.IRequestHandler<Request471, Response471>.Handle(
		Request471 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request472(long Id) : Mediator.IRequest<Response472>, MediatR.IRequest<Response472>;

public record struct Response472(long Id);

[Handler]
public sealed partial class Request472Handler
	: Mediator.IRequestHandler<Request472, Response472>,
	MediatR.IRequestHandler<Request472, Response472>
{
	private static ValueTask<Response472> Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response472> Mediator.IRequestHandler<Request472, Response472>.Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response472> MediatR.IRequestHandler<Request472, Response472>.Handle(
		Request472 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request473(long Id) : Mediator.IRequest<Response473>, MediatR.IRequest<Response473>;

public record struct Response473(long Id);

[Handler]
public sealed partial class Request473Handler
	: Mediator.IRequestHandler<Request473, Response473>,
	MediatR.IRequestHandler<Request473, Response473>
{
	private static ValueTask<Response473> Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response473> Mediator.IRequestHandler<Request473, Response473>.Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response473> MediatR.IRequestHandler<Request473, Response473>.Handle(
		Request473 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request474(long Id) : Mediator.IRequest<Response474>, MediatR.IRequest<Response474>;

public record struct Response474(long Id);

[Handler]
public sealed partial class Request474Handler
	: Mediator.IRequestHandler<Request474, Response474>,
	MediatR.IRequestHandler<Request474, Response474>
{
	private static ValueTask<Response474> Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response474> Mediator.IRequestHandler<Request474, Response474>.Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response474> MediatR.IRequestHandler<Request474, Response474>.Handle(
		Request474 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request475(long Id) : Mediator.IRequest<Response475>, MediatR.IRequest<Response475>;

public record struct Response475(long Id);

[Handler]
public sealed partial class Request475Handler
	: Mediator.IRequestHandler<Request475, Response475>,
	MediatR.IRequestHandler<Request475, Response475>
{
	private static ValueTask<Response475> Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response475> Mediator.IRequestHandler<Request475, Response475>.Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response475> MediatR.IRequestHandler<Request475, Response475>.Handle(
		Request475 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request476(long Id) : Mediator.IRequest<Response476>, MediatR.IRequest<Response476>;

public record struct Response476(long Id);

[Handler]
public sealed partial class Request476Handler
	: Mediator.IRequestHandler<Request476, Response476>,
	MediatR.IRequestHandler<Request476, Response476>
{
	private static ValueTask<Response476> Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response476> Mediator.IRequestHandler<Request476, Response476>.Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response476> MediatR.IRequestHandler<Request476, Response476>.Handle(
		Request476 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request477(long Id) : Mediator.IRequest<Response477>, MediatR.IRequest<Response477>;

public record struct Response477(long Id);

[Handler]
public sealed partial class Request477Handler
	: Mediator.IRequestHandler<Request477, Response477>,
	MediatR.IRequestHandler<Request477, Response477>
{
	private static ValueTask<Response477> Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response477> Mediator.IRequestHandler<Request477, Response477>.Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response477> MediatR.IRequestHandler<Request477, Response477>.Handle(
		Request477 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request478(long Id) : Mediator.IRequest<Response478>, MediatR.IRequest<Response478>;

public record struct Response478(long Id);

[Handler]
public sealed partial class Request478Handler
	: Mediator.IRequestHandler<Request478, Response478>,
	MediatR.IRequestHandler<Request478, Response478>
{
	private static ValueTask<Response478> Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response478> Mediator.IRequestHandler<Request478, Response478>.Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response478> MediatR.IRequestHandler<Request478, Response478>.Handle(
		Request478 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request479(long Id) : Mediator.IRequest<Response479>, MediatR.IRequest<Response479>;

public record struct Response479(long Id);

[Handler]
public sealed partial class Request479Handler
	: Mediator.IRequestHandler<Request479, Response479>,
	MediatR.IRequestHandler<Request479, Response479>
{
	private static ValueTask<Response479> Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response479> Mediator.IRequestHandler<Request479, Response479>.Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response479> MediatR.IRequestHandler<Request479, Response479>.Handle(
		Request479 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request480(long Id) : Mediator.IRequest<Response480>, MediatR.IRequest<Response480>;

public record struct Response480(long Id);

[Handler]
public sealed partial class Request480Handler
	: Mediator.IRequestHandler<Request480, Response480>,
	MediatR.IRequestHandler<Request480, Response480>
{
	private static ValueTask<Response480> Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response480> Mediator.IRequestHandler<Request480, Response480>.Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response480> MediatR.IRequestHandler<Request480, Response480>.Handle(
		Request480 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request481(long Id) : Mediator.IRequest<Response481>, MediatR.IRequest<Response481>;

public record struct Response481(long Id);

[Handler]
public sealed partial class Request481Handler
	: Mediator.IRequestHandler<Request481, Response481>,
	MediatR.IRequestHandler<Request481, Response481>
{
	private static ValueTask<Response481> Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response481> Mediator.IRequestHandler<Request481, Response481>.Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response481> MediatR.IRequestHandler<Request481, Response481>.Handle(
		Request481 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request482(long Id) : Mediator.IRequest<Response482>, MediatR.IRequest<Response482>;

public record struct Response482(long Id);

[Handler]
public sealed partial class Request482Handler
	: Mediator.IRequestHandler<Request482, Response482>,
	MediatR.IRequestHandler<Request482, Response482>
{
	private static ValueTask<Response482> Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response482> Mediator.IRequestHandler<Request482, Response482>.Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response482> MediatR.IRequestHandler<Request482, Response482>.Handle(
		Request482 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request483(long Id) : Mediator.IRequest<Response483>, MediatR.IRequest<Response483>;

public record struct Response483(long Id);

[Handler]
public sealed partial class Request483Handler
	: Mediator.IRequestHandler<Request483, Response483>,
	MediatR.IRequestHandler<Request483, Response483>
{
	private static ValueTask<Response483> Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response483> Mediator.IRequestHandler<Request483, Response483>.Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response483> MediatR.IRequestHandler<Request483, Response483>.Handle(
		Request483 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request484(long Id) : Mediator.IRequest<Response484>, MediatR.IRequest<Response484>;

public record struct Response484(long Id);

[Handler]
public sealed partial class Request484Handler
	: Mediator.IRequestHandler<Request484, Response484>,
	MediatR.IRequestHandler<Request484, Response484>
{
	private static ValueTask<Response484> Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response484> Mediator.IRequestHandler<Request484, Response484>.Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response484> MediatR.IRequestHandler<Request484, Response484>.Handle(
		Request484 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request485(long Id) : Mediator.IRequest<Response485>, MediatR.IRequest<Response485>;

public record struct Response485(long Id);

[Handler]
public sealed partial class Request485Handler
	: Mediator.IRequestHandler<Request485, Response485>,
	MediatR.IRequestHandler<Request485, Response485>
{
	private static ValueTask<Response485> Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response485> Mediator.IRequestHandler<Request485, Response485>.Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response485> MediatR.IRequestHandler<Request485, Response485>.Handle(
		Request485 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request486(long Id) : Mediator.IRequest<Response486>, MediatR.IRequest<Response486>;

public record struct Response486(long Id);

[Handler]
public sealed partial class Request486Handler
	: Mediator.IRequestHandler<Request486, Response486>,
	MediatR.IRequestHandler<Request486, Response486>
{
	private static ValueTask<Response486> Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response486> Mediator.IRequestHandler<Request486, Response486>.Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response486> MediatR.IRequestHandler<Request486, Response486>.Handle(
		Request486 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request487(long Id) : Mediator.IRequest<Response487>, MediatR.IRequest<Response487>;

public record struct Response487(long Id);

[Handler]
public sealed partial class Request487Handler
	: Mediator.IRequestHandler<Request487, Response487>,
	MediatR.IRequestHandler<Request487, Response487>
{
	private static ValueTask<Response487> Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response487> Mediator.IRequestHandler<Request487, Response487>.Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response487> MediatR.IRequestHandler<Request487, Response487>.Handle(
		Request487 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request488(long Id) : Mediator.IRequest<Response488>, MediatR.IRequest<Response488>;

public record struct Response488(long Id);

[Handler]
public sealed partial class Request488Handler
	: Mediator.IRequestHandler<Request488, Response488>,
	MediatR.IRequestHandler<Request488, Response488>
{
	private static ValueTask<Response488> Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response488> Mediator.IRequestHandler<Request488, Response488>.Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response488> MediatR.IRequestHandler<Request488, Response488>.Handle(
		Request488 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request489(long Id) : Mediator.IRequest<Response489>, MediatR.IRequest<Response489>;

public record struct Response489(long Id);

[Handler]
public sealed partial class Request489Handler
	: Mediator.IRequestHandler<Request489, Response489>,
	MediatR.IRequestHandler<Request489, Response489>
{
	private static ValueTask<Response489> Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response489> Mediator.IRequestHandler<Request489, Response489>.Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response489> MediatR.IRequestHandler<Request489, Response489>.Handle(
		Request489 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request490(long Id) : Mediator.IRequest<Response490>, MediatR.IRequest<Response490>;

public record struct Response490(long Id);

[Handler]
public sealed partial class Request490Handler
	: Mediator.IRequestHandler<Request490, Response490>,
	MediatR.IRequestHandler<Request490, Response490>
{
	private static ValueTask<Response490> Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response490> Mediator.IRequestHandler<Request490, Response490>.Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response490> MediatR.IRequestHandler<Request490, Response490>.Handle(
		Request490 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request491(long Id) : Mediator.IRequest<Response491>, MediatR.IRequest<Response491>;

public record struct Response491(long Id);

[Handler]
public sealed partial class Request491Handler
	: Mediator.IRequestHandler<Request491, Response491>,
	MediatR.IRequestHandler<Request491, Response491>
{
	private static ValueTask<Response491> Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response491> Mediator.IRequestHandler<Request491, Response491>.Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response491> MediatR.IRequestHandler<Request491, Response491>.Handle(
		Request491 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request492(long Id) : Mediator.IRequest<Response492>, MediatR.IRequest<Response492>;

public record struct Response492(long Id);

[Handler]
public sealed partial class Request492Handler
	: Mediator.IRequestHandler<Request492, Response492>,
	MediatR.IRequestHandler<Request492, Response492>
{
	private static ValueTask<Response492> Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response492> Mediator.IRequestHandler<Request492, Response492>.Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response492> MediatR.IRequestHandler<Request492, Response492>.Handle(
		Request492 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request493(long Id) : Mediator.IRequest<Response493>, MediatR.IRequest<Response493>;

public record struct Response493(long Id);

[Handler]
public sealed partial class Request493Handler
	: Mediator.IRequestHandler<Request493, Response493>,
	MediatR.IRequestHandler<Request493, Response493>
{
	private static ValueTask<Response493> Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response493> Mediator.IRequestHandler<Request493, Response493>.Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response493> MediatR.IRequestHandler<Request493, Response493>.Handle(
		Request493 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request494(long Id) : Mediator.IRequest<Response494>, MediatR.IRequest<Response494>;

public record struct Response494(long Id);

[Handler]
public sealed partial class Request494Handler
	: Mediator.IRequestHandler<Request494, Response494>,
	MediatR.IRequestHandler<Request494, Response494>
{
	private static ValueTask<Response494> Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response494> Mediator.IRequestHandler<Request494, Response494>.Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response494> MediatR.IRequestHandler<Request494, Response494>.Handle(
		Request494 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request495(long Id) : Mediator.IRequest<Response495>, MediatR.IRequest<Response495>;

public record struct Response495(long Id);

[Handler]
public sealed partial class Request495Handler
	: Mediator.IRequestHandler<Request495, Response495>,
	MediatR.IRequestHandler<Request495, Response495>
{
	private static ValueTask<Response495> Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response495> Mediator.IRequestHandler<Request495, Response495>.Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response495> MediatR.IRequestHandler<Request495, Response495>.Handle(
		Request495 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request496(long Id) : Mediator.IRequest<Response496>, MediatR.IRequest<Response496>;

public record struct Response496(long Id);

[Handler]
public sealed partial class Request496Handler
	: Mediator.IRequestHandler<Request496, Response496>,
	MediatR.IRequestHandler<Request496, Response496>
{
	private static ValueTask<Response496> Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response496> Mediator.IRequestHandler<Request496, Response496>.Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response496> MediatR.IRequestHandler<Request496, Response496>.Handle(
		Request496 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request497(long Id) : Mediator.IRequest<Response497>, MediatR.IRequest<Response497>;

public record struct Response497(long Id);

[Handler]
public sealed partial class Request497Handler
	: Mediator.IRequestHandler<Request497, Response497>,
	MediatR.IRequestHandler<Request497, Response497>
{
	private static ValueTask<Response497> Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response497> Mediator.IRequestHandler<Request497, Response497>.Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response497> MediatR.IRequestHandler<Request497, Response497>.Handle(
		Request497 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request498(long Id) : Mediator.IRequest<Response498>, MediatR.IRequest<Response498>;

public record struct Response498(long Id);

[Handler]
public sealed partial class Request498Handler
	: Mediator.IRequestHandler<Request498, Response498>,
	MediatR.IRequestHandler<Request498, Response498>
{
	private static ValueTask<Response498> Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response498> Mediator.IRequestHandler<Request498, Response498>.Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response498> MediatR.IRequestHandler<Request498, Response498>.Handle(
		Request498 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request499(long Id) : Mediator.IRequest<Response499>, MediatR.IRequest<Response499>;

public record struct Response499(long Id);

[Handler]
public sealed partial class Request499Handler
	: Mediator.IRequestHandler<Request499, Response499>,
	MediatR.IRequestHandler<Request499, Response499>
{
	private static ValueTask<Response499> Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response499> Mediator.IRequestHandler<Request499, Response499>.Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response499> MediatR.IRequestHandler<Request499, Response499>.Handle(
		Request499 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request500(long Id) : Mediator.IRequest<Response500>, MediatR.IRequest<Response500>;

public record struct Response500(long Id);

[Handler]
public sealed partial class Request500Handler
	: Mediator.IRequestHandler<Request500, Response500>,
	MediatR.IRequestHandler<Request500, Response500>
{
	private static ValueTask<Response500> Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response500> Mediator.IRequestHandler<Request500, Response500>.Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response500> MediatR.IRequestHandler<Request500, Response500>.Handle(
		Request500 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request501(long Id) : Mediator.IRequest<Response501>, MediatR.IRequest<Response501>;

public record struct Response501(long Id);

[Handler]
public sealed partial class Request501Handler
	: Mediator.IRequestHandler<Request501, Response501>,
	MediatR.IRequestHandler<Request501, Response501>
{
	private static ValueTask<Response501> Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response501> Mediator.IRequestHandler<Request501, Response501>.Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response501> MediatR.IRequestHandler<Request501, Response501>.Handle(
		Request501 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request502(long Id) : Mediator.IRequest<Response502>, MediatR.IRequest<Response502>;

public record struct Response502(long Id);

[Handler]
public sealed partial class Request502Handler
	: Mediator.IRequestHandler<Request502, Response502>,
	MediatR.IRequestHandler<Request502, Response502>
{
	private static ValueTask<Response502> Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response502> Mediator.IRequestHandler<Request502, Response502>.Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response502> MediatR.IRequestHandler<Request502, Response502>.Handle(
		Request502 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request503(long Id) : Mediator.IRequest<Response503>, MediatR.IRequest<Response503>;

public record struct Response503(long Id);

[Handler]
public sealed partial class Request503Handler
	: Mediator.IRequestHandler<Request503, Response503>,
	MediatR.IRequestHandler<Request503, Response503>
{
	private static ValueTask<Response503> Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response503> Mediator.IRequestHandler<Request503, Response503>.Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response503> MediatR.IRequestHandler<Request503, Response503>.Handle(
		Request503 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request504(long Id) : Mediator.IRequest<Response504>, MediatR.IRequest<Response504>;

public record struct Response504(long Id);

[Handler]
public sealed partial class Request504Handler
	: Mediator.IRequestHandler<Request504, Response504>,
	MediatR.IRequestHandler<Request504, Response504>
{
	private static ValueTask<Response504> Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response504> Mediator.IRequestHandler<Request504, Response504>.Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response504> MediatR.IRequestHandler<Request504, Response504>.Handle(
		Request504 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request505(long Id) : Mediator.IRequest<Response505>, MediatR.IRequest<Response505>;

public record struct Response505(long Id);

[Handler]
public sealed partial class Request505Handler
	: Mediator.IRequestHandler<Request505, Response505>,
	MediatR.IRequestHandler<Request505, Response505>
{
	private static ValueTask<Response505> Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response505> Mediator.IRequestHandler<Request505, Response505>.Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response505> MediatR.IRequestHandler<Request505, Response505>.Handle(
		Request505 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request506(long Id) : Mediator.IRequest<Response506>, MediatR.IRequest<Response506>;

public record struct Response506(long Id);

[Handler]
public sealed partial class Request506Handler
	: Mediator.IRequestHandler<Request506, Response506>,
	MediatR.IRequestHandler<Request506, Response506>
{
	private static ValueTask<Response506> Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response506> Mediator.IRequestHandler<Request506, Response506>.Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response506> MediatR.IRequestHandler<Request506, Response506>.Handle(
		Request506 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request507(long Id) : Mediator.IRequest<Response507>, MediatR.IRequest<Response507>;

public record struct Response507(long Id);

[Handler]
public sealed partial class Request507Handler
	: Mediator.IRequestHandler<Request507, Response507>,
	MediatR.IRequestHandler<Request507, Response507>
{
	private static ValueTask<Response507> Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response507> Mediator.IRequestHandler<Request507, Response507>.Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response507> MediatR.IRequestHandler<Request507, Response507>.Handle(
		Request507 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request508(long Id) : Mediator.IRequest<Response508>, MediatR.IRequest<Response508>;

public record struct Response508(long Id);

[Handler]
public sealed partial class Request508Handler
	: Mediator.IRequestHandler<Request508, Response508>,
	MediatR.IRequestHandler<Request508, Response508>
{
	private static ValueTask<Response508> Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response508> Mediator.IRequestHandler<Request508, Response508>.Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response508> MediatR.IRequestHandler<Request508, Response508>.Handle(
		Request508 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request509(long Id) : Mediator.IRequest<Response509>, MediatR.IRequest<Response509>;

public record struct Response509(long Id);

[Handler]
public sealed partial class Request509Handler
	: Mediator.IRequestHandler<Request509, Response509>,
	MediatR.IRequestHandler<Request509, Response509>
{
	private static ValueTask<Response509> Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response509> Mediator.IRequestHandler<Request509, Response509>.Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response509> MediatR.IRequestHandler<Request509, Response509>.Handle(
		Request509 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request510(long Id) : Mediator.IRequest<Response510>, MediatR.IRequest<Response510>;

public record struct Response510(long Id);

[Handler]
public sealed partial class Request510Handler
	: Mediator.IRequestHandler<Request510, Response510>,
	MediatR.IRequestHandler<Request510, Response510>
{
	private static ValueTask<Response510> Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response510> Mediator.IRequestHandler<Request510, Response510>.Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response510> MediatR.IRequestHandler<Request510, Response510>.Handle(
		Request510 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request511(long Id) : Mediator.IRequest<Response511>, MediatR.IRequest<Response511>;

public record struct Response511(long Id);

[Handler]
public sealed partial class Request511Handler
	: Mediator.IRequestHandler<Request511, Response511>,
	MediatR.IRequestHandler<Request511, Response511>
{
	private static ValueTask<Response511> Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response511> Mediator.IRequestHandler<Request511, Response511>.Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response511> MediatR.IRequestHandler<Request511, Response511>.Handle(
		Request511 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request512(long Id) : Mediator.IRequest<Response512>, MediatR.IRequest<Response512>;

public record struct Response512(long Id);

[Handler]
public sealed partial class Request512Handler
	: Mediator.IRequestHandler<Request512, Response512>,
	MediatR.IRequestHandler<Request512, Response512>
{
	private static ValueTask<Response512> Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response512> Mediator.IRequestHandler<Request512, Response512>.Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response512> MediatR.IRequestHandler<Request512, Response512>.Handle(
		Request512 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request513(long Id) : Mediator.IRequest<Response513>, MediatR.IRequest<Response513>;

public record struct Response513(long Id);

[Handler]
public sealed partial class Request513Handler
	: Mediator.IRequestHandler<Request513, Response513>,
	MediatR.IRequestHandler<Request513, Response513>
{
	private static ValueTask<Response513> Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response513> Mediator.IRequestHandler<Request513, Response513>.Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response513> MediatR.IRequestHandler<Request513, Response513>.Handle(
		Request513 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request514(long Id) : Mediator.IRequest<Response514>, MediatR.IRequest<Response514>;

public record struct Response514(long Id);

[Handler]
public sealed partial class Request514Handler
	: Mediator.IRequestHandler<Request514, Response514>,
	MediatR.IRequestHandler<Request514, Response514>
{
	private static ValueTask<Response514> Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response514> Mediator.IRequestHandler<Request514, Response514>.Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response514> MediatR.IRequestHandler<Request514, Response514>.Handle(
		Request514 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request515(long Id) : Mediator.IRequest<Response515>, MediatR.IRequest<Response515>;

public record struct Response515(long Id);

[Handler]
public sealed partial class Request515Handler
	: Mediator.IRequestHandler<Request515, Response515>,
	MediatR.IRequestHandler<Request515, Response515>
{
	private static ValueTask<Response515> Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response515> Mediator.IRequestHandler<Request515, Response515>.Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response515> MediatR.IRequestHandler<Request515, Response515>.Handle(
		Request515 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request516(long Id) : Mediator.IRequest<Response516>, MediatR.IRequest<Response516>;

public record struct Response516(long Id);

[Handler]
public sealed partial class Request516Handler
	: Mediator.IRequestHandler<Request516, Response516>,
	MediatR.IRequestHandler<Request516, Response516>
{
	private static ValueTask<Response516> Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response516> Mediator.IRequestHandler<Request516, Response516>.Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response516> MediatR.IRequestHandler<Request516, Response516>.Handle(
		Request516 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request517(long Id) : Mediator.IRequest<Response517>, MediatR.IRequest<Response517>;

public record struct Response517(long Id);

[Handler]
public sealed partial class Request517Handler
	: Mediator.IRequestHandler<Request517, Response517>,
	MediatR.IRequestHandler<Request517, Response517>
{
	private static ValueTask<Response517> Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response517> Mediator.IRequestHandler<Request517, Response517>.Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response517> MediatR.IRequestHandler<Request517, Response517>.Handle(
		Request517 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request518(long Id) : Mediator.IRequest<Response518>, MediatR.IRequest<Response518>;

public record struct Response518(long Id);

[Handler]
public sealed partial class Request518Handler
	: Mediator.IRequestHandler<Request518, Response518>,
	MediatR.IRequestHandler<Request518, Response518>
{
	private static ValueTask<Response518> Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response518> Mediator.IRequestHandler<Request518, Response518>.Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response518> MediatR.IRequestHandler<Request518, Response518>.Handle(
		Request518 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request519(long Id) : Mediator.IRequest<Response519>, MediatR.IRequest<Response519>;

public record struct Response519(long Id);

[Handler]
public sealed partial class Request519Handler
	: Mediator.IRequestHandler<Request519, Response519>,
	MediatR.IRequestHandler<Request519, Response519>
{
	private static ValueTask<Response519> Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response519> Mediator.IRequestHandler<Request519, Response519>.Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response519> MediatR.IRequestHandler<Request519, Response519>.Handle(
		Request519 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request520(long Id) : Mediator.IRequest<Response520>, MediatR.IRequest<Response520>;

public record struct Response520(long Id);

[Handler]
public sealed partial class Request520Handler
	: Mediator.IRequestHandler<Request520, Response520>,
	MediatR.IRequestHandler<Request520, Response520>
{
	private static ValueTask<Response520> Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response520> Mediator.IRequestHandler<Request520, Response520>.Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response520> MediatR.IRequestHandler<Request520, Response520>.Handle(
		Request520 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request521(long Id) : Mediator.IRequest<Response521>, MediatR.IRequest<Response521>;

public record struct Response521(long Id);

[Handler]
public sealed partial class Request521Handler
	: Mediator.IRequestHandler<Request521, Response521>,
	MediatR.IRequestHandler<Request521, Response521>
{
	private static ValueTask<Response521> Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response521> Mediator.IRequestHandler<Request521, Response521>.Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response521> MediatR.IRequestHandler<Request521, Response521>.Handle(
		Request521 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request522(long Id) : Mediator.IRequest<Response522>, MediatR.IRequest<Response522>;

public record struct Response522(long Id);

[Handler]
public sealed partial class Request522Handler
	: Mediator.IRequestHandler<Request522, Response522>,
	MediatR.IRequestHandler<Request522, Response522>
{
	private static ValueTask<Response522> Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response522> Mediator.IRequestHandler<Request522, Response522>.Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response522> MediatR.IRequestHandler<Request522, Response522>.Handle(
		Request522 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request523(long Id) : Mediator.IRequest<Response523>, MediatR.IRequest<Response523>;

public record struct Response523(long Id);

[Handler]
public sealed partial class Request523Handler
	: Mediator.IRequestHandler<Request523, Response523>,
	MediatR.IRequestHandler<Request523, Response523>
{
	private static ValueTask<Response523> Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response523> Mediator.IRequestHandler<Request523, Response523>.Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response523> MediatR.IRequestHandler<Request523, Response523>.Handle(
		Request523 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request524(long Id) : Mediator.IRequest<Response524>, MediatR.IRequest<Response524>;

public record struct Response524(long Id);

[Handler]
public sealed partial class Request524Handler
	: Mediator.IRequestHandler<Request524, Response524>,
	MediatR.IRequestHandler<Request524, Response524>
{
	private static ValueTask<Response524> Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response524> Mediator.IRequestHandler<Request524, Response524>.Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response524> MediatR.IRequestHandler<Request524, Response524>.Handle(
		Request524 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request525(long Id) : Mediator.IRequest<Response525>, MediatR.IRequest<Response525>;

public record struct Response525(long Id);

[Handler]
public sealed partial class Request525Handler
	: Mediator.IRequestHandler<Request525, Response525>,
	MediatR.IRequestHandler<Request525, Response525>
{
	private static ValueTask<Response525> Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response525> Mediator.IRequestHandler<Request525, Response525>.Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response525> MediatR.IRequestHandler<Request525, Response525>.Handle(
		Request525 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request526(long Id) : Mediator.IRequest<Response526>, MediatR.IRequest<Response526>;

public record struct Response526(long Id);

[Handler]
public sealed partial class Request526Handler
	: Mediator.IRequestHandler<Request526, Response526>,
	MediatR.IRequestHandler<Request526, Response526>
{
	private static ValueTask<Response526> Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response526> Mediator.IRequestHandler<Request526, Response526>.Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response526> MediatR.IRequestHandler<Request526, Response526>.Handle(
		Request526 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request527(long Id) : Mediator.IRequest<Response527>, MediatR.IRequest<Response527>;

public record struct Response527(long Id);

[Handler]
public sealed partial class Request527Handler
	: Mediator.IRequestHandler<Request527, Response527>,
	MediatR.IRequestHandler<Request527, Response527>
{
	private static ValueTask<Response527> Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response527> Mediator.IRequestHandler<Request527, Response527>.Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response527> MediatR.IRequestHandler<Request527, Response527>.Handle(
		Request527 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request528(long Id) : Mediator.IRequest<Response528>, MediatR.IRequest<Response528>;

public record struct Response528(long Id);

[Handler]
public sealed partial class Request528Handler
	: Mediator.IRequestHandler<Request528, Response528>,
	MediatR.IRequestHandler<Request528, Response528>
{
	private static ValueTask<Response528> Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response528> Mediator.IRequestHandler<Request528, Response528>.Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response528> MediatR.IRequestHandler<Request528, Response528>.Handle(
		Request528 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request529(long Id) : Mediator.IRequest<Response529>, MediatR.IRequest<Response529>;

public record struct Response529(long Id);

[Handler]
public sealed partial class Request529Handler
	: Mediator.IRequestHandler<Request529, Response529>,
	MediatR.IRequestHandler<Request529, Response529>
{
	private static ValueTask<Response529> Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response529> Mediator.IRequestHandler<Request529, Response529>.Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response529> MediatR.IRequestHandler<Request529, Response529>.Handle(
		Request529 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request530(long Id) : Mediator.IRequest<Response530>, MediatR.IRequest<Response530>;

public record struct Response530(long Id);

[Handler]
public sealed partial class Request530Handler
	: Mediator.IRequestHandler<Request530, Response530>,
	MediatR.IRequestHandler<Request530, Response530>
{
	private static ValueTask<Response530> Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response530> Mediator.IRequestHandler<Request530, Response530>.Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response530> MediatR.IRequestHandler<Request530, Response530>.Handle(
		Request530 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request531(long Id) : Mediator.IRequest<Response531>, MediatR.IRequest<Response531>;

public record struct Response531(long Id);

[Handler]
public sealed partial class Request531Handler
	: Mediator.IRequestHandler<Request531, Response531>,
	MediatR.IRequestHandler<Request531, Response531>
{
	private static ValueTask<Response531> Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response531> Mediator.IRequestHandler<Request531, Response531>.Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response531> MediatR.IRequestHandler<Request531, Response531>.Handle(
		Request531 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request532(long Id) : Mediator.IRequest<Response532>, MediatR.IRequest<Response532>;

public record struct Response532(long Id);

[Handler]
public sealed partial class Request532Handler
	: Mediator.IRequestHandler<Request532, Response532>,
	MediatR.IRequestHandler<Request532, Response532>
{
	private static ValueTask<Response532> Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response532> Mediator.IRequestHandler<Request532, Response532>.Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response532> MediatR.IRequestHandler<Request532, Response532>.Handle(
		Request532 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request533(long Id) : Mediator.IRequest<Response533>, MediatR.IRequest<Response533>;

public record struct Response533(long Id);

[Handler]
public sealed partial class Request533Handler
	: Mediator.IRequestHandler<Request533, Response533>,
	MediatR.IRequestHandler<Request533, Response533>
{
	private static ValueTask<Response533> Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response533> Mediator.IRequestHandler<Request533, Response533>.Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response533> MediatR.IRequestHandler<Request533, Response533>.Handle(
		Request533 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request534(long Id) : Mediator.IRequest<Response534>, MediatR.IRequest<Response534>;

public record struct Response534(long Id);

[Handler]
public sealed partial class Request534Handler
	: Mediator.IRequestHandler<Request534, Response534>,
	MediatR.IRequestHandler<Request534, Response534>
{
	private static ValueTask<Response534> Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response534> Mediator.IRequestHandler<Request534, Response534>.Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response534> MediatR.IRequestHandler<Request534, Response534>.Handle(
		Request534 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request535(long Id) : Mediator.IRequest<Response535>, MediatR.IRequest<Response535>;

public record struct Response535(long Id);

[Handler]
public sealed partial class Request535Handler
	: Mediator.IRequestHandler<Request535, Response535>,
	MediatR.IRequestHandler<Request535, Response535>
{
	private static ValueTask<Response535> Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response535> Mediator.IRequestHandler<Request535, Response535>.Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response535> MediatR.IRequestHandler<Request535, Response535>.Handle(
		Request535 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request536(long Id) : Mediator.IRequest<Response536>, MediatR.IRequest<Response536>;

public record struct Response536(long Id);

[Handler]
public sealed partial class Request536Handler
	: Mediator.IRequestHandler<Request536, Response536>,
	MediatR.IRequestHandler<Request536, Response536>
{
	private static ValueTask<Response536> Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response536> Mediator.IRequestHandler<Request536, Response536>.Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response536> MediatR.IRequestHandler<Request536, Response536>.Handle(
		Request536 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request537(long Id) : Mediator.IRequest<Response537>, MediatR.IRequest<Response537>;

public record struct Response537(long Id);

[Handler]
public sealed partial class Request537Handler
	: Mediator.IRequestHandler<Request537, Response537>,
	MediatR.IRequestHandler<Request537, Response537>
{
	private static ValueTask<Response537> Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response537> Mediator.IRequestHandler<Request537, Response537>.Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response537> MediatR.IRequestHandler<Request537, Response537>.Handle(
		Request537 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request538(long Id) : Mediator.IRequest<Response538>, MediatR.IRequest<Response538>;

public record struct Response538(long Id);

[Handler]
public sealed partial class Request538Handler
	: Mediator.IRequestHandler<Request538, Response538>,
	MediatR.IRequestHandler<Request538, Response538>
{
	private static ValueTask<Response538> Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response538> Mediator.IRequestHandler<Request538, Response538>.Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response538> MediatR.IRequestHandler<Request538, Response538>.Handle(
		Request538 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request539(long Id) : Mediator.IRequest<Response539>, MediatR.IRequest<Response539>;

public record struct Response539(long Id);

[Handler]
public sealed partial class Request539Handler
	: Mediator.IRequestHandler<Request539, Response539>,
	MediatR.IRequestHandler<Request539, Response539>
{
	private static ValueTask<Response539> Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response539> Mediator.IRequestHandler<Request539, Response539>.Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response539> MediatR.IRequestHandler<Request539, Response539>.Handle(
		Request539 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request540(long Id) : Mediator.IRequest<Response540>, MediatR.IRequest<Response540>;

public record struct Response540(long Id);

[Handler]
public sealed partial class Request540Handler
	: Mediator.IRequestHandler<Request540, Response540>,
	MediatR.IRequestHandler<Request540, Response540>
{
	private static ValueTask<Response540> Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response540> Mediator.IRequestHandler<Request540, Response540>.Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response540> MediatR.IRequestHandler<Request540, Response540>.Handle(
		Request540 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request541(long Id) : Mediator.IRequest<Response541>, MediatR.IRequest<Response541>;

public record struct Response541(long Id);

[Handler]
public sealed partial class Request541Handler
	: Mediator.IRequestHandler<Request541, Response541>,
	MediatR.IRequestHandler<Request541, Response541>
{
	private static ValueTask<Response541> Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response541> Mediator.IRequestHandler<Request541, Response541>.Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response541> MediatR.IRequestHandler<Request541, Response541>.Handle(
		Request541 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request542(long Id) : Mediator.IRequest<Response542>, MediatR.IRequest<Response542>;

public record struct Response542(long Id);

[Handler]
public sealed partial class Request542Handler
	: Mediator.IRequestHandler<Request542, Response542>,
	MediatR.IRequestHandler<Request542, Response542>
{
	private static ValueTask<Response542> Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response542> Mediator.IRequestHandler<Request542, Response542>.Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response542> MediatR.IRequestHandler<Request542, Response542>.Handle(
		Request542 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request543(long Id) : Mediator.IRequest<Response543>, MediatR.IRequest<Response543>;

public record struct Response543(long Id);

[Handler]
public sealed partial class Request543Handler
	: Mediator.IRequestHandler<Request543, Response543>,
	MediatR.IRequestHandler<Request543, Response543>
{
	private static ValueTask<Response543> Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response543> Mediator.IRequestHandler<Request543, Response543>.Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response543> MediatR.IRequestHandler<Request543, Response543>.Handle(
		Request543 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request544(long Id) : Mediator.IRequest<Response544>, MediatR.IRequest<Response544>;

public record struct Response544(long Id);

[Handler]
public sealed partial class Request544Handler
	: Mediator.IRequestHandler<Request544, Response544>,
	MediatR.IRequestHandler<Request544, Response544>
{
	private static ValueTask<Response544> Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response544> Mediator.IRequestHandler<Request544, Response544>.Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response544> MediatR.IRequestHandler<Request544, Response544>.Handle(
		Request544 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request545(long Id) : Mediator.IRequest<Response545>, MediatR.IRequest<Response545>;

public record struct Response545(long Id);

[Handler]
public sealed partial class Request545Handler
	: Mediator.IRequestHandler<Request545, Response545>,
	MediatR.IRequestHandler<Request545, Response545>
{
	private static ValueTask<Response545> Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response545> Mediator.IRequestHandler<Request545, Response545>.Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response545> MediatR.IRequestHandler<Request545, Response545>.Handle(
		Request545 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request546(long Id) : Mediator.IRequest<Response546>, MediatR.IRequest<Response546>;

public record struct Response546(long Id);

[Handler]
public sealed partial class Request546Handler
	: Mediator.IRequestHandler<Request546, Response546>,
	MediatR.IRequestHandler<Request546, Response546>
{
	private static ValueTask<Response546> Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response546> Mediator.IRequestHandler<Request546, Response546>.Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response546> MediatR.IRequestHandler<Request546, Response546>.Handle(
		Request546 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request547(long Id) : Mediator.IRequest<Response547>, MediatR.IRequest<Response547>;

public record struct Response547(long Id);

[Handler]
public sealed partial class Request547Handler
	: Mediator.IRequestHandler<Request547, Response547>,
	MediatR.IRequestHandler<Request547, Response547>
{
	private static ValueTask<Response547> Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response547> Mediator.IRequestHandler<Request547, Response547>.Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response547> MediatR.IRequestHandler<Request547, Response547>.Handle(
		Request547 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request548(long Id) : Mediator.IRequest<Response548>, MediatR.IRequest<Response548>;

public record struct Response548(long Id);

[Handler]
public sealed partial class Request548Handler
	: Mediator.IRequestHandler<Request548, Response548>,
	MediatR.IRequestHandler<Request548, Response548>
{
	private static ValueTask<Response548> Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response548> Mediator.IRequestHandler<Request548, Response548>.Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response548> MediatR.IRequestHandler<Request548, Response548>.Handle(
		Request548 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request549(long Id) : Mediator.IRequest<Response549>, MediatR.IRequest<Response549>;

public record struct Response549(long Id);

[Handler]
public sealed partial class Request549Handler
	: Mediator.IRequestHandler<Request549, Response549>,
	MediatR.IRequestHandler<Request549, Response549>
{
	private static ValueTask<Response549> Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response549> Mediator.IRequestHandler<Request549, Response549>.Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response549> MediatR.IRequestHandler<Request549, Response549>.Handle(
		Request549 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request550(long Id) : Mediator.IRequest<Response550>, MediatR.IRequest<Response550>;

public record struct Response550(long Id);

[Handler]
public sealed partial class Request550Handler
	: Mediator.IRequestHandler<Request550, Response550>,
	MediatR.IRequestHandler<Request550, Response550>
{
	private static ValueTask<Response550> Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response550> Mediator.IRequestHandler<Request550, Response550>.Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response550> MediatR.IRequestHandler<Request550, Response550>.Handle(
		Request550 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request551(long Id) : Mediator.IRequest<Response551>, MediatR.IRequest<Response551>;

public record struct Response551(long Id);

[Handler]
public sealed partial class Request551Handler
	: Mediator.IRequestHandler<Request551, Response551>,
	MediatR.IRequestHandler<Request551, Response551>
{
	private static ValueTask<Response551> Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response551> Mediator.IRequestHandler<Request551, Response551>.Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response551> MediatR.IRequestHandler<Request551, Response551>.Handle(
		Request551 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request552(long Id) : Mediator.IRequest<Response552>, MediatR.IRequest<Response552>;

public record struct Response552(long Id);

[Handler]
public sealed partial class Request552Handler
	: Mediator.IRequestHandler<Request552, Response552>,
	MediatR.IRequestHandler<Request552, Response552>
{
	private static ValueTask<Response552> Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response552> Mediator.IRequestHandler<Request552, Response552>.Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response552> MediatR.IRequestHandler<Request552, Response552>.Handle(
		Request552 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request553(long Id) : Mediator.IRequest<Response553>, MediatR.IRequest<Response553>;

public record struct Response553(long Id);

[Handler]
public sealed partial class Request553Handler
	: Mediator.IRequestHandler<Request553, Response553>,
	MediatR.IRequestHandler<Request553, Response553>
{
	private static ValueTask<Response553> Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response553> Mediator.IRequestHandler<Request553, Response553>.Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response553> MediatR.IRequestHandler<Request553, Response553>.Handle(
		Request553 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request554(long Id) : Mediator.IRequest<Response554>, MediatR.IRequest<Response554>;

public record struct Response554(long Id);

[Handler]
public sealed partial class Request554Handler
	: Mediator.IRequestHandler<Request554, Response554>,
	MediatR.IRequestHandler<Request554, Response554>
{
	private static ValueTask<Response554> Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response554> Mediator.IRequestHandler<Request554, Response554>.Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response554> MediatR.IRequestHandler<Request554, Response554>.Handle(
		Request554 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request555(long Id) : Mediator.IRequest<Response555>, MediatR.IRequest<Response555>;

public record struct Response555(long Id);

[Handler]
public sealed partial class Request555Handler
	: Mediator.IRequestHandler<Request555, Response555>,
	MediatR.IRequestHandler<Request555, Response555>
{
	private static ValueTask<Response555> Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response555> Mediator.IRequestHandler<Request555, Response555>.Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response555> MediatR.IRequestHandler<Request555, Response555>.Handle(
		Request555 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request556(long Id) : Mediator.IRequest<Response556>, MediatR.IRequest<Response556>;

public record struct Response556(long Id);

[Handler]
public sealed partial class Request556Handler
	: Mediator.IRequestHandler<Request556, Response556>,
	MediatR.IRequestHandler<Request556, Response556>
{
	private static ValueTask<Response556> Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response556> Mediator.IRequestHandler<Request556, Response556>.Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response556> MediatR.IRequestHandler<Request556, Response556>.Handle(
		Request556 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request557(long Id) : Mediator.IRequest<Response557>, MediatR.IRequest<Response557>;

public record struct Response557(long Id);

[Handler]
public sealed partial class Request557Handler
	: Mediator.IRequestHandler<Request557, Response557>,
	MediatR.IRequestHandler<Request557, Response557>
{
	private static ValueTask<Response557> Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response557> Mediator.IRequestHandler<Request557, Response557>.Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response557> MediatR.IRequestHandler<Request557, Response557>.Handle(
		Request557 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request558(long Id) : Mediator.IRequest<Response558>, MediatR.IRequest<Response558>;

public record struct Response558(long Id);

[Handler]
public sealed partial class Request558Handler
	: Mediator.IRequestHandler<Request558, Response558>,
	MediatR.IRequestHandler<Request558, Response558>
{
	private static ValueTask<Response558> Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response558> Mediator.IRequestHandler<Request558, Response558>.Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response558> MediatR.IRequestHandler<Request558, Response558>.Handle(
		Request558 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request559(long Id) : Mediator.IRequest<Response559>, MediatR.IRequest<Response559>;

public record struct Response559(long Id);

[Handler]
public sealed partial class Request559Handler
	: Mediator.IRequestHandler<Request559, Response559>,
	MediatR.IRequestHandler<Request559, Response559>
{
	private static ValueTask<Response559> Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response559> Mediator.IRequestHandler<Request559, Response559>.Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response559> MediatR.IRequestHandler<Request559, Response559>.Handle(
		Request559 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request560(long Id) : Mediator.IRequest<Response560>, MediatR.IRequest<Response560>;

public record struct Response560(long Id);

[Handler]
public sealed partial class Request560Handler
	: Mediator.IRequestHandler<Request560, Response560>,
	MediatR.IRequestHandler<Request560, Response560>
{
	private static ValueTask<Response560> Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response560> Mediator.IRequestHandler<Request560, Response560>.Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response560> MediatR.IRequestHandler<Request560, Response560>.Handle(
		Request560 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request561(long Id) : Mediator.IRequest<Response561>, MediatR.IRequest<Response561>;

public record struct Response561(long Id);

[Handler]
public sealed partial class Request561Handler
	: Mediator.IRequestHandler<Request561, Response561>,
	MediatR.IRequestHandler<Request561, Response561>
{
	private static ValueTask<Response561> Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response561> Mediator.IRequestHandler<Request561, Response561>.Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response561> MediatR.IRequestHandler<Request561, Response561>.Handle(
		Request561 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request562(long Id) : Mediator.IRequest<Response562>, MediatR.IRequest<Response562>;

public record struct Response562(long Id);

[Handler]
public sealed partial class Request562Handler
	: Mediator.IRequestHandler<Request562, Response562>,
	MediatR.IRequestHandler<Request562, Response562>
{
	private static ValueTask<Response562> Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response562> Mediator.IRequestHandler<Request562, Response562>.Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response562> MediatR.IRequestHandler<Request562, Response562>.Handle(
		Request562 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request563(long Id) : Mediator.IRequest<Response563>, MediatR.IRequest<Response563>;

public record struct Response563(long Id);

[Handler]
public sealed partial class Request563Handler
	: Mediator.IRequestHandler<Request563, Response563>,
	MediatR.IRequestHandler<Request563, Response563>
{
	private static ValueTask<Response563> Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response563> Mediator.IRequestHandler<Request563, Response563>.Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response563> MediatR.IRequestHandler<Request563, Response563>.Handle(
		Request563 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request564(long Id) : Mediator.IRequest<Response564>, MediatR.IRequest<Response564>;

public record struct Response564(long Id);

[Handler]
public sealed partial class Request564Handler
	: Mediator.IRequestHandler<Request564, Response564>,
	MediatR.IRequestHandler<Request564, Response564>
{
	private static ValueTask<Response564> Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response564> Mediator.IRequestHandler<Request564, Response564>.Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response564> MediatR.IRequestHandler<Request564, Response564>.Handle(
		Request564 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request565(long Id) : Mediator.IRequest<Response565>, MediatR.IRequest<Response565>;

public record struct Response565(long Id);

[Handler]
public sealed partial class Request565Handler
	: Mediator.IRequestHandler<Request565, Response565>,
	MediatR.IRequestHandler<Request565, Response565>
{
	private static ValueTask<Response565> Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response565> Mediator.IRequestHandler<Request565, Response565>.Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response565> MediatR.IRequestHandler<Request565, Response565>.Handle(
		Request565 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request566(long Id) : Mediator.IRequest<Response566>, MediatR.IRequest<Response566>;

public record struct Response566(long Id);

[Handler]
public sealed partial class Request566Handler
	: Mediator.IRequestHandler<Request566, Response566>,
	MediatR.IRequestHandler<Request566, Response566>
{
	private static ValueTask<Response566> Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response566> Mediator.IRequestHandler<Request566, Response566>.Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response566> MediatR.IRequestHandler<Request566, Response566>.Handle(
		Request566 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request567(long Id) : Mediator.IRequest<Response567>, MediatR.IRequest<Response567>;

public record struct Response567(long Id);

[Handler]
public sealed partial class Request567Handler
	: Mediator.IRequestHandler<Request567, Response567>,
	MediatR.IRequestHandler<Request567, Response567>
{
	private static ValueTask<Response567> Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response567> Mediator.IRequestHandler<Request567, Response567>.Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response567> MediatR.IRequestHandler<Request567, Response567>.Handle(
		Request567 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request568(long Id) : Mediator.IRequest<Response568>, MediatR.IRequest<Response568>;

public record struct Response568(long Id);

[Handler]
public sealed partial class Request568Handler
	: Mediator.IRequestHandler<Request568, Response568>,
	MediatR.IRequestHandler<Request568, Response568>
{
	private static ValueTask<Response568> Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response568> Mediator.IRequestHandler<Request568, Response568>.Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response568> MediatR.IRequestHandler<Request568, Response568>.Handle(
		Request568 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request569(long Id) : Mediator.IRequest<Response569>, MediatR.IRequest<Response569>;

public record struct Response569(long Id);

[Handler]
public sealed partial class Request569Handler
	: Mediator.IRequestHandler<Request569, Response569>,
	MediatR.IRequestHandler<Request569, Response569>
{
	private static ValueTask<Response569> Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response569> Mediator.IRequestHandler<Request569, Response569>.Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response569> MediatR.IRequestHandler<Request569, Response569>.Handle(
		Request569 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request570(long Id) : Mediator.IRequest<Response570>, MediatR.IRequest<Response570>;

public record struct Response570(long Id);

[Handler]
public sealed partial class Request570Handler
	: Mediator.IRequestHandler<Request570, Response570>,
	MediatR.IRequestHandler<Request570, Response570>
{
	private static ValueTask<Response570> Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response570> Mediator.IRequestHandler<Request570, Response570>.Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response570> MediatR.IRequestHandler<Request570, Response570>.Handle(
		Request570 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request571(long Id) : Mediator.IRequest<Response571>, MediatR.IRequest<Response571>;

public record struct Response571(long Id);

[Handler]
public sealed partial class Request571Handler
	: Mediator.IRequestHandler<Request571, Response571>,
	MediatR.IRequestHandler<Request571, Response571>
{
	private static ValueTask<Response571> Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response571> Mediator.IRequestHandler<Request571, Response571>.Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response571> MediatR.IRequestHandler<Request571, Response571>.Handle(
		Request571 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request572(long Id) : Mediator.IRequest<Response572>, MediatR.IRequest<Response572>;

public record struct Response572(long Id);

[Handler]
public sealed partial class Request572Handler
	: Mediator.IRequestHandler<Request572, Response572>,
	MediatR.IRequestHandler<Request572, Response572>
{
	private static ValueTask<Response572> Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response572> Mediator.IRequestHandler<Request572, Response572>.Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response572> MediatR.IRequestHandler<Request572, Response572>.Handle(
		Request572 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request573(long Id) : Mediator.IRequest<Response573>, MediatR.IRequest<Response573>;

public record struct Response573(long Id);

[Handler]
public sealed partial class Request573Handler
	: Mediator.IRequestHandler<Request573, Response573>,
	MediatR.IRequestHandler<Request573, Response573>
{
	private static ValueTask<Response573> Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response573> Mediator.IRequestHandler<Request573, Response573>.Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response573> MediatR.IRequestHandler<Request573, Response573>.Handle(
		Request573 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request574(long Id) : Mediator.IRequest<Response574>, MediatR.IRequest<Response574>;

public record struct Response574(long Id);

[Handler]
public sealed partial class Request574Handler
	: Mediator.IRequestHandler<Request574, Response574>,
	MediatR.IRequestHandler<Request574, Response574>
{
	private static ValueTask<Response574> Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response574> Mediator.IRequestHandler<Request574, Response574>.Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response574> MediatR.IRequestHandler<Request574, Response574>.Handle(
		Request574 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request575(long Id) : Mediator.IRequest<Response575>, MediatR.IRequest<Response575>;

public record struct Response575(long Id);

[Handler]
public sealed partial class Request575Handler
	: Mediator.IRequestHandler<Request575, Response575>,
	MediatR.IRequestHandler<Request575, Response575>
{
	private static ValueTask<Response575> Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response575> Mediator.IRequestHandler<Request575, Response575>.Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response575> MediatR.IRequestHandler<Request575, Response575>.Handle(
		Request575 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request576(long Id) : Mediator.IRequest<Response576>, MediatR.IRequest<Response576>;

public record struct Response576(long Id);

[Handler]
public sealed partial class Request576Handler
	: Mediator.IRequestHandler<Request576, Response576>,
	MediatR.IRequestHandler<Request576, Response576>
{
	private static ValueTask<Response576> Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response576> Mediator.IRequestHandler<Request576, Response576>.Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response576> MediatR.IRequestHandler<Request576, Response576>.Handle(
		Request576 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request577(long Id) : Mediator.IRequest<Response577>, MediatR.IRequest<Response577>;

public record struct Response577(long Id);

[Handler]
public sealed partial class Request577Handler
	: Mediator.IRequestHandler<Request577, Response577>,
	MediatR.IRequestHandler<Request577, Response577>
{
	private static ValueTask<Response577> Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response577> Mediator.IRequestHandler<Request577, Response577>.Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response577> MediatR.IRequestHandler<Request577, Response577>.Handle(
		Request577 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request578(long Id) : Mediator.IRequest<Response578>, MediatR.IRequest<Response578>;

public record struct Response578(long Id);

[Handler]
public sealed partial class Request578Handler
	: Mediator.IRequestHandler<Request578, Response578>,
	MediatR.IRequestHandler<Request578, Response578>
{
	private static ValueTask<Response578> Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response578> Mediator.IRequestHandler<Request578, Response578>.Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response578> MediatR.IRequestHandler<Request578, Response578>.Handle(
		Request578 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request579(long Id) : Mediator.IRequest<Response579>, MediatR.IRequest<Response579>;

public record struct Response579(long Id);

[Handler]
public sealed partial class Request579Handler
	: Mediator.IRequestHandler<Request579, Response579>,
	MediatR.IRequestHandler<Request579, Response579>
{
	private static ValueTask<Response579> Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response579> Mediator.IRequestHandler<Request579, Response579>.Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response579> MediatR.IRequestHandler<Request579, Response579>.Handle(
		Request579 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request580(long Id) : Mediator.IRequest<Response580>, MediatR.IRequest<Response580>;

public record struct Response580(long Id);

[Handler]
public sealed partial class Request580Handler
	: Mediator.IRequestHandler<Request580, Response580>,
	MediatR.IRequestHandler<Request580, Response580>
{
	private static ValueTask<Response580> Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response580> Mediator.IRequestHandler<Request580, Response580>.Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response580> MediatR.IRequestHandler<Request580, Response580>.Handle(
		Request580 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request581(long Id) : Mediator.IRequest<Response581>, MediatR.IRequest<Response581>;

public record struct Response581(long Id);

[Handler]
public sealed partial class Request581Handler
	: Mediator.IRequestHandler<Request581, Response581>,
	MediatR.IRequestHandler<Request581, Response581>
{
	private static ValueTask<Response581> Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response581> Mediator.IRequestHandler<Request581, Response581>.Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response581> MediatR.IRequestHandler<Request581, Response581>.Handle(
		Request581 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request582(long Id) : Mediator.IRequest<Response582>, MediatR.IRequest<Response582>;

public record struct Response582(long Id);

[Handler]
public sealed partial class Request582Handler
	: Mediator.IRequestHandler<Request582, Response582>,
	MediatR.IRequestHandler<Request582, Response582>
{
	private static ValueTask<Response582> Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response582> Mediator.IRequestHandler<Request582, Response582>.Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response582> MediatR.IRequestHandler<Request582, Response582>.Handle(
		Request582 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request583(long Id) : Mediator.IRequest<Response583>, MediatR.IRequest<Response583>;

public record struct Response583(long Id);

[Handler]
public sealed partial class Request583Handler
	: Mediator.IRequestHandler<Request583, Response583>,
	MediatR.IRequestHandler<Request583, Response583>
{
	private static ValueTask<Response583> Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response583> Mediator.IRequestHandler<Request583, Response583>.Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response583> MediatR.IRequestHandler<Request583, Response583>.Handle(
		Request583 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request584(long Id) : Mediator.IRequest<Response584>, MediatR.IRequest<Response584>;

public record struct Response584(long Id);

[Handler]
public sealed partial class Request584Handler
	: Mediator.IRequestHandler<Request584, Response584>,
	MediatR.IRequestHandler<Request584, Response584>
{
	private static ValueTask<Response584> Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response584> Mediator.IRequestHandler<Request584, Response584>.Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response584> MediatR.IRequestHandler<Request584, Response584>.Handle(
		Request584 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request585(long Id) : Mediator.IRequest<Response585>, MediatR.IRequest<Response585>;

public record struct Response585(long Id);

[Handler]
public sealed partial class Request585Handler
	: Mediator.IRequestHandler<Request585, Response585>,
	MediatR.IRequestHandler<Request585, Response585>
{
	private static ValueTask<Response585> Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response585> Mediator.IRequestHandler<Request585, Response585>.Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response585> MediatR.IRequestHandler<Request585, Response585>.Handle(
		Request585 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request586(long Id) : Mediator.IRequest<Response586>, MediatR.IRequest<Response586>;

public record struct Response586(long Id);

[Handler]
public sealed partial class Request586Handler
	: Mediator.IRequestHandler<Request586, Response586>,
	MediatR.IRequestHandler<Request586, Response586>
{
	private static ValueTask<Response586> Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response586> Mediator.IRequestHandler<Request586, Response586>.Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response586> MediatR.IRequestHandler<Request586, Response586>.Handle(
		Request586 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request587(long Id) : Mediator.IRequest<Response587>, MediatR.IRequest<Response587>;

public record struct Response587(long Id);

[Handler]
public sealed partial class Request587Handler
	: Mediator.IRequestHandler<Request587, Response587>,
	MediatR.IRequestHandler<Request587, Response587>
{
	private static ValueTask<Response587> Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response587> Mediator.IRequestHandler<Request587, Response587>.Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response587> MediatR.IRequestHandler<Request587, Response587>.Handle(
		Request587 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request588(long Id) : Mediator.IRequest<Response588>, MediatR.IRequest<Response588>;

public record struct Response588(long Id);

[Handler]
public sealed partial class Request588Handler
	: Mediator.IRequestHandler<Request588, Response588>,
	MediatR.IRequestHandler<Request588, Response588>
{
	private static ValueTask<Response588> Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response588> Mediator.IRequestHandler<Request588, Response588>.Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response588> MediatR.IRequestHandler<Request588, Response588>.Handle(
		Request588 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request589(long Id) : Mediator.IRequest<Response589>, MediatR.IRequest<Response589>;

public record struct Response589(long Id);

[Handler]
public sealed partial class Request589Handler
	: Mediator.IRequestHandler<Request589, Response589>,
	MediatR.IRequestHandler<Request589, Response589>
{
	private static ValueTask<Response589> Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response589> Mediator.IRequestHandler<Request589, Response589>.Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response589> MediatR.IRequestHandler<Request589, Response589>.Handle(
		Request589 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request590(long Id) : Mediator.IRequest<Response590>, MediatR.IRequest<Response590>;

public record struct Response590(long Id);

[Handler]
public sealed partial class Request590Handler
	: Mediator.IRequestHandler<Request590, Response590>,
	MediatR.IRequestHandler<Request590, Response590>
{
	private static ValueTask<Response590> Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response590> Mediator.IRequestHandler<Request590, Response590>.Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response590> MediatR.IRequestHandler<Request590, Response590>.Handle(
		Request590 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request591(long Id) : Mediator.IRequest<Response591>, MediatR.IRequest<Response591>;

public record struct Response591(long Id);

[Handler]
public sealed partial class Request591Handler
	: Mediator.IRequestHandler<Request591, Response591>,
	MediatR.IRequestHandler<Request591, Response591>
{
	private static ValueTask<Response591> Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response591> Mediator.IRequestHandler<Request591, Response591>.Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response591> MediatR.IRequestHandler<Request591, Response591>.Handle(
		Request591 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request592(long Id) : Mediator.IRequest<Response592>, MediatR.IRequest<Response592>;

public record struct Response592(long Id);

[Handler]
public sealed partial class Request592Handler
	: Mediator.IRequestHandler<Request592, Response592>,
	MediatR.IRequestHandler<Request592, Response592>
{
	private static ValueTask<Response592> Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response592> Mediator.IRequestHandler<Request592, Response592>.Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response592> MediatR.IRequestHandler<Request592, Response592>.Handle(
		Request592 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request593(long Id) : Mediator.IRequest<Response593>, MediatR.IRequest<Response593>;

public record struct Response593(long Id);

[Handler]
public sealed partial class Request593Handler
	: Mediator.IRequestHandler<Request593, Response593>,
	MediatR.IRequestHandler<Request593, Response593>
{
	private static ValueTask<Response593> Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response593> Mediator.IRequestHandler<Request593, Response593>.Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response593> MediatR.IRequestHandler<Request593, Response593>.Handle(
		Request593 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request594(long Id) : Mediator.IRequest<Response594>, MediatR.IRequest<Response594>;

public record struct Response594(long Id);

[Handler]
public sealed partial class Request594Handler
	: Mediator.IRequestHandler<Request594, Response594>,
	MediatR.IRequestHandler<Request594, Response594>
{
	private static ValueTask<Response594> Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response594> Mediator.IRequestHandler<Request594, Response594>.Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response594> MediatR.IRequestHandler<Request594, Response594>.Handle(
		Request594 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request595(long Id) : Mediator.IRequest<Response595>, MediatR.IRequest<Response595>;

public record struct Response595(long Id);

[Handler]
public sealed partial class Request595Handler
	: Mediator.IRequestHandler<Request595, Response595>,
	MediatR.IRequestHandler<Request595, Response595>
{
	private static ValueTask<Response595> Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response595> Mediator.IRequestHandler<Request595, Response595>.Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response595> MediatR.IRequestHandler<Request595, Response595>.Handle(
		Request595 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request596(long Id) : Mediator.IRequest<Response596>, MediatR.IRequest<Response596>;

public record struct Response596(long Id);

[Handler]
public sealed partial class Request596Handler
	: Mediator.IRequestHandler<Request596, Response596>,
	MediatR.IRequestHandler<Request596, Response596>
{
	private static ValueTask<Response596> Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response596> Mediator.IRequestHandler<Request596, Response596>.Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response596> MediatR.IRequestHandler<Request596, Response596>.Handle(
		Request596 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request597(long Id) : Mediator.IRequest<Response597>, MediatR.IRequest<Response597>;

public record struct Response597(long Id);

[Handler]
public sealed partial class Request597Handler
	: Mediator.IRequestHandler<Request597, Response597>,
	MediatR.IRequestHandler<Request597, Response597>
{
	private static ValueTask<Response597> Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response597> Mediator.IRequestHandler<Request597, Response597>.Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response597> MediatR.IRequestHandler<Request597, Response597>.Handle(
		Request597 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request598(long Id) : Mediator.IRequest<Response598>, MediatR.IRequest<Response598>;

public record struct Response598(long Id);

[Handler]
public sealed partial class Request598Handler
	: Mediator.IRequestHandler<Request598, Response598>,
	MediatR.IRequestHandler<Request598, Response598>
{
	private static ValueTask<Response598> Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response598> Mediator.IRequestHandler<Request598, Response598>.Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response598> MediatR.IRequestHandler<Request598, Response598>.Handle(
		Request598 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request599(long Id) : Mediator.IRequest<Response599>, MediatR.IRequest<Response599>;

public record struct Response599(long Id);

[Handler]
public sealed partial class Request599Handler
	: Mediator.IRequestHandler<Request599, Response599>,
	MediatR.IRequestHandler<Request599, Response599>
{
	private static ValueTask<Response599> Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response599> Mediator.IRequestHandler<Request599, Response599>.Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response599> MediatR.IRequestHandler<Request599, Response599>.Handle(
		Request599 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request600(long Id) : Mediator.IRequest<Response600>, MediatR.IRequest<Response600>;

public record struct Response600(long Id);

[Handler]
public sealed partial class Request600Handler
	: Mediator.IRequestHandler<Request600, Response600>,
	MediatR.IRequestHandler<Request600, Response600>
{
	private static ValueTask<Response600> Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response600> Mediator.IRequestHandler<Request600, Response600>.Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response600> MediatR.IRequestHandler<Request600, Response600>.Handle(
		Request600 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request601(long Id) : Mediator.IRequest<Response601>, MediatR.IRequest<Response601>;

public record struct Response601(long Id);

[Handler]
public sealed partial class Request601Handler
	: Mediator.IRequestHandler<Request601, Response601>,
	MediatR.IRequestHandler<Request601, Response601>
{
	private static ValueTask<Response601> Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response601> Mediator.IRequestHandler<Request601, Response601>.Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response601> MediatR.IRequestHandler<Request601, Response601>.Handle(
		Request601 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request602(long Id) : Mediator.IRequest<Response602>, MediatR.IRequest<Response602>;

public record struct Response602(long Id);

[Handler]
public sealed partial class Request602Handler
	: Mediator.IRequestHandler<Request602, Response602>,
	MediatR.IRequestHandler<Request602, Response602>
{
	private static ValueTask<Response602> Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response602> Mediator.IRequestHandler<Request602, Response602>.Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response602> MediatR.IRequestHandler<Request602, Response602>.Handle(
		Request602 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request603(long Id) : Mediator.IRequest<Response603>, MediatR.IRequest<Response603>;

public record struct Response603(long Id);

[Handler]
public sealed partial class Request603Handler
	: Mediator.IRequestHandler<Request603, Response603>,
	MediatR.IRequestHandler<Request603, Response603>
{
	private static ValueTask<Response603> Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response603> Mediator.IRequestHandler<Request603, Response603>.Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response603> MediatR.IRequestHandler<Request603, Response603>.Handle(
		Request603 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request604(long Id) : Mediator.IRequest<Response604>, MediatR.IRequest<Response604>;

public record struct Response604(long Id);

[Handler]
public sealed partial class Request604Handler
	: Mediator.IRequestHandler<Request604, Response604>,
	MediatR.IRequestHandler<Request604, Response604>
{
	private static ValueTask<Response604> Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response604> Mediator.IRequestHandler<Request604, Response604>.Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response604> MediatR.IRequestHandler<Request604, Response604>.Handle(
		Request604 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request605(long Id) : Mediator.IRequest<Response605>, MediatR.IRequest<Response605>;

public record struct Response605(long Id);

[Handler]
public sealed partial class Request605Handler
	: Mediator.IRequestHandler<Request605, Response605>,
	MediatR.IRequestHandler<Request605, Response605>
{
	private static ValueTask<Response605> Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response605> Mediator.IRequestHandler<Request605, Response605>.Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response605> MediatR.IRequestHandler<Request605, Response605>.Handle(
		Request605 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request606(long Id) : Mediator.IRequest<Response606>, MediatR.IRequest<Response606>;

public record struct Response606(long Id);

[Handler]
public sealed partial class Request606Handler
	: Mediator.IRequestHandler<Request606, Response606>,
	MediatR.IRequestHandler<Request606, Response606>
{
	private static ValueTask<Response606> Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response606> Mediator.IRequestHandler<Request606, Response606>.Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response606> MediatR.IRequestHandler<Request606, Response606>.Handle(
		Request606 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request607(long Id) : Mediator.IRequest<Response607>, MediatR.IRequest<Response607>;

public record struct Response607(long Id);

[Handler]
public sealed partial class Request607Handler
	: Mediator.IRequestHandler<Request607, Response607>,
	MediatR.IRequestHandler<Request607, Response607>
{
	private static ValueTask<Response607> Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response607> Mediator.IRequestHandler<Request607, Response607>.Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response607> MediatR.IRequestHandler<Request607, Response607>.Handle(
		Request607 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request608(long Id) : Mediator.IRequest<Response608>, MediatR.IRequest<Response608>;

public record struct Response608(long Id);

[Handler]
public sealed partial class Request608Handler
	: Mediator.IRequestHandler<Request608, Response608>,
	MediatR.IRequestHandler<Request608, Response608>
{
	private static ValueTask<Response608> Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response608> Mediator.IRequestHandler<Request608, Response608>.Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response608> MediatR.IRequestHandler<Request608, Response608>.Handle(
		Request608 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request609(long Id) : Mediator.IRequest<Response609>, MediatR.IRequest<Response609>;

public record struct Response609(long Id);

[Handler]
public sealed partial class Request609Handler
	: Mediator.IRequestHandler<Request609, Response609>,
	MediatR.IRequestHandler<Request609, Response609>
{
	private static ValueTask<Response609> Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response609> Mediator.IRequestHandler<Request609, Response609>.Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response609> MediatR.IRequestHandler<Request609, Response609>.Handle(
		Request609 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request610(long Id) : Mediator.IRequest<Response610>, MediatR.IRequest<Response610>;

public record struct Response610(long Id);

[Handler]
public sealed partial class Request610Handler
	: Mediator.IRequestHandler<Request610, Response610>,
	MediatR.IRequestHandler<Request610, Response610>
{
	private static ValueTask<Response610> Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response610> Mediator.IRequestHandler<Request610, Response610>.Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response610> MediatR.IRequestHandler<Request610, Response610>.Handle(
		Request610 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request611(long Id) : Mediator.IRequest<Response611>, MediatR.IRequest<Response611>;

public record struct Response611(long Id);

[Handler]
public sealed partial class Request611Handler
	: Mediator.IRequestHandler<Request611, Response611>,
	MediatR.IRequestHandler<Request611, Response611>
{
	private static ValueTask<Response611> Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response611> Mediator.IRequestHandler<Request611, Response611>.Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response611> MediatR.IRequestHandler<Request611, Response611>.Handle(
		Request611 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request612(long Id) : Mediator.IRequest<Response612>, MediatR.IRequest<Response612>;

public record struct Response612(long Id);

[Handler]
public sealed partial class Request612Handler
	: Mediator.IRequestHandler<Request612, Response612>,
	MediatR.IRequestHandler<Request612, Response612>
{
	private static ValueTask<Response612> Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response612> Mediator.IRequestHandler<Request612, Response612>.Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response612> MediatR.IRequestHandler<Request612, Response612>.Handle(
		Request612 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request613(long Id) : Mediator.IRequest<Response613>, MediatR.IRequest<Response613>;

public record struct Response613(long Id);

[Handler]
public sealed partial class Request613Handler
	: Mediator.IRequestHandler<Request613, Response613>,
	MediatR.IRequestHandler<Request613, Response613>
{
	private static ValueTask<Response613> Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response613> Mediator.IRequestHandler<Request613, Response613>.Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response613> MediatR.IRequestHandler<Request613, Response613>.Handle(
		Request613 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request614(long Id) : Mediator.IRequest<Response614>, MediatR.IRequest<Response614>;

public record struct Response614(long Id);

[Handler]
public sealed partial class Request614Handler
	: Mediator.IRequestHandler<Request614, Response614>,
	MediatR.IRequestHandler<Request614, Response614>
{
	private static ValueTask<Response614> Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response614> Mediator.IRequestHandler<Request614, Response614>.Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response614> MediatR.IRequestHandler<Request614, Response614>.Handle(
		Request614 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request615(long Id) : Mediator.IRequest<Response615>, MediatR.IRequest<Response615>;

public record struct Response615(long Id);

[Handler]
public sealed partial class Request615Handler
	: Mediator.IRequestHandler<Request615, Response615>,
	MediatR.IRequestHandler<Request615, Response615>
{
	private static ValueTask<Response615> Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response615> Mediator.IRequestHandler<Request615, Response615>.Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response615> MediatR.IRequestHandler<Request615, Response615>.Handle(
		Request615 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request616(long Id) : Mediator.IRequest<Response616>, MediatR.IRequest<Response616>;

public record struct Response616(long Id);

[Handler]
public sealed partial class Request616Handler
	: Mediator.IRequestHandler<Request616, Response616>,
	MediatR.IRequestHandler<Request616, Response616>
{
	private static ValueTask<Response616> Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response616> Mediator.IRequestHandler<Request616, Response616>.Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response616> MediatR.IRequestHandler<Request616, Response616>.Handle(
		Request616 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request617(long Id) : Mediator.IRequest<Response617>, MediatR.IRequest<Response617>;

public record struct Response617(long Id);

[Handler]
public sealed partial class Request617Handler
	: Mediator.IRequestHandler<Request617, Response617>,
	MediatR.IRequestHandler<Request617, Response617>
{
	private static ValueTask<Response617> Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response617> Mediator.IRequestHandler<Request617, Response617>.Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response617> MediatR.IRequestHandler<Request617, Response617>.Handle(
		Request617 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request618(long Id) : Mediator.IRequest<Response618>, MediatR.IRequest<Response618>;

public record struct Response618(long Id);

[Handler]
public sealed partial class Request618Handler
	: Mediator.IRequestHandler<Request618, Response618>,
	MediatR.IRequestHandler<Request618, Response618>
{
	private static ValueTask<Response618> Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response618> Mediator.IRequestHandler<Request618, Response618>.Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response618> MediatR.IRequestHandler<Request618, Response618>.Handle(
		Request618 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request619(long Id) : Mediator.IRequest<Response619>, MediatR.IRequest<Response619>;

public record struct Response619(long Id);

[Handler]
public sealed partial class Request619Handler
	: Mediator.IRequestHandler<Request619, Response619>,
	MediatR.IRequestHandler<Request619, Response619>
{
	private static ValueTask<Response619> Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response619> Mediator.IRequestHandler<Request619, Response619>.Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response619> MediatR.IRequestHandler<Request619, Response619>.Handle(
		Request619 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request620(long Id) : Mediator.IRequest<Response620>, MediatR.IRequest<Response620>;

public record struct Response620(long Id);

[Handler]
public sealed partial class Request620Handler
	: Mediator.IRequestHandler<Request620, Response620>,
	MediatR.IRequestHandler<Request620, Response620>
{
	private static ValueTask<Response620> Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response620> Mediator.IRequestHandler<Request620, Response620>.Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response620> MediatR.IRequestHandler<Request620, Response620>.Handle(
		Request620 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request621(long Id) : Mediator.IRequest<Response621>, MediatR.IRequest<Response621>;

public record struct Response621(long Id);

[Handler]
public sealed partial class Request621Handler
	: Mediator.IRequestHandler<Request621, Response621>,
	MediatR.IRequestHandler<Request621, Response621>
{
	private static ValueTask<Response621> Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response621> Mediator.IRequestHandler<Request621, Response621>.Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response621> MediatR.IRequestHandler<Request621, Response621>.Handle(
		Request621 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request622(long Id) : Mediator.IRequest<Response622>, MediatR.IRequest<Response622>;

public record struct Response622(long Id);

[Handler]
public sealed partial class Request622Handler
	: Mediator.IRequestHandler<Request622, Response622>,
	MediatR.IRequestHandler<Request622, Response622>
{
	private static ValueTask<Response622> Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response622> Mediator.IRequestHandler<Request622, Response622>.Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response622> MediatR.IRequestHandler<Request622, Response622>.Handle(
		Request622 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request623(long Id) : Mediator.IRequest<Response623>, MediatR.IRequest<Response623>;

public record struct Response623(long Id);

[Handler]
public sealed partial class Request623Handler
	: Mediator.IRequestHandler<Request623, Response623>,
	MediatR.IRequestHandler<Request623, Response623>
{
	private static ValueTask<Response623> Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response623> Mediator.IRequestHandler<Request623, Response623>.Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response623> MediatR.IRequestHandler<Request623, Response623>.Handle(
		Request623 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request624(long Id) : Mediator.IRequest<Response624>, MediatR.IRequest<Response624>;

public record struct Response624(long Id);

[Handler]
public sealed partial class Request624Handler
	: Mediator.IRequestHandler<Request624, Response624>,
	MediatR.IRequestHandler<Request624, Response624>
{
	private static ValueTask<Response624> Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response624> Mediator.IRequestHandler<Request624, Response624>.Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response624> MediatR.IRequestHandler<Request624, Response624>.Handle(
		Request624 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request625(long Id) : Mediator.IRequest<Response625>, MediatR.IRequest<Response625>;

public record struct Response625(long Id);

[Handler]
public sealed partial class Request625Handler
	: Mediator.IRequestHandler<Request625, Response625>,
	MediatR.IRequestHandler<Request625, Response625>
{
	private static ValueTask<Response625> Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response625> Mediator.IRequestHandler<Request625, Response625>.Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response625> MediatR.IRequestHandler<Request625, Response625>.Handle(
		Request625 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request626(long Id) : Mediator.IRequest<Response626>, MediatR.IRequest<Response626>;

public record struct Response626(long Id);

[Handler]
public sealed partial class Request626Handler
	: Mediator.IRequestHandler<Request626, Response626>,
	MediatR.IRequestHandler<Request626, Response626>
{
	private static ValueTask<Response626> Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response626> Mediator.IRequestHandler<Request626, Response626>.Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response626> MediatR.IRequestHandler<Request626, Response626>.Handle(
		Request626 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request627(long Id) : Mediator.IRequest<Response627>, MediatR.IRequest<Response627>;

public record struct Response627(long Id);

[Handler]
public sealed partial class Request627Handler
	: Mediator.IRequestHandler<Request627, Response627>,
	MediatR.IRequestHandler<Request627, Response627>
{
	private static ValueTask<Response627> Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response627> Mediator.IRequestHandler<Request627, Response627>.Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response627> MediatR.IRequestHandler<Request627, Response627>.Handle(
		Request627 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request628(long Id) : Mediator.IRequest<Response628>, MediatR.IRequest<Response628>;

public record struct Response628(long Id);

[Handler]
public sealed partial class Request628Handler
	: Mediator.IRequestHandler<Request628, Response628>,
	MediatR.IRequestHandler<Request628, Response628>
{
	private static ValueTask<Response628> Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response628> Mediator.IRequestHandler<Request628, Response628>.Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response628> MediatR.IRequestHandler<Request628, Response628>.Handle(
		Request628 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request629(long Id) : Mediator.IRequest<Response629>, MediatR.IRequest<Response629>;

public record struct Response629(long Id);

[Handler]
public sealed partial class Request629Handler
	: Mediator.IRequestHandler<Request629, Response629>,
	MediatR.IRequestHandler<Request629, Response629>
{
	private static ValueTask<Response629> Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response629> Mediator.IRequestHandler<Request629, Response629>.Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response629> MediatR.IRequestHandler<Request629, Response629>.Handle(
		Request629 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request630(long Id) : Mediator.IRequest<Response630>, MediatR.IRequest<Response630>;

public record struct Response630(long Id);

[Handler]
public sealed partial class Request630Handler
	: Mediator.IRequestHandler<Request630, Response630>,
	MediatR.IRequestHandler<Request630, Response630>
{
	private static ValueTask<Response630> Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response630> Mediator.IRequestHandler<Request630, Response630>.Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response630> MediatR.IRequestHandler<Request630, Response630>.Handle(
		Request630 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request631(long Id) : Mediator.IRequest<Response631>, MediatR.IRequest<Response631>;

public record struct Response631(long Id);

[Handler]
public sealed partial class Request631Handler
	: Mediator.IRequestHandler<Request631, Response631>,
	MediatR.IRequestHandler<Request631, Response631>
{
	private static ValueTask<Response631> Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response631> Mediator.IRequestHandler<Request631, Response631>.Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response631> MediatR.IRequestHandler<Request631, Response631>.Handle(
		Request631 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request632(long Id) : Mediator.IRequest<Response632>, MediatR.IRequest<Response632>;

public record struct Response632(long Id);

[Handler]
public sealed partial class Request632Handler
	: Mediator.IRequestHandler<Request632, Response632>,
	MediatR.IRequestHandler<Request632, Response632>
{
	private static ValueTask<Response632> Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response632> Mediator.IRequestHandler<Request632, Response632>.Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response632> MediatR.IRequestHandler<Request632, Response632>.Handle(
		Request632 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request633(long Id) : Mediator.IRequest<Response633>, MediatR.IRequest<Response633>;

public record struct Response633(long Id);

[Handler]
public sealed partial class Request633Handler
	: Mediator.IRequestHandler<Request633, Response633>,
	MediatR.IRequestHandler<Request633, Response633>
{
	private static ValueTask<Response633> Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response633> Mediator.IRequestHandler<Request633, Response633>.Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response633> MediatR.IRequestHandler<Request633, Response633>.Handle(
		Request633 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request634(long Id) : Mediator.IRequest<Response634>, MediatR.IRequest<Response634>;

public record struct Response634(long Id);

[Handler]
public sealed partial class Request634Handler
	: Mediator.IRequestHandler<Request634, Response634>,
	MediatR.IRequestHandler<Request634, Response634>
{
	private static ValueTask<Response634> Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response634> Mediator.IRequestHandler<Request634, Response634>.Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response634> MediatR.IRequestHandler<Request634, Response634>.Handle(
		Request634 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request635(long Id) : Mediator.IRequest<Response635>, MediatR.IRequest<Response635>;

public record struct Response635(long Id);

[Handler]
public sealed partial class Request635Handler
	: Mediator.IRequestHandler<Request635, Response635>,
	MediatR.IRequestHandler<Request635, Response635>
{
	private static ValueTask<Response635> Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response635> Mediator.IRequestHandler<Request635, Response635>.Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response635> MediatR.IRequestHandler<Request635, Response635>.Handle(
		Request635 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request636(long Id) : Mediator.IRequest<Response636>, MediatR.IRequest<Response636>;

public record struct Response636(long Id);

[Handler]
public sealed partial class Request636Handler
	: Mediator.IRequestHandler<Request636, Response636>,
	MediatR.IRequestHandler<Request636, Response636>
{
	private static ValueTask<Response636> Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response636> Mediator.IRequestHandler<Request636, Response636>.Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response636> MediatR.IRequestHandler<Request636, Response636>.Handle(
		Request636 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request637(long Id) : Mediator.IRequest<Response637>, MediatR.IRequest<Response637>;

public record struct Response637(long Id);

[Handler]
public sealed partial class Request637Handler
	: Mediator.IRequestHandler<Request637, Response637>,
	MediatR.IRequestHandler<Request637, Response637>
{
	private static ValueTask<Response637> Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response637> Mediator.IRequestHandler<Request637, Response637>.Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response637> MediatR.IRequestHandler<Request637, Response637>.Handle(
		Request637 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request638(long Id) : Mediator.IRequest<Response638>, MediatR.IRequest<Response638>;

public record struct Response638(long Id);

[Handler]
public sealed partial class Request638Handler
	: Mediator.IRequestHandler<Request638, Response638>,
	MediatR.IRequestHandler<Request638, Response638>
{
	private static ValueTask<Response638> Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response638> Mediator.IRequestHandler<Request638, Response638>.Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response638> MediatR.IRequestHandler<Request638, Response638>.Handle(
		Request638 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request639(long Id) : Mediator.IRequest<Response639>, MediatR.IRequest<Response639>;

public record struct Response639(long Id);

[Handler]
public sealed partial class Request639Handler
	: Mediator.IRequestHandler<Request639, Response639>,
	MediatR.IRequestHandler<Request639, Response639>
{
	private static ValueTask<Response639> Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response639> Mediator.IRequestHandler<Request639, Response639>.Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response639> MediatR.IRequestHandler<Request639, Response639>.Handle(
		Request639 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request640(long Id) : Mediator.IRequest<Response640>, MediatR.IRequest<Response640>;

public record struct Response640(long Id);

[Handler]
public sealed partial class Request640Handler
	: Mediator.IRequestHandler<Request640, Response640>,
	MediatR.IRequestHandler<Request640, Response640>
{
	private static ValueTask<Response640> Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response640> Mediator.IRequestHandler<Request640, Response640>.Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response640> MediatR.IRequestHandler<Request640, Response640>.Handle(
		Request640 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request641(long Id) : Mediator.IRequest<Response641>, MediatR.IRequest<Response641>;

public record struct Response641(long Id);

[Handler]
public sealed partial class Request641Handler
	: Mediator.IRequestHandler<Request641, Response641>,
	MediatR.IRequestHandler<Request641, Response641>
{
	private static ValueTask<Response641> Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response641> Mediator.IRequestHandler<Request641, Response641>.Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response641> MediatR.IRequestHandler<Request641, Response641>.Handle(
		Request641 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request642(long Id) : Mediator.IRequest<Response642>, MediatR.IRequest<Response642>;

public record struct Response642(long Id);

[Handler]
public sealed partial class Request642Handler
	: Mediator.IRequestHandler<Request642, Response642>,
	MediatR.IRequestHandler<Request642, Response642>
{
	private static ValueTask<Response642> Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response642> Mediator.IRequestHandler<Request642, Response642>.Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response642> MediatR.IRequestHandler<Request642, Response642>.Handle(
		Request642 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request643(long Id) : Mediator.IRequest<Response643>, MediatR.IRequest<Response643>;

public record struct Response643(long Id);

[Handler]
public sealed partial class Request643Handler
	: Mediator.IRequestHandler<Request643, Response643>,
	MediatR.IRequestHandler<Request643, Response643>
{
	private static ValueTask<Response643> Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response643> Mediator.IRequestHandler<Request643, Response643>.Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response643> MediatR.IRequestHandler<Request643, Response643>.Handle(
		Request643 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request644(long Id) : Mediator.IRequest<Response644>, MediatR.IRequest<Response644>;

public record struct Response644(long Id);

[Handler]
public sealed partial class Request644Handler
	: Mediator.IRequestHandler<Request644, Response644>,
	MediatR.IRequestHandler<Request644, Response644>
{
	private static ValueTask<Response644> Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response644> Mediator.IRequestHandler<Request644, Response644>.Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response644> MediatR.IRequestHandler<Request644, Response644>.Handle(
		Request644 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request645(long Id) : Mediator.IRequest<Response645>, MediatR.IRequest<Response645>;

public record struct Response645(long Id);

[Handler]
public sealed partial class Request645Handler
	: Mediator.IRequestHandler<Request645, Response645>,
	MediatR.IRequestHandler<Request645, Response645>
{
	private static ValueTask<Response645> Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response645> Mediator.IRequestHandler<Request645, Response645>.Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response645> MediatR.IRequestHandler<Request645, Response645>.Handle(
		Request645 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request646(long Id) : Mediator.IRequest<Response646>, MediatR.IRequest<Response646>;

public record struct Response646(long Id);

[Handler]
public sealed partial class Request646Handler
	: Mediator.IRequestHandler<Request646, Response646>,
	MediatR.IRequestHandler<Request646, Response646>
{
	private static ValueTask<Response646> Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response646> Mediator.IRequestHandler<Request646, Response646>.Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response646> MediatR.IRequestHandler<Request646, Response646>.Handle(
		Request646 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request647(long Id) : Mediator.IRequest<Response647>, MediatR.IRequest<Response647>;

public record struct Response647(long Id);

[Handler]
public sealed partial class Request647Handler
	: Mediator.IRequestHandler<Request647, Response647>,
	MediatR.IRequestHandler<Request647, Response647>
{
	private static ValueTask<Response647> Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response647> Mediator.IRequestHandler<Request647, Response647>.Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response647> MediatR.IRequestHandler<Request647, Response647>.Handle(
		Request647 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request648(long Id) : Mediator.IRequest<Response648>, MediatR.IRequest<Response648>;

public record struct Response648(long Id);

[Handler]
public sealed partial class Request648Handler
	: Mediator.IRequestHandler<Request648, Response648>,
	MediatR.IRequestHandler<Request648, Response648>
{
	private static ValueTask<Response648> Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response648> Mediator.IRequestHandler<Request648, Response648>.Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response648> MediatR.IRequestHandler<Request648, Response648>.Handle(
		Request648 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request649(long Id) : Mediator.IRequest<Response649>, MediatR.IRequest<Response649>;

public record struct Response649(long Id);

[Handler]
public sealed partial class Request649Handler
	: Mediator.IRequestHandler<Request649, Response649>,
	MediatR.IRequestHandler<Request649, Response649>
{
	private static ValueTask<Response649> Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response649> Mediator.IRequestHandler<Request649, Response649>.Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response649> MediatR.IRequestHandler<Request649, Response649>.Handle(
		Request649 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request650(long Id) : Mediator.IRequest<Response650>, MediatR.IRequest<Response650>;

public record struct Response650(long Id);

[Handler]
public sealed partial class Request650Handler
	: Mediator.IRequestHandler<Request650, Response650>,
	MediatR.IRequestHandler<Request650, Response650>
{
	private static ValueTask<Response650> Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response650> Mediator.IRequestHandler<Request650, Response650>.Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response650> MediatR.IRequestHandler<Request650, Response650>.Handle(
		Request650 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request651(long Id) : Mediator.IRequest<Response651>, MediatR.IRequest<Response651>;

public record struct Response651(long Id);

[Handler]
public sealed partial class Request651Handler
	: Mediator.IRequestHandler<Request651, Response651>,
	MediatR.IRequestHandler<Request651, Response651>
{
	private static ValueTask<Response651> Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response651> Mediator.IRequestHandler<Request651, Response651>.Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response651> MediatR.IRequestHandler<Request651, Response651>.Handle(
		Request651 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request652(long Id) : Mediator.IRequest<Response652>, MediatR.IRequest<Response652>;

public record struct Response652(long Id);

[Handler]
public sealed partial class Request652Handler
	: Mediator.IRequestHandler<Request652, Response652>,
	MediatR.IRequestHandler<Request652, Response652>
{
	private static ValueTask<Response652> Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response652> Mediator.IRequestHandler<Request652, Response652>.Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response652> MediatR.IRequestHandler<Request652, Response652>.Handle(
		Request652 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request653(long Id) : Mediator.IRequest<Response653>, MediatR.IRequest<Response653>;

public record struct Response653(long Id);

[Handler]
public sealed partial class Request653Handler
	: Mediator.IRequestHandler<Request653, Response653>,
	MediatR.IRequestHandler<Request653, Response653>
{
	private static ValueTask<Response653> Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response653> Mediator.IRequestHandler<Request653, Response653>.Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response653> MediatR.IRequestHandler<Request653, Response653>.Handle(
		Request653 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request654(long Id) : Mediator.IRequest<Response654>, MediatR.IRequest<Response654>;

public record struct Response654(long Id);

[Handler]
public sealed partial class Request654Handler
	: Mediator.IRequestHandler<Request654, Response654>,
	MediatR.IRequestHandler<Request654, Response654>
{
	private static ValueTask<Response654> Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response654> Mediator.IRequestHandler<Request654, Response654>.Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response654> MediatR.IRequestHandler<Request654, Response654>.Handle(
		Request654 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request655(long Id) : Mediator.IRequest<Response655>, MediatR.IRequest<Response655>;

public record struct Response655(long Id);

[Handler]
public sealed partial class Request655Handler
	: Mediator.IRequestHandler<Request655, Response655>,
	MediatR.IRequestHandler<Request655, Response655>
{
	private static ValueTask<Response655> Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response655> Mediator.IRequestHandler<Request655, Response655>.Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response655> MediatR.IRequestHandler<Request655, Response655>.Handle(
		Request655 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request656(long Id) : Mediator.IRequest<Response656>, MediatR.IRequest<Response656>;

public record struct Response656(long Id);

[Handler]
public sealed partial class Request656Handler
	: Mediator.IRequestHandler<Request656, Response656>,
	MediatR.IRequestHandler<Request656, Response656>
{
	private static ValueTask<Response656> Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response656> Mediator.IRequestHandler<Request656, Response656>.Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response656> MediatR.IRequestHandler<Request656, Response656>.Handle(
		Request656 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request657(long Id) : Mediator.IRequest<Response657>, MediatR.IRequest<Response657>;

public record struct Response657(long Id);

[Handler]
public sealed partial class Request657Handler
	: Mediator.IRequestHandler<Request657, Response657>,
	MediatR.IRequestHandler<Request657, Response657>
{
	private static ValueTask<Response657> Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response657> Mediator.IRequestHandler<Request657, Response657>.Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response657> MediatR.IRequestHandler<Request657, Response657>.Handle(
		Request657 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request658(long Id) : Mediator.IRequest<Response658>, MediatR.IRequest<Response658>;

public record struct Response658(long Id);

[Handler]
public sealed partial class Request658Handler
	: Mediator.IRequestHandler<Request658, Response658>,
	MediatR.IRequestHandler<Request658, Response658>
{
	private static ValueTask<Response658> Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response658> Mediator.IRequestHandler<Request658, Response658>.Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response658> MediatR.IRequestHandler<Request658, Response658>.Handle(
		Request658 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request659(long Id) : Mediator.IRequest<Response659>, MediatR.IRequest<Response659>;

public record struct Response659(long Id);

[Handler]
public sealed partial class Request659Handler
	: Mediator.IRequestHandler<Request659, Response659>,
	MediatR.IRequestHandler<Request659, Response659>
{
	private static ValueTask<Response659> Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response659> Mediator.IRequestHandler<Request659, Response659>.Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response659> MediatR.IRequestHandler<Request659, Response659>.Handle(
		Request659 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request660(long Id) : Mediator.IRequest<Response660>, MediatR.IRequest<Response660>;

public record struct Response660(long Id);

[Handler]
public sealed partial class Request660Handler
	: Mediator.IRequestHandler<Request660, Response660>,
	MediatR.IRequestHandler<Request660, Response660>
{
	private static ValueTask<Response660> Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response660> Mediator.IRequestHandler<Request660, Response660>.Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response660> MediatR.IRequestHandler<Request660, Response660>.Handle(
		Request660 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request661(long Id) : Mediator.IRequest<Response661>, MediatR.IRequest<Response661>;

public record struct Response661(long Id);

[Handler]
public sealed partial class Request661Handler
	: Mediator.IRequestHandler<Request661, Response661>,
	MediatR.IRequestHandler<Request661, Response661>
{
	private static ValueTask<Response661> Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response661> Mediator.IRequestHandler<Request661, Response661>.Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response661> MediatR.IRequestHandler<Request661, Response661>.Handle(
		Request661 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request662(long Id) : Mediator.IRequest<Response662>, MediatR.IRequest<Response662>;

public record struct Response662(long Id);

[Handler]
public sealed partial class Request662Handler
	: Mediator.IRequestHandler<Request662, Response662>,
	MediatR.IRequestHandler<Request662, Response662>
{
	private static ValueTask<Response662> Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response662> Mediator.IRequestHandler<Request662, Response662>.Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response662> MediatR.IRequestHandler<Request662, Response662>.Handle(
		Request662 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request663(long Id) : Mediator.IRequest<Response663>, MediatR.IRequest<Response663>;

public record struct Response663(long Id);

[Handler]
public sealed partial class Request663Handler
	: Mediator.IRequestHandler<Request663, Response663>,
	MediatR.IRequestHandler<Request663, Response663>
{
	private static ValueTask<Response663> Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response663> Mediator.IRequestHandler<Request663, Response663>.Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response663> MediatR.IRequestHandler<Request663, Response663>.Handle(
		Request663 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request664(long Id) : Mediator.IRequest<Response664>, MediatR.IRequest<Response664>;

public record struct Response664(long Id);

[Handler]
public sealed partial class Request664Handler
	: Mediator.IRequestHandler<Request664, Response664>,
	MediatR.IRequestHandler<Request664, Response664>
{
	private static ValueTask<Response664> Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response664> Mediator.IRequestHandler<Request664, Response664>.Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response664> MediatR.IRequestHandler<Request664, Response664>.Handle(
		Request664 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request665(long Id) : Mediator.IRequest<Response665>, MediatR.IRequest<Response665>;

public record struct Response665(long Id);

[Handler]
public sealed partial class Request665Handler
	: Mediator.IRequestHandler<Request665, Response665>,
	MediatR.IRequestHandler<Request665, Response665>
{
	private static ValueTask<Response665> Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response665> Mediator.IRequestHandler<Request665, Response665>.Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response665> MediatR.IRequestHandler<Request665, Response665>.Handle(
		Request665 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request666(long Id) : Mediator.IRequest<Response666>, MediatR.IRequest<Response666>;

public record struct Response666(long Id);

[Handler]
public sealed partial class Request666Handler
	: Mediator.IRequestHandler<Request666, Response666>,
	MediatR.IRequestHandler<Request666, Response666>
{
	private static ValueTask<Response666> Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response666> Mediator.IRequestHandler<Request666, Response666>.Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response666> MediatR.IRequestHandler<Request666, Response666>.Handle(
		Request666 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request667(long Id) : Mediator.IRequest<Response667>, MediatR.IRequest<Response667>;

public record struct Response667(long Id);

[Handler]
public sealed partial class Request667Handler
	: Mediator.IRequestHandler<Request667, Response667>,
	MediatR.IRequestHandler<Request667, Response667>
{
	private static ValueTask<Response667> Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response667> Mediator.IRequestHandler<Request667, Response667>.Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response667> MediatR.IRequestHandler<Request667, Response667>.Handle(
		Request667 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request668(long Id) : Mediator.IRequest<Response668>, MediatR.IRequest<Response668>;

public record struct Response668(long Id);

[Handler]
public sealed partial class Request668Handler
	: Mediator.IRequestHandler<Request668, Response668>,
	MediatR.IRequestHandler<Request668, Response668>
{
	private static ValueTask<Response668> Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response668> Mediator.IRequestHandler<Request668, Response668>.Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response668> MediatR.IRequestHandler<Request668, Response668>.Handle(
		Request668 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request669(long Id) : Mediator.IRequest<Response669>, MediatR.IRequest<Response669>;

public record struct Response669(long Id);

[Handler]
public sealed partial class Request669Handler
	: Mediator.IRequestHandler<Request669, Response669>,
	MediatR.IRequestHandler<Request669, Response669>
{
	private static ValueTask<Response669> Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response669> Mediator.IRequestHandler<Request669, Response669>.Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response669> MediatR.IRequestHandler<Request669, Response669>.Handle(
		Request669 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request670(long Id) : Mediator.IRequest<Response670>, MediatR.IRequest<Response670>;

public record struct Response670(long Id);

[Handler]
public sealed partial class Request670Handler
	: Mediator.IRequestHandler<Request670, Response670>,
	MediatR.IRequestHandler<Request670, Response670>
{
	private static ValueTask<Response670> Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response670> Mediator.IRequestHandler<Request670, Response670>.Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response670> MediatR.IRequestHandler<Request670, Response670>.Handle(
		Request670 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request671(long Id) : Mediator.IRequest<Response671>, MediatR.IRequest<Response671>;

public record struct Response671(long Id);

[Handler]
public sealed partial class Request671Handler
	: Mediator.IRequestHandler<Request671, Response671>,
	MediatR.IRequestHandler<Request671, Response671>
{
	private static ValueTask<Response671> Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response671> Mediator.IRequestHandler<Request671, Response671>.Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response671> MediatR.IRequestHandler<Request671, Response671>.Handle(
		Request671 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request672(long Id) : Mediator.IRequest<Response672>, MediatR.IRequest<Response672>;

public record struct Response672(long Id);

[Handler]
public sealed partial class Request672Handler
	: Mediator.IRequestHandler<Request672, Response672>,
	MediatR.IRequestHandler<Request672, Response672>
{
	private static ValueTask<Response672> Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response672> Mediator.IRequestHandler<Request672, Response672>.Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response672> MediatR.IRequestHandler<Request672, Response672>.Handle(
		Request672 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request673(long Id) : Mediator.IRequest<Response673>, MediatR.IRequest<Response673>;

public record struct Response673(long Id);

[Handler]
public sealed partial class Request673Handler
	: Mediator.IRequestHandler<Request673, Response673>,
	MediatR.IRequestHandler<Request673, Response673>
{
	private static ValueTask<Response673> Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response673> Mediator.IRequestHandler<Request673, Response673>.Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response673> MediatR.IRequestHandler<Request673, Response673>.Handle(
		Request673 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request674(long Id) : Mediator.IRequest<Response674>, MediatR.IRequest<Response674>;

public record struct Response674(long Id);

[Handler]
public sealed partial class Request674Handler
	: Mediator.IRequestHandler<Request674, Response674>,
	MediatR.IRequestHandler<Request674, Response674>
{
	private static ValueTask<Response674> Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response674> Mediator.IRequestHandler<Request674, Response674>.Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response674> MediatR.IRequestHandler<Request674, Response674>.Handle(
		Request674 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request675(long Id) : Mediator.IRequest<Response675>, MediatR.IRequest<Response675>;

public record struct Response675(long Id);

[Handler]
public sealed partial class Request675Handler
	: Mediator.IRequestHandler<Request675, Response675>,
	MediatR.IRequestHandler<Request675, Response675>
{
	private static ValueTask<Response675> Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response675> Mediator.IRequestHandler<Request675, Response675>.Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response675> MediatR.IRequestHandler<Request675, Response675>.Handle(
		Request675 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request676(long Id) : Mediator.IRequest<Response676>, MediatR.IRequest<Response676>;

public record struct Response676(long Id);

[Handler]
public sealed partial class Request676Handler
	: Mediator.IRequestHandler<Request676, Response676>,
	MediatR.IRequestHandler<Request676, Response676>
{
	private static ValueTask<Response676> Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response676> Mediator.IRequestHandler<Request676, Response676>.Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response676> MediatR.IRequestHandler<Request676, Response676>.Handle(
		Request676 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request677(long Id) : Mediator.IRequest<Response677>, MediatR.IRequest<Response677>;

public record struct Response677(long Id);

[Handler]
public sealed partial class Request677Handler
	: Mediator.IRequestHandler<Request677, Response677>,
	MediatR.IRequestHandler<Request677, Response677>
{
	private static ValueTask<Response677> Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response677> Mediator.IRequestHandler<Request677, Response677>.Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response677> MediatR.IRequestHandler<Request677, Response677>.Handle(
		Request677 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request678(long Id) : Mediator.IRequest<Response678>, MediatR.IRequest<Response678>;

public record struct Response678(long Id);

[Handler]
public sealed partial class Request678Handler
	: Mediator.IRequestHandler<Request678, Response678>,
	MediatR.IRequestHandler<Request678, Response678>
{
	private static ValueTask<Response678> Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response678> Mediator.IRequestHandler<Request678, Response678>.Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response678> MediatR.IRequestHandler<Request678, Response678>.Handle(
		Request678 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request679(long Id) : Mediator.IRequest<Response679>, MediatR.IRequest<Response679>;

public record struct Response679(long Id);

[Handler]
public sealed partial class Request679Handler
	: Mediator.IRequestHandler<Request679, Response679>,
	MediatR.IRequestHandler<Request679, Response679>
{
	private static ValueTask<Response679> Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response679> Mediator.IRequestHandler<Request679, Response679>.Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response679> MediatR.IRequestHandler<Request679, Response679>.Handle(
		Request679 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request680(long Id) : Mediator.IRequest<Response680>, MediatR.IRequest<Response680>;

public record struct Response680(long Id);

[Handler]
public sealed partial class Request680Handler
	: Mediator.IRequestHandler<Request680, Response680>,
	MediatR.IRequestHandler<Request680, Response680>
{
	private static ValueTask<Response680> Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response680> Mediator.IRequestHandler<Request680, Response680>.Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response680> MediatR.IRequestHandler<Request680, Response680>.Handle(
		Request680 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request681(long Id) : Mediator.IRequest<Response681>, MediatR.IRequest<Response681>;

public record struct Response681(long Id);

[Handler]
public sealed partial class Request681Handler
	: Mediator.IRequestHandler<Request681, Response681>,
	MediatR.IRequestHandler<Request681, Response681>
{
	private static ValueTask<Response681> Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response681> Mediator.IRequestHandler<Request681, Response681>.Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response681> MediatR.IRequestHandler<Request681, Response681>.Handle(
		Request681 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request682(long Id) : Mediator.IRequest<Response682>, MediatR.IRequest<Response682>;

public record struct Response682(long Id);

[Handler]
public sealed partial class Request682Handler
	: Mediator.IRequestHandler<Request682, Response682>,
	MediatR.IRequestHandler<Request682, Response682>
{
	private static ValueTask<Response682> Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response682> Mediator.IRequestHandler<Request682, Response682>.Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response682> MediatR.IRequestHandler<Request682, Response682>.Handle(
		Request682 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request683(long Id) : Mediator.IRequest<Response683>, MediatR.IRequest<Response683>;

public record struct Response683(long Id);

[Handler]
public sealed partial class Request683Handler
	: Mediator.IRequestHandler<Request683, Response683>,
	MediatR.IRequestHandler<Request683, Response683>
{
	private static ValueTask<Response683> Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response683> Mediator.IRequestHandler<Request683, Response683>.Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response683> MediatR.IRequestHandler<Request683, Response683>.Handle(
		Request683 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request684(long Id) : Mediator.IRequest<Response684>, MediatR.IRequest<Response684>;

public record struct Response684(long Id);

[Handler]
public sealed partial class Request684Handler
	: Mediator.IRequestHandler<Request684, Response684>,
	MediatR.IRequestHandler<Request684, Response684>
{
	private static ValueTask<Response684> Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response684> Mediator.IRequestHandler<Request684, Response684>.Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response684> MediatR.IRequestHandler<Request684, Response684>.Handle(
		Request684 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request685(long Id) : Mediator.IRequest<Response685>, MediatR.IRequest<Response685>;

public record struct Response685(long Id);

[Handler]
public sealed partial class Request685Handler
	: Mediator.IRequestHandler<Request685, Response685>,
	MediatR.IRequestHandler<Request685, Response685>
{
	private static ValueTask<Response685> Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response685> Mediator.IRequestHandler<Request685, Response685>.Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response685> MediatR.IRequestHandler<Request685, Response685>.Handle(
		Request685 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request686(long Id) : Mediator.IRequest<Response686>, MediatR.IRequest<Response686>;

public record struct Response686(long Id);

[Handler]
public sealed partial class Request686Handler
	: Mediator.IRequestHandler<Request686, Response686>,
	MediatR.IRequestHandler<Request686, Response686>
{
	private static ValueTask<Response686> Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response686> Mediator.IRequestHandler<Request686, Response686>.Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response686> MediatR.IRequestHandler<Request686, Response686>.Handle(
		Request686 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request687(long Id) : Mediator.IRequest<Response687>, MediatR.IRequest<Response687>;

public record struct Response687(long Id);

[Handler]
public sealed partial class Request687Handler
	: Mediator.IRequestHandler<Request687, Response687>,
	MediatR.IRequestHandler<Request687, Response687>
{
	private static ValueTask<Response687> Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response687> Mediator.IRequestHandler<Request687, Response687>.Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response687> MediatR.IRequestHandler<Request687, Response687>.Handle(
		Request687 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request688(long Id) : Mediator.IRequest<Response688>, MediatR.IRequest<Response688>;

public record struct Response688(long Id);

[Handler]
public sealed partial class Request688Handler
	: Mediator.IRequestHandler<Request688, Response688>,
	MediatR.IRequestHandler<Request688, Response688>
{
	private static ValueTask<Response688> Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response688> Mediator.IRequestHandler<Request688, Response688>.Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response688> MediatR.IRequestHandler<Request688, Response688>.Handle(
		Request688 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request689(long Id) : Mediator.IRequest<Response689>, MediatR.IRequest<Response689>;

public record struct Response689(long Id);

[Handler]
public sealed partial class Request689Handler
	: Mediator.IRequestHandler<Request689, Response689>,
	MediatR.IRequestHandler<Request689, Response689>
{
	private static ValueTask<Response689> Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response689> Mediator.IRequestHandler<Request689, Response689>.Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response689> MediatR.IRequestHandler<Request689, Response689>.Handle(
		Request689 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request690(long Id) : Mediator.IRequest<Response690>, MediatR.IRequest<Response690>;

public record struct Response690(long Id);

[Handler]
public sealed partial class Request690Handler
	: Mediator.IRequestHandler<Request690, Response690>,
	MediatR.IRequestHandler<Request690, Response690>
{
	private static ValueTask<Response690> Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response690> Mediator.IRequestHandler<Request690, Response690>.Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response690> MediatR.IRequestHandler<Request690, Response690>.Handle(
		Request690 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request691(long Id) : Mediator.IRequest<Response691>, MediatR.IRequest<Response691>;

public record struct Response691(long Id);

[Handler]
public sealed partial class Request691Handler
	: Mediator.IRequestHandler<Request691, Response691>,
	MediatR.IRequestHandler<Request691, Response691>
{
	private static ValueTask<Response691> Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response691> Mediator.IRequestHandler<Request691, Response691>.Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response691> MediatR.IRequestHandler<Request691, Response691>.Handle(
		Request691 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request692(long Id) : Mediator.IRequest<Response692>, MediatR.IRequest<Response692>;

public record struct Response692(long Id);

[Handler]
public sealed partial class Request692Handler
	: Mediator.IRequestHandler<Request692, Response692>,
	MediatR.IRequestHandler<Request692, Response692>
{
	private static ValueTask<Response692> Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response692> Mediator.IRequestHandler<Request692, Response692>.Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response692> MediatR.IRequestHandler<Request692, Response692>.Handle(
		Request692 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request693(long Id) : Mediator.IRequest<Response693>, MediatR.IRequest<Response693>;

public record struct Response693(long Id);

[Handler]
public sealed partial class Request693Handler
	: Mediator.IRequestHandler<Request693, Response693>,
	MediatR.IRequestHandler<Request693, Response693>
{
	private static ValueTask<Response693> Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response693> Mediator.IRequestHandler<Request693, Response693>.Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response693> MediatR.IRequestHandler<Request693, Response693>.Handle(
		Request693 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request694(long Id) : Mediator.IRequest<Response694>, MediatR.IRequest<Response694>;

public record struct Response694(long Id);

[Handler]
public sealed partial class Request694Handler
	: Mediator.IRequestHandler<Request694, Response694>,
	MediatR.IRequestHandler<Request694, Response694>
{
	private static ValueTask<Response694> Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response694> Mediator.IRequestHandler<Request694, Response694>.Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response694> MediatR.IRequestHandler<Request694, Response694>.Handle(
		Request694 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request695(long Id) : Mediator.IRequest<Response695>, MediatR.IRequest<Response695>;

public record struct Response695(long Id);

[Handler]
public sealed partial class Request695Handler
	: Mediator.IRequestHandler<Request695, Response695>,
	MediatR.IRequestHandler<Request695, Response695>
{
	private static ValueTask<Response695> Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response695> Mediator.IRequestHandler<Request695, Response695>.Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response695> MediatR.IRequestHandler<Request695, Response695>.Handle(
		Request695 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request696(long Id) : Mediator.IRequest<Response696>, MediatR.IRequest<Response696>;

public record struct Response696(long Id);

[Handler]
public sealed partial class Request696Handler
	: Mediator.IRequestHandler<Request696, Response696>,
	MediatR.IRequestHandler<Request696, Response696>
{
	private static ValueTask<Response696> Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response696> Mediator.IRequestHandler<Request696, Response696>.Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response696> MediatR.IRequestHandler<Request696, Response696>.Handle(
		Request696 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request697(long Id) : Mediator.IRequest<Response697>, MediatR.IRequest<Response697>;

public record struct Response697(long Id);

[Handler]
public sealed partial class Request697Handler
	: Mediator.IRequestHandler<Request697, Response697>,
	MediatR.IRequestHandler<Request697, Response697>
{
	private static ValueTask<Response697> Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response697> Mediator.IRequestHandler<Request697, Response697>.Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response697> MediatR.IRequestHandler<Request697, Response697>.Handle(
		Request697 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request698(long Id) : Mediator.IRequest<Response698>, MediatR.IRequest<Response698>;

public record struct Response698(long Id);

[Handler]
public sealed partial class Request698Handler
	: Mediator.IRequestHandler<Request698, Response698>,
	MediatR.IRequestHandler<Request698, Response698>
{
	private static ValueTask<Response698> Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response698> Mediator.IRequestHandler<Request698, Response698>.Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response698> MediatR.IRequestHandler<Request698, Response698>.Handle(
		Request698 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request699(long Id) : Mediator.IRequest<Response699>, MediatR.IRequest<Response699>;

public record struct Response699(long Id);

[Handler]
public sealed partial class Request699Handler
	: Mediator.IRequestHandler<Request699, Response699>,
	MediatR.IRequestHandler<Request699, Response699>
{
	private static ValueTask<Response699> Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response699> Mediator.IRequestHandler<Request699, Response699>.Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response699> MediatR.IRequestHandler<Request699, Response699>.Handle(
		Request699 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request700(long Id) : Mediator.IRequest<Response700>, MediatR.IRequest<Response700>;

public record struct Response700(long Id);

[Handler]
public sealed partial class Request700Handler
	: Mediator.IRequestHandler<Request700, Response700>,
	MediatR.IRequestHandler<Request700, Response700>
{
	private static ValueTask<Response700> Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response700> Mediator.IRequestHandler<Request700, Response700>.Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response700> MediatR.IRequestHandler<Request700, Response700>.Handle(
		Request700 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request701(long Id) : Mediator.IRequest<Response701>, MediatR.IRequest<Response701>;

public record struct Response701(long Id);

[Handler]
public sealed partial class Request701Handler
	: Mediator.IRequestHandler<Request701, Response701>,
	MediatR.IRequestHandler<Request701, Response701>
{
	private static ValueTask<Response701> Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response701> Mediator.IRequestHandler<Request701, Response701>.Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response701> MediatR.IRequestHandler<Request701, Response701>.Handle(
		Request701 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request702(long Id) : Mediator.IRequest<Response702>, MediatR.IRequest<Response702>;

public record struct Response702(long Id);

[Handler]
public sealed partial class Request702Handler
	: Mediator.IRequestHandler<Request702, Response702>,
	MediatR.IRequestHandler<Request702, Response702>
{
	private static ValueTask<Response702> Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response702> Mediator.IRequestHandler<Request702, Response702>.Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response702> MediatR.IRequestHandler<Request702, Response702>.Handle(
		Request702 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request703(long Id) : Mediator.IRequest<Response703>, MediatR.IRequest<Response703>;

public record struct Response703(long Id);

[Handler]
public sealed partial class Request703Handler
	: Mediator.IRequestHandler<Request703, Response703>,
	MediatR.IRequestHandler<Request703, Response703>
{
	private static ValueTask<Response703> Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response703> Mediator.IRequestHandler<Request703, Response703>.Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response703> MediatR.IRequestHandler<Request703, Response703>.Handle(
		Request703 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request704(long Id) : Mediator.IRequest<Response704>, MediatR.IRequest<Response704>;

public record struct Response704(long Id);

[Handler]
public sealed partial class Request704Handler
	: Mediator.IRequestHandler<Request704, Response704>,
	MediatR.IRequestHandler<Request704, Response704>
{
	private static ValueTask<Response704> Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response704> Mediator.IRequestHandler<Request704, Response704>.Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response704> MediatR.IRequestHandler<Request704, Response704>.Handle(
		Request704 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request705(long Id) : Mediator.IRequest<Response705>, MediatR.IRequest<Response705>;

public record struct Response705(long Id);

[Handler]
public sealed partial class Request705Handler
	: Mediator.IRequestHandler<Request705, Response705>,
	MediatR.IRequestHandler<Request705, Response705>
{
	private static ValueTask<Response705> Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response705> Mediator.IRequestHandler<Request705, Response705>.Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response705> MediatR.IRequestHandler<Request705, Response705>.Handle(
		Request705 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request706(long Id) : Mediator.IRequest<Response706>, MediatR.IRequest<Response706>;

public record struct Response706(long Id);

[Handler]
public sealed partial class Request706Handler
	: Mediator.IRequestHandler<Request706, Response706>,
	MediatR.IRequestHandler<Request706, Response706>
{
	private static ValueTask<Response706> Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response706> Mediator.IRequestHandler<Request706, Response706>.Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response706> MediatR.IRequestHandler<Request706, Response706>.Handle(
		Request706 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request707(long Id) : Mediator.IRequest<Response707>, MediatR.IRequest<Response707>;

public record struct Response707(long Id);

[Handler]
public sealed partial class Request707Handler
	: Mediator.IRequestHandler<Request707, Response707>,
	MediatR.IRequestHandler<Request707, Response707>
{
	private static ValueTask<Response707> Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response707> Mediator.IRequestHandler<Request707, Response707>.Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response707> MediatR.IRequestHandler<Request707, Response707>.Handle(
		Request707 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request708(long Id) : Mediator.IRequest<Response708>, MediatR.IRequest<Response708>;

public record struct Response708(long Id);

[Handler]
public sealed partial class Request708Handler
	: Mediator.IRequestHandler<Request708, Response708>,
	MediatR.IRequestHandler<Request708, Response708>
{
	private static ValueTask<Response708> Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response708> Mediator.IRequestHandler<Request708, Response708>.Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response708> MediatR.IRequestHandler<Request708, Response708>.Handle(
		Request708 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request709(long Id) : Mediator.IRequest<Response709>, MediatR.IRequest<Response709>;

public record struct Response709(long Id);

[Handler]
public sealed partial class Request709Handler
	: Mediator.IRequestHandler<Request709, Response709>,
	MediatR.IRequestHandler<Request709, Response709>
{
	private static ValueTask<Response709> Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response709> Mediator.IRequestHandler<Request709, Response709>.Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response709> MediatR.IRequestHandler<Request709, Response709>.Handle(
		Request709 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request710(long Id) : Mediator.IRequest<Response710>, MediatR.IRequest<Response710>;

public record struct Response710(long Id);

[Handler]
public sealed partial class Request710Handler
	: Mediator.IRequestHandler<Request710, Response710>,
	MediatR.IRequestHandler<Request710, Response710>
{
	private static ValueTask<Response710> Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response710> Mediator.IRequestHandler<Request710, Response710>.Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response710> MediatR.IRequestHandler<Request710, Response710>.Handle(
		Request710 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request711(long Id) : Mediator.IRequest<Response711>, MediatR.IRequest<Response711>;

public record struct Response711(long Id);

[Handler]
public sealed partial class Request711Handler
	: Mediator.IRequestHandler<Request711, Response711>,
	MediatR.IRequestHandler<Request711, Response711>
{
	private static ValueTask<Response711> Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response711> Mediator.IRequestHandler<Request711, Response711>.Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response711> MediatR.IRequestHandler<Request711, Response711>.Handle(
		Request711 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request712(long Id) : Mediator.IRequest<Response712>, MediatR.IRequest<Response712>;

public record struct Response712(long Id);

[Handler]
public sealed partial class Request712Handler
	: Mediator.IRequestHandler<Request712, Response712>,
	MediatR.IRequestHandler<Request712, Response712>
{
	private static ValueTask<Response712> Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response712> Mediator.IRequestHandler<Request712, Response712>.Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response712> MediatR.IRequestHandler<Request712, Response712>.Handle(
		Request712 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request713(long Id) : Mediator.IRequest<Response713>, MediatR.IRequest<Response713>;

public record struct Response713(long Id);

[Handler]
public sealed partial class Request713Handler
	: Mediator.IRequestHandler<Request713, Response713>,
	MediatR.IRequestHandler<Request713, Response713>
{
	private static ValueTask<Response713> Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response713> Mediator.IRequestHandler<Request713, Response713>.Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response713> MediatR.IRequestHandler<Request713, Response713>.Handle(
		Request713 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request714(long Id) : Mediator.IRequest<Response714>, MediatR.IRequest<Response714>;

public record struct Response714(long Id);

[Handler]
public sealed partial class Request714Handler
	: Mediator.IRequestHandler<Request714, Response714>,
	MediatR.IRequestHandler<Request714, Response714>
{
	private static ValueTask<Response714> Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response714> Mediator.IRequestHandler<Request714, Response714>.Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response714> MediatR.IRequestHandler<Request714, Response714>.Handle(
		Request714 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request715(long Id) : Mediator.IRequest<Response715>, MediatR.IRequest<Response715>;

public record struct Response715(long Id);

[Handler]
public sealed partial class Request715Handler
	: Mediator.IRequestHandler<Request715, Response715>,
	MediatR.IRequestHandler<Request715, Response715>
{
	private static ValueTask<Response715> Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response715> Mediator.IRequestHandler<Request715, Response715>.Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response715> MediatR.IRequestHandler<Request715, Response715>.Handle(
		Request715 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request716(long Id) : Mediator.IRequest<Response716>, MediatR.IRequest<Response716>;

public record struct Response716(long Id);

[Handler]
public sealed partial class Request716Handler
	: Mediator.IRequestHandler<Request716, Response716>,
	MediatR.IRequestHandler<Request716, Response716>
{
	private static ValueTask<Response716> Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response716> Mediator.IRequestHandler<Request716, Response716>.Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response716> MediatR.IRequestHandler<Request716, Response716>.Handle(
		Request716 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request717(long Id) : Mediator.IRequest<Response717>, MediatR.IRequest<Response717>;

public record struct Response717(long Id);

[Handler]
public sealed partial class Request717Handler
	: Mediator.IRequestHandler<Request717, Response717>,
	MediatR.IRequestHandler<Request717, Response717>
{
	private static ValueTask<Response717> Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response717> Mediator.IRequestHandler<Request717, Response717>.Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response717> MediatR.IRequestHandler<Request717, Response717>.Handle(
		Request717 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request718(long Id) : Mediator.IRequest<Response718>, MediatR.IRequest<Response718>;

public record struct Response718(long Id);

[Handler]
public sealed partial class Request718Handler
	: Mediator.IRequestHandler<Request718, Response718>,
	MediatR.IRequestHandler<Request718, Response718>
{
	private static ValueTask<Response718> Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response718> Mediator.IRequestHandler<Request718, Response718>.Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response718> MediatR.IRequestHandler<Request718, Response718>.Handle(
		Request718 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request719(long Id) : Mediator.IRequest<Response719>, MediatR.IRequest<Response719>;

public record struct Response719(long Id);

[Handler]
public sealed partial class Request719Handler
	: Mediator.IRequestHandler<Request719, Response719>,
	MediatR.IRequestHandler<Request719, Response719>
{
	private static ValueTask<Response719> Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response719> Mediator.IRequestHandler<Request719, Response719>.Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response719> MediatR.IRequestHandler<Request719, Response719>.Handle(
		Request719 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request720(long Id) : Mediator.IRequest<Response720>, MediatR.IRequest<Response720>;

public record struct Response720(long Id);

[Handler]
public sealed partial class Request720Handler
	: Mediator.IRequestHandler<Request720, Response720>,
	MediatR.IRequestHandler<Request720, Response720>
{
	private static ValueTask<Response720> Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response720> Mediator.IRequestHandler<Request720, Response720>.Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response720> MediatR.IRequestHandler<Request720, Response720>.Handle(
		Request720 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request721(long Id) : Mediator.IRequest<Response721>, MediatR.IRequest<Response721>;

public record struct Response721(long Id);

[Handler]
public sealed partial class Request721Handler
	: Mediator.IRequestHandler<Request721, Response721>,
	MediatR.IRequestHandler<Request721, Response721>
{
	private static ValueTask<Response721> Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response721> Mediator.IRequestHandler<Request721, Response721>.Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response721> MediatR.IRequestHandler<Request721, Response721>.Handle(
		Request721 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request722(long Id) : Mediator.IRequest<Response722>, MediatR.IRequest<Response722>;

public record struct Response722(long Id);

[Handler]
public sealed partial class Request722Handler
	: Mediator.IRequestHandler<Request722, Response722>,
	MediatR.IRequestHandler<Request722, Response722>
{
	private static ValueTask<Response722> Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response722> Mediator.IRequestHandler<Request722, Response722>.Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response722> MediatR.IRequestHandler<Request722, Response722>.Handle(
		Request722 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request723(long Id) : Mediator.IRequest<Response723>, MediatR.IRequest<Response723>;

public record struct Response723(long Id);

[Handler]
public sealed partial class Request723Handler
	: Mediator.IRequestHandler<Request723, Response723>,
	MediatR.IRequestHandler<Request723, Response723>
{
	private static ValueTask<Response723> Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response723> Mediator.IRequestHandler<Request723, Response723>.Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response723> MediatR.IRequestHandler<Request723, Response723>.Handle(
		Request723 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request724(long Id) : Mediator.IRequest<Response724>, MediatR.IRequest<Response724>;

public record struct Response724(long Id);

[Handler]
public sealed partial class Request724Handler
	: Mediator.IRequestHandler<Request724, Response724>,
	MediatR.IRequestHandler<Request724, Response724>
{
	private static ValueTask<Response724> Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response724> Mediator.IRequestHandler<Request724, Response724>.Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response724> MediatR.IRequestHandler<Request724, Response724>.Handle(
		Request724 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request725(long Id) : Mediator.IRequest<Response725>, MediatR.IRequest<Response725>;

public record struct Response725(long Id);

[Handler]
public sealed partial class Request725Handler
	: Mediator.IRequestHandler<Request725, Response725>,
	MediatR.IRequestHandler<Request725, Response725>
{
	private static ValueTask<Response725> Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response725> Mediator.IRequestHandler<Request725, Response725>.Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response725> MediatR.IRequestHandler<Request725, Response725>.Handle(
		Request725 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request726(long Id) : Mediator.IRequest<Response726>, MediatR.IRequest<Response726>;

public record struct Response726(long Id);

[Handler]
public sealed partial class Request726Handler
	: Mediator.IRequestHandler<Request726, Response726>,
	MediatR.IRequestHandler<Request726, Response726>
{
	private static ValueTask<Response726> Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response726> Mediator.IRequestHandler<Request726, Response726>.Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response726> MediatR.IRequestHandler<Request726, Response726>.Handle(
		Request726 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request727(long Id) : Mediator.IRequest<Response727>, MediatR.IRequest<Response727>;

public record struct Response727(long Id);

[Handler]
public sealed partial class Request727Handler
	: Mediator.IRequestHandler<Request727, Response727>,
	MediatR.IRequestHandler<Request727, Response727>
{
	private static ValueTask<Response727> Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response727> Mediator.IRequestHandler<Request727, Response727>.Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response727> MediatR.IRequestHandler<Request727, Response727>.Handle(
		Request727 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request728(long Id) : Mediator.IRequest<Response728>, MediatR.IRequest<Response728>;

public record struct Response728(long Id);

[Handler]
public sealed partial class Request728Handler
	: Mediator.IRequestHandler<Request728, Response728>,
	MediatR.IRequestHandler<Request728, Response728>
{
	private static ValueTask<Response728> Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response728> Mediator.IRequestHandler<Request728, Response728>.Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response728> MediatR.IRequestHandler<Request728, Response728>.Handle(
		Request728 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request729(long Id) : Mediator.IRequest<Response729>, MediatR.IRequest<Response729>;

public record struct Response729(long Id);

[Handler]
public sealed partial class Request729Handler
	: Mediator.IRequestHandler<Request729, Response729>,
	MediatR.IRequestHandler<Request729, Response729>
{
	private static ValueTask<Response729> Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response729> Mediator.IRequestHandler<Request729, Response729>.Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response729> MediatR.IRequestHandler<Request729, Response729>.Handle(
		Request729 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request730(long Id) : Mediator.IRequest<Response730>, MediatR.IRequest<Response730>;

public record struct Response730(long Id);

[Handler]
public sealed partial class Request730Handler
	: Mediator.IRequestHandler<Request730, Response730>,
	MediatR.IRequestHandler<Request730, Response730>
{
	private static ValueTask<Response730> Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response730> Mediator.IRequestHandler<Request730, Response730>.Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response730> MediatR.IRequestHandler<Request730, Response730>.Handle(
		Request730 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request731(long Id) : Mediator.IRequest<Response731>, MediatR.IRequest<Response731>;

public record struct Response731(long Id);

[Handler]
public sealed partial class Request731Handler
	: Mediator.IRequestHandler<Request731, Response731>,
	MediatR.IRequestHandler<Request731, Response731>
{
	private static ValueTask<Response731> Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response731> Mediator.IRequestHandler<Request731, Response731>.Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response731> MediatR.IRequestHandler<Request731, Response731>.Handle(
		Request731 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request732(long Id) : Mediator.IRequest<Response732>, MediatR.IRequest<Response732>;

public record struct Response732(long Id);

[Handler]
public sealed partial class Request732Handler
	: Mediator.IRequestHandler<Request732, Response732>,
	MediatR.IRequestHandler<Request732, Response732>
{
	private static ValueTask<Response732> Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response732> Mediator.IRequestHandler<Request732, Response732>.Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response732> MediatR.IRequestHandler<Request732, Response732>.Handle(
		Request732 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request733(long Id) : Mediator.IRequest<Response733>, MediatR.IRequest<Response733>;

public record struct Response733(long Id);

[Handler]
public sealed partial class Request733Handler
	: Mediator.IRequestHandler<Request733, Response733>,
	MediatR.IRequestHandler<Request733, Response733>
{
	private static ValueTask<Response733> Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response733> Mediator.IRequestHandler<Request733, Response733>.Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response733> MediatR.IRequestHandler<Request733, Response733>.Handle(
		Request733 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request734(long Id) : Mediator.IRequest<Response734>, MediatR.IRequest<Response734>;

public record struct Response734(long Id);

[Handler]
public sealed partial class Request734Handler
	: Mediator.IRequestHandler<Request734, Response734>,
	MediatR.IRequestHandler<Request734, Response734>
{
	private static ValueTask<Response734> Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response734> Mediator.IRequestHandler<Request734, Response734>.Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response734> MediatR.IRequestHandler<Request734, Response734>.Handle(
		Request734 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request735(long Id) : Mediator.IRequest<Response735>, MediatR.IRequest<Response735>;

public record struct Response735(long Id);

[Handler]
public sealed partial class Request735Handler
	: Mediator.IRequestHandler<Request735, Response735>,
	MediatR.IRequestHandler<Request735, Response735>
{
	private static ValueTask<Response735> Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response735> Mediator.IRequestHandler<Request735, Response735>.Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response735> MediatR.IRequestHandler<Request735, Response735>.Handle(
		Request735 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request736(long Id) : Mediator.IRequest<Response736>, MediatR.IRequest<Response736>;

public record struct Response736(long Id);

[Handler]
public sealed partial class Request736Handler
	: Mediator.IRequestHandler<Request736, Response736>,
	MediatR.IRequestHandler<Request736, Response736>
{
	private static ValueTask<Response736> Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response736> Mediator.IRequestHandler<Request736, Response736>.Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response736> MediatR.IRequestHandler<Request736, Response736>.Handle(
		Request736 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request737(long Id) : Mediator.IRequest<Response737>, MediatR.IRequest<Response737>;

public record struct Response737(long Id);

[Handler]
public sealed partial class Request737Handler
	: Mediator.IRequestHandler<Request737, Response737>,
	MediatR.IRequestHandler<Request737, Response737>
{
	private static ValueTask<Response737> Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response737> Mediator.IRequestHandler<Request737, Response737>.Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response737> MediatR.IRequestHandler<Request737, Response737>.Handle(
		Request737 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request738(long Id) : Mediator.IRequest<Response738>, MediatR.IRequest<Response738>;

public record struct Response738(long Id);

[Handler]
public sealed partial class Request738Handler
	: Mediator.IRequestHandler<Request738, Response738>,
	MediatR.IRequestHandler<Request738, Response738>
{
	private static ValueTask<Response738> Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response738> Mediator.IRequestHandler<Request738, Response738>.Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response738> MediatR.IRequestHandler<Request738, Response738>.Handle(
		Request738 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request739(long Id) : Mediator.IRequest<Response739>, MediatR.IRequest<Response739>;

public record struct Response739(long Id);

[Handler]
public sealed partial class Request739Handler
	: Mediator.IRequestHandler<Request739, Response739>,
	MediatR.IRequestHandler<Request739, Response739>
{
	private static ValueTask<Response739> Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response739> Mediator.IRequestHandler<Request739, Response739>.Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response739> MediatR.IRequestHandler<Request739, Response739>.Handle(
		Request739 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request740(long Id) : Mediator.IRequest<Response740>, MediatR.IRequest<Response740>;

public record struct Response740(long Id);

[Handler]
public sealed partial class Request740Handler
	: Mediator.IRequestHandler<Request740, Response740>,
	MediatR.IRequestHandler<Request740, Response740>
{
	private static ValueTask<Response740> Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response740> Mediator.IRequestHandler<Request740, Response740>.Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response740> MediatR.IRequestHandler<Request740, Response740>.Handle(
		Request740 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request741(long Id) : Mediator.IRequest<Response741>, MediatR.IRequest<Response741>;

public record struct Response741(long Id);

[Handler]
public sealed partial class Request741Handler
	: Mediator.IRequestHandler<Request741, Response741>,
	MediatR.IRequestHandler<Request741, Response741>
{
	private static ValueTask<Response741> Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response741> Mediator.IRequestHandler<Request741, Response741>.Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response741> MediatR.IRequestHandler<Request741, Response741>.Handle(
		Request741 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request742(long Id) : Mediator.IRequest<Response742>, MediatR.IRequest<Response742>;

public record struct Response742(long Id);

[Handler]
public sealed partial class Request742Handler
	: Mediator.IRequestHandler<Request742, Response742>,
	MediatR.IRequestHandler<Request742, Response742>
{
	private static ValueTask<Response742> Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response742> Mediator.IRequestHandler<Request742, Response742>.Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response742> MediatR.IRequestHandler<Request742, Response742>.Handle(
		Request742 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request743(long Id) : Mediator.IRequest<Response743>, MediatR.IRequest<Response743>;

public record struct Response743(long Id);

[Handler]
public sealed partial class Request743Handler
	: Mediator.IRequestHandler<Request743, Response743>,
	MediatR.IRequestHandler<Request743, Response743>
{
	private static ValueTask<Response743> Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response743> Mediator.IRequestHandler<Request743, Response743>.Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response743> MediatR.IRequestHandler<Request743, Response743>.Handle(
		Request743 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request744(long Id) : Mediator.IRequest<Response744>, MediatR.IRequest<Response744>;

public record struct Response744(long Id);

[Handler]
public sealed partial class Request744Handler
	: Mediator.IRequestHandler<Request744, Response744>,
	MediatR.IRequestHandler<Request744, Response744>
{
	private static ValueTask<Response744> Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response744> Mediator.IRequestHandler<Request744, Response744>.Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response744> MediatR.IRequestHandler<Request744, Response744>.Handle(
		Request744 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request745(long Id) : Mediator.IRequest<Response745>, MediatR.IRequest<Response745>;

public record struct Response745(long Id);

[Handler]
public sealed partial class Request745Handler
	: Mediator.IRequestHandler<Request745, Response745>,
	MediatR.IRequestHandler<Request745, Response745>
{
	private static ValueTask<Response745> Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response745> Mediator.IRequestHandler<Request745, Response745>.Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response745> MediatR.IRequestHandler<Request745, Response745>.Handle(
		Request745 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request746(long Id) : Mediator.IRequest<Response746>, MediatR.IRequest<Response746>;

public record struct Response746(long Id);

[Handler]
public sealed partial class Request746Handler
	: Mediator.IRequestHandler<Request746, Response746>,
	MediatR.IRequestHandler<Request746, Response746>
{
	private static ValueTask<Response746> Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response746> Mediator.IRequestHandler<Request746, Response746>.Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response746> MediatR.IRequestHandler<Request746, Response746>.Handle(
		Request746 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request747(long Id) : Mediator.IRequest<Response747>, MediatR.IRequest<Response747>;

public record struct Response747(long Id);

[Handler]
public sealed partial class Request747Handler
	: Mediator.IRequestHandler<Request747, Response747>,
	MediatR.IRequestHandler<Request747, Response747>
{
	private static ValueTask<Response747> Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response747> Mediator.IRequestHandler<Request747, Response747>.Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response747> MediatR.IRequestHandler<Request747, Response747>.Handle(
		Request747 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request748(long Id) : Mediator.IRequest<Response748>, MediatR.IRequest<Response748>;

public record struct Response748(long Id);

[Handler]
public sealed partial class Request748Handler
	: Mediator.IRequestHandler<Request748, Response748>,
	MediatR.IRequestHandler<Request748, Response748>
{
	private static ValueTask<Response748> Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response748> Mediator.IRequestHandler<Request748, Response748>.Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response748> MediatR.IRequestHandler<Request748, Response748>.Handle(
		Request748 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request749(long Id) : Mediator.IRequest<Response749>, MediatR.IRequest<Response749>;

public record struct Response749(long Id);

[Handler]
public sealed partial class Request749Handler
	: Mediator.IRequestHandler<Request749, Response749>,
	MediatR.IRequestHandler<Request749, Response749>
{
	private static ValueTask<Response749> Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response749> Mediator.IRequestHandler<Request749, Response749>.Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response749> MediatR.IRequestHandler<Request749, Response749>.Handle(
		Request749 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request750(long Id) : Mediator.IRequest<Response750>, MediatR.IRequest<Response750>;

public record struct Response750(long Id);

[Handler]
public sealed partial class Request750Handler
	: Mediator.IRequestHandler<Request750, Response750>,
	MediatR.IRequestHandler<Request750, Response750>
{
	private static ValueTask<Response750> Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response750> Mediator.IRequestHandler<Request750, Response750>.Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response750> MediatR.IRequestHandler<Request750, Response750>.Handle(
		Request750 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request751(long Id) : Mediator.IRequest<Response751>, MediatR.IRequest<Response751>;

public record struct Response751(long Id);

[Handler]
public sealed partial class Request751Handler
	: Mediator.IRequestHandler<Request751, Response751>,
	MediatR.IRequestHandler<Request751, Response751>
{
	private static ValueTask<Response751> Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response751> Mediator.IRequestHandler<Request751, Response751>.Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response751> MediatR.IRequestHandler<Request751, Response751>.Handle(
		Request751 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request752(long Id) : Mediator.IRequest<Response752>, MediatR.IRequest<Response752>;

public record struct Response752(long Id);

[Handler]
public sealed partial class Request752Handler
	: Mediator.IRequestHandler<Request752, Response752>,
	MediatR.IRequestHandler<Request752, Response752>
{
	private static ValueTask<Response752> Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response752> Mediator.IRequestHandler<Request752, Response752>.Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response752> MediatR.IRequestHandler<Request752, Response752>.Handle(
		Request752 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request753(long Id) : Mediator.IRequest<Response753>, MediatR.IRequest<Response753>;

public record struct Response753(long Id);

[Handler]
public sealed partial class Request753Handler
	: Mediator.IRequestHandler<Request753, Response753>,
	MediatR.IRequestHandler<Request753, Response753>
{
	private static ValueTask<Response753> Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response753> Mediator.IRequestHandler<Request753, Response753>.Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response753> MediatR.IRequestHandler<Request753, Response753>.Handle(
		Request753 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request754(long Id) : Mediator.IRequest<Response754>, MediatR.IRequest<Response754>;

public record struct Response754(long Id);

[Handler]
public sealed partial class Request754Handler
	: Mediator.IRequestHandler<Request754, Response754>,
	MediatR.IRequestHandler<Request754, Response754>
{
	private static ValueTask<Response754> Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response754> Mediator.IRequestHandler<Request754, Response754>.Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response754> MediatR.IRequestHandler<Request754, Response754>.Handle(
		Request754 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request755(long Id) : Mediator.IRequest<Response755>, MediatR.IRequest<Response755>;

public record struct Response755(long Id);

[Handler]
public sealed partial class Request755Handler
	: Mediator.IRequestHandler<Request755, Response755>,
	MediatR.IRequestHandler<Request755, Response755>
{
	private static ValueTask<Response755> Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response755> Mediator.IRequestHandler<Request755, Response755>.Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response755> MediatR.IRequestHandler<Request755, Response755>.Handle(
		Request755 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request756(long Id) : Mediator.IRequest<Response756>, MediatR.IRequest<Response756>;

public record struct Response756(long Id);

[Handler]
public sealed partial class Request756Handler
	: Mediator.IRequestHandler<Request756, Response756>,
	MediatR.IRequestHandler<Request756, Response756>
{
	private static ValueTask<Response756> Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response756> Mediator.IRequestHandler<Request756, Response756>.Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response756> MediatR.IRequestHandler<Request756, Response756>.Handle(
		Request756 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request757(long Id) : Mediator.IRequest<Response757>, MediatR.IRequest<Response757>;

public record struct Response757(long Id);

[Handler]
public sealed partial class Request757Handler
	: Mediator.IRequestHandler<Request757, Response757>,
	MediatR.IRequestHandler<Request757, Response757>
{
	private static ValueTask<Response757> Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response757> Mediator.IRequestHandler<Request757, Response757>.Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response757> MediatR.IRequestHandler<Request757, Response757>.Handle(
		Request757 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request758(long Id) : Mediator.IRequest<Response758>, MediatR.IRequest<Response758>;

public record struct Response758(long Id);

[Handler]
public sealed partial class Request758Handler
	: Mediator.IRequestHandler<Request758, Response758>,
	MediatR.IRequestHandler<Request758, Response758>
{
	private static ValueTask<Response758> Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response758> Mediator.IRequestHandler<Request758, Response758>.Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response758> MediatR.IRequestHandler<Request758, Response758>.Handle(
		Request758 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request759(long Id) : Mediator.IRequest<Response759>, MediatR.IRequest<Response759>;

public record struct Response759(long Id);

[Handler]
public sealed partial class Request759Handler
	: Mediator.IRequestHandler<Request759, Response759>,
	MediatR.IRequestHandler<Request759, Response759>
{
	private static ValueTask<Response759> Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response759> Mediator.IRequestHandler<Request759, Response759>.Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response759> MediatR.IRequestHandler<Request759, Response759>.Handle(
		Request759 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request760(long Id) : Mediator.IRequest<Response760>, MediatR.IRequest<Response760>;

public record struct Response760(long Id);

[Handler]
public sealed partial class Request760Handler
	: Mediator.IRequestHandler<Request760, Response760>,
	MediatR.IRequestHandler<Request760, Response760>
{
	private static ValueTask<Response760> Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response760> Mediator.IRequestHandler<Request760, Response760>.Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response760> MediatR.IRequestHandler<Request760, Response760>.Handle(
		Request760 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request761(long Id) : Mediator.IRequest<Response761>, MediatR.IRequest<Response761>;

public record struct Response761(long Id);

[Handler]
public sealed partial class Request761Handler
	: Mediator.IRequestHandler<Request761, Response761>,
	MediatR.IRequestHandler<Request761, Response761>
{
	private static ValueTask<Response761> Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response761> Mediator.IRequestHandler<Request761, Response761>.Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response761> MediatR.IRequestHandler<Request761, Response761>.Handle(
		Request761 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request762(long Id) : Mediator.IRequest<Response762>, MediatR.IRequest<Response762>;

public record struct Response762(long Id);

[Handler]
public sealed partial class Request762Handler
	: Mediator.IRequestHandler<Request762, Response762>,
	MediatR.IRequestHandler<Request762, Response762>
{
	private static ValueTask<Response762> Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response762> Mediator.IRequestHandler<Request762, Response762>.Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response762> MediatR.IRequestHandler<Request762, Response762>.Handle(
		Request762 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request763(long Id) : Mediator.IRequest<Response763>, MediatR.IRequest<Response763>;

public record struct Response763(long Id);

[Handler]
public sealed partial class Request763Handler
	: Mediator.IRequestHandler<Request763, Response763>,
	MediatR.IRequestHandler<Request763, Response763>
{
	private static ValueTask<Response763> Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response763> Mediator.IRequestHandler<Request763, Response763>.Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response763> MediatR.IRequestHandler<Request763, Response763>.Handle(
		Request763 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request764(long Id) : Mediator.IRequest<Response764>, MediatR.IRequest<Response764>;

public record struct Response764(long Id);

[Handler]
public sealed partial class Request764Handler
	: Mediator.IRequestHandler<Request764, Response764>,
	MediatR.IRequestHandler<Request764, Response764>
{
	private static ValueTask<Response764> Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response764> Mediator.IRequestHandler<Request764, Response764>.Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response764> MediatR.IRequestHandler<Request764, Response764>.Handle(
		Request764 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request765(long Id) : Mediator.IRequest<Response765>, MediatR.IRequest<Response765>;

public record struct Response765(long Id);

[Handler]
public sealed partial class Request765Handler
	: Mediator.IRequestHandler<Request765, Response765>,
	MediatR.IRequestHandler<Request765, Response765>
{
	private static ValueTask<Response765> Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response765> Mediator.IRequestHandler<Request765, Response765>.Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response765> MediatR.IRequestHandler<Request765, Response765>.Handle(
		Request765 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request766(long Id) : Mediator.IRequest<Response766>, MediatR.IRequest<Response766>;

public record struct Response766(long Id);

[Handler]
public sealed partial class Request766Handler
	: Mediator.IRequestHandler<Request766, Response766>,
	MediatR.IRequestHandler<Request766, Response766>
{
	private static ValueTask<Response766> Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response766> Mediator.IRequestHandler<Request766, Response766>.Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response766> MediatR.IRequestHandler<Request766, Response766>.Handle(
		Request766 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request767(long Id) : Mediator.IRequest<Response767>, MediatR.IRequest<Response767>;

public record struct Response767(long Id);

[Handler]
public sealed partial class Request767Handler
	: Mediator.IRequestHandler<Request767, Response767>,
	MediatR.IRequestHandler<Request767, Response767>
{
	private static ValueTask<Response767> Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response767> Mediator.IRequestHandler<Request767, Response767>.Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response767> MediatR.IRequestHandler<Request767, Response767>.Handle(
		Request767 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request768(long Id) : Mediator.IRequest<Response768>, MediatR.IRequest<Response768>;

public record struct Response768(long Id);

[Handler]
public sealed partial class Request768Handler
	: Mediator.IRequestHandler<Request768, Response768>,
	MediatR.IRequestHandler<Request768, Response768>
{
	private static ValueTask<Response768> Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response768> Mediator.IRequestHandler<Request768, Response768>.Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response768> MediatR.IRequestHandler<Request768, Response768>.Handle(
		Request768 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request769(long Id) : Mediator.IRequest<Response769>, MediatR.IRequest<Response769>;

public record struct Response769(long Id);

[Handler]
public sealed partial class Request769Handler
	: Mediator.IRequestHandler<Request769, Response769>,
	MediatR.IRequestHandler<Request769, Response769>
{
	private static ValueTask<Response769> Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response769> Mediator.IRequestHandler<Request769, Response769>.Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response769> MediatR.IRequestHandler<Request769, Response769>.Handle(
		Request769 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request770(long Id) : Mediator.IRequest<Response770>, MediatR.IRequest<Response770>;

public record struct Response770(long Id);

[Handler]
public sealed partial class Request770Handler
	: Mediator.IRequestHandler<Request770, Response770>,
	MediatR.IRequestHandler<Request770, Response770>
{
	private static ValueTask<Response770> Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response770> Mediator.IRequestHandler<Request770, Response770>.Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response770> MediatR.IRequestHandler<Request770, Response770>.Handle(
		Request770 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request771(long Id) : Mediator.IRequest<Response771>, MediatR.IRequest<Response771>;

public record struct Response771(long Id);

[Handler]
public sealed partial class Request771Handler
	: Mediator.IRequestHandler<Request771, Response771>,
	MediatR.IRequestHandler<Request771, Response771>
{
	private static ValueTask<Response771> Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response771> Mediator.IRequestHandler<Request771, Response771>.Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response771> MediatR.IRequestHandler<Request771, Response771>.Handle(
		Request771 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request772(long Id) : Mediator.IRequest<Response772>, MediatR.IRequest<Response772>;

public record struct Response772(long Id);

[Handler]
public sealed partial class Request772Handler
	: Mediator.IRequestHandler<Request772, Response772>,
	MediatR.IRequestHandler<Request772, Response772>
{
	private static ValueTask<Response772> Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response772> Mediator.IRequestHandler<Request772, Response772>.Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response772> MediatR.IRequestHandler<Request772, Response772>.Handle(
		Request772 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request773(long Id) : Mediator.IRequest<Response773>, MediatR.IRequest<Response773>;

public record struct Response773(long Id);

[Handler]
public sealed partial class Request773Handler
	: Mediator.IRequestHandler<Request773, Response773>,
	MediatR.IRequestHandler<Request773, Response773>
{
	private static ValueTask<Response773> Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response773> Mediator.IRequestHandler<Request773, Response773>.Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response773> MediatR.IRequestHandler<Request773, Response773>.Handle(
		Request773 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request774(long Id) : Mediator.IRequest<Response774>, MediatR.IRequest<Response774>;

public record struct Response774(long Id);

[Handler]
public sealed partial class Request774Handler
	: Mediator.IRequestHandler<Request774, Response774>,
	MediatR.IRequestHandler<Request774, Response774>
{
	private static ValueTask<Response774> Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response774> Mediator.IRequestHandler<Request774, Response774>.Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response774> MediatR.IRequestHandler<Request774, Response774>.Handle(
		Request774 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request775(long Id) : Mediator.IRequest<Response775>, MediatR.IRequest<Response775>;

public record struct Response775(long Id);

[Handler]
public sealed partial class Request775Handler
	: Mediator.IRequestHandler<Request775, Response775>,
	MediatR.IRequestHandler<Request775, Response775>
{
	private static ValueTask<Response775> Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response775> Mediator.IRequestHandler<Request775, Response775>.Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response775> MediatR.IRequestHandler<Request775, Response775>.Handle(
		Request775 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request776(long Id) : Mediator.IRequest<Response776>, MediatR.IRequest<Response776>;

public record struct Response776(long Id);

[Handler]
public sealed partial class Request776Handler
	: Mediator.IRequestHandler<Request776, Response776>,
	MediatR.IRequestHandler<Request776, Response776>
{
	private static ValueTask<Response776> Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response776> Mediator.IRequestHandler<Request776, Response776>.Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response776> MediatR.IRequestHandler<Request776, Response776>.Handle(
		Request776 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request777(long Id) : Mediator.IRequest<Response777>, MediatR.IRequest<Response777>;

public record struct Response777(long Id);

[Handler]
public sealed partial class Request777Handler
	: Mediator.IRequestHandler<Request777, Response777>,
	MediatR.IRequestHandler<Request777, Response777>
{
	private static ValueTask<Response777> Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response777> Mediator.IRequestHandler<Request777, Response777>.Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response777> MediatR.IRequestHandler<Request777, Response777>.Handle(
		Request777 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request778(long Id) : Mediator.IRequest<Response778>, MediatR.IRequest<Response778>;

public record struct Response778(long Id);

[Handler]
public sealed partial class Request778Handler
	: Mediator.IRequestHandler<Request778, Response778>,
	MediatR.IRequestHandler<Request778, Response778>
{
	private static ValueTask<Response778> Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response778> Mediator.IRequestHandler<Request778, Response778>.Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response778> MediatR.IRequestHandler<Request778, Response778>.Handle(
		Request778 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request779(long Id) : Mediator.IRequest<Response779>, MediatR.IRequest<Response779>;

public record struct Response779(long Id);

[Handler]
public sealed partial class Request779Handler
	: Mediator.IRequestHandler<Request779, Response779>,
	MediatR.IRequestHandler<Request779, Response779>
{
	private static ValueTask<Response779> Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response779> Mediator.IRequestHandler<Request779, Response779>.Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response779> MediatR.IRequestHandler<Request779, Response779>.Handle(
		Request779 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request780(long Id) : Mediator.IRequest<Response780>, MediatR.IRequest<Response780>;

public record struct Response780(long Id);

[Handler]
public sealed partial class Request780Handler
	: Mediator.IRequestHandler<Request780, Response780>,
	MediatR.IRequestHandler<Request780, Response780>
{
	private static ValueTask<Response780> Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response780> Mediator.IRequestHandler<Request780, Response780>.Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response780> MediatR.IRequestHandler<Request780, Response780>.Handle(
		Request780 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request781(long Id) : Mediator.IRequest<Response781>, MediatR.IRequest<Response781>;

public record struct Response781(long Id);

[Handler]
public sealed partial class Request781Handler
	: Mediator.IRequestHandler<Request781, Response781>,
	MediatR.IRequestHandler<Request781, Response781>
{
	private static ValueTask<Response781> Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response781> Mediator.IRequestHandler<Request781, Response781>.Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response781> MediatR.IRequestHandler<Request781, Response781>.Handle(
		Request781 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request782(long Id) : Mediator.IRequest<Response782>, MediatR.IRequest<Response782>;

public record struct Response782(long Id);

[Handler]
public sealed partial class Request782Handler
	: Mediator.IRequestHandler<Request782, Response782>,
	MediatR.IRequestHandler<Request782, Response782>
{
	private static ValueTask<Response782> Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response782> Mediator.IRequestHandler<Request782, Response782>.Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response782> MediatR.IRequestHandler<Request782, Response782>.Handle(
		Request782 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request783(long Id) : Mediator.IRequest<Response783>, MediatR.IRequest<Response783>;

public record struct Response783(long Id);

[Handler]
public sealed partial class Request783Handler
	: Mediator.IRequestHandler<Request783, Response783>,
	MediatR.IRequestHandler<Request783, Response783>
{
	private static ValueTask<Response783> Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response783> Mediator.IRequestHandler<Request783, Response783>.Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response783> MediatR.IRequestHandler<Request783, Response783>.Handle(
		Request783 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request784(long Id) : Mediator.IRequest<Response784>, MediatR.IRequest<Response784>;

public record struct Response784(long Id);

[Handler]
public sealed partial class Request784Handler
	: Mediator.IRequestHandler<Request784, Response784>,
	MediatR.IRequestHandler<Request784, Response784>
{
	private static ValueTask<Response784> Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response784> Mediator.IRequestHandler<Request784, Response784>.Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response784> MediatR.IRequestHandler<Request784, Response784>.Handle(
		Request784 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request785(long Id) : Mediator.IRequest<Response785>, MediatR.IRequest<Response785>;

public record struct Response785(long Id);

[Handler]
public sealed partial class Request785Handler
	: Mediator.IRequestHandler<Request785, Response785>,
	MediatR.IRequestHandler<Request785, Response785>
{
	private static ValueTask<Response785> Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response785> Mediator.IRequestHandler<Request785, Response785>.Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response785> MediatR.IRequestHandler<Request785, Response785>.Handle(
		Request785 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request786(long Id) : Mediator.IRequest<Response786>, MediatR.IRequest<Response786>;

public record struct Response786(long Id);

[Handler]
public sealed partial class Request786Handler
	: Mediator.IRequestHandler<Request786, Response786>,
	MediatR.IRequestHandler<Request786, Response786>
{
	private static ValueTask<Response786> Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response786> Mediator.IRequestHandler<Request786, Response786>.Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response786> MediatR.IRequestHandler<Request786, Response786>.Handle(
		Request786 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request787(long Id) : Mediator.IRequest<Response787>, MediatR.IRequest<Response787>;

public record struct Response787(long Id);

[Handler]
public sealed partial class Request787Handler
	: Mediator.IRequestHandler<Request787, Response787>,
	MediatR.IRequestHandler<Request787, Response787>
{
	private static ValueTask<Response787> Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response787> Mediator.IRequestHandler<Request787, Response787>.Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response787> MediatR.IRequestHandler<Request787, Response787>.Handle(
		Request787 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request788(long Id) : Mediator.IRequest<Response788>, MediatR.IRequest<Response788>;

public record struct Response788(long Id);

[Handler]
public sealed partial class Request788Handler
	: Mediator.IRequestHandler<Request788, Response788>,
	MediatR.IRequestHandler<Request788, Response788>
{
	private static ValueTask<Response788> Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response788> Mediator.IRequestHandler<Request788, Response788>.Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response788> MediatR.IRequestHandler<Request788, Response788>.Handle(
		Request788 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request789(long Id) : Mediator.IRequest<Response789>, MediatR.IRequest<Response789>;

public record struct Response789(long Id);

[Handler]
public sealed partial class Request789Handler
	: Mediator.IRequestHandler<Request789, Response789>,
	MediatR.IRequestHandler<Request789, Response789>
{
	private static ValueTask<Response789> Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response789> Mediator.IRequestHandler<Request789, Response789>.Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response789> MediatR.IRequestHandler<Request789, Response789>.Handle(
		Request789 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request790(long Id) : Mediator.IRequest<Response790>, MediatR.IRequest<Response790>;

public record struct Response790(long Id);

[Handler]
public sealed partial class Request790Handler
	: Mediator.IRequestHandler<Request790, Response790>,
	MediatR.IRequestHandler<Request790, Response790>
{
	private static ValueTask<Response790> Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response790> Mediator.IRequestHandler<Request790, Response790>.Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response790> MediatR.IRequestHandler<Request790, Response790>.Handle(
		Request790 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request791(long Id) : Mediator.IRequest<Response791>, MediatR.IRequest<Response791>;

public record struct Response791(long Id);

[Handler]
public sealed partial class Request791Handler
	: Mediator.IRequestHandler<Request791, Response791>,
	MediatR.IRequestHandler<Request791, Response791>
{
	private static ValueTask<Response791> Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response791> Mediator.IRequestHandler<Request791, Response791>.Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response791> MediatR.IRequestHandler<Request791, Response791>.Handle(
		Request791 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request792(long Id) : Mediator.IRequest<Response792>, MediatR.IRequest<Response792>;

public record struct Response792(long Id);

[Handler]
public sealed partial class Request792Handler
	: Mediator.IRequestHandler<Request792, Response792>,
	MediatR.IRequestHandler<Request792, Response792>
{
	private static ValueTask<Response792> Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response792> Mediator.IRequestHandler<Request792, Response792>.Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response792> MediatR.IRequestHandler<Request792, Response792>.Handle(
		Request792 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request793(long Id) : Mediator.IRequest<Response793>, MediatR.IRequest<Response793>;

public record struct Response793(long Id);

[Handler]
public sealed partial class Request793Handler
	: Mediator.IRequestHandler<Request793, Response793>,
	MediatR.IRequestHandler<Request793, Response793>
{
	private static ValueTask<Response793> Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response793> Mediator.IRequestHandler<Request793, Response793>.Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response793> MediatR.IRequestHandler<Request793, Response793>.Handle(
		Request793 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request794(long Id) : Mediator.IRequest<Response794>, MediatR.IRequest<Response794>;

public record struct Response794(long Id);

[Handler]
public sealed partial class Request794Handler
	: Mediator.IRequestHandler<Request794, Response794>,
	MediatR.IRequestHandler<Request794, Response794>
{
	private static ValueTask<Response794> Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response794> Mediator.IRequestHandler<Request794, Response794>.Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response794> MediatR.IRequestHandler<Request794, Response794>.Handle(
		Request794 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request795(long Id) : Mediator.IRequest<Response795>, MediatR.IRequest<Response795>;

public record struct Response795(long Id);

[Handler]
public sealed partial class Request795Handler
	: Mediator.IRequestHandler<Request795, Response795>,
	MediatR.IRequestHandler<Request795, Response795>
{
	private static ValueTask<Response795> Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response795> Mediator.IRequestHandler<Request795, Response795>.Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response795> MediatR.IRequestHandler<Request795, Response795>.Handle(
		Request795 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request796(long Id) : Mediator.IRequest<Response796>, MediatR.IRequest<Response796>;

public record struct Response796(long Id);

[Handler]
public sealed partial class Request796Handler
	: Mediator.IRequestHandler<Request796, Response796>,
	MediatR.IRequestHandler<Request796, Response796>
{
	private static ValueTask<Response796> Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response796> Mediator.IRequestHandler<Request796, Response796>.Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response796> MediatR.IRequestHandler<Request796, Response796>.Handle(
		Request796 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request797(long Id) : Mediator.IRequest<Response797>, MediatR.IRequest<Response797>;

public record struct Response797(long Id);

[Handler]
public sealed partial class Request797Handler
	: Mediator.IRequestHandler<Request797, Response797>,
	MediatR.IRequestHandler<Request797, Response797>
{
	private static ValueTask<Response797> Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response797> Mediator.IRequestHandler<Request797, Response797>.Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response797> MediatR.IRequestHandler<Request797, Response797>.Handle(
		Request797 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request798(long Id) : Mediator.IRequest<Response798>, MediatR.IRequest<Response798>;

public record struct Response798(long Id);

[Handler]
public sealed partial class Request798Handler
	: Mediator.IRequestHandler<Request798, Response798>,
	MediatR.IRequestHandler<Request798, Response798>
{
	private static ValueTask<Response798> Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response798> Mediator.IRequestHandler<Request798, Response798>.Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response798> MediatR.IRequestHandler<Request798, Response798>.Handle(
		Request798 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request799(long Id) : Mediator.IRequest<Response799>, MediatR.IRequest<Response799>;

public record struct Response799(long Id);

[Handler]
public sealed partial class Request799Handler
	: Mediator.IRequestHandler<Request799, Response799>,
	MediatR.IRequestHandler<Request799, Response799>
{
	private static ValueTask<Response799> Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response799> Mediator.IRequestHandler<Request799, Response799>.Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response799> MediatR.IRequestHandler<Request799, Response799>.Handle(
		Request799 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request800(long Id) : Mediator.IRequest<Response800>, MediatR.IRequest<Response800>;

public record struct Response800(long Id);

[Handler]
public sealed partial class Request800Handler
	: Mediator.IRequestHandler<Request800, Response800>,
	MediatR.IRequestHandler<Request800, Response800>
{
	private static ValueTask<Response800> Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response800> Mediator.IRequestHandler<Request800, Response800>.Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response800> MediatR.IRequestHandler<Request800, Response800>.Handle(
		Request800 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request801(long Id) : Mediator.IRequest<Response801>, MediatR.IRequest<Response801>;

public record struct Response801(long Id);

[Handler]
public sealed partial class Request801Handler
	: Mediator.IRequestHandler<Request801, Response801>,
	MediatR.IRequestHandler<Request801, Response801>
{
	private static ValueTask<Response801> Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response801> Mediator.IRequestHandler<Request801, Response801>.Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response801> MediatR.IRequestHandler<Request801, Response801>.Handle(
		Request801 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request802(long Id) : Mediator.IRequest<Response802>, MediatR.IRequest<Response802>;

public record struct Response802(long Id);

[Handler]
public sealed partial class Request802Handler
	: Mediator.IRequestHandler<Request802, Response802>,
	MediatR.IRequestHandler<Request802, Response802>
{
	private static ValueTask<Response802> Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response802> Mediator.IRequestHandler<Request802, Response802>.Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response802> MediatR.IRequestHandler<Request802, Response802>.Handle(
		Request802 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request803(long Id) : Mediator.IRequest<Response803>, MediatR.IRequest<Response803>;

public record struct Response803(long Id);

[Handler]
public sealed partial class Request803Handler
	: Mediator.IRequestHandler<Request803, Response803>,
	MediatR.IRequestHandler<Request803, Response803>
{
	private static ValueTask<Response803> Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response803> Mediator.IRequestHandler<Request803, Response803>.Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response803> MediatR.IRequestHandler<Request803, Response803>.Handle(
		Request803 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request804(long Id) : Mediator.IRequest<Response804>, MediatR.IRequest<Response804>;

public record struct Response804(long Id);

[Handler]
public sealed partial class Request804Handler
	: Mediator.IRequestHandler<Request804, Response804>,
	MediatR.IRequestHandler<Request804, Response804>
{
	private static ValueTask<Response804> Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response804> Mediator.IRequestHandler<Request804, Response804>.Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response804> MediatR.IRequestHandler<Request804, Response804>.Handle(
		Request804 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request805(long Id) : Mediator.IRequest<Response805>, MediatR.IRequest<Response805>;

public record struct Response805(long Id);

[Handler]
public sealed partial class Request805Handler
	: Mediator.IRequestHandler<Request805, Response805>,
	MediatR.IRequestHandler<Request805, Response805>
{
	private static ValueTask<Response805> Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response805> Mediator.IRequestHandler<Request805, Response805>.Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response805> MediatR.IRequestHandler<Request805, Response805>.Handle(
		Request805 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request806(long Id) : Mediator.IRequest<Response806>, MediatR.IRequest<Response806>;

public record struct Response806(long Id);

[Handler]
public sealed partial class Request806Handler
	: Mediator.IRequestHandler<Request806, Response806>,
	MediatR.IRequestHandler<Request806, Response806>
{
	private static ValueTask<Response806> Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response806> Mediator.IRequestHandler<Request806, Response806>.Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response806> MediatR.IRequestHandler<Request806, Response806>.Handle(
		Request806 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request807(long Id) : Mediator.IRequest<Response807>, MediatR.IRequest<Response807>;

public record struct Response807(long Id);

[Handler]
public sealed partial class Request807Handler
	: Mediator.IRequestHandler<Request807, Response807>,
	MediatR.IRequestHandler<Request807, Response807>
{
	private static ValueTask<Response807> Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response807> Mediator.IRequestHandler<Request807, Response807>.Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response807> MediatR.IRequestHandler<Request807, Response807>.Handle(
		Request807 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request808(long Id) : Mediator.IRequest<Response808>, MediatR.IRequest<Response808>;

public record struct Response808(long Id);

[Handler]
public sealed partial class Request808Handler
	: Mediator.IRequestHandler<Request808, Response808>,
	MediatR.IRequestHandler<Request808, Response808>
{
	private static ValueTask<Response808> Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response808> Mediator.IRequestHandler<Request808, Response808>.Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response808> MediatR.IRequestHandler<Request808, Response808>.Handle(
		Request808 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request809(long Id) : Mediator.IRequest<Response809>, MediatR.IRequest<Response809>;

public record struct Response809(long Id);

[Handler]
public sealed partial class Request809Handler
	: Mediator.IRequestHandler<Request809, Response809>,
	MediatR.IRequestHandler<Request809, Response809>
{
	private static ValueTask<Response809> Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response809> Mediator.IRequestHandler<Request809, Response809>.Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response809> MediatR.IRequestHandler<Request809, Response809>.Handle(
		Request809 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request810(long Id) : Mediator.IRequest<Response810>, MediatR.IRequest<Response810>;

public record struct Response810(long Id);

[Handler]
public sealed partial class Request810Handler
	: Mediator.IRequestHandler<Request810, Response810>,
	MediatR.IRequestHandler<Request810, Response810>
{
	private static ValueTask<Response810> Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response810> Mediator.IRequestHandler<Request810, Response810>.Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response810> MediatR.IRequestHandler<Request810, Response810>.Handle(
		Request810 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request811(long Id) : Mediator.IRequest<Response811>, MediatR.IRequest<Response811>;

public record struct Response811(long Id);

[Handler]
public sealed partial class Request811Handler
	: Mediator.IRequestHandler<Request811, Response811>,
	MediatR.IRequestHandler<Request811, Response811>
{
	private static ValueTask<Response811> Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response811> Mediator.IRequestHandler<Request811, Response811>.Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response811> MediatR.IRequestHandler<Request811, Response811>.Handle(
		Request811 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request812(long Id) : Mediator.IRequest<Response812>, MediatR.IRequest<Response812>;

public record struct Response812(long Id);

[Handler]
public sealed partial class Request812Handler
	: Mediator.IRequestHandler<Request812, Response812>,
	MediatR.IRequestHandler<Request812, Response812>
{
	private static ValueTask<Response812> Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response812> Mediator.IRequestHandler<Request812, Response812>.Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response812> MediatR.IRequestHandler<Request812, Response812>.Handle(
		Request812 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request813(long Id) : Mediator.IRequest<Response813>, MediatR.IRequest<Response813>;

public record struct Response813(long Id);

[Handler]
public sealed partial class Request813Handler
	: Mediator.IRequestHandler<Request813, Response813>,
	MediatR.IRequestHandler<Request813, Response813>
{
	private static ValueTask<Response813> Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response813> Mediator.IRequestHandler<Request813, Response813>.Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response813> MediatR.IRequestHandler<Request813, Response813>.Handle(
		Request813 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request814(long Id) : Mediator.IRequest<Response814>, MediatR.IRequest<Response814>;

public record struct Response814(long Id);

[Handler]
public sealed partial class Request814Handler
	: Mediator.IRequestHandler<Request814, Response814>,
	MediatR.IRequestHandler<Request814, Response814>
{
	private static ValueTask<Response814> Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response814> Mediator.IRequestHandler<Request814, Response814>.Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response814> MediatR.IRequestHandler<Request814, Response814>.Handle(
		Request814 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request815(long Id) : Mediator.IRequest<Response815>, MediatR.IRequest<Response815>;

public record struct Response815(long Id);

[Handler]
public sealed partial class Request815Handler
	: Mediator.IRequestHandler<Request815, Response815>,
	MediatR.IRequestHandler<Request815, Response815>
{
	private static ValueTask<Response815> Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response815> Mediator.IRequestHandler<Request815, Response815>.Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response815> MediatR.IRequestHandler<Request815, Response815>.Handle(
		Request815 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request816(long Id) : Mediator.IRequest<Response816>, MediatR.IRequest<Response816>;

public record struct Response816(long Id);

[Handler]
public sealed partial class Request816Handler
	: Mediator.IRequestHandler<Request816, Response816>,
	MediatR.IRequestHandler<Request816, Response816>
{
	private static ValueTask<Response816> Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response816> Mediator.IRequestHandler<Request816, Response816>.Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response816> MediatR.IRequestHandler<Request816, Response816>.Handle(
		Request816 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request817(long Id) : Mediator.IRequest<Response817>, MediatR.IRequest<Response817>;

public record struct Response817(long Id);

[Handler]
public sealed partial class Request817Handler
	: Mediator.IRequestHandler<Request817, Response817>,
	MediatR.IRequestHandler<Request817, Response817>
{
	private static ValueTask<Response817> Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response817> Mediator.IRequestHandler<Request817, Response817>.Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response817> MediatR.IRequestHandler<Request817, Response817>.Handle(
		Request817 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request818(long Id) : Mediator.IRequest<Response818>, MediatR.IRequest<Response818>;

public record struct Response818(long Id);

[Handler]
public sealed partial class Request818Handler
	: Mediator.IRequestHandler<Request818, Response818>,
	MediatR.IRequestHandler<Request818, Response818>
{
	private static ValueTask<Response818> Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response818> Mediator.IRequestHandler<Request818, Response818>.Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response818> MediatR.IRequestHandler<Request818, Response818>.Handle(
		Request818 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request819(long Id) : Mediator.IRequest<Response819>, MediatR.IRequest<Response819>;

public record struct Response819(long Id);

[Handler]
public sealed partial class Request819Handler
	: Mediator.IRequestHandler<Request819, Response819>,
	MediatR.IRequestHandler<Request819, Response819>
{
	private static ValueTask<Response819> Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response819> Mediator.IRequestHandler<Request819, Response819>.Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response819> MediatR.IRequestHandler<Request819, Response819>.Handle(
		Request819 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request820(long Id) : Mediator.IRequest<Response820>, MediatR.IRequest<Response820>;

public record struct Response820(long Id);

[Handler]
public sealed partial class Request820Handler
	: Mediator.IRequestHandler<Request820, Response820>,
	MediatR.IRequestHandler<Request820, Response820>
{
	private static ValueTask<Response820> Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response820> Mediator.IRequestHandler<Request820, Response820>.Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response820> MediatR.IRequestHandler<Request820, Response820>.Handle(
		Request820 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request821(long Id) : Mediator.IRequest<Response821>, MediatR.IRequest<Response821>;

public record struct Response821(long Id);

[Handler]
public sealed partial class Request821Handler
	: Mediator.IRequestHandler<Request821, Response821>,
	MediatR.IRequestHandler<Request821, Response821>
{
	private static ValueTask<Response821> Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response821> Mediator.IRequestHandler<Request821, Response821>.Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response821> MediatR.IRequestHandler<Request821, Response821>.Handle(
		Request821 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request822(long Id) : Mediator.IRequest<Response822>, MediatR.IRequest<Response822>;

public record struct Response822(long Id);

[Handler]
public sealed partial class Request822Handler
	: Mediator.IRequestHandler<Request822, Response822>,
	MediatR.IRequestHandler<Request822, Response822>
{
	private static ValueTask<Response822> Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response822> Mediator.IRequestHandler<Request822, Response822>.Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response822> MediatR.IRequestHandler<Request822, Response822>.Handle(
		Request822 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request823(long Id) : Mediator.IRequest<Response823>, MediatR.IRequest<Response823>;

public record struct Response823(long Id);

[Handler]
public sealed partial class Request823Handler
	: Mediator.IRequestHandler<Request823, Response823>,
	MediatR.IRequestHandler<Request823, Response823>
{
	private static ValueTask<Response823> Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response823> Mediator.IRequestHandler<Request823, Response823>.Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response823> MediatR.IRequestHandler<Request823, Response823>.Handle(
		Request823 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request824(long Id) : Mediator.IRequest<Response824>, MediatR.IRequest<Response824>;

public record struct Response824(long Id);

[Handler]
public sealed partial class Request824Handler
	: Mediator.IRequestHandler<Request824, Response824>,
	MediatR.IRequestHandler<Request824, Response824>
{
	private static ValueTask<Response824> Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response824> Mediator.IRequestHandler<Request824, Response824>.Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response824> MediatR.IRequestHandler<Request824, Response824>.Handle(
		Request824 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request825(long Id) : Mediator.IRequest<Response825>, MediatR.IRequest<Response825>;

public record struct Response825(long Id);

[Handler]
public sealed partial class Request825Handler
	: Mediator.IRequestHandler<Request825, Response825>,
	MediatR.IRequestHandler<Request825, Response825>
{
	private static ValueTask<Response825> Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response825> Mediator.IRequestHandler<Request825, Response825>.Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response825> MediatR.IRequestHandler<Request825, Response825>.Handle(
		Request825 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request826(long Id) : Mediator.IRequest<Response826>, MediatR.IRequest<Response826>;

public record struct Response826(long Id);

[Handler]
public sealed partial class Request826Handler
	: Mediator.IRequestHandler<Request826, Response826>,
	MediatR.IRequestHandler<Request826, Response826>
{
	private static ValueTask<Response826> Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response826> Mediator.IRequestHandler<Request826, Response826>.Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response826> MediatR.IRequestHandler<Request826, Response826>.Handle(
		Request826 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request827(long Id) : Mediator.IRequest<Response827>, MediatR.IRequest<Response827>;

public record struct Response827(long Id);

[Handler]
public sealed partial class Request827Handler
	: Mediator.IRequestHandler<Request827, Response827>,
	MediatR.IRequestHandler<Request827, Response827>
{
	private static ValueTask<Response827> Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response827> Mediator.IRequestHandler<Request827, Response827>.Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response827> MediatR.IRequestHandler<Request827, Response827>.Handle(
		Request827 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request828(long Id) : Mediator.IRequest<Response828>, MediatR.IRequest<Response828>;

public record struct Response828(long Id);

[Handler]
public sealed partial class Request828Handler
	: Mediator.IRequestHandler<Request828, Response828>,
	MediatR.IRequestHandler<Request828, Response828>
{
	private static ValueTask<Response828> Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response828> Mediator.IRequestHandler<Request828, Response828>.Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response828> MediatR.IRequestHandler<Request828, Response828>.Handle(
		Request828 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request829(long Id) : Mediator.IRequest<Response829>, MediatR.IRequest<Response829>;

public record struct Response829(long Id);

[Handler]
public sealed partial class Request829Handler
	: Mediator.IRequestHandler<Request829, Response829>,
	MediatR.IRequestHandler<Request829, Response829>
{
	private static ValueTask<Response829> Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response829> Mediator.IRequestHandler<Request829, Response829>.Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response829> MediatR.IRequestHandler<Request829, Response829>.Handle(
		Request829 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request830(long Id) : Mediator.IRequest<Response830>, MediatR.IRequest<Response830>;

public record struct Response830(long Id);

[Handler]
public sealed partial class Request830Handler
	: Mediator.IRequestHandler<Request830, Response830>,
	MediatR.IRequestHandler<Request830, Response830>
{
	private static ValueTask<Response830> Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response830> Mediator.IRequestHandler<Request830, Response830>.Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response830> MediatR.IRequestHandler<Request830, Response830>.Handle(
		Request830 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request831(long Id) : Mediator.IRequest<Response831>, MediatR.IRequest<Response831>;

public record struct Response831(long Id);

[Handler]
public sealed partial class Request831Handler
	: Mediator.IRequestHandler<Request831, Response831>,
	MediatR.IRequestHandler<Request831, Response831>
{
	private static ValueTask<Response831> Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response831> Mediator.IRequestHandler<Request831, Response831>.Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response831> MediatR.IRequestHandler<Request831, Response831>.Handle(
		Request831 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request832(long Id) : Mediator.IRequest<Response832>, MediatR.IRequest<Response832>;

public record struct Response832(long Id);

[Handler]
public sealed partial class Request832Handler
	: Mediator.IRequestHandler<Request832, Response832>,
	MediatR.IRequestHandler<Request832, Response832>
{
	private static ValueTask<Response832> Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response832> Mediator.IRequestHandler<Request832, Response832>.Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response832> MediatR.IRequestHandler<Request832, Response832>.Handle(
		Request832 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request833(long Id) : Mediator.IRequest<Response833>, MediatR.IRequest<Response833>;

public record struct Response833(long Id);

[Handler]
public sealed partial class Request833Handler
	: Mediator.IRequestHandler<Request833, Response833>,
	MediatR.IRequestHandler<Request833, Response833>
{
	private static ValueTask<Response833> Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response833> Mediator.IRequestHandler<Request833, Response833>.Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response833> MediatR.IRequestHandler<Request833, Response833>.Handle(
		Request833 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request834(long Id) : Mediator.IRequest<Response834>, MediatR.IRequest<Response834>;

public record struct Response834(long Id);

[Handler]
public sealed partial class Request834Handler
	: Mediator.IRequestHandler<Request834, Response834>,
	MediatR.IRequestHandler<Request834, Response834>
{
	private static ValueTask<Response834> Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response834> Mediator.IRequestHandler<Request834, Response834>.Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response834> MediatR.IRequestHandler<Request834, Response834>.Handle(
		Request834 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request835(long Id) : Mediator.IRequest<Response835>, MediatR.IRequest<Response835>;

public record struct Response835(long Id);

[Handler]
public sealed partial class Request835Handler
	: Mediator.IRequestHandler<Request835, Response835>,
	MediatR.IRequestHandler<Request835, Response835>
{
	private static ValueTask<Response835> Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response835> Mediator.IRequestHandler<Request835, Response835>.Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response835> MediatR.IRequestHandler<Request835, Response835>.Handle(
		Request835 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request836(long Id) : Mediator.IRequest<Response836>, MediatR.IRequest<Response836>;

public record struct Response836(long Id);

[Handler]
public sealed partial class Request836Handler
	: Mediator.IRequestHandler<Request836, Response836>,
	MediatR.IRequestHandler<Request836, Response836>
{
	private static ValueTask<Response836> Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response836> Mediator.IRequestHandler<Request836, Response836>.Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response836> MediatR.IRequestHandler<Request836, Response836>.Handle(
		Request836 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request837(long Id) : Mediator.IRequest<Response837>, MediatR.IRequest<Response837>;

public record struct Response837(long Id);

[Handler]
public sealed partial class Request837Handler
	: Mediator.IRequestHandler<Request837, Response837>,
	MediatR.IRequestHandler<Request837, Response837>
{
	private static ValueTask<Response837> Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response837> Mediator.IRequestHandler<Request837, Response837>.Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response837> MediatR.IRequestHandler<Request837, Response837>.Handle(
		Request837 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request838(long Id) : Mediator.IRequest<Response838>, MediatR.IRequest<Response838>;

public record struct Response838(long Id);

[Handler]
public sealed partial class Request838Handler
	: Mediator.IRequestHandler<Request838, Response838>,
	MediatR.IRequestHandler<Request838, Response838>
{
	private static ValueTask<Response838> Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response838> Mediator.IRequestHandler<Request838, Response838>.Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response838> MediatR.IRequestHandler<Request838, Response838>.Handle(
		Request838 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request839(long Id) : Mediator.IRequest<Response839>, MediatR.IRequest<Response839>;

public record struct Response839(long Id);

[Handler]
public sealed partial class Request839Handler
	: Mediator.IRequestHandler<Request839, Response839>,
	MediatR.IRequestHandler<Request839, Response839>
{
	private static ValueTask<Response839> Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response839> Mediator.IRequestHandler<Request839, Response839>.Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response839> MediatR.IRequestHandler<Request839, Response839>.Handle(
		Request839 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request840(long Id) : Mediator.IRequest<Response840>, MediatR.IRequest<Response840>;

public record struct Response840(long Id);

[Handler]
public sealed partial class Request840Handler
	: Mediator.IRequestHandler<Request840, Response840>,
	MediatR.IRequestHandler<Request840, Response840>
{
	private static ValueTask<Response840> Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response840> Mediator.IRequestHandler<Request840, Response840>.Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response840> MediatR.IRequestHandler<Request840, Response840>.Handle(
		Request840 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request841(long Id) : Mediator.IRequest<Response841>, MediatR.IRequest<Response841>;

public record struct Response841(long Id);

[Handler]
public sealed partial class Request841Handler
	: Mediator.IRequestHandler<Request841, Response841>,
	MediatR.IRequestHandler<Request841, Response841>
{
	private static ValueTask<Response841> Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response841> Mediator.IRequestHandler<Request841, Response841>.Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response841> MediatR.IRequestHandler<Request841, Response841>.Handle(
		Request841 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request842(long Id) : Mediator.IRequest<Response842>, MediatR.IRequest<Response842>;

public record struct Response842(long Id);

[Handler]
public sealed partial class Request842Handler
	: Mediator.IRequestHandler<Request842, Response842>,
	MediatR.IRequestHandler<Request842, Response842>
{
	private static ValueTask<Response842> Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response842> Mediator.IRequestHandler<Request842, Response842>.Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response842> MediatR.IRequestHandler<Request842, Response842>.Handle(
		Request842 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request843(long Id) : Mediator.IRequest<Response843>, MediatR.IRequest<Response843>;

public record struct Response843(long Id);

[Handler]
public sealed partial class Request843Handler
	: Mediator.IRequestHandler<Request843, Response843>,
	MediatR.IRequestHandler<Request843, Response843>
{
	private static ValueTask<Response843> Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response843> Mediator.IRequestHandler<Request843, Response843>.Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response843> MediatR.IRequestHandler<Request843, Response843>.Handle(
		Request843 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request844(long Id) : Mediator.IRequest<Response844>, MediatR.IRequest<Response844>;

public record struct Response844(long Id);

[Handler]
public sealed partial class Request844Handler
	: Mediator.IRequestHandler<Request844, Response844>,
	MediatR.IRequestHandler<Request844, Response844>
{
	private static ValueTask<Response844> Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response844> Mediator.IRequestHandler<Request844, Response844>.Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response844> MediatR.IRequestHandler<Request844, Response844>.Handle(
		Request844 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request845(long Id) : Mediator.IRequest<Response845>, MediatR.IRequest<Response845>;

public record struct Response845(long Id);

[Handler]
public sealed partial class Request845Handler
	: Mediator.IRequestHandler<Request845, Response845>,
	MediatR.IRequestHandler<Request845, Response845>
{
	private static ValueTask<Response845> Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response845> Mediator.IRequestHandler<Request845, Response845>.Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response845> MediatR.IRequestHandler<Request845, Response845>.Handle(
		Request845 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request846(long Id) : Mediator.IRequest<Response846>, MediatR.IRequest<Response846>;

public record struct Response846(long Id);

[Handler]
public sealed partial class Request846Handler
	: Mediator.IRequestHandler<Request846, Response846>,
	MediatR.IRequestHandler<Request846, Response846>
{
	private static ValueTask<Response846> Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response846> Mediator.IRequestHandler<Request846, Response846>.Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response846> MediatR.IRequestHandler<Request846, Response846>.Handle(
		Request846 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request847(long Id) : Mediator.IRequest<Response847>, MediatR.IRequest<Response847>;

public record struct Response847(long Id);

[Handler]
public sealed partial class Request847Handler
	: Mediator.IRequestHandler<Request847, Response847>,
	MediatR.IRequestHandler<Request847, Response847>
{
	private static ValueTask<Response847> Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response847> Mediator.IRequestHandler<Request847, Response847>.Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response847> MediatR.IRequestHandler<Request847, Response847>.Handle(
		Request847 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request848(long Id) : Mediator.IRequest<Response848>, MediatR.IRequest<Response848>;

public record struct Response848(long Id);

[Handler]
public sealed partial class Request848Handler
	: Mediator.IRequestHandler<Request848, Response848>,
	MediatR.IRequestHandler<Request848, Response848>
{
	private static ValueTask<Response848> Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response848> Mediator.IRequestHandler<Request848, Response848>.Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response848> MediatR.IRequestHandler<Request848, Response848>.Handle(
		Request848 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request849(long Id) : Mediator.IRequest<Response849>, MediatR.IRequest<Response849>;

public record struct Response849(long Id);

[Handler]
public sealed partial class Request849Handler
	: Mediator.IRequestHandler<Request849, Response849>,
	MediatR.IRequestHandler<Request849, Response849>
{
	private static ValueTask<Response849> Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response849> Mediator.IRequestHandler<Request849, Response849>.Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response849> MediatR.IRequestHandler<Request849, Response849>.Handle(
		Request849 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request850(long Id) : Mediator.IRequest<Response850>, MediatR.IRequest<Response850>;

public record struct Response850(long Id);

[Handler]
public sealed partial class Request850Handler
	: Mediator.IRequestHandler<Request850, Response850>,
	MediatR.IRequestHandler<Request850, Response850>
{
	private static ValueTask<Response850> Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response850> Mediator.IRequestHandler<Request850, Response850>.Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response850> MediatR.IRequestHandler<Request850, Response850>.Handle(
		Request850 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request851(long Id) : Mediator.IRequest<Response851>, MediatR.IRequest<Response851>;

public record struct Response851(long Id);

[Handler]
public sealed partial class Request851Handler
	: Mediator.IRequestHandler<Request851, Response851>,
	MediatR.IRequestHandler<Request851, Response851>
{
	private static ValueTask<Response851> Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response851> Mediator.IRequestHandler<Request851, Response851>.Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response851> MediatR.IRequestHandler<Request851, Response851>.Handle(
		Request851 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request852(long Id) : Mediator.IRequest<Response852>, MediatR.IRequest<Response852>;

public record struct Response852(long Id);

[Handler]
public sealed partial class Request852Handler
	: Mediator.IRequestHandler<Request852, Response852>,
	MediatR.IRequestHandler<Request852, Response852>
{
	private static ValueTask<Response852> Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response852> Mediator.IRequestHandler<Request852, Response852>.Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response852> MediatR.IRequestHandler<Request852, Response852>.Handle(
		Request852 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request853(long Id) : Mediator.IRequest<Response853>, MediatR.IRequest<Response853>;

public record struct Response853(long Id);

[Handler]
public sealed partial class Request853Handler
	: Mediator.IRequestHandler<Request853, Response853>,
	MediatR.IRequestHandler<Request853, Response853>
{
	private static ValueTask<Response853> Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response853> Mediator.IRequestHandler<Request853, Response853>.Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response853> MediatR.IRequestHandler<Request853, Response853>.Handle(
		Request853 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request854(long Id) : Mediator.IRequest<Response854>, MediatR.IRequest<Response854>;

public record struct Response854(long Id);

[Handler]
public sealed partial class Request854Handler
	: Mediator.IRequestHandler<Request854, Response854>,
	MediatR.IRequestHandler<Request854, Response854>
{
	private static ValueTask<Response854> Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response854> Mediator.IRequestHandler<Request854, Response854>.Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response854> MediatR.IRequestHandler<Request854, Response854>.Handle(
		Request854 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request855(long Id) : Mediator.IRequest<Response855>, MediatR.IRequest<Response855>;

public record struct Response855(long Id);

[Handler]
public sealed partial class Request855Handler
	: Mediator.IRequestHandler<Request855, Response855>,
	MediatR.IRequestHandler<Request855, Response855>
{
	private static ValueTask<Response855> Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response855> Mediator.IRequestHandler<Request855, Response855>.Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response855> MediatR.IRequestHandler<Request855, Response855>.Handle(
		Request855 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request856(long Id) : Mediator.IRequest<Response856>, MediatR.IRequest<Response856>;

public record struct Response856(long Id);

[Handler]
public sealed partial class Request856Handler
	: Mediator.IRequestHandler<Request856, Response856>,
	MediatR.IRequestHandler<Request856, Response856>
{
	private static ValueTask<Response856> Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response856> Mediator.IRequestHandler<Request856, Response856>.Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response856> MediatR.IRequestHandler<Request856, Response856>.Handle(
		Request856 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request857(long Id) : Mediator.IRequest<Response857>, MediatR.IRequest<Response857>;

public record struct Response857(long Id);

[Handler]
public sealed partial class Request857Handler
	: Mediator.IRequestHandler<Request857, Response857>,
	MediatR.IRequestHandler<Request857, Response857>
{
	private static ValueTask<Response857> Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response857> Mediator.IRequestHandler<Request857, Response857>.Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response857> MediatR.IRequestHandler<Request857, Response857>.Handle(
		Request857 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request858(long Id) : Mediator.IRequest<Response858>, MediatR.IRequest<Response858>;

public record struct Response858(long Id);

[Handler]
public sealed partial class Request858Handler
	: Mediator.IRequestHandler<Request858, Response858>,
	MediatR.IRequestHandler<Request858, Response858>
{
	private static ValueTask<Response858> Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response858> Mediator.IRequestHandler<Request858, Response858>.Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response858> MediatR.IRequestHandler<Request858, Response858>.Handle(
		Request858 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request859(long Id) : Mediator.IRequest<Response859>, MediatR.IRequest<Response859>;

public record struct Response859(long Id);

[Handler]
public sealed partial class Request859Handler
	: Mediator.IRequestHandler<Request859, Response859>,
	MediatR.IRequestHandler<Request859, Response859>
{
	private static ValueTask<Response859> Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response859> Mediator.IRequestHandler<Request859, Response859>.Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response859> MediatR.IRequestHandler<Request859, Response859>.Handle(
		Request859 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request860(long Id) : Mediator.IRequest<Response860>, MediatR.IRequest<Response860>;

public record struct Response860(long Id);

[Handler]
public sealed partial class Request860Handler
	: Mediator.IRequestHandler<Request860, Response860>,
	MediatR.IRequestHandler<Request860, Response860>
{
	private static ValueTask<Response860> Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response860> Mediator.IRequestHandler<Request860, Response860>.Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response860> MediatR.IRequestHandler<Request860, Response860>.Handle(
		Request860 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request861(long Id) : Mediator.IRequest<Response861>, MediatR.IRequest<Response861>;

public record struct Response861(long Id);

[Handler]
public sealed partial class Request861Handler
	: Mediator.IRequestHandler<Request861, Response861>,
	MediatR.IRequestHandler<Request861, Response861>
{
	private static ValueTask<Response861> Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response861> Mediator.IRequestHandler<Request861, Response861>.Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response861> MediatR.IRequestHandler<Request861, Response861>.Handle(
		Request861 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request862(long Id) : Mediator.IRequest<Response862>, MediatR.IRequest<Response862>;

public record struct Response862(long Id);

[Handler]
public sealed partial class Request862Handler
	: Mediator.IRequestHandler<Request862, Response862>,
	MediatR.IRequestHandler<Request862, Response862>
{
	private static ValueTask<Response862> Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response862> Mediator.IRequestHandler<Request862, Response862>.Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response862> MediatR.IRequestHandler<Request862, Response862>.Handle(
		Request862 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request863(long Id) : Mediator.IRequest<Response863>, MediatR.IRequest<Response863>;

public record struct Response863(long Id);

[Handler]
public sealed partial class Request863Handler
	: Mediator.IRequestHandler<Request863, Response863>,
	MediatR.IRequestHandler<Request863, Response863>
{
	private static ValueTask<Response863> Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response863> Mediator.IRequestHandler<Request863, Response863>.Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response863> MediatR.IRequestHandler<Request863, Response863>.Handle(
		Request863 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request864(long Id) : Mediator.IRequest<Response864>, MediatR.IRequest<Response864>;

public record struct Response864(long Id);

[Handler]
public sealed partial class Request864Handler
	: Mediator.IRequestHandler<Request864, Response864>,
	MediatR.IRequestHandler<Request864, Response864>
{
	private static ValueTask<Response864> Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response864> Mediator.IRequestHandler<Request864, Response864>.Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response864> MediatR.IRequestHandler<Request864, Response864>.Handle(
		Request864 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request865(long Id) : Mediator.IRequest<Response865>, MediatR.IRequest<Response865>;

public record struct Response865(long Id);

[Handler]
public sealed partial class Request865Handler
	: Mediator.IRequestHandler<Request865, Response865>,
	MediatR.IRequestHandler<Request865, Response865>
{
	private static ValueTask<Response865> Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response865> Mediator.IRequestHandler<Request865, Response865>.Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response865> MediatR.IRequestHandler<Request865, Response865>.Handle(
		Request865 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request866(long Id) : Mediator.IRequest<Response866>, MediatR.IRequest<Response866>;

public record struct Response866(long Id);

[Handler]
public sealed partial class Request866Handler
	: Mediator.IRequestHandler<Request866, Response866>,
	MediatR.IRequestHandler<Request866, Response866>
{
	private static ValueTask<Response866> Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response866> Mediator.IRequestHandler<Request866, Response866>.Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response866> MediatR.IRequestHandler<Request866, Response866>.Handle(
		Request866 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request867(long Id) : Mediator.IRequest<Response867>, MediatR.IRequest<Response867>;

public record struct Response867(long Id);

[Handler]
public sealed partial class Request867Handler
	: Mediator.IRequestHandler<Request867, Response867>,
	MediatR.IRequestHandler<Request867, Response867>
{
	private static ValueTask<Response867> Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response867> Mediator.IRequestHandler<Request867, Response867>.Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response867> MediatR.IRequestHandler<Request867, Response867>.Handle(
		Request867 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request868(long Id) : Mediator.IRequest<Response868>, MediatR.IRequest<Response868>;

public record struct Response868(long Id);

[Handler]
public sealed partial class Request868Handler
	: Mediator.IRequestHandler<Request868, Response868>,
	MediatR.IRequestHandler<Request868, Response868>
{
	private static ValueTask<Response868> Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response868> Mediator.IRequestHandler<Request868, Response868>.Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response868> MediatR.IRequestHandler<Request868, Response868>.Handle(
		Request868 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request869(long Id) : Mediator.IRequest<Response869>, MediatR.IRequest<Response869>;

public record struct Response869(long Id);

[Handler]
public sealed partial class Request869Handler
	: Mediator.IRequestHandler<Request869, Response869>,
	MediatR.IRequestHandler<Request869, Response869>
{
	private static ValueTask<Response869> Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response869> Mediator.IRequestHandler<Request869, Response869>.Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response869> MediatR.IRequestHandler<Request869, Response869>.Handle(
		Request869 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request870(long Id) : Mediator.IRequest<Response870>, MediatR.IRequest<Response870>;

public record struct Response870(long Id);

[Handler]
public sealed partial class Request870Handler
	: Mediator.IRequestHandler<Request870, Response870>,
	MediatR.IRequestHandler<Request870, Response870>
{
	private static ValueTask<Response870> Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response870> Mediator.IRequestHandler<Request870, Response870>.Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response870> MediatR.IRequestHandler<Request870, Response870>.Handle(
		Request870 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request871(long Id) : Mediator.IRequest<Response871>, MediatR.IRequest<Response871>;

public record struct Response871(long Id);

[Handler]
public sealed partial class Request871Handler
	: Mediator.IRequestHandler<Request871, Response871>,
	MediatR.IRequestHandler<Request871, Response871>
{
	private static ValueTask<Response871> Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response871> Mediator.IRequestHandler<Request871, Response871>.Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response871> MediatR.IRequestHandler<Request871, Response871>.Handle(
		Request871 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request872(long Id) : Mediator.IRequest<Response872>, MediatR.IRequest<Response872>;

public record struct Response872(long Id);

[Handler]
public sealed partial class Request872Handler
	: Mediator.IRequestHandler<Request872, Response872>,
	MediatR.IRequestHandler<Request872, Response872>
{
	private static ValueTask<Response872> Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response872> Mediator.IRequestHandler<Request872, Response872>.Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response872> MediatR.IRequestHandler<Request872, Response872>.Handle(
		Request872 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request873(long Id) : Mediator.IRequest<Response873>, MediatR.IRequest<Response873>;

public record struct Response873(long Id);

[Handler]
public sealed partial class Request873Handler
	: Mediator.IRequestHandler<Request873, Response873>,
	MediatR.IRequestHandler<Request873, Response873>
{
	private static ValueTask<Response873> Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response873> Mediator.IRequestHandler<Request873, Response873>.Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response873> MediatR.IRequestHandler<Request873, Response873>.Handle(
		Request873 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request874(long Id) : Mediator.IRequest<Response874>, MediatR.IRequest<Response874>;

public record struct Response874(long Id);

[Handler]
public sealed partial class Request874Handler
	: Mediator.IRequestHandler<Request874, Response874>,
	MediatR.IRequestHandler<Request874, Response874>
{
	private static ValueTask<Response874> Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response874> Mediator.IRequestHandler<Request874, Response874>.Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response874> MediatR.IRequestHandler<Request874, Response874>.Handle(
		Request874 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request875(long Id) : Mediator.IRequest<Response875>, MediatR.IRequest<Response875>;

public record struct Response875(long Id);

[Handler]
public sealed partial class Request875Handler
	: Mediator.IRequestHandler<Request875, Response875>,
	MediatR.IRequestHandler<Request875, Response875>
{
	private static ValueTask<Response875> Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response875> Mediator.IRequestHandler<Request875, Response875>.Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response875> MediatR.IRequestHandler<Request875, Response875>.Handle(
		Request875 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request876(long Id) : Mediator.IRequest<Response876>, MediatR.IRequest<Response876>;

public record struct Response876(long Id);

[Handler]
public sealed partial class Request876Handler
	: Mediator.IRequestHandler<Request876, Response876>,
	MediatR.IRequestHandler<Request876, Response876>
{
	private static ValueTask<Response876> Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response876> Mediator.IRequestHandler<Request876, Response876>.Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response876> MediatR.IRequestHandler<Request876, Response876>.Handle(
		Request876 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request877(long Id) : Mediator.IRequest<Response877>, MediatR.IRequest<Response877>;

public record struct Response877(long Id);

[Handler]
public sealed partial class Request877Handler
	: Mediator.IRequestHandler<Request877, Response877>,
	MediatR.IRequestHandler<Request877, Response877>
{
	private static ValueTask<Response877> Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response877> Mediator.IRequestHandler<Request877, Response877>.Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response877> MediatR.IRequestHandler<Request877, Response877>.Handle(
		Request877 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request878(long Id) : Mediator.IRequest<Response878>, MediatR.IRequest<Response878>;

public record struct Response878(long Id);

[Handler]
public sealed partial class Request878Handler
	: Mediator.IRequestHandler<Request878, Response878>,
	MediatR.IRequestHandler<Request878, Response878>
{
	private static ValueTask<Response878> Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response878> Mediator.IRequestHandler<Request878, Response878>.Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response878> MediatR.IRequestHandler<Request878, Response878>.Handle(
		Request878 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request879(long Id) : Mediator.IRequest<Response879>, MediatR.IRequest<Response879>;

public record struct Response879(long Id);

[Handler]
public sealed partial class Request879Handler
	: Mediator.IRequestHandler<Request879, Response879>,
	MediatR.IRequestHandler<Request879, Response879>
{
	private static ValueTask<Response879> Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response879> Mediator.IRequestHandler<Request879, Response879>.Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response879> MediatR.IRequestHandler<Request879, Response879>.Handle(
		Request879 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request880(long Id) : Mediator.IRequest<Response880>, MediatR.IRequest<Response880>;

public record struct Response880(long Id);

[Handler]
public sealed partial class Request880Handler
	: Mediator.IRequestHandler<Request880, Response880>,
	MediatR.IRequestHandler<Request880, Response880>
{
	private static ValueTask<Response880> Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response880> Mediator.IRequestHandler<Request880, Response880>.Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response880> MediatR.IRequestHandler<Request880, Response880>.Handle(
		Request880 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request881(long Id) : Mediator.IRequest<Response881>, MediatR.IRequest<Response881>;

public record struct Response881(long Id);

[Handler]
public sealed partial class Request881Handler
	: Mediator.IRequestHandler<Request881, Response881>,
	MediatR.IRequestHandler<Request881, Response881>
{
	private static ValueTask<Response881> Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response881> Mediator.IRequestHandler<Request881, Response881>.Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response881> MediatR.IRequestHandler<Request881, Response881>.Handle(
		Request881 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request882(long Id) : Mediator.IRequest<Response882>, MediatR.IRequest<Response882>;

public record struct Response882(long Id);

[Handler]
public sealed partial class Request882Handler
	: Mediator.IRequestHandler<Request882, Response882>,
	MediatR.IRequestHandler<Request882, Response882>
{
	private static ValueTask<Response882> Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response882> Mediator.IRequestHandler<Request882, Response882>.Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response882> MediatR.IRequestHandler<Request882, Response882>.Handle(
		Request882 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request883(long Id) : Mediator.IRequest<Response883>, MediatR.IRequest<Response883>;

public record struct Response883(long Id);

[Handler]
public sealed partial class Request883Handler
	: Mediator.IRequestHandler<Request883, Response883>,
	MediatR.IRequestHandler<Request883, Response883>
{
	private static ValueTask<Response883> Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response883> Mediator.IRequestHandler<Request883, Response883>.Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response883> MediatR.IRequestHandler<Request883, Response883>.Handle(
		Request883 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request884(long Id) : Mediator.IRequest<Response884>, MediatR.IRequest<Response884>;

public record struct Response884(long Id);

[Handler]
public sealed partial class Request884Handler
	: Mediator.IRequestHandler<Request884, Response884>,
	MediatR.IRequestHandler<Request884, Response884>
{
	private static ValueTask<Response884> Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response884> Mediator.IRequestHandler<Request884, Response884>.Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response884> MediatR.IRequestHandler<Request884, Response884>.Handle(
		Request884 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request885(long Id) : Mediator.IRequest<Response885>, MediatR.IRequest<Response885>;

public record struct Response885(long Id);

[Handler]
public sealed partial class Request885Handler
	: Mediator.IRequestHandler<Request885, Response885>,
	MediatR.IRequestHandler<Request885, Response885>
{
	private static ValueTask<Response885> Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response885> Mediator.IRequestHandler<Request885, Response885>.Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response885> MediatR.IRequestHandler<Request885, Response885>.Handle(
		Request885 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request886(long Id) : Mediator.IRequest<Response886>, MediatR.IRequest<Response886>;

public record struct Response886(long Id);

[Handler]
public sealed partial class Request886Handler
	: Mediator.IRequestHandler<Request886, Response886>,
	MediatR.IRequestHandler<Request886, Response886>
{
	private static ValueTask<Response886> Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response886> Mediator.IRequestHandler<Request886, Response886>.Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response886> MediatR.IRequestHandler<Request886, Response886>.Handle(
		Request886 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request887(long Id) : Mediator.IRequest<Response887>, MediatR.IRequest<Response887>;

public record struct Response887(long Id);

[Handler]
public sealed partial class Request887Handler
	: Mediator.IRequestHandler<Request887, Response887>,
	MediatR.IRequestHandler<Request887, Response887>
{
	private static ValueTask<Response887> Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response887> Mediator.IRequestHandler<Request887, Response887>.Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response887> MediatR.IRequestHandler<Request887, Response887>.Handle(
		Request887 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request888(long Id) : Mediator.IRequest<Response888>, MediatR.IRequest<Response888>;

public record struct Response888(long Id);

[Handler]
public sealed partial class Request888Handler
	: Mediator.IRequestHandler<Request888, Response888>,
	MediatR.IRequestHandler<Request888, Response888>
{
	private static ValueTask<Response888> Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response888> Mediator.IRequestHandler<Request888, Response888>.Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response888> MediatR.IRequestHandler<Request888, Response888>.Handle(
		Request888 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request889(long Id) : Mediator.IRequest<Response889>, MediatR.IRequest<Response889>;

public record struct Response889(long Id);

[Handler]
public sealed partial class Request889Handler
	: Mediator.IRequestHandler<Request889, Response889>,
	MediatR.IRequestHandler<Request889, Response889>
{
	private static ValueTask<Response889> Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response889> Mediator.IRequestHandler<Request889, Response889>.Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response889> MediatR.IRequestHandler<Request889, Response889>.Handle(
		Request889 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request890(long Id) : Mediator.IRequest<Response890>, MediatR.IRequest<Response890>;

public record struct Response890(long Id);

[Handler]
public sealed partial class Request890Handler
	: Mediator.IRequestHandler<Request890, Response890>,
	MediatR.IRequestHandler<Request890, Response890>
{
	private static ValueTask<Response890> Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response890> Mediator.IRequestHandler<Request890, Response890>.Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response890> MediatR.IRequestHandler<Request890, Response890>.Handle(
		Request890 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request891(long Id) : Mediator.IRequest<Response891>, MediatR.IRequest<Response891>;

public record struct Response891(long Id);

[Handler]
public sealed partial class Request891Handler
	: Mediator.IRequestHandler<Request891, Response891>,
	MediatR.IRequestHandler<Request891, Response891>
{
	private static ValueTask<Response891> Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response891> Mediator.IRequestHandler<Request891, Response891>.Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response891> MediatR.IRequestHandler<Request891, Response891>.Handle(
		Request891 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request892(long Id) : Mediator.IRequest<Response892>, MediatR.IRequest<Response892>;

public record struct Response892(long Id);

[Handler]
public sealed partial class Request892Handler
	: Mediator.IRequestHandler<Request892, Response892>,
	MediatR.IRequestHandler<Request892, Response892>
{
	private static ValueTask<Response892> Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response892> Mediator.IRequestHandler<Request892, Response892>.Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response892> MediatR.IRequestHandler<Request892, Response892>.Handle(
		Request892 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request893(long Id) : Mediator.IRequest<Response893>, MediatR.IRequest<Response893>;

public record struct Response893(long Id);

[Handler]
public sealed partial class Request893Handler
	: Mediator.IRequestHandler<Request893, Response893>,
	MediatR.IRequestHandler<Request893, Response893>
{
	private static ValueTask<Response893> Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response893> Mediator.IRequestHandler<Request893, Response893>.Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response893> MediatR.IRequestHandler<Request893, Response893>.Handle(
		Request893 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request894(long Id) : Mediator.IRequest<Response894>, MediatR.IRequest<Response894>;

public record struct Response894(long Id);

[Handler]
public sealed partial class Request894Handler
	: Mediator.IRequestHandler<Request894, Response894>,
	MediatR.IRequestHandler<Request894, Response894>
{
	private static ValueTask<Response894> Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response894> Mediator.IRequestHandler<Request894, Response894>.Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response894> MediatR.IRequestHandler<Request894, Response894>.Handle(
		Request894 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request895(long Id) : Mediator.IRequest<Response895>, MediatR.IRequest<Response895>;

public record struct Response895(long Id);

[Handler]
public sealed partial class Request895Handler
	: Mediator.IRequestHandler<Request895, Response895>,
	MediatR.IRequestHandler<Request895, Response895>
{
	private static ValueTask<Response895> Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response895> Mediator.IRequestHandler<Request895, Response895>.Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response895> MediatR.IRequestHandler<Request895, Response895>.Handle(
		Request895 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request896(long Id) : Mediator.IRequest<Response896>, MediatR.IRequest<Response896>;

public record struct Response896(long Id);

[Handler]
public sealed partial class Request896Handler
	: Mediator.IRequestHandler<Request896, Response896>,
	MediatR.IRequestHandler<Request896, Response896>
{
	private static ValueTask<Response896> Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response896> Mediator.IRequestHandler<Request896, Response896>.Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response896> MediatR.IRequestHandler<Request896, Response896>.Handle(
		Request896 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request897(long Id) : Mediator.IRequest<Response897>, MediatR.IRequest<Response897>;

public record struct Response897(long Id);

[Handler]
public sealed partial class Request897Handler
	: Mediator.IRequestHandler<Request897, Response897>,
	MediatR.IRequestHandler<Request897, Response897>
{
	private static ValueTask<Response897> Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response897> Mediator.IRequestHandler<Request897, Response897>.Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response897> MediatR.IRequestHandler<Request897, Response897>.Handle(
		Request897 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request898(long Id) : Mediator.IRequest<Response898>, MediatR.IRequest<Response898>;

public record struct Response898(long Id);

[Handler]
public sealed partial class Request898Handler
	: Mediator.IRequestHandler<Request898, Response898>,
	MediatR.IRequestHandler<Request898, Response898>
{
	private static ValueTask<Response898> Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response898> Mediator.IRequestHandler<Request898, Response898>.Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response898> MediatR.IRequestHandler<Request898, Response898>.Handle(
		Request898 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request899(long Id) : Mediator.IRequest<Response899>, MediatR.IRequest<Response899>;

public record struct Response899(long Id);

[Handler]
public sealed partial class Request899Handler
	: Mediator.IRequestHandler<Request899, Response899>,
	MediatR.IRequestHandler<Request899, Response899>
{
	private static ValueTask<Response899> Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response899> Mediator.IRequestHandler<Request899, Response899>.Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response899> MediatR.IRequestHandler<Request899, Response899>.Handle(
		Request899 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request900(long Id) : Mediator.IRequest<Response900>, MediatR.IRequest<Response900>;

public record struct Response900(long Id);

[Handler]
public sealed partial class Request900Handler
	: Mediator.IRequestHandler<Request900, Response900>,
	MediatR.IRequestHandler<Request900, Response900>
{
	private static ValueTask<Response900> Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response900> Mediator.IRequestHandler<Request900, Response900>.Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response900> MediatR.IRequestHandler<Request900, Response900>.Handle(
		Request900 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request901(long Id) : Mediator.IRequest<Response901>, MediatR.IRequest<Response901>;

public record struct Response901(long Id);

[Handler]
public sealed partial class Request901Handler
	: Mediator.IRequestHandler<Request901, Response901>,
	MediatR.IRequestHandler<Request901, Response901>
{
	private static ValueTask<Response901> Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response901> Mediator.IRequestHandler<Request901, Response901>.Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response901> MediatR.IRequestHandler<Request901, Response901>.Handle(
		Request901 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request902(long Id) : Mediator.IRequest<Response902>, MediatR.IRequest<Response902>;

public record struct Response902(long Id);

[Handler]
public sealed partial class Request902Handler
	: Mediator.IRequestHandler<Request902, Response902>,
	MediatR.IRequestHandler<Request902, Response902>
{
	private static ValueTask<Response902> Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response902> Mediator.IRequestHandler<Request902, Response902>.Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response902> MediatR.IRequestHandler<Request902, Response902>.Handle(
		Request902 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request903(long Id) : Mediator.IRequest<Response903>, MediatR.IRequest<Response903>;

public record struct Response903(long Id);

[Handler]
public sealed partial class Request903Handler
	: Mediator.IRequestHandler<Request903, Response903>,
	MediatR.IRequestHandler<Request903, Response903>
{
	private static ValueTask<Response903> Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response903> Mediator.IRequestHandler<Request903, Response903>.Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response903> MediatR.IRequestHandler<Request903, Response903>.Handle(
		Request903 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request904(long Id) : Mediator.IRequest<Response904>, MediatR.IRequest<Response904>;

public record struct Response904(long Id);

[Handler]
public sealed partial class Request904Handler
	: Mediator.IRequestHandler<Request904, Response904>,
	MediatR.IRequestHandler<Request904, Response904>
{
	private static ValueTask<Response904> Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response904> Mediator.IRequestHandler<Request904, Response904>.Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response904> MediatR.IRequestHandler<Request904, Response904>.Handle(
		Request904 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request905(long Id) : Mediator.IRequest<Response905>, MediatR.IRequest<Response905>;

public record struct Response905(long Id);

[Handler]
public sealed partial class Request905Handler
	: Mediator.IRequestHandler<Request905, Response905>,
	MediatR.IRequestHandler<Request905, Response905>
{
	private static ValueTask<Response905> Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response905> Mediator.IRequestHandler<Request905, Response905>.Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response905> MediatR.IRequestHandler<Request905, Response905>.Handle(
		Request905 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request906(long Id) : Mediator.IRequest<Response906>, MediatR.IRequest<Response906>;

public record struct Response906(long Id);

[Handler]
public sealed partial class Request906Handler
	: Mediator.IRequestHandler<Request906, Response906>,
	MediatR.IRequestHandler<Request906, Response906>
{
	private static ValueTask<Response906> Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response906> Mediator.IRequestHandler<Request906, Response906>.Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response906> MediatR.IRequestHandler<Request906, Response906>.Handle(
		Request906 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request907(long Id) : Mediator.IRequest<Response907>, MediatR.IRequest<Response907>;

public record struct Response907(long Id);

[Handler]
public sealed partial class Request907Handler
	: Mediator.IRequestHandler<Request907, Response907>,
	MediatR.IRequestHandler<Request907, Response907>
{
	private static ValueTask<Response907> Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response907> Mediator.IRequestHandler<Request907, Response907>.Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response907> MediatR.IRequestHandler<Request907, Response907>.Handle(
		Request907 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request908(long Id) : Mediator.IRequest<Response908>, MediatR.IRequest<Response908>;

public record struct Response908(long Id);

[Handler]
public sealed partial class Request908Handler
	: Mediator.IRequestHandler<Request908, Response908>,
	MediatR.IRequestHandler<Request908, Response908>
{
	private static ValueTask<Response908> Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response908> Mediator.IRequestHandler<Request908, Response908>.Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response908> MediatR.IRequestHandler<Request908, Response908>.Handle(
		Request908 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request909(long Id) : Mediator.IRequest<Response909>, MediatR.IRequest<Response909>;

public record struct Response909(long Id);

[Handler]
public sealed partial class Request909Handler
	: Mediator.IRequestHandler<Request909, Response909>,
	MediatR.IRequestHandler<Request909, Response909>
{
	private static ValueTask<Response909> Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response909> Mediator.IRequestHandler<Request909, Response909>.Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response909> MediatR.IRequestHandler<Request909, Response909>.Handle(
		Request909 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request910(long Id) : Mediator.IRequest<Response910>, MediatR.IRequest<Response910>;

public record struct Response910(long Id);

[Handler]
public sealed partial class Request910Handler
	: Mediator.IRequestHandler<Request910, Response910>,
	MediatR.IRequestHandler<Request910, Response910>
{
	private static ValueTask<Response910> Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response910> Mediator.IRequestHandler<Request910, Response910>.Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response910> MediatR.IRequestHandler<Request910, Response910>.Handle(
		Request910 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request911(long Id) : Mediator.IRequest<Response911>, MediatR.IRequest<Response911>;

public record struct Response911(long Id);

[Handler]
public sealed partial class Request911Handler
	: Mediator.IRequestHandler<Request911, Response911>,
	MediatR.IRequestHandler<Request911, Response911>
{
	private static ValueTask<Response911> Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response911> Mediator.IRequestHandler<Request911, Response911>.Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response911> MediatR.IRequestHandler<Request911, Response911>.Handle(
		Request911 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request912(long Id) : Mediator.IRequest<Response912>, MediatR.IRequest<Response912>;

public record struct Response912(long Id);

[Handler]
public sealed partial class Request912Handler
	: Mediator.IRequestHandler<Request912, Response912>,
	MediatR.IRequestHandler<Request912, Response912>
{
	private static ValueTask<Response912> Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response912> Mediator.IRequestHandler<Request912, Response912>.Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response912> MediatR.IRequestHandler<Request912, Response912>.Handle(
		Request912 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request913(long Id) : Mediator.IRequest<Response913>, MediatR.IRequest<Response913>;

public record struct Response913(long Id);

[Handler]
public sealed partial class Request913Handler
	: Mediator.IRequestHandler<Request913, Response913>,
	MediatR.IRequestHandler<Request913, Response913>
{
	private static ValueTask<Response913> Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response913> Mediator.IRequestHandler<Request913, Response913>.Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response913> MediatR.IRequestHandler<Request913, Response913>.Handle(
		Request913 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request914(long Id) : Mediator.IRequest<Response914>, MediatR.IRequest<Response914>;

public record struct Response914(long Id);

[Handler]
public sealed partial class Request914Handler
	: Mediator.IRequestHandler<Request914, Response914>,
	MediatR.IRequestHandler<Request914, Response914>
{
	private static ValueTask<Response914> Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response914> Mediator.IRequestHandler<Request914, Response914>.Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response914> MediatR.IRequestHandler<Request914, Response914>.Handle(
		Request914 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request915(long Id) : Mediator.IRequest<Response915>, MediatR.IRequest<Response915>;

public record struct Response915(long Id);

[Handler]
public sealed partial class Request915Handler
	: Mediator.IRequestHandler<Request915, Response915>,
	MediatR.IRequestHandler<Request915, Response915>
{
	private static ValueTask<Response915> Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response915> Mediator.IRequestHandler<Request915, Response915>.Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response915> MediatR.IRequestHandler<Request915, Response915>.Handle(
		Request915 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request916(long Id) : Mediator.IRequest<Response916>, MediatR.IRequest<Response916>;

public record struct Response916(long Id);

[Handler]
public sealed partial class Request916Handler
	: Mediator.IRequestHandler<Request916, Response916>,
	MediatR.IRequestHandler<Request916, Response916>
{
	private static ValueTask<Response916> Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response916> Mediator.IRequestHandler<Request916, Response916>.Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response916> MediatR.IRequestHandler<Request916, Response916>.Handle(
		Request916 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request917(long Id) : Mediator.IRequest<Response917>, MediatR.IRequest<Response917>;

public record struct Response917(long Id);

[Handler]
public sealed partial class Request917Handler
	: Mediator.IRequestHandler<Request917, Response917>,
	MediatR.IRequestHandler<Request917, Response917>
{
	private static ValueTask<Response917> Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response917> Mediator.IRequestHandler<Request917, Response917>.Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response917> MediatR.IRequestHandler<Request917, Response917>.Handle(
		Request917 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request918(long Id) : Mediator.IRequest<Response918>, MediatR.IRequest<Response918>;

public record struct Response918(long Id);

[Handler]
public sealed partial class Request918Handler
	: Mediator.IRequestHandler<Request918, Response918>,
	MediatR.IRequestHandler<Request918, Response918>
{
	private static ValueTask<Response918> Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response918> Mediator.IRequestHandler<Request918, Response918>.Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response918> MediatR.IRequestHandler<Request918, Response918>.Handle(
		Request918 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request919(long Id) : Mediator.IRequest<Response919>, MediatR.IRequest<Response919>;

public record struct Response919(long Id);

[Handler]
public sealed partial class Request919Handler
	: Mediator.IRequestHandler<Request919, Response919>,
	MediatR.IRequestHandler<Request919, Response919>
{
	private static ValueTask<Response919> Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response919> Mediator.IRequestHandler<Request919, Response919>.Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response919> MediatR.IRequestHandler<Request919, Response919>.Handle(
		Request919 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request920(long Id) : Mediator.IRequest<Response920>, MediatR.IRequest<Response920>;

public record struct Response920(long Id);

[Handler]
public sealed partial class Request920Handler
	: Mediator.IRequestHandler<Request920, Response920>,
	MediatR.IRequestHandler<Request920, Response920>
{
	private static ValueTask<Response920> Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response920> Mediator.IRequestHandler<Request920, Response920>.Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response920> MediatR.IRequestHandler<Request920, Response920>.Handle(
		Request920 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request921(long Id) : Mediator.IRequest<Response921>, MediatR.IRequest<Response921>;

public record struct Response921(long Id);

[Handler]
public sealed partial class Request921Handler
	: Mediator.IRequestHandler<Request921, Response921>,
	MediatR.IRequestHandler<Request921, Response921>
{
	private static ValueTask<Response921> Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response921> Mediator.IRequestHandler<Request921, Response921>.Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response921> MediatR.IRequestHandler<Request921, Response921>.Handle(
		Request921 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request922(long Id) : Mediator.IRequest<Response922>, MediatR.IRequest<Response922>;

public record struct Response922(long Id);

[Handler]
public sealed partial class Request922Handler
	: Mediator.IRequestHandler<Request922, Response922>,
	MediatR.IRequestHandler<Request922, Response922>
{
	private static ValueTask<Response922> Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response922> Mediator.IRequestHandler<Request922, Response922>.Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response922> MediatR.IRequestHandler<Request922, Response922>.Handle(
		Request922 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request923(long Id) : Mediator.IRequest<Response923>, MediatR.IRequest<Response923>;

public record struct Response923(long Id);

[Handler]
public sealed partial class Request923Handler
	: Mediator.IRequestHandler<Request923, Response923>,
	MediatR.IRequestHandler<Request923, Response923>
{
	private static ValueTask<Response923> Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response923> Mediator.IRequestHandler<Request923, Response923>.Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response923> MediatR.IRequestHandler<Request923, Response923>.Handle(
		Request923 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request924(long Id) : Mediator.IRequest<Response924>, MediatR.IRequest<Response924>;

public record struct Response924(long Id);

[Handler]
public sealed partial class Request924Handler
	: Mediator.IRequestHandler<Request924, Response924>,
	MediatR.IRequestHandler<Request924, Response924>
{
	private static ValueTask<Response924> Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response924> Mediator.IRequestHandler<Request924, Response924>.Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response924> MediatR.IRequestHandler<Request924, Response924>.Handle(
		Request924 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request925(long Id) : Mediator.IRequest<Response925>, MediatR.IRequest<Response925>;

public record struct Response925(long Id);

[Handler]
public sealed partial class Request925Handler
	: Mediator.IRequestHandler<Request925, Response925>,
	MediatR.IRequestHandler<Request925, Response925>
{
	private static ValueTask<Response925> Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response925> Mediator.IRequestHandler<Request925, Response925>.Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response925> MediatR.IRequestHandler<Request925, Response925>.Handle(
		Request925 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request926(long Id) : Mediator.IRequest<Response926>, MediatR.IRequest<Response926>;

public record struct Response926(long Id);

[Handler]
public sealed partial class Request926Handler
	: Mediator.IRequestHandler<Request926, Response926>,
	MediatR.IRequestHandler<Request926, Response926>
{
	private static ValueTask<Response926> Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response926> Mediator.IRequestHandler<Request926, Response926>.Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response926> MediatR.IRequestHandler<Request926, Response926>.Handle(
		Request926 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request927(long Id) : Mediator.IRequest<Response927>, MediatR.IRequest<Response927>;

public record struct Response927(long Id);

[Handler]
public sealed partial class Request927Handler
	: Mediator.IRequestHandler<Request927, Response927>,
	MediatR.IRequestHandler<Request927, Response927>
{
	private static ValueTask<Response927> Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response927> Mediator.IRequestHandler<Request927, Response927>.Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response927> MediatR.IRequestHandler<Request927, Response927>.Handle(
		Request927 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request928(long Id) : Mediator.IRequest<Response928>, MediatR.IRequest<Response928>;

public record struct Response928(long Id);

[Handler]
public sealed partial class Request928Handler
	: Mediator.IRequestHandler<Request928, Response928>,
	MediatR.IRequestHandler<Request928, Response928>
{
	private static ValueTask<Response928> Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response928> Mediator.IRequestHandler<Request928, Response928>.Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response928> MediatR.IRequestHandler<Request928, Response928>.Handle(
		Request928 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request929(long Id) : Mediator.IRequest<Response929>, MediatR.IRequest<Response929>;

public record struct Response929(long Id);

[Handler]
public sealed partial class Request929Handler
	: Mediator.IRequestHandler<Request929, Response929>,
	MediatR.IRequestHandler<Request929, Response929>
{
	private static ValueTask<Response929> Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response929> Mediator.IRequestHandler<Request929, Response929>.Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response929> MediatR.IRequestHandler<Request929, Response929>.Handle(
		Request929 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request930(long Id) : Mediator.IRequest<Response930>, MediatR.IRequest<Response930>;

public record struct Response930(long Id);

[Handler]
public sealed partial class Request930Handler
	: Mediator.IRequestHandler<Request930, Response930>,
	MediatR.IRequestHandler<Request930, Response930>
{
	private static ValueTask<Response930> Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response930> Mediator.IRequestHandler<Request930, Response930>.Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response930> MediatR.IRequestHandler<Request930, Response930>.Handle(
		Request930 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request931(long Id) : Mediator.IRequest<Response931>, MediatR.IRequest<Response931>;

public record struct Response931(long Id);

[Handler]
public sealed partial class Request931Handler
	: Mediator.IRequestHandler<Request931, Response931>,
	MediatR.IRequestHandler<Request931, Response931>
{
	private static ValueTask<Response931> Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response931> Mediator.IRequestHandler<Request931, Response931>.Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response931> MediatR.IRequestHandler<Request931, Response931>.Handle(
		Request931 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request932(long Id) : Mediator.IRequest<Response932>, MediatR.IRequest<Response932>;

public record struct Response932(long Id);

[Handler]
public sealed partial class Request932Handler
	: Mediator.IRequestHandler<Request932, Response932>,
	MediatR.IRequestHandler<Request932, Response932>
{
	private static ValueTask<Response932> Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response932> Mediator.IRequestHandler<Request932, Response932>.Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response932> MediatR.IRequestHandler<Request932, Response932>.Handle(
		Request932 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request933(long Id) : Mediator.IRequest<Response933>, MediatR.IRequest<Response933>;

public record struct Response933(long Id);

[Handler]
public sealed partial class Request933Handler
	: Mediator.IRequestHandler<Request933, Response933>,
	MediatR.IRequestHandler<Request933, Response933>
{
	private static ValueTask<Response933> Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response933> Mediator.IRequestHandler<Request933, Response933>.Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response933> MediatR.IRequestHandler<Request933, Response933>.Handle(
		Request933 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request934(long Id) : Mediator.IRequest<Response934>, MediatR.IRequest<Response934>;

public record struct Response934(long Id);

[Handler]
public sealed partial class Request934Handler
	: Mediator.IRequestHandler<Request934, Response934>,
	MediatR.IRequestHandler<Request934, Response934>
{
	private static ValueTask<Response934> Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response934> Mediator.IRequestHandler<Request934, Response934>.Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response934> MediatR.IRequestHandler<Request934, Response934>.Handle(
		Request934 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request935(long Id) : Mediator.IRequest<Response935>, MediatR.IRequest<Response935>;

public record struct Response935(long Id);

[Handler]
public sealed partial class Request935Handler
	: Mediator.IRequestHandler<Request935, Response935>,
	MediatR.IRequestHandler<Request935, Response935>
{
	private static ValueTask<Response935> Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response935> Mediator.IRequestHandler<Request935, Response935>.Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response935> MediatR.IRequestHandler<Request935, Response935>.Handle(
		Request935 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request936(long Id) : Mediator.IRequest<Response936>, MediatR.IRequest<Response936>;

public record struct Response936(long Id);

[Handler]
public sealed partial class Request936Handler
	: Mediator.IRequestHandler<Request936, Response936>,
	MediatR.IRequestHandler<Request936, Response936>
{
	private static ValueTask<Response936> Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response936> Mediator.IRequestHandler<Request936, Response936>.Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response936> MediatR.IRequestHandler<Request936, Response936>.Handle(
		Request936 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request937(long Id) : Mediator.IRequest<Response937>, MediatR.IRequest<Response937>;

public record struct Response937(long Id);

[Handler]
public sealed partial class Request937Handler
	: Mediator.IRequestHandler<Request937, Response937>,
	MediatR.IRequestHandler<Request937, Response937>
{
	private static ValueTask<Response937> Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response937> Mediator.IRequestHandler<Request937, Response937>.Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response937> MediatR.IRequestHandler<Request937, Response937>.Handle(
		Request937 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request938(long Id) : Mediator.IRequest<Response938>, MediatR.IRequest<Response938>;

public record struct Response938(long Id);

[Handler]
public sealed partial class Request938Handler
	: Mediator.IRequestHandler<Request938, Response938>,
	MediatR.IRequestHandler<Request938, Response938>
{
	private static ValueTask<Response938> Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response938> Mediator.IRequestHandler<Request938, Response938>.Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response938> MediatR.IRequestHandler<Request938, Response938>.Handle(
		Request938 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request939(long Id) : Mediator.IRequest<Response939>, MediatR.IRequest<Response939>;

public record struct Response939(long Id);

[Handler]
public sealed partial class Request939Handler
	: Mediator.IRequestHandler<Request939, Response939>,
	MediatR.IRequestHandler<Request939, Response939>
{
	private static ValueTask<Response939> Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response939> Mediator.IRequestHandler<Request939, Response939>.Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response939> MediatR.IRequestHandler<Request939, Response939>.Handle(
		Request939 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request940(long Id) : Mediator.IRequest<Response940>, MediatR.IRequest<Response940>;

public record struct Response940(long Id);

[Handler]
public sealed partial class Request940Handler
	: Mediator.IRequestHandler<Request940, Response940>,
	MediatR.IRequestHandler<Request940, Response940>
{
	private static ValueTask<Response940> Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response940> Mediator.IRequestHandler<Request940, Response940>.Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response940> MediatR.IRequestHandler<Request940, Response940>.Handle(
		Request940 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request941(long Id) : Mediator.IRequest<Response941>, MediatR.IRequest<Response941>;

public record struct Response941(long Id);

[Handler]
public sealed partial class Request941Handler
	: Mediator.IRequestHandler<Request941, Response941>,
	MediatR.IRequestHandler<Request941, Response941>
{
	private static ValueTask<Response941> Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response941> Mediator.IRequestHandler<Request941, Response941>.Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response941> MediatR.IRequestHandler<Request941, Response941>.Handle(
		Request941 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request942(long Id) : Mediator.IRequest<Response942>, MediatR.IRequest<Response942>;

public record struct Response942(long Id);

[Handler]
public sealed partial class Request942Handler
	: Mediator.IRequestHandler<Request942, Response942>,
	MediatR.IRequestHandler<Request942, Response942>
{
	private static ValueTask<Response942> Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response942> Mediator.IRequestHandler<Request942, Response942>.Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response942> MediatR.IRequestHandler<Request942, Response942>.Handle(
		Request942 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request943(long Id) : Mediator.IRequest<Response943>, MediatR.IRequest<Response943>;

public record struct Response943(long Id);

[Handler]
public sealed partial class Request943Handler
	: Mediator.IRequestHandler<Request943, Response943>,
	MediatR.IRequestHandler<Request943, Response943>
{
	private static ValueTask<Response943> Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response943> Mediator.IRequestHandler<Request943, Response943>.Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response943> MediatR.IRequestHandler<Request943, Response943>.Handle(
		Request943 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request944(long Id) : Mediator.IRequest<Response944>, MediatR.IRequest<Response944>;

public record struct Response944(long Id);

[Handler]
public sealed partial class Request944Handler
	: Mediator.IRequestHandler<Request944, Response944>,
	MediatR.IRequestHandler<Request944, Response944>
{
	private static ValueTask<Response944> Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response944> Mediator.IRequestHandler<Request944, Response944>.Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response944> MediatR.IRequestHandler<Request944, Response944>.Handle(
		Request944 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request945(long Id) : Mediator.IRequest<Response945>, MediatR.IRequest<Response945>;

public record struct Response945(long Id);

[Handler]
public sealed partial class Request945Handler
	: Mediator.IRequestHandler<Request945, Response945>,
	MediatR.IRequestHandler<Request945, Response945>
{
	private static ValueTask<Response945> Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response945> Mediator.IRequestHandler<Request945, Response945>.Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response945> MediatR.IRequestHandler<Request945, Response945>.Handle(
		Request945 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request946(long Id) : Mediator.IRequest<Response946>, MediatR.IRequest<Response946>;

public record struct Response946(long Id);

[Handler]
public sealed partial class Request946Handler
	: Mediator.IRequestHandler<Request946, Response946>,
	MediatR.IRequestHandler<Request946, Response946>
{
	private static ValueTask<Response946> Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response946> Mediator.IRequestHandler<Request946, Response946>.Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response946> MediatR.IRequestHandler<Request946, Response946>.Handle(
		Request946 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request947(long Id) : Mediator.IRequest<Response947>, MediatR.IRequest<Response947>;

public record struct Response947(long Id);

[Handler]
public sealed partial class Request947Handler
	: Mediator.IRequestHandler<Request947, Response947>,
	MediatR.IRequestHandler<Request947, Response947>
{
	private static ValueTask<Response947> Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response947> Mediator.IRequestHandler<Request947, Response947>.Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response947> MediatR.IRequestHandler<Request947, Response947>.Handle(
		Request947 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request948(long Id) : Mediator.IRequest<Response948>, MediatR.IRequest<Response948>;

public record struct Response948(long Id);

[Handler]
public sealed partial class Request948Handler
	: Mediator.IRequestHandler<Request948, Response948>,
	MediatR.IRequestHandler<Request948, Response948>
{
	private static ValueTask<Response948> Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response948> Mediator.IRequestHandler<Request948, Response948>.Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response948> MediatR.IRequestHandler<Request948, Response948>.Handle(
		Request948 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request949(long Id) : Mediator.IRequest<Response949>, MediatR.IRequest<Response949>;

public record struct Response949(long Id);

[Handler]
public sealed partial class Request949Handler
	: Mediator.IRequestHandler<Request949, Response949>,
	MediatR.IRequestHandler<Request949, Response949>
{
	private static ValueTask<Response949> Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response949> Mediator.IRequestHandler<Request949, Response949>.Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response949> MediatR.IRequestHandler<Request949, Response949>.Handle(
		Request949 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request950(long Id) : Mediator.IRequest<Response950>, MediatR.IRequest<Response950>;

public record struct Response950(long Id);

[Handler]
public sealed partial class Request950Handler
	: Mediator.IRequestHandler<Request950, Response950>,
	MediatR.IRequestHandler<Request950, Response950>
{
	private static ValueTask<Response950> Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response950> Mediator.IRequestHandler<Request950, Response950>.Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response950> MediatR.IRequestHandler<Request950, Response950>.Handle(
		Request950 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request951(long Id) : Mediator.IRequest<Response951>, MediatR.IRequest<Response951>;

public record struct Response951(long Id);

[Handler]
public sealed partial class Request951Handler
	: Mediator.IRequestHandler<Request951, Response951>,
	MediatR.IRequestHandler<Request951, Response951>
{
	private static ValueTask<Response951> Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response951> Mediator.IRequestHandler<Request951, Response951>.Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response951> MediatR.IRequestHandler<Request951, Response951>.Handle(
		Request951 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request952(long Id) : Mediator.IRequest<Response952>, MediatR.IRequest<Response952>;

public record struct Response952(long Id);

[Handler]
public sealed partial class Request952Handler
	: Mediator.IRequestHandler<Request952, Response952>,
	MediatR.IRequestHandler<Request952, Response952>
{
	private static ValueTask<Response952> Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response952> Mediator.IRequestHandler<Request952, Response952>.Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response952> MediatR.IRequestHandler<Request952, Response952>.Handle(
		Request952 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request953(long Id) : Mediator.IRequest<Response953>, MediatR.IRequest<Response953>;

public record struct Response953(long Id);

[Handler]
public sealed partial class Request953Handler
	: Mediator.IRequestHandler<Request953, Response953>,
	MediatR.IRequestHandler<Request953, Response953>
{
	private static ValueTask<Response953> Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response953> Mediator.IRequestHandler<Request953, Response953>.Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response953> MediatR.IRequestHandler<Request953, Response953>.Handle(
		Request953 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request954(long Id) : Mediator.IRequest<Response954>, MediatR.IRequest<Response954>;

public record struct Response954(long Id);

[Handler]
public sealed partial class Request954Handler
	: Mediator.IRequestHandler<Request954, Response954>,
	MediatR.IRequestHandler<Request954, Response954>
{
	private static ValueTask<Response954> Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response954> Mediator.IRequestHandler<Request954, Response954>.Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response954> MediatR.IRequestHandler<Request954, Response954>.Handle(
		Request954 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request955(long Id) : Mediator.IRequest<Response955>, MediatR.IRequest<Response955>;

public record struct Response955(long Id);

[Handler]
public sealed partial class Request955Handler
	: Mediator.IRequestHandler<Request955, Response955>,
	MediatR.IRequestHandler<Request955, Response955>
{
	private static ValueTask<Response955> Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response955> Mediator.IRequestHandler<Request955, Response955>.Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response955> MediatR.IRequestHandler<Request955, Response955>.Handle(
		Request955 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request956(long Id) : Mediator.IRequest<Response956>, MediatR.IRequest<Response956>;

public record struct Response956(long Id);

[Handler]
public sealed partial class Request956Handler
	: Mediator.IRequestHandler<Request956, Response956>,
	MediatR.IRequestHandler<Request956, Response956>
{
	private static ValueTask<Response956> Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response956> Mediator.IRequestHandler<Request956, Response956>.Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response956> MediatR.IRequestHandler<Request956, Response956>.Handle(
		Request956 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request957(long Id) : Mediator.IRequest<Response957>, MediatR.IRequest<Response957>;

public record struct Response957(long Id);

[Handler]
public sealed partial class Request957Handler
	: Mediator.IRequestHandler<Request957, Response957>,
	MediatR.IRequestHandler<Request957, Response957>
{
	private static ValueTask<Response957> Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response957> Mediator.IRequestHandler<Request957, Response957>.Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response957> MediatR.IRequestHandler<Request957, Response957>.Handle(
		Request957 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request958(long Id) : Mediator.IRequest<Response958>, MediatR.IRequest<Response958>;

public record struct Response958(long Id);

[Handler]
public sealed partial class Request958Handler
	: Mediator.IRequestHandler<Request958, Response958>,
	MediatR.IRequestHandler<Request958, Response958>
{
	private static ValueTask<Response958> Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response958> Mediator.IRequestHandler<Request958, Response958>.Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response958> MediatR.IRequestHandler<Request958, Response958>.Handle(
		Request958 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request959(long Id) : Mediator.IRequest<Response959>, MediatR.IRequest<Response959>;

public record struct Response959(long Id);

[Handler]
public sealed partial class Request959Handler
	: Mediator.IRequestHandler<Request959, Response959>,
	MediatR.IRequestHandler<Request959, Response959>
{
	private static ValueTask<Response959> Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response959> Mediator.IRequestHandler<Request959, Response959>.Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response959> MediatR.IRequestHandler<Request959, Response959>.Handle(
		Request959 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request960(long Id) : Mediator.IRequest<Response960>, MediatR.IRequest<Response960>;

public record struct Response960(long Id);

[Handler]
public sealed partial class Request960Handler
	: Mediator.IRequestHandler<Request960, Response960>,
	MediatR.IRequestHandler<Request960, Response960>
{
	private static ValueTask<Response960> Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response960> Mediator.IRequestHandler<Request960, Response960>.Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response960> MediatR.IRequestHandler<Request960, Response960>.Handle(
		Request960 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request961(long Id) : Mediator.IRequest<Response961>, MediatR.IRequest<Response961>;

public record struct Response961(long Id);

[Handler]
public sealed partial class Request961Handler
	: Mediator.IRequestHandler<Request961, Response961>,
	MediatR.IRequestHandler<Request961, Response961>
{
	private static ValueTask<Response961> Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response961> Mediator.IRequestHandler<Request961, Response961>.Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response961> MediatR.IRequestHandler<Request961, Response961>.Handle(
		Request961 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request962(long Id) : Mediator.IRequest<Response962>, MediatR.IRequest<Response962>;

public record struct Response962(long Id);

[Handler]
public sealed partial class Request962Handler
	: Mediator.IRequestHandler<Request962, Response962>,
	MediatR.IRequestHandler<Request962, Response962>
{
	private static ValueTask<Response962> Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response962> Mediator.IRequestHandler<Request962, Response962>.Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response962> MediatR.IRequestHandler<Request962, Response962>.Handle(
		Request962 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request963(long Id) : Mediator.IRequest<Response963>, MediatR.IRequest<Response963>;

public record struct Response963(long Id);

[Handler]
public sealed partial class Request963Handler
	: Mediator.IRequestHandler<Request963, Response963>,
	MediatR.IRequestHandler<Request963, Response963>
{
	private static ValueTask<Response963> Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response963> Mediator.IRequestHandler<Request963, Response963>.Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response963> MediatR.IRequestHandler<Request963, Response963>.Handle(
		Request963 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request964(long Id) : Mediator.IRequest<Response964>, MediatR.IRequest<Response964>;

public record struct Response964(long Id);

[Handler]
public sealed partial class Request964Handler
	: Mediator.IRequestHandler<Request964, Response964>,
	MediatR.IRequestHandler<Request964, Response964>
{
	private static ValueTask<Response964> Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response964> Mediator.IRequestHandler<Request964, Response964>.Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response964> MediatR.IRequestHandler<Request964, Response964>.Handle(
		Request964 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request965(long Id) : Mediator.IRequest<Response965>, MediatR.IRequest<Response965>;

public record struct Response965(long Id);

[Handler]
public sealed partial class Request965Handler
	: Mediator.IRequestHandler<Request965, Response965>,
	MediatR.IRequestHandler<Request965, Response965>
{
	private static ValueTask<Response965> Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response965> Mediator.IRequestHandler<Request965, Response965>.Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response965> MediatR.IRequestHandler<Request965, Response965>.Handle(
		Request965 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request966(long Id) : Mediator.IRequest<Response966>, MediatR.IRequest<Response966>;

public record struct Response966(long Id);

[Handler]
public sealed partial class Request966Handler
	: Mediator.IRequestHandler<Request966, Response966>,
	MediatR.IRequestHandler<Request966, Response966>
{
	private static ValueTask<Response966> Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response966> Mediator.IRequestHandler<Request966, Response966>.Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response966> MediatR.IRequestHandler<Request966, Response966>.Handle(
		Request966 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request967(long Id) : Mediator.IRequest<Response967>, MediatR.IRequest<Response967>;

public record struct Response967(long Id);

[Handler]
public sealed partial class Request967Handler
	: Mediator.IRequestHandler<Request967, Response967>,
	MediatR.IRequestHandler<Request967, Response967>
{
	private static ValueTask<Response967> Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response967> Mediator.IRequestHandler<Request967, Response967>.Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response967> MediatR.IRequestHandler<Request967, Response967>.Handle(
		Request967 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request968(long Id) : Mediator.IRequest<Response968>, MediatR.IRequest<Response968>;

public record struct Response968(long Id);

[Handler]
public sealed partial class Request968Handler
	: Mediator.IRequestHandler<Request968, Response968>,
	MediatR.IRequestHandler<Request968, Response968>
{
	private static ValueTask<Response968> Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response968> Mediator.IRequestHandler<Request968, Response968>.Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response968> MediatR.IRequestHandler<Request968, Response968>.Handle(
		Request968 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request969(long Id) : Mediator.IRequest<Response969>, MediatR.IRequest<Response969>;

public record struct Response969(long Id);

[Handler]
public sealed partial class Request969Handler
	: Mediator.IRequestHandler<Request969, Response969>,
	MediatR.IRequestHandler<Request969, Response969>
{
	private static ValueTask<Response969> Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response969> Mediator.IRequestHandler<Request969, Response969>.Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response969> MediatR.IRequestHandler<Request969, Response969>.Handle(
		Request969 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request970(long Id) : Mediator.IRequest<Response970>, MediatR.IRequest<Response970>;

public record struct Response970(long Id);

[Handler]
public sealed partial class Request970Handler
	: Mediator.IRequestHandler<Request970, Response970>,
	MediatR.IRequestHandler<Request970, Response970>
{
	private static ValueTask<Response970> Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response970> Mediator.IRequestHandler<Request970, Response970>.Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response970> MediatR.IRequestHandler<Request970, Response970>.Handle(
		Request970 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request971(long Id) : Mediator.IRequest<Response971>, MediatR.IRequest<Response971>;

public record struct Response971(long Id);

[Handler]
public sealed partial class Request971Handler
	: Mediator.IRequestHandler<Request971, Response971>,
	MediatR.IRequestHandler<Request971, Response971>
{
	private static ValueTask<Response971> Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response971> Mediator.IRequestHandler<Request971, Response971>.Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response971> MediatR.IRequestHandler<Request971, Response971>.Handle(
		Request971 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request972(long Id) : Mediator.IRequest<Response972>, MediatR.IRequest<Response972>;

public record struct Response972(long Id);

[Handler]
public sealed partial class Request972Handler
	: Mediator.IRequestHandler<Request972, Response972>,
	MediatR.IRequestHandler<Request972, Response972>
{
	private static ValueTask<Response972> Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response972> Mediator.IRequestHandler<Request972, Response972>.Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response972> MediatR.IRequestHandler<Request972, Response972>.Handle(
		Request972 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request973(long Id) : Mediator.IRequest<Response973>, MediatR.IRequest<Response973>;

public record struct Response973(long Id);

[Handler]
public sealed partial class Request973Handler
	: Mediator.IRequestHandler<Request973, Response973>,
	MediatR.IRequestHandler<Request973, Response973>
{
	private static ValueTask<Response973> Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response973> Mediator.IRequestHandler<Request973, Response973>.Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response973> MediatR.IRequestHandler<Request973, Response973>.Handle(
		Request973 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request974(long Id) : Mediator.IRequest<Response974>, MediatR.IRequest<Response974>;

public record struct Response974(long Id);

[Handler]
public sealed partial class Request974Handler
	: Mediator.IRequestHandler<Request974, Response974>,
	MediatR.IRequestHandler<Request974, Response974>
{
	private static ValueTask<Response974> Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response974> Mediator.IRequestHandler<Request974, Response974>.Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response974> MediatR.IRequestHandler<Request974, Response974>.Handle(
		Request974 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request975(long Id) : Mediator.IRequest<Response975>, MediatR.IRequest<Response975>;

public record struct Response975(long Id);

[Handler]
public sealed partial class Request975Handler
	: Mediator.IRequestHandler<Request975, Response975>,
	MediatR.IRequestHandler<Request975, Response975>
{
	private static ValueTask<Response975> Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response975> Mediator.IRequestHandler<Request975, Response975>.Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response975> MediatR.IRequestHandler<Request975, Response975>.Handle(
		Request975 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request976(long Id) : Mediator.IRequest<Response976>, MediatR.IRequest<Response976>;

public record struct Response976(long Id);

[Handler]
public sealed partial class Request976Handler
	: Mediator.IRequestHandler<Request976, Response976>,
	MediatR.IRequestHandler<Request976, Response976>
{
	private static ValueTask<Response976> Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response976> Mediator.IRequestHandler<Request976, Response976>.Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response976> MediatR.IRequestHandler<Request976, Response976>.Handle(
		Request976 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request977(long Id) : Mediator.IRequest<Response977>, MediatR.IRequest<Response977>;

public record struct Response977(long Id);

[Handler]
public sealed partial class Request977Handler
	: Mediator.IRequestHandler<Request977, Response977>,
	MediatR.IRequestHandler<Request977, Response977>
{
	private static ValueTask<Response977> Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response977> Mediator.IRequestHandler<Request977, Response977>.Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response977> MediatR.IRequestHandler<Request977, Response977>.Handle(
		Request977 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request978(long Id) : Mediator.IRequest<Response978>, MediatR.IRequest<Response978>;

public record struct Response978(long Id);

[Handler]
public sealed partial class Request978Handler
	: Mediator.IRequestHandler<Request978, Response978>,
	MediatR.IRequestHandler<Request978, Response978>
{
	private static ValueTask<Response978> Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response978> Mediator.IRequestHandler<Request978, Response978>.Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response978> MediatR.IRequestHandler<Request978, Response978>.Handle(
		Request978 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request979(long Id) : Mediator.IRequest<Response979>, MediatR.IRequest<Response979>;

public record struct Response979(long Id);

[Handler]
public sealed partial class Request979Handler
	: Mediator.IRequestHandler<Request979, Response979>,
	MediatR.IRequestHandler<Request979, Response979>
{
	private static ValueTask<Response979> Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response979> Mediator.IRequestHandler<Request979, Response979>.Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response979> MediatR.IRequestHandler<Request979, Response979>.Handle(
		Request979 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request980(long Id) : Mediator.IRequest<Response980>, MediatR.IRequest<Response980>;

public record struct Response980(long Id);

[Handler]
public sealed partial class Request980Handler
	: Mediator.IRequestHandler<Request980, Response980>,
	MediatR.IRequestHandler<Request980, Response980>
{
	private static ValueTask<Response980> Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response980> Mediator.IRequestHandler<Request980, Response980>.Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response980> MediatR.IRequestHandler<Request980, Response980>.Handle(
		Request980 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request981(long Id) : Mediator.IRequest<Response981>, MediatR.IRequest<Response981>;

public record struct Response981(long Id);

[Handler]
public sealed partial class Request981Handler
	: Mediator.IRequestHandler<Request981, Response981>,
	MediatR.IRequestHandler<Request981, Response981>
{
	private static ValueTask<Response981> Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response981> Mediator.IRequestHandler<Request981, Response981>.Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response981> MediatR.IRequestHandler<Request981, Response981>.Handle(
		Request981 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request982(long Id) : Mediator.IRequest<Response982>, MediatR.IRequest<Response982>;

public record struct Response982(long Id);

[Handler]
public sealed partial class Request982Handler
	: Mediator.IRequestHandler<Request982, Response982>,
	MediatR.IRequestHandler<Request982, Response982>
{
	private static ValueTask<Response982> Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response982> Mediator.IRequestHandler<Request982, Response982>.Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response982> MediatR.IRequestHandler<Request982, Response982>.Handle(
		Request982 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request983(long Id) : Mediator.IRequest<Response983>, MediatR.IRequest<Response983>;

public record struct Response983(long Id);

[Handler]
public sealed partial class Request983Handler
	: Mediator.IRequestHandler<Request983, Response983>,
	MediatR.IRequestHandler<Request983, Response983>
{
	private static ValueTask<Response983> Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response983> Mediator.IRequestHandler<Request983, Response983>.Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response983> MediatR.IRequestHandler<Request983, Response983>.Handle(
		Request983 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request984(long Id) : Mediator.IRequest<Response984>, MediatR.IRequest<Response984>;

public record struct Response984(long Id);

[Handler]
public sealed partial class Request984Handler
	: Mediator.IRequestHandler<Request984, Response984>,
	MediatR.IRequestHandler<Request984, Response984>
{
	private static ValueTask<Response984> Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response984> Mediator.IRequestHandler<Request984, Response984>.Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response984> MediatR.IRequestHandler<Request984, Response984>.Handle(
		Request984 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request985(long Id) : Mediator.IRequest<Response985>, MediatR.IRequest<Response985>;

public record struct Response985(long Id);

[Handler]
public sealed partial class Request985Handler
	: Mediator.IRequestHandler<Request985, Response985>,
	MediatR.IRequestHandler<Request985, Response985>
{
	private static ValueTask<Response985> Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response985> Mediator.IRequestHandler<Request985, Response985>.Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response985> MediatR.IRequestHandler<Request985, Response985>.Handle(
		Request985 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request986(long Id) : Mediator.IRequest<Response986>, MediatR.IRequest<Response986>;

public record struct Response986(long Id);

[Handler]
public sealed partial class Request986Handler
	: Mediator.IRequestHandler<Request986, Response986>,
	MediatR.IRequestHandler<Request986, Response986>
{
	private static ValueTask<Response986> Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response986> Mediator.IRequestHandler<Request986, Response986>.Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response986> MediatR.IRequestHandler<Request986, Response986>.Handle(
		Request986 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request987(long Id) : Mediator.IRequest<Response987>, MediatR.IRequest<Response987>;

public record struct Response987(long Id);

[Handler]
public sealed partial class Request987Handler
	: Mediator.IRequestHandler<Request987, Response987>,
	MediatR.IRequestHandler<Request987, Response987>
{
	private static ValueTask<Response987> Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response987> Mediator.IRequestHandler<Request987, Response987>.Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response987> MediatR.IRequestHandler<Request987, Response987>.Handle(
		Request987 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request988(long Id) : Mediator.IRequest<Response988>, MediatR.IRequest<Response988>;

public record struct Response988(long Id);

[Handler]
public sealed partial class Request988Handler
	: Mediator.IRequestHandler<Request988, Response988>,
	MediatR.IRequestHandler<Request988, Response988>
{
	private static ValueTask<Response988> Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response988> Mediator.IRequestHandler<Request988, Response988>.Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response988> MediatR.IRequestHandler<Request988, Response988>.Handle(
		Request988 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request989(long Id) : Mediator.IRequest<Response989>, MediatR.IRequest<Response989>;

public record struct Response989(long Id);

[Handler]
public sealed partial class Request989Handler
	: Mediator.IRequestHandler<Request989, Response989>,
	MediatR.IRequestHandler<Request989, Response989>
{
	private static ValueTask<Response989> Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response989> Mediator.IRequestHandler<Request989, Response989>.Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response989> MediatR.IRequestHandler<Request989, Response989>.Handle(
		Request989 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request990(long Id) : Mediator.IRequest<Response990>, MediatR.IRequest<Response990>;

public record struct Response990(long Id);

[Handler]
public sealed partial class Request990Handler
	: Mediator.IRequestHandler<Request990, Response990>,
	MediatR.IRequestHandler<Request990, Response990>
{
	private static ValueTask<Response990> Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response990> Mediator.IRequestHandler<Request990, Response990>.Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response990> MediatR.IRequestHandler<Request990, Response990>.Handle(
		Request990 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request991(long Id) : Mediator.IRequest<Response991>, MediatR.IRequest<Response991>;

public record struct Response991(long Id);

[Handler]
public sealed partial class Request991Handler
	: Mediator.IRequestHandler<Request991, Response991>,
	MediatR.IRequestHandler<Request991, Response991>
{
	private static ValueTask<Response991> Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response991> Mediator.IRequestHandler<Request991, Response991>.Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response991> MediatR.IRequestHandler<Request991, Response991>.Handle(
		Request991 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request992(long Id) : Mediator.IRequest<Response992>, MediatR.IRequest<Response992>;

public record struct Response992(long Id);

[Handler]
public sealed partial class Request992Handler
	: Mediator.IRequestHandler<Request992, Response992>,
	MediatR.IRequestHandler<Request992, Response992>
{
	private static ValueTask<Response992> Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response992> Mediator.IRequestHandler<Request992, Response992>.Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response992> MediatR.IRequestHandler<Request992, Response992>.Handle(
		Request992 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request993(long Id) : Mediator.IRequest<Response993>, MediatR.IRequest<Response993>;

public record struct Response993(long Id);

[Handler]
public sealed partial class Request993Handler
	: Mediator.IRequestHandler<Request993, Response993>,
	MediatR.IRequestHandler<Request993, Response993>
{
	private static ValueTask<Response993> Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response993> Mediator.IRequestHandler<Request993, Response993>.Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response993> MediatR.IRequestHandler<Request993, Response993>.Handle(
		Request993 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request994(long Id) : Mediator.IRequest<Response994>, MediatR.IRequest<Response994>;

public record struct Response994(long Id);

[Handler]
public sealed partial class Request994Handler
	: Mediator.IRequestHandler<Request994, Response994>,
	MediatR.IRequestHandler<Request994, Response994>
{
	private static ValueTask<Response994> Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response994> Mediator.IRequestHandler<Request994, Response994>.Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response994> MediatR.IRequestHandler<Request994, Response994>.Handle(
		Request994 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request995(long Id) : Mediator.IRequest<Response995>, MediatR.IRequest<Response995>;

public record struct Response995(long Id);

[Handler]
public sealed partial class Request995Handler
	: Mediator.IRequestHandler<Request995, Response995>,
	MediatR.IRequestHandler<Request995, Response995>
{
	private static ValueTask<Response995> Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response995> Mediator.IRequestHandler<Request995, Response995>.Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response995> MediatR.IRequestHandler<Request995, Response995>.Handle(
		Request995 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request996(long Id) : Mediator.IRequest<Response996>, MediatR.IRequest<Response996>;

public record struct Response996(long Id);

[Handler]
public sealed partial class Request996Handler
	: Mediator.IRequestHandler<Request996, Response996>,
	MediatR.IRequestHandler<Request996, Response996>
{
	private static ValueTask<Response996> Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response996> Mediator.IRequestHandler<Request996, Response996>.Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response996> MediatR.IRequestHandler<Request996, Response996>.Handle(
		Request996 request,
		CancellationToken cancellationToken
	) => default!;
}

public sealed record Request997(long Id) : Mediator.IRequest<Response997>, MediatR.IRequest<Response997>;

public record struct Response997(long Id);

[Handler]
public sealed partial class Request997Handler
	: Mediator.IRequestHandler<Request997, Response997>,
	MediatR.IRequestHandler<Request997, Response997>
{
	private static ValueTask<Response997> Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default;

	ValueTask<Response997> Mediator.IRequestHandler<Request997, Response997>.Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default;

	Task<Response997> MediatR.IRequestHandler<Request997, Response997>.Handle(
		Request997 request,
		CancellationToken cancellationToken
	) => default!;
}
