using System;
using FlutterSDK;
using FlutterSDK.Widgets.Framework;
using System.Net.Http;
using FlutterBinding.UI;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using SkiaSharp;
using FlutterBinding.Engine.Painting;
using static FlutterSDK.Global;
using FlutterBinding.Mapping;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
namespace FlutterSDK.Material.App
{
    internal static class AppDefaultClass
    {
        public static FlutterSDK.Painting.Textstyle.TextStyle _ErrorTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
    }

    /// <Summary>
    /// An application that uses material design.
    ///
    /// A convenience widget that wraps a number of widgets that are commonly
    /// required for material design applications. It builds upon a [WidgetsApp] by
    /// adding material-design specific functionality, such as [AnimatedTheme] and
    /// [GridPaper].
    ///
    /// The [MaterialApp] configures the top-level [Navigator] to search for routes
    /// in the following order:
    ///
    ///  1. For the `/` route, the [home] property, if non-null, is used.
    ///
    ///  2. Otherwise, the [routes] table is used, if it has an entry for the route.
    ///
    ///  3. Otherwise, [onGenerateRoute] is called, if provided. It should return a
    ///     non-null value for any _valid_ route not handled by [home] and [routes].
    ///
    ///  4. Finally if all else fails [onUnknownRoute] is called.
    ///
    /// If a [Navigator] is created, at least one of these options must handle the
    /// `/` route, since it is used when an invalid [initialRoute] is specified on
    /// startup (e.g. by another application launching this one with an intent on
    /// Android; see [Window.defaultRouteName]).
    ///
    /// This widget also configures the observer of the top-level [Navigator] (if
    /// any) to perform [Hero] animations.
    ///
    /// If [home], [routes], [onGenerateRoute], and [onUnknownRoute] are all null,
    /// and [builder] is not null, then no [Navigator] is created.
    ///
    /// {@tool snippet}
    /// This example shows how to create a [MaterialApp] that disables the "debug"
    /// banner with a [home] route that will be displayed when the app is launched.
    ///
    /// ![The MaterialApp displays a Scaffold ](https://flutter.github.io/assets-for-api-docs/assets/material/basic_material_app.png)
    ///
    /// ```dart
    /// MaterialApp(
    ///   home: Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('Home'),
    ///     ),
    ///   ),
    ///   debugShowCheckedModeBanner: false,
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// This example shows how to create a [MaterialApp] that uses the [routes]
    /// `Map` to define the "home" route and an "about" route.
    ///
    /// ```dart
    /// MaterialApp(
    ///   routes: <String, WidgetBuilder>{
    ///     '/': (BuildContext context) {
    ///       return Scaffold(
    ///         appBar: AppBar(
    ///           title: const Text('Home Route'),
    ///         ),
    ///       );
    ///     },
    ///     '/about': (BuildContext context) {
    ///       return Scaffold(
    ///         appBar: AppBar(
    ///           title: const Text('About Route'),
    ///         ),
    ///       );
    ///      }
    ///    },
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// This example shows how to create a [MaterialApp] that defines a [theme] that
    /// will be used for material widgets in the app.
    ///
    /// ![The MaterialApp displays a Scaffold with a dark background and a blue / grey AppBar at the top](https://flutter.github.io/assets-for-api-docs/assets/material/theme_material_app.png)
    ///
    /// ```dart
    /// MaterialApp(
    ///   theme: ThemeData(
    ///     brightness: Brightness.dark,
    ///     primaryColor: Colors.blueGrey
    ///   ),
    ///   home: Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('MaterialApp Theme'),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Scaffold], which provides standard app elements like an [AppBar] and a [Drawer].
    ///  * [Navigator], which is used to manage the app's stack of pages.
    ///  * [MaterialPageRoute], which defines an app page that transitions in a material-specific way.
    ///  * [WidgetsApp], which defines the basic app elements but does not depend on the material library.
    ///  * The Flutter Internationalization Tutorial,
    ///    <https://flutter.dev/tutorials/internationalization/>.
    /// </Summary>
    public class MaterialApp : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public MaterialApp(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> navigatorKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState>), FlutterSDK.Widgets.Framework.Widget home = default(FlutterSDK.Widgets.Framework.Widget), Dictionary<string, object> routes = default(Dictionary<string, object>), string initialRoute = default(string), FlutterSDK.Widgets.Navigator.RouteFactory onGenerateRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.App.InitialRouteListFactory onGenerateInitialRoutes = default(FlutterSDK.Widgets.App.InitialRouteListFactory), FlutterSDK.Widgets.Navigator.RouteFactory onUnknownRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), List<FlutterSDK.Widgets.Navigator.NavigatorObserver> navigatorObservers = default(List<FlutterSDK.Widgets.Navigator.NavigatorObserver>), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), string title = default(string), FlutterSDK.Widgets.App.GenerateAppTitle onGenerateTitle = default(FlutterSDK.Widgets.App.GenerateAppTitle), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData), FlutterSDK.Material.Themedata.ThemeData darkTheme = default(FlutterSDK.Material.Themedata.ThemeData), FlutterSDK.Material.App.ThemeMode themeMode = default(FlutterSDK.Material.App.ThemeMode), Locale locale = default(Locale), Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> localizationsDelegates = default(Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>>), FlutterSDK.Widgets.App.LocaleListResolutionCallback localeListResolutionCallback = default(FlutterSDK.Widgets.App.LocaleListResolutionCallback), FlutterSDK.Widgets.App.LocaleResolutionCallback localeResolutionCallback = default(FlutterSDK.Widgets.App.LocaleResolutionCallback), Iterable<Locale> supportedLocales = default(Iterable<Locale>), bool debugShowMaterialGrid = false, bool showPerformanceOverlay = false, bool checkerboardRasterCacheImages = false, bool checkerboardOffscreenLayers = false, bool showSemanticsDebugger = false, bool debugShowCheckedModeBanner = true, Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> actions = default(Dictionary<FlutterSDK.Foundation.Key.LocalKey, object>))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
    public virtual FlutterSDK.Widgets.Framework.Widget Home { get; set; }
    public virtual Dictionary<string, object> Routes { get; set; }
    public virtual string InitialRoute { get; set; }
    public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
    public virtual FlutterSDK.Widgets.App.InitialRouteListFactory OnGenerateInitialRoutes { get; set; }
    public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
    public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }
    public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
    public virtual string Title { get; set; }
    public virtual FlutterSDK.Widgets.App.GenerateAppTitle OnGenerateTitle { get; set; }
    public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get; set; }
    public virtual FlutterSDK.Material.Themedata.ThemeData DarkTheme { get; set; }
    public virtual FlutterSDK.Material.App.ThemeMode ThemeMode { get; set; }
    public virtual FlutterBinding.UI.Color Color { get; set; }
    public virtual Locale Locale { get; set; }
    public virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> LocalizationsDelegates { get; set; }
    public virtual FlutterSDK.Widgets.App.LocaleListResolutionCallback LocaleListResolutionCallback { get; set; }
    public virtual FlutterSDK.Widgets.App.LocaleResolutionCallback LocaleResolutionCallback { get; set; }
    public virtual Iterable<Locale> SupportedLocales { get; set; }
    public virtual bool ShowPerformanceOverlay { get; set; }
    public virtual bool CheckerboardRasterCacheImages { get; set; }
    public virtual bool CheckerboardOffscreenLayers { get; set; }
    public virtual bool ShowSemanticsDebugger { get; set; }
    public virtual bool DebugShowCheckedModeBanner { get; set; }
    public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
    public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }
    public virtual bool DebugShowMaterialGrid { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.App._MaterialAppState CreateState() => new _MaterialAppState();


    #endregion
}


