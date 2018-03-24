// <assemblyHash>68551095</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=15.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias i;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("Initial", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("Initial")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace Initial.Fakes
{
    /// <summary>Shim type of Initial.Mine</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(i::Initial.Mine))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Mine")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimMine
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<i::Initial.Mine>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimMine()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimMine(i::Initial.Mine instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of Mine.daj(Int32 y)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<i::Initial.Mine, int, int> dajInt32
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("daj", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, "daj", typeof(int), new global::System.Type[]{typeof(int)});
                }
            }

            /// <summary>Sets the shim of Mine.poloncz(String dwa)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<i::Initial.Mine, string, string> polonczString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("poloncz", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, 
                         "poloncz", typeof(string), new global::System.Type[]{typeof(string)});
                }
            }

            /// <summary>Sets the shim of Mine.get_x()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<i::Initial.Mine, int> xGet
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_x", 36)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance
                        ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, "get_x", typeof(int), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of Mine.set_x(Int32 value)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<i::Initial.Mine, int> xSetInt32
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_x", 36)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance
                        ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, "set_x", typeof(void), new global::System.Type[]{typeof(int)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Initial.Fakes.ShimMine.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Initial.Fakes.ShimMine.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(i::Initial.Mine), value);
            }
        }

        /// <summary>Sets the shim of Mine.Mine()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<i::Initial.Mine> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Mine.Mine(IMineSample sample)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<i::Initial.Mine, i::Initial.IMineSample> ConstructorIMineSample
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(i::Initial.Mine), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{typeof(i::Initial.IMineSample)});
            }
        }

        /// <summary>Sets the shim of Mine.daj(Int32 y)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, int> dajInt32
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("daj", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<i::Initial.Mine, int, int>(value)), 
                     typeof(i::Initial.Mine), base.Instance, "daj", typeof(int), new global::System.Type[]{typeof(int)});
            }
        }

        /// <summary>Sets the shim of Mine.poloncz(String dwa)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string> polonczString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("poloncz", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<i::Initial.Mine, string, string>(value)), 
                                                                                                    typeof(i::Initial.Mine), base.Instance, "poloncz", typeof(string), new global::System.Type[]{typeof(string)});
            }
        }

        /// <summary>Sets the shim of Mine.get_x()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int> xGet
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_x", 36)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<i::Initial.Mine, int>(value)), 
                     typeof(i::Initial.Mine), base.Instance, "get_x", typeof(int), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Mine.set_x(Int32 value)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<int> xSetInt32
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_x", 36)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<i::Initial.Mine, int>(value)), 
                     typeof(i::Initial.Mine), base.Instance, "set_x", typeof(void), new global::System.Type[]{typeof(int)});
            }
        }
    }
}
namespace Initial.Fakes
{
    /// <summary>Stub type of Initial.IMineSample</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(i::Initial.IMineSample))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of IMineSample")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubIMineSample
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<i::Initial.IMineSample>
      , i::Initial.IMineSample
    {
        /// <summary>Initializes a new instance of type StubIMineSample</summary>
        public StubIMineSample()
        {
        }

        /// <summary>Sets the stub of IMineSample.quadraticEquation(Int32 a, Int32 b, Int32 c)</summary>
        double i::Initial.IMineSample.quadraticEquation(
            int a,
            int b,
            int c
        )
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, int, int, double> ___currentMethod
                 = ((i::Initial.IMineSample)this).quadraticEquation;
              ___observer.Enter(typeof(i::Initial.IMineSample), (global::System.Delegate)___currentMethod, (object)a, (object)b, (object)c);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, int, int, double> ___sh = this.QuadraticEquationInt32Int32Int32;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(a, b, c);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::Initial.Fakes.StubIMineSample, double>(this, "Initial.IMineSample.quadraticEquation");
            }
        }

        /// <summary>Sets the stub of IMineSample.quadraticEquation(Int32 a, Int32 b, Int32 c)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, int, int, double> QuadraticEquationInt32Int32Int32;
    }
}
namespace Initial.Fakes
{
    /// <summary>Stub type of Initial.Mine</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(i::Initial.Mine))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of Mine")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubMine
      : i::Initial.Mine
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<i::Initial.Mine>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubMine()
        {
            this.InitializeStub();
        }

        /// <summary>Initializes a new instance</summary>
        public StubMine(i::Initial.IMineSample sample)
        : base(sample)
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubMine</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
