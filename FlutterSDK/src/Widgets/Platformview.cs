﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routenotificationmessages;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Widgets.Platformview
{
    /// <Summary>
    /// A factory for a surface presenting a platform view as part of the widget hierarchy.
    ///
    /// The returned widget should present the platform view associated with `controller`.
    ///
    /// See also:
    ///
    ///  * [PlatformViewSurface], a common widget for presenting platform views.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget PlatformViewSurfaceFactory(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Services.Platformviews.PlatformViewController controller);
    /// <Summary>
    /// Constructs a [PlatformViewController].
    ///
    /// The [PlatformViewController.id] field of the created controller must match the value of the
    /// params [PlatformViewCreationParams.id] field.
    ///
    /// See also:
    ///
    ///  * [PlatformViewLink], which links a platform view with the Flutter framework.
    /// </Summary>
    public delegate FlutterSDK.Services.Platformviews.PlatformViewController CreatePlatformViewCallback(FlutterSDK.Widgets.Platformview.PlatformViewCreationParams params);
    internal static class PlatformviewDefaultClass
    {
    }

    /// <Summary>
    /// Embeds an Android view in the Widget hierarchy.
    ///
    /// Requires Android API level 20 or greater.
    ///
    /// Embedding Android views is an expensive operation and should be avoided when a Flutter
    /// equivalent is possible.
    ///
    /// The embedded Android view is painted just like any other Flutter widget and transformations
    /// apply to it as well.
    ///
    /// {@template flutter.widgets.platformViews.layout}
    /// The widget fills all available space, the parent of this object must provide bounded layout
    /// constraints.
    /// {@endtemplate}
    ///
    /// {@template flutter.widgets.platformViews.gestures}
    /// The widget participates in Flutter's [GestureArena]s, and dispatches touch events to the
    /// platform view iff it won the arena. Specific gestures that should be dispatched to the platform
    /// view can be specified in the `gestureRecognizers` constructor parameter. If
    /// the set of gesture recognizers is empty, a gesture will be dispatched to the platform
    /// view iff it was not claimed by any other gesture recognizer.
    /// {@endtemplate}
    ///
    /// The Android view object is created using a [PlatformViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html).
    /// Plugins can register platform view factories with [PlatformViewRegistry#registerViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewRegistry.html#registerViewFactory-java.lang.String-io.flutter.plugin.platform.PlatformViewFactory-).
    ///
    /// Registration is typically done in the plugin's registerWith method, e.g:
    ///
    /// ```java
    ///   public static void registerWith(Registrar registrar) {
    ///     registrar.platformViewRegistry().registerViewFactory("webview", WebViewFactory(registrar.messenger()));
    ///   }
    /// ```
    ///
    /// {@template flutter.widgets.platformViews.lifetime}
    /// The platform view's lifetime is the same as the lifetime of the [State] object for this widget.
    /// When the [State] is disposed the platform view (and auxiliary resources) are lazily
    /// released (some resources are immediately released and some by platform garbage collector).
    /// A stateful widget's state is disposed when the widget is removed from the tree or when it is
    /// moved within the tree. If the stateful widget has a key and it's only moved relative to its siblings,
    /// or it has a [GlobalKey] and it's moved within the tree, it will not be disposed.
    /// {@endtemplate}
    /// </Summary>
    public class AndroidView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that embeds an Android view.
        ///
        /// {@template flutter.widgets.platformViews.constructorParams}
        /// The `viewType` and `hitTestBehavior` parameters must not be null.
        /// If `creationParams` is not null then `creationParamsCodec` must not be null.
        /// {@endtemplate}
        /// </Summary>
        public AndroidView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), TextDirection layoutDirection = default(TextDirection), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>))
        : base(key: key)
        {
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.HitTestBehavior = hitTestBehavior;
            this.LayoutDirection = layoutDirection;
            this.GestureRecognizers = gestureRecognizers;
            this.CreationParams = creationParams;
            this.CreationParamsCodec = creationParamsCodec;
        }
        /// <Summary>
        /// The unique identifier for Android view type to be embedded by this widget.
        ///
        /// A [PlatformViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html)
        /// for this type must have been registered.
        ///
        /// See also:
        ///
        ///  * [AndroidView] for an example of registering a platform view factory.
        /// </Summary>
        public virtual string ViewType { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.platformViews.createdParam}
        /// Callback to invoke after the platform view has been created.
        ///
        /// May be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.platformViews.hittestParam}
        /// How this widget should behave during hit testing.
        ///
        /// This defaults to [PlatformViewHitTestBehavior.opaque].
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.platformViews.directionParam}
        /// The text direction to use for the embedded view.
        ///
        /// If this is null, the ambient [Directionality] is used instead.
        /// {@endtemplate}
        /// </Summary>
        public virtual TextDirection LayoutDirection { get; set; }
        /// <Summary>
        /// Which gestures should be forwarded to the Android view.
        ///
        /// {@template flutter.widgets.platformViews.gestureRecognizersDescHead}
        /// The gesture recognizers built by factories in this set participate in the gesture arena for
        /// each pointer that was put down on the widget. If any of these recognizers win the
        /// gesture arena, the entire pointer event sequence starting from the pointer down event
        /// will be dispatched to the platform view.
        ///
        /// When null, an empty set of gesture recognizer factories is used, in which case a pointer event sequence
        /// will only be dispatched to the platform view if no other member of the arena claimed it.
        /// {@endtemplate}
        ///
        /// For example, with the following setup vertical drags will not be dispatched to the Android
        /// view as the vertical drag gesture is claimed by the parent [GestureDetector].
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails d) {},
        ///   child: AndroidView(
        ///     viewType: 'webview',
        ///   ),
        /// )
        /// ```
        ///
        /// To get the [AndroidView] to claim the vertical drag gestures we can pass a vertical drag
        /// gesture recognizer factory in [gestureRecognizers] e.g:
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails details) {},
        ///   child: SizedBox(
        ///     width: 200.0,
        ///     height: 100.0,
        ///     child: AndroidView(
        ///       viewType: 'webview',
        ///       gestureRecognizers: <Factory<OneSequenceGestureRecognizer>>[
        ///         new Factory<OneSequenceGestureRecognizer>(
        ///           () => new EagerGestureRecognizer(),
        ///         ),
        ///       ].toSet(),
        ///     ),
        ///   ),
        /// )
        /// ```
        ///
        /// {@template flutter.widgets.platformViews.gestureRecognizersDescFoot}
        /// A platform view can be configured to consume all pointers that were put down in its bounds
        /// by passing a factory for an [EagerGestureRecognizer] in [gestureRecognizers].
        /// [EagerGestureRecognizer] is a special gesture recognizer that immediately claims the gesture
        /// after a pointer down event.
        ///
        /// The `gestureRecognizers` property must not contain more than one factory with the same [Factory.type].
        ///
        /// Changing `gestureRecognizers` results in rejection of any active gesture arenas (if the
        /// platform view is actively participating in an arena).
        /// {@endtemplate}
        /// </Summary>
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        /// <Summary>
        /// Passed as the args argument of [PlatformViewFactory#create](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html#create-android.content.Context-int-java.lang.Object-)
        ///
        /// This can be used by plugins to pass constructor parameters to the embedded Android view.
        /// </Summary>
        public virtual object CreationParams { get; set; }
        /// <Summary>
        /// The codec used to encode `creationParams` before sending it to the
        /// platform side. It should match the codec passed to the constructor of [PlatformViewFactory](/javadoc/io/flutter/plugin/platform/PlatformViewFactory.html#PlatformViewFactory-io.flutter.plugin.common.MessageCodec-).
        ///
        /// This is typically one of: [StandardMessageCodec], [JSONMessageCodec], [StringCodec], or [BinaryCodec].
        ///
        /// This must not be null if [creationParams] is not null.
        /// </Summary>
        public virtual FlutterSDK.Services.Messagecodec.MessageCodec<object> CreationParamsCodec { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.AndroidView> CreateState() => new _AndroidViewState();


    }


    /// <Summary>
    /// Embeds an iOS view in the Widget hierarchy.
    ///
    /// {@macro flutter.rendering.platformView.preview}
    ///
    /// Embedding iOS views is an expensive operation and should be avoided when a Flutter
    /// equivalent is possible.
    ///
    /// {@macro flutter.widgets.platformViews.layout}
    ///
    /// {@macro flutter.widgets.platformViews.gestures}
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    ///
    /// Construction of UIViews is done asynchronously, before the UIView is ready this widget paints
    /// nothing while maintaining the same layout constraints.
    ///
    /// If a conic path clipping is applied to a UIKitView,
    /// a quad path is used to approximate the clip due to limitation of Quartz.
    /// </Summary>
    public class UiKitView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that embeds an iOS view.
        ///
        /// {@macro flutter.widgets.platformViews.constructorParams}
        /// </Summary>
        public UiKitView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), TextDirection layoutDirection = default(TextDirection), object creationParams = default(object), FlutterSDK.Services.Messagecodec.MessageCodec<object> creationParamsCodec = default(FlutterSDK.Services.Messagecodec.MessageCodec<object>), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.HitTestBehavior = hitTestBehavior;
            this.LayoutDirection = layoutDirection;
            this.CreationParams = creationParams;
            this.CreationParamsCodec = creationParamsCodec;
            this.GestureRecognizers = gestureRecognizers;
        }
        /// <Summary>
        /// The unique identifier for iOS view type to be embedded by this widget.
        ///
        /// A PlatformViewFactory for this type must have been registered.
        /// </Summary>
        public virtual string ViewType { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.platformViews.createdParam}
        /// </Summary>
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.platformViews.hittestParam}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.platformViews.directionParam}
        /// </Summary>
        public virtual TextDirection LayoutDirection { get; set; }
        /// <Summary>
        /// Passed as the `arguments` argument of [-\[FlutterPlatformViewFactory createWithFrame:viewIdentifier:arguments:\]](/objcdoc/Protocols/FlutterPlatformViewFactory.html#/c:objc(pl)FlutterPlatformViewFactory(im)createWithFrame:viewIdentifier:arguments:)
        ///
        /// This can be used by plugins to pass constructor parameters to the embedded iOS view.
        /// </Summary>
        public virtual object CreationParams { get; set; }
        /// <Summary>
        /// The codec used to encode `creationParams` before sending it to the
        /// platform side. It should match the codec returned by [-\[FlutterPlatformViewFactory createArgsCodec:\]](/objcdoc/Protocols/FlutterPlatformViewFactory.html#/c:objc(pl)FlutterPlatformViewFactory(im)createArgsCodec)
        ///
        /// This is typically one of: [StandardMessageCodec], [JSONMessageCodec], [StringCodec], or [BinaryCodec].
        ///
        /// This must not be null if [creationParams] is not null.
        /// </Summary>
        public virtual FlutterSDK.Services.Messagecodec.MessageCodec<object> CreationParamsCodec { get; set; }
        /// <Summary>
        /// Which gestures should be forwarded to the UIKit view.
        ///
        /// {@macro flutter.widgets.platformViews.gestureRecognizersDescHead}
        ///
        /// For example, with the following setup vertical drags will not be dispatched to the UIKit
        /// view as the vertical drag gesture is claimed by the parent [GestureDetector].
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails details) {},
        ///   child: UiKitView(
        ///     viewType: 'webview',
        ///   ),
        /// )
        /// ```
        ///
        /// To get the [UiKitView] to claim the vertical drag gestures we can pass a vertical drag
        /// gesture recognizer factory in [gestureRecognizers] e.g:
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails details) {},
        ///   child: SizedBox(
        ///     width: 200.0,
        ///     height: 100.0,
        ///     child: UiKitView(
        ///       viewType: 'webview',
        ///       gestureRecognizers: <Factory<OneSequenceGestureRecognizer>>[
        ///         new Factory<OneSequenceGestureRecognizer>(
        ///           () => new EagerGestureRecognizer(),
        ///         ),
        ///       ].toSet(),
        ///     ),
        ///   ),
        /// )
        /// ```
        ///
        /// {@macro flutter.widgets.platformViews.gestureRecognizersDescFoot}
        /// </Summary>
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.UiKitView> CreateState() => new _UiKitViewState();


    }


    /// <Summary>
    /// Embeds an HTML element in the Widget hierarchy in Flutter Web.
    ///
    /// *NOTE*: This only works in Flutter Web. To embed web content on other
    /// platforms, consider using the `flutter_webview` plugin.
    ///
    /// Embedding HTML is an expensive operation and should be avoided when a
    /// Flutter equivalent is possible.
    ///
    /// The embedded HTML is painted just like any other Flutter widget and
    /// transformations apply to it as well. This widget should only be used in
    /// Flutter Web.
    ///
    /// {@macro flutter.widgets.platformViews.layout}
    ///
    /// Due to security restrictions with cross-origin `<iframe>` elements, Flutter
    /// cannot dispatch pointer events to an HTML view. If an `<iframe>` is the
    /// target of an event, the window containing the `<iframe>` is not notified
    /// of the event. In particular, this means that any pointer events which land
    /// on an `<iframe>` will not be seen by Flutter, and so the HTML view cannot
    /// participate in gesture detection with other widgets.
    ///
    /// The way we enable accessibility on Flutter for web is to have a full-page
    /// button which waits for a double tap. Placing this full-page button in front
    /// of the scene would cause platform views not to receive pointer events. The
    /// tradeoff is that by placing the scene in front of the semantics placeholder
    /// will cause platform views to block pointer events from reaching the
    /// placeholder. This means that in order to enable accessibility, you must
    /// double tap the app *outside of a platform view*. As a consequence, a
    /// full-screen platform view will make it impossible to enable accessibility.
    /// Make sure that your HTML views are sized no larger than necessary, or you
    /// may cause difficulty for users trying to enable accessibility.
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    /// </Summary>
    public class HtmlElementView : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a platform view for Flutter Web.
        ///
        /// `viewType` identifies the type of platform view to create.
        /// </Summary>
        public HtmlElementView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string viewType = default(string))
        : base(key: key)
        {
            this.ViewType = viewType;
        }
        /// <Summary>
        /// The unique identifier for the HTML view type to be embedded by this widget.
        ///
        /// A PlatformViewFactory for this type must have been registered.
        /// </Summary>
        public virtual string ViewType { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new PlatformViewLink(viewType: ViewType, onCreatePlatformView: _CreateHtmlElementView, surfaceFactory: (BuildContext context, PlatformViewController controller) =>
            {
                return new PlatformViewSurface(controller: controller, gestureRecognizers: new Dictionary<Factory<OneSequenceGestureRecognizer>> { }, hitTestBehavior: PlatformViewHitTestBehavior.Opaque);
            }
            );
        }




        /// <Summary>
        /// Creates the controller and kicks off its initialization.
        /// </Summary>
        private FlutterSDK.Widgets.Platformview._HtmlElementViewController _CreateHtmlElementView(FlutterSDK.Widgets.Platformview.PlatformViewCreationParams params)
        {
            _HtmlElementViewController controller = new _HtmlElementViewController(params.Id, ViewType);
            controller._Initialize().Then((_) =>
            {
params.OnPlatformViewCreated(params.Id);
            }
            );
            return controller;
        }



    }


    public class _HtmlElementViewController : FlutterSDK.Services.Platformviews.PlatformViewController
    {
        public _HtmlElementViewController(int viewId, string viewType)
        {
            this.ViewId = viewId;
            this.ViewType = viewType;
        }
        public new int ViewId { get; set; }
        /// <Summary>
        /// The unique identifier for the HTML view type to be embedded by this widget.
        ///
        /// A PlatformViewFactory for this type must have been registered.
        /// </Summary>
        public virtual string ViewType { get; set; }
        internal virtual bool _Initialized { get; set; }

        private async Future<object> _Initialize()
        {
            Dictionary<string, object> args = new Dictionary<string, object> { { "id", ViewId }{ "viewType", ViewType } };
            await SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("create", args);
            _Initialized = true;
        }




        public new void ClearFocus()
        {
        }




        public new void DispatchPointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
        }




        public new void Dispose()
        {
            if (_Initialized)
            {
                SystemchannelsDefaultClass.SystemChannels.Platform_views.InvokeMethod("dispose", ViewId);
            }

        }



    }


    public class _AndroidViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.AndroidView>
    {
        public _AndroidViewState()
        { }
        internal virtual int _Id { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.AndroidViewController _Controller { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }
        internal virtual bool _Initialized { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }
        internal virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> _EmptyRecognizersSet { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Focus(focusNode: _FocusNode, onFocusChange: _OnFocusChange, child: new _AndroidPlatformView(controller: _Controller, hitTestBehavior: Widget.HitTestBehavior, gestureRecognizers: Widget.GestureRecognizers ?? _EmptyRecognizersSet));
        }




        private void _InitializeOnce()
        {
            if (_Initialized)
            {
                return;
            }

            _Initialized = true;
            _CreateNewAndroidView();
            _FocusNode = new FocusNode(debugLabel: $"'AndroidView(id: {_Id})'");
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            _InitializeOnce();
            if (didChangeLayoutDirection)
            {
                _Controller.SetLayoutDirection(_LayoutDirection);
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.AndroidView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller.Dispose();
                _CreateNewAndroidView();
                return;
            }

            if (didChangeLayoutDirection)
            {
                _Controller.SetLayoutDirection(_LayoutDirection);
            }

        }




        private TextDirection _FindLayoutDirection()
        {

            return Widget.LayoutDirection ?? BasicDefaultClass.Directionality.Of(Context);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private void _CreateNewAndroidView()
        {
            _Id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            _Controller = PlatformviewsDefaultClass.PlatformViewsService.InitAndroidView(id: _Id, viewType: Widget.ViewType, layoutDirection: _LayoutDirection, creationParams: Widget.CreationParams, creationParamsCodec: Widget.CreationParamsCodec, onFocus: () =>
            {
                _FocusNode.RequestFocus();
            }
            );
            if (Widget.OnPlatformViewCreated != null)
            {
                _Controller.AddOnPlatformViewCreatedListener(Widget.OnPlatformViewCreated);
            }

        }




        private void _OnFocusChange(bool isFocused)
        {
            if (!_Controller.IsCreated)
            {
                return;
            }

            if (!isFocused)
            {
                _Controller.ClearFocus().CatchError((object e) =>
                {
                    if (((MissingPluginException)e) is MissingPluginException)
                    {
                        return;
                    }

                }
                );
                return;
            }

            SystemchannelsDefaultClass.SystemChannels.TextInput.InvokeMethod("TextInput.setPlatformViewClient", _Id).CatchError((object e) =>
            {
                if (e is MissingPluginException)
                {
                    return;
                }

            }
            );
        }



    }


    public class _UiKitViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.UiKitView>
    {
        public _UiKitViewState()
        { }
        internal virtual FlutterSDK.Services.Platformviews.UiKitViewController _Controller { get; set; }
        internal virtual TextDirection _LayoutDirection { get; set; }
        internal virtual bool _Initialized { get; set; }
        internal virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> _EmptyRecognizersSet { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Controller == null)
            {
                return SizedBox.Expand();
            }

            return new _UiKitPlatformView(controller: _Controller, hitTestBehavior: Widget.HitTestBehavior, gestureRecognizers: Widget.GestureRecognizers ?? _EmptyRecognizersSet);
        }




        private void _InitializeOnce()
        {
            if (_Initialized)
            {
                return;
            }

            _Initialized = true;
            _CreateNewUiKitView();
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            _InitializeOnce();
            if (didChangeLayoutDirection)
            {
                _Controller?.SetLayoutDirection(_LayoutDirection);
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.UiKitView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            TextDirection newLayoutDirection = _FindLayoutDirection();
            bool didChangeLayoutDirection = _LayoutDirection != newLayoutDirection;
            _LayoutDirection = newLayoutDirection;
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller?.Dispose();
                _CreateNewUiKitView();
                return;
            }

            if (didChangeLayoutDirection)
            {
                _Controller?.SetLayoutDirection(_LayoutDirection);
            }

        }




        private TextDirection _FindLayoutDirection()
        {

            return Widget.LayoutDirection ?? BasicDefaultClass.Directionality.Of(Context);
        }




        public new void Dispose()
        {
            _Controller?.Dispose();
            base.Dispose();
        }




        private async Future<object> _CreateNewUiKitView()
        {
            int id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            UiKitViewController controller = await PlatformviewsDefaultClass.PlatformViewsService.InitUiKitView(id: id, viewType: Widget.ViewType, layoutDirection: _LayoutDirection, creationParams: Widget.CreationParams, creationParamsCodec: Widget.CreationParamsCodec);
            if (!Mounted)
            {
                controller.Dispose();
                return;
            }

            if (Widget.OnPlatformViewCreated != null)
            {
                Widget.OnPlatformViewCreated(id);
            }

            SetState(() =>
            {
                _Controller = controller;
            }
            );
        }



    }


    public class _AndroidPlatformView : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _AndroidPlatformView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.AndroidViewController controller = default(FlutterSDK.Services.Platformviews.AndroidViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        public virtual FlutterSDK.Services.Platformviews.AndroidViewController Controller { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderAndroidView(viewController: Controller, hitTestBehavior: HitTestBehavior, gestureRecognizers: GestureRecognizers);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.RenderAndroidView renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



    }


    public class _UiKitPlatformView : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _UiKitPlatformView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.UiKitViewController controller = default(FlutterSDK.Services.Platformviews.UiKitViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        public virtual FlutterSDK.Services.Platformviews.UiKitViewController Controller { get; set; }
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderUiKitView(viewController: Controller, hitTestBehavior: HitTestBehavior, gestureRecognizers: GestureRecognizers);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.RenderUiKitView renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewController = Controller;
            renderObject.HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



    }


    /// <Summary>
    /// The parameters used to create a [PlatformViewController].
    ///
    /// See also:
    ///
    ///  * [CreatePlatformViewCallback] which uses this object to create a [PlatformViewController].
    /// </Summary>
    public class PlatformViewCreationParams
    {
        internal PlatformViewCreationParams(int id = default(int), string viewType = default(string), FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback onPlatformViewCreated = default(FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>))
        : base()
        {
            this.Id = id;
            this.ViewType = viewType;
            this.OnPlatformViewCreated = onPlatformViewCreated;
            this.OnFocusChanged = onFocusChanged;
        }
        /// <Summary>
        /// The unique identifier for the new platform view.
        ///
        /// [PlatformViewController.viewId] should match this id.
        /// </Summary>
        public virtual int Id { get; set; }
        /// <Summary>
        /// The unique identifier for the type of platform view to be embedded.
        ///
        /// This viewType is used to tell the platform which type of view to
        /// associate with the [id].
        /// </Summary>
        public virtual string ViewType { get; set; }
        /// <Summary>
        /// Callback invoked after the platform view has been created.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformviews.PlatformViewCreatedCallback OnPlatformViewCreated { get; set; }
        /// <Summary>
        /// Callback invoked when the platform view's focus is changed on the platform side.
        ///
        /// The value is true when the platform view gains focus and false when it loses focus.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChanged { get; set; }
    }


    /// <Summary>
    /// Links a platform view with the Flutter framework.
    ///
    /// Provides common functionality for embedding a platform view (e.g an android.view.View on Android)
    /// with the Flutter framework.
    ///
    /// {@macro flutter.widgets.platformViews.lifetime}
    ///
    /// To implement a new platform view widget, return this widget in the `build` method.
    /// For example:
    /// ```dart
    /// class FooPlatformView extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return PlatformViewLink(
    ///       viewType: 'webview',
    ///       onCreatePlatformView: createFooWebView,
    ///       surfaceFactory: (BuildContext context, PlatformViewController controller) {
    ///        return PlatformViewSurface(
    ///            gestureRecognizers: gestureRecognizers,
    ///            controller: controller,
    ///            hitTestBehavior: PlatformViewHitTestBehavior.opaque,
    ///        );
    ///       },
    ///    );
    ///   }
    /// }
    /// ```
    ///
    /// The `surfaceFactory` and the `onCreatePlatformView` are only called when the
    /// state of this widget is initialized, or when the `viewType` changes.
    /// </Summary>
    public class PlatformViewLink : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Construct a [PlatformViewLink] widget.
        ///
        /// The `surfaceFactory` and the `onCreatePlatformView` must not be null.
        ///
        /// See also:
        ///
        ///  * [PlatformViewSurface] for details on the widget returned by `surfaceFactory`.
        ///  * [PlatformViewCreationParams] for how each parameter can be used when implementing `createPlatformView`.
        /// </Summary>
        public PlatformViewLink(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory surfaceFactory = default(FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory), FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback onCreatePlatformView = default(FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback), string viewType = default(string))
        : base(key: key)
        {
            this.ViewType = viewType;
        }
        internal virtual FlutterSDK.Widgets.Platformview.PlatformViewSurfaceFactory _SurfaceFactory { get; set; }
        internal virtual FlutterSDK.Widgets.Platformview.CreatePlatformViewCallback _OnCreatePlatformView { get; set; }
        /// <Summary>
        /// The unique identifier for the view type to be embedded.
        ///
        /// Typically, this viewType has already been registered on the platform side.
        /// </Summary>
        public virtual string ViewType { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _PlatformViewLinkState();


    }


    public class _PlatformViewLinkState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Platformview.PlatformViewLink>
    {
        public _PlatformViewLinkState()
        { }
        internal virtual int _Id { get; set; }
        internal virtual FlutterSDK.Services.Platformviews.PlatformViewController _Controller { get; set; }
        internal virtual bool _PlatformViewCreated { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Surface { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _FocusNode { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (!_PlatformViewCreated)
            {
                return SizedBox.Expand();
            }

            _Surface = (_Surface == null ? Widget._SurfaceFactory(context, _Controller) : _Surface);
            return new Focus(focusNode: _FocusNode, onFocusChange: _HandleFrameworkFocusChanged, child: _Surface);
        }




        public new void InitState()
        {
            _FocusNode = new FocusNode(debugLabel: $"'PlatformView(id: {_Id})'");
            _Initialize();
            base.InitState();
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Platformview.PlatformViewLink oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.ViewType != oldWidget.ViewType)
            {
                _Controller?.Dispose();
                _Surface = null;
                _PlatformViewCreated = false;
                _Initialize();
            }

        }




        private void _Initialize()
        {
            _Id = PlatformviewsDefaultClass.PlatformViewsRegistry.GetNextPlatformViewId();
            _Controller = Widget._OnCreatePlatformView(PlatformViewCreationParams._(id: _Id, viewType: Widget.ViewType, onPlatformViewCreated: _OnPlatformViewCreated, onFocusChanged: _HandlePlatformFocusChanged));
        }




        private void _OnPlatformViewCreated(int id)
        {
            SetState(() =>
            {
                _PlatformViewCreated = true;
            }
            );
        }




        private void _HandleFrameworkFocusChanged(bool isFocused)
        {
            if (!isFocused)
            {
                _Controller?.ClearFocus();
            }

        }




        private void _HandlePlatformFocusChanged(bool isFocused)
        {
            if (isFocused)
            {
                _FocusNode.RequestFocus();
            }

        }




        public new void Dispose()
        {
            _Controller?.Dispose();
            _Controller = null;
            base.Dispose();
        }



    }


    /// <Summary>
    /// Integrates a platform view with Flutter's compositor, touch, and semantics subsystems.
    ///
    /// The compositor integration is done by adding a [PlatformViewLayer] to the layer tree. [PlatformViewLayer]
    /// isn't supported on all platforms (e.g on Android platform views are composited using a [TextureLayer]).
    /// Custom Flutter embedders can support [PlatformViewLayer]s by implementing a SystemCompositor.
    ///
    /// The widget fills all available space, the parent of this object must provide bounded layout
    /// constraints.
    ///
    /// If the associated platform view is not created the [PlatformViewSurface] does not paint any contents.
    ///
    /// See also:
    ///
    ///  * [AndroidView] which embeds an Android platform view in the widget hierarchy.
    ///  * [UIKitView] which embeds an iOS platform view in the widget hierarchy.
    /// </Summary>
    public class PlatformViewSurface : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        /// <Summary>
        /// Construct a `PlatformViewSurface`.
        ///
        /// The [controller] must not be null.
        /// </Summary>
        public PlatformViewSurface(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Platformviews.PlatformViewController controller = default(FlutterSDK.Services.Platformviews.PlatformViewController), FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior hitTestBehavior = default(FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior), HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> gestureRecognizers = default(HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>>))
        : base(key: key)
        {
            this.Controller = controller;
            this.HitTestBehavior = hitTestBehavior;
            this.GestureRecognizers = gestureRecognizers;
        }
        /// <Summary>
        /// The controller for the platform view integrated by this [PlatformViewSurface].
        ///
        /// [PlatformViewController] is used for dispatching touch events to the platform view.
        /// [PlatformViewController.viewId] identifies the platform view whose contents are painted by this widget.
        /// </Summary>
        public virtual FlutterSDK.Services.Platformviews.PlatformViewController Controller { get; set; }
        /// <Summary>
        /// Which gestures should be forwarded to the PlatformView.
        ///
        /// {@macro flutter.widgets.platformViews.gestureRecognizersDescHead}
        ///
        /// For example, with the following setup vertical drags will not be dispatched to the platform view
        /// as the vertical drag gesture is claimed by the parent [GestureDetector].
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails details) {},
        ///   child: PlatformViewSurface(
        ///   ),
        /// )
        /// ```
        ///
        /// To get the [PlatformViewSurface] to claim the vertical drag gestures we can pass a vertical drag
        /// gesture recognizer factory in [gestureRecognizers] e.g:
        ///
        /// ```dart
        /// GestureDetector(
        ///   onVerticalDragStart: (DragStartDetails details) {},
        ///   child: SizedBox(
        ///     width: 200.0,
        ///     height: 100.0,
        ///     child: PlatformViewSurface(
        ///       gestureRecognizers: <Factory<OneSequenceGestureRecognizer>>[
        ///         new Factory<OneSequenceGestureRecognizer>(
        ///           () => new EagerGestureRecognizer(),
        ///         ),
        ///       ].toSet(),
        ///     ),
        ///   ),
        /// )
        /// ```
        ///
        /// {@macro flutter.widgets.platformViews.gestureRecognizersDescFoot}
        /// </Summary>
        public virtual HashSet<FlutterSDK.Foundation.Basictypes.Factory<FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer>> GestureRecognizers { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.platformViews.hittestParam}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Platformview.PlatformViewHitTestBehavior HitTestBehavior { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new PlatformViewRenderBox(controller: Controller, gestureRecognizers: GestureRecognizers, hitTestBehavior: HitTestBehavior);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Platformview.PlatformViewRenderBox renderObject)
        {
            ..Controller = Controller..HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Controller = Controller..HitTestBehavior = HitTestBehavior;
            renderObject.UpdateGestureRecognizers(GestureRecognizers);
        }



    }

}