public class _MaterialScrollBehavior : FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior
{
    #region constructors
    public _MaterialScrollBehavior()
    { }
    #endregion

    #region fields
    #endregion

    #region methods

    public new FlutterSDK.Foundation.Platform.TargetPlatform GetPlatform(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return ThemeDefaultClass.Theme.Of(context).Platform;
    }




    public new FlutterSDK.Widgets.Framework.Widget BuildViewportChrome(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection)
    {
        switch (GetPlatform(context)) { case TargetPlatform.IOS: case TargetPlatform.Linux: case TargetPlatform.MacOS: case TargetPlatform.Windows: return child; case TargetPlatform.Android: case TargetPlatform.Fuchsia: return new GlowingOverscrollIndicator(child: child, axisDirection: axisDirection, color: ThemeDefaultClass.Theme.Of(context).AccentColor); }
        return null;
    }



    #endregion
}


public class _MaterialAppState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.App.MaterialApp>
{
    #region constructors
    public _MaterialAppState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Heroes.HeroController _HeroController { get; set; }
    internal virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> _NavigatorObservers { get; set; }
    internal virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _LocalizationsDelegates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _HeroController = new HeroController(createRectTween: _CreateRectTween);
        _UpdateNavigator();
    }




    public new void DidUpdateWidget(FlutterSDK.Material.App.MaterialApp oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (Widget.NavigatorKey != oldWidget.NavigatorKey)
        {
            _HeroController = new HeroController(createRectTween: _CreateRectTween);
        }

        _UpdateNavigator();
    }




    private void _UpdateNavigator()
    {
        if (Widget.Home != null || Widget.Routes.IsNotEmpty || Widget.OnGenerateRoute != null || Widget.OnUnknownRoute != null)
        {
            _NavigatorObservers = List<NavigatorObserver>.From(Widget.NavigatorObservers);
            List<NavigatorObserver>.From(Widget.NavigatorObservers).Add(_HeroController);
        }
        else
        {
            _NavigatorObservers = new List, < NavigatorObserver > (};
    }

}




