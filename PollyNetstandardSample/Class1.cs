using System;
using Polly;

namespace PollyNetstandardSample
{
    public class Class1
    {
	    private Policy _policy;

	    public Class1()
	    {
		    _policy = Policy.Timeout(() => TimeSpan.FromDays(1));
	    }
    }
}