private FlutterSDK.Animation.Tween.RectTween _CreateRectTween(FlutterBinding.UI.Rect begin, FlutterBinding.UI.Rect end)
{
    return new MaterialRectArcTween(begin: begin, end: end);
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    Widget result = new WidgetsApp(key: new GlobalObjectKey(this), navigatorKey: Widget.NavigatorKey, navigatorObservers: _NavigatorObservers, pageRouteBuilder: (RouteSettings settings, WidgetBuilder builder) =>
    {
        return new MaterialPageRoute<T>(settings: settings, builder: builder);
    }
    , home: Widget.Home, routes: Widget.Routes, initialRoute: Widget.InitialRoute, onGenerateRoute: Widget.OnGenerateRoute, onGenerateInitialRoutes: Widget.OnGenerateInitialRoutes, onUnknownRoute: Widget.OnUnknownRoute, builder: (BuildContext context, Widget child) =>
    {
        ThemeMode mode = Widget.ThemeMode ?? ThemeMode.System;
        ThemeData theme = default(ThemeData);
        if (Widget.DarkTheme != null)
        {
            Ui.Brightness platformBrightness = MediaqueryDefaultClass.MediaQuery.PlatformBrightnessOf(context);
            if (mode == ThemeMode.Dark || (mode == ThemeMode.System && platformBrightness == Ui.Brightness.Dark))
            {
                theme = Widget.DarkTheme;
            }

        }

        theme = (theme == null ? Widget.Theme ?? ThemeData.Fallback() : theme);
        return new AnimatedTheme(data: theme, isMaterialAppTheme: true, child: Widget.Builder != null ? new Builder(builder: (BuildContext context) =>
        {
            return Widget.Builder(context, child);
        }
    ) : child);
    }
    , title: Widget.Title, onGenerateTitle: Widget.OnGenerateTitle, textStyle: AppDefaultClass._ErrorTextStyle, color: Widget.Color ?? Widget.Theme?.PrimaryColor ?? ColorsDefaultClass.Colors.Blue, locale: Widget.Locale, localizationsDelegates: _LocalizationsDelegates, localeResolutionCallback: Widget.LocaleResolutionCallback, localeListResolutionCallback: Widget.LocaleListResolutionCallback, supportedLocales: Widget.SupportedLocales, showPerformanceOverlay: Widget.ShowPerformanceOverlay, checkerboardRasterCacheImages: Widget.CheckerboardRasterCacheImages, checkerboardOffscreenLayers: Widget.CheckerboardOffscreenLayers, showSemanticsDebugger: Widget.ShowSemanticsDebugger, debugShowCheckedModeBanner: Widget.DebugShowCheckedModeBanner, inspectorSelectButtonBuilder: (BuildContext context, VoidCallback onPressed) =>
    {
        return new FloatingActionButton(child: new Icon(IconsDefaultClass.Icons.Search), onPressed: onPressed, mini: true);
    }
    , shortcuts: Widget.Shortcuts, actions: Widget.Actions);

    return new ScrollConfiguration(behavior: new _MaterialScrollBehavior(), child: result);
}



#endregion
}


/// <Summary>
/// Describes which theme will be used by [MaterialApp].
/// </Summary>
public enum ThemeMode
{

    /// <Summary>
    /// Use either the light or dark theme based on what the user has selected in
    /// the system settings.
    /// </Summary>
    System,
    /// <Summary>
    /// Always use the light mode regardless of system preference.
    /// </Summary>
    Light,
    /// <Summary>
    /// Always use the dark mode (if available) regardless of system preference.
    /// </Summary>
    Dark,
}

}