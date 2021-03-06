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
namespace FlutterSDK.Painting.Imageprovider
{
    /// <Summary>
    /// Signature for the callback taken by [_createErrorHandlerAndKey].
    /// </Summary>
    public delegate void _KeyAndErrorHandlerCallback<T>(T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError);
    /// <Summary>
    /// Signature used for error handling by [_createErrorHandlerAndKey].
    /// </Summary>
    public delegate Future<object> _AsyncKeyErrorHandler<T>(T key, object exception, StackTrace stack);
    /// <Summary>
    /// Performs the decode process for use in [ImageProvider.load].
    ///
    /// This callback allows decoupling of the `cacheWidth` and `cacheHeight`
    /// parameters from implementations of [ImageProvider] that do not use them.
    ///
    /// See also:
    ///
    ///  * [ResizeImage], which uses this to override the `cacheWidth` and `cacheHeight` parameters.
    /// </Summary>
    public delegate Future<SKCodec> DecoderCallback(Uint8List bytes, int cacheWidth = default(int), int cacheHeight = default(int));
    internal static class ImageproviderDefaultClass
    {
    }

    /// <Summary>
    /// Identifies an image without committing to the precise final asset. This
    /// allows a set of images to be identified and for the precise image to later
    /// be resolved based on the environment, e.g. the device pixel ratio.
    ///
    /// To obtain an [ImageStream] from an [ImageProvider], call [resolve],
    /// passing it an [ImageConfiguration] object.
    ///
    /// [ImageProvider] uses the global [imageCache] to cache images.
    ///
    /// The type argument `T` is the type of the object used to represent a resolved
    /// configuration. This is also the type used for the key in the image cache. It
    /// should be immutable and implement the [==] operator and the [hashCode]
    /// getter. Subclasses should subclass a variant of [ImageProvider] with an
    /// explicit `T` type argument.
    ///
    /// The type argument does not have to be specified when using the type as an
    /// argument (where any image provider is acceptable).
    ///
    /// The following image formats are supported: {@macro flutter.dart:ui.imageFormats}
    ///
    /// ## Lifecycle of resolving an image
    ///
    /// The [ImageProvider] goes through the following lifecycle to resolve an
    /// image, once the [resolve] method is called:
    ///
    ///   1. Create an [ImageStream] using [createStream] to return to the caller.
    ///      This stream will be used to communicate back to the caller when the
    ///      image is decoded and ready to display, or when an error occurs.
    ///   2. Obtain the key for the image using [obtainKey].
    ///      Calling this method can throw exceptions into the zone asynchronously
    ///      or into the callstack synchronously. To handle that, an error handler
    ///      is created that catches both synchronous and asynchronous errors, to
    ///      make sure errors can be routed to the correct consumers.
    ///      The error handler is passed on to [resolveStreamForKey] and the
    ///      [ImageCache].
    ///   3. If the key is successfully obtained, schedule resolution of the image
    ///      using that key. This is handled by [resolveStreamForKey]. That method
    ///      may fizzle if it determines the image is no longer necessary, use the
    ///      provided [ImageErrorListener] to report an error, set the completer
    ///      from the cache if possible, or call [load] to fetch the encoded image
    ///      bytes and schedule decoding.
    ///   4. The [load] method is responsible for both fetching the encoded bytes
    ///      and decoding them using the provided [DecoderCallback]. It is called
    ///      in a context that uses the [ImageErrorListener] to report errors back.
    ///
    /// Subclasses normally only have to implement the [load] and [obtainKey]
    /// methods. A subclass that needs finer grained control over the [ImageStream]
    /// type must override [createStream]. A subclass that needs finer grained
    /// control over the resolution, such as delaying calling [load], must override
    /// [resolveStreamForKey].
    ///
    /// The [resolve] method is marked as [nonVirtual] so that [ImageProvider]s can
    /// be properly composed, and so that the base class can properly set up error
    /// handling for subsequent methods.
    ///
    /// ## Using an [ImageProvider]
    ///
    /// {@tool snippet}
    ///
    /// The following shows the code required to write a widget that fully conforms
    /// to the [ImageProvider] and [Widget] protocols. (It is essentially a
    /// bare-bones version of the [widgets.Image] widget.)
    ///
    /// ```dart
    /// class MyImage extends StatefulWidget {
    ///   const MyImage({
    ///     Key key,
    ///     @required this.imageProvider,
    ///   }) : assert(imageProvider != null),
    ///        super(key: key);
    ///
    ///   final ImageProvider imageProvider;
    ///
    ///   @override
    ///   _MyImageState createState() => _MyImageState();
    /// }
    ///
    /// class _MyImageState extends State<MyImage> {
    ///   ImageStream _imageStream;
    ///   ImageInfo _imageInfo;
    ///
    ///   @override
    ///   void didChangeDependencies() {
    ///     super.didChangeDependencies();
    ///     // We call _getImage here because createLocalImageConfiguration() needs to
    ///     // be called again if the dependencies changed, in case the changes relate
    ///     // to the DefaultAssetBundle, MediaQuery, etc, which that method uses.
    ///     _getImage();
    ///   }
    ///
    ///   @override
    ///   void didUpdateWidget(MyImage oldWidget) {
    ///     super.didUpdateWidget(oldWidget);
    ///     if (widget.imageProvider != oldWidget.imageProvider)
    ///       _getImage();
    ///   }
    ///
    ///   void _getImage() {
    ///     final ImageStream oldImageStream = _imageStream;
    ///     _imageStream = widget.imageProvider.resolve(createLocalImageConfiguration(context));
    ///     if (_imageStream.key != oldImageStream?.key) {
    ///       // If the keys are the same, then we got the same image back, and so we don't
    ///       // need to update the listeners. If the key changed, though, we must make sure
    ///       // to switch our listeners to the new image stream.
    ///       final ImageStreamListener listener = ImageStreamListener(_updateImage);
    ///       oldImageStream?.removeListener(listener);
    ///       _imageStream.addListener(listener);
    ///     }
    ///   }
    ///
    ///   void _updateImage(ImageInfo imageInfo, bool synchronousCall) {
    ///     setState(() {
    ///       // Trigger a build whenever the image changes.
    ///       _imageInfo = imageInfo;
    ///     });
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _imageStream.removeListener(ImageStreamListener(_updateImage));
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return RawImage(
    ///       image: _imageInfo?.image, // this is a dart:ui Image object
    ///       scale: _imageInfo?.scale ?? 1.0,
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public interface IImageProvider<T>
    {
        FlutterSDK.Painting.Imagestream.ImageStream Resolve(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        FlutterSDK.Painting.Imagestream.ImageStream CreateStream(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        Future<FlutterSDK.Painting.Imagecache.ImageCacheStatus> ObtainCacheStatus(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Painting.Imagestream.ImageErrorListener handleError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener));
        void ResolveStreamForKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imagestream.ImageStream stream, T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError);
        Future<bool> Evict(FlutterSDK.Painting.Imagecache.ImageCache cache = default(FlutterSDK.Painting.Imagecache.ImageCache), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration));
        Future<T> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration);
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(T key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
        string ToString();
    }


    /// <Summary>
    /// A subclass of [ImageProvider] that knows about [AssetBundle]s.
    ///
    /// This factors out the common logic of [AssetBundle]-based [ImageProvider]
    /// classes, simplifying what subclasses must implement to just [obtainKey].
    /// </Summary>
    public interface IAssetBundleImageProvider
    {
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
    }


    /// <Summary>
    /// Fetches the given URL from the network, associating it with the given scale.
    ///
    /// The image will be cached regardless of cache headers from the server.
    ///
    /// When a network image is used on the Web platform, the [cacheWidth] and
    /// [cacheHeight] parameters of the [DecoderCallback] are ignored as the Web
    /// engine delegates image decoding of network images to the Web, which does
    /// not support custom decode sizes.
    ///
    /// See also:
    ///
    ///  * [Image.network] for a shorthand of an [Image] widget backed by [NetworkImage].
    /// </Summary>
    public interface INetworkImage
    {
        FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.NetworkImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode);
        string Url { get; }
        double Scale { get; }
        Dictionary<string, string> Headers { get; }
    }


    /// <Summary>
    /// Configuration information passed to the [ImageProvider.resolve] method to
    /// select a specific image.
    ///
    /// See also:
    ///
    ///  * [createLocalImageConfiguration], which creates an [ImageConfiguration]
    ///    based on ambient configuration in a [Widget] environment.
    ///  * [ImageProvider], which uses [ImageConfiguration] objects to determine
    ///    which image to obtain.
    /// </Summary>
    public class ImageConfiguration
    {
        /// <Summary>
        /// Creates an object holding the configuration information for an [ImageProvider].
        ///
        /// All the arguments are optional. Configuration information is merely
        /// advisory and best-effort.
        /// </Summary>
        public ImageConfiguration(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double devicePixelRatio = default(double), Locale locale = default(Locale), TextDirection textDirection = default(TextDirection), Size size = default(Size), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform))
        {
            this.Bundle = bundle;
            this.DevicePixelRatio = devicePixelRatio;
            this.Locale = locale;
            this.TextDirection = textDirection;
            this.Size = size;
            this.Platform = platform;
        }
        /// <Summary>
        /// The preferred [AssetBundle] to use if the [ImageProvider] needs one and
        /// does not have one already selected.
        /// </Summary>
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        /// <Summary>
        /// The device pixel ratio where the image will be shown.
        /// </Summary>
        public virtual double DevicePixelRatio { get; set; }
        /// <Summary>
        /// The language and region for which to select the image.
        /// </Summary>
        public virtual Locale Locale { get; set; }
        /// <Summary>
        /// The reading direction of the language for which to select the image.
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// The size at which the image will be rendered.
        /// </Summary>
        public virtual Size Size { get; set; }
        /// <Summary>
        /// The [TargetPlatform] for which assets should be used. This allows images
        /// to be specified in a platform-neutral fashion yet use different assets on
        /// different platforms, to match local conventions e.g. for color matching or
        /// shadows.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform { get; set; }
        /// <Summary>
        /// An image configuration that provides no additional information.
        ///
        /// Useful when resolving an [ImageProvider] without any context.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Empty { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates an object holding the configuration information for an [ImageProvider].
        ///
        /// All the arguments are optional. Configuration information is merely
        /// advisory and best-effort.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration CopyWith(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double devicePixelRatio = default(double), Locale locale = default(Locale), TextDirection textDirection = default(TextDirection), Size size = default(Size), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform))
        {
            return new ImageConfiguration(bundle: bundle ?? this.Bundle, devicePixelRatio: devicePixelRatio == default(double) ? this.devicePixelRatio : devicePixelRatio, locale: locale ?? this.Locale, textDirection: textDirection ?? this.TextDirection, size: size ?? this.Size, platform: platform ?? this.Platform);
        }




        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is ImageConfiguration && other.Bundle == Bundle && other.DevicePixelRatio == DevicePixelRatio && other.Locale == Locale && other.TextDirection == TextDirection && other.Size == Size && other.Platform == Platform;
        }




    }


    /// <Summary>
    /// Identifies an image without committing to the precise final asset. This
    /// allows a set of images to be identified and for the precise image to later
    /// be resolved based on the environment, e.g. the device pixel ratio.
    ///
    /// To obtain an [ImageStream] from an [ImageProvider], call [resolve],
    /// passing it an [ImageConfiguration] object.
    ///
    /// [ImageProvider] uses the global [imageCache] to cache images.
    ///
    /// The type argument `T` is the type of the object used to represent a resolved
    /// configuration. This is also the type used for the key in the image cache. It
    /// should be immutable and implement the [==] operator and the [hashCode]
    /// getter. Subclasses should subclass a variant of [ImageProvider] with an
    /// explicit `T` type argument.
    ///
    /// The type argument does not have to be specified when using the type as an
    /// argument (where any image provider is acceptable).
    ///
    /// The following image formats are supported: {@macro flutter.dart:ui.imageFormats}
    ///
    /// ## Lifecycle of resolving an image
    ///
    /// The [ImageProvider] goes through the following lifecycle to resolve an
    /// image, once the [resolve] method is called:
    ///
    ///   1. Create an [ImageStream] using [createStream] to return to the caller.
    ///      This stream will be used to communicate back to the caller when the
    ///      image is decoded and ready to display, or when an error occurs.
    ///   2. Obtain the key for the image using [obtainKey].
    ///      Calling this method can throw exceptions into the zone asynchronously
    ///      or into the callstack synchronously. To handle that, an error handler
    ///      is created that catches both synchronous and asynchronous errors, to
    ///      make sure errors can be routed to the correct consumers.
    ///      The error handler is passed on to [resolveStreamForKey] and the
    ///      [ImageCache].
    ///   3. If the key is successfully obtained, schedule resolution of the image
    ///      using that key. This is handled by [resolveStreamForKey]. That method
    ///      may fizzle if it determines the image is no longer necessary, use the
    ///      provided [ImageErrorListener] to report an error, set the completer
    ///      from the cache if possible, or call [load] to fetch the encoded image
    ///      bytes and schedule decoding.
    ///   4. The [load] method is responsible for both fetching the encoded bytes
    ///      and decoding them using the provided [DecoderCallback]. It is called
    ///      in a context that uses the [ImageErrorListener] to report errors back.
    ///
    /// Subclasses normally only have to implement the [load] and [obtainKey]
    /// methods. A subclass that needs finer grained control over the [ImageStream]
    /// type must override [createStream]. A subclass that needs finer grained
    /// control over the resolution, such as delaying calling [load], must override
    /// [resolveStreamForKey].
    ///
    /// The [resolve] method is marked as [nonVirtual] so that [ImageProvider]s can
    /// be properly composed, and so that the base class can properly set up error
    /// handling for subsequent methods.
    ///
    /// ## Using an [ImageProvider]
    ///
    /// {@tool snippet}
    ///
    /// The following shows the code required to write a widget that fully conforms
    /// to the [ImageProvider] and [Widget] protocols. (It is essentially a
    /// bare-bones version of the [widgets.Image] widget.)
    ///
    /// ```dart
    /// class MyImage extends StatefulWidget {
    ///   const MyImage({
    ///     Key key,
    ///     @required this.imageProvider,
    ///   }) : assert(imageProvider != null),
    ///        super(key: key);
    ///
    ///   final ImageProvider imageProvider;
    ///
    ///   @override
    ///   _MyImageState createState() => _MyImageState();
    /// }
    ///
    /// class _MyImageState extends State<MyImage> {
    ///   ImageStream _imageStream;
    ///   ImageInfo _imageInfo;
    ///
    ///   @override
    ///   void didChangeDependencies() {
    ///     super.didChangeDependencies();
    ///     // We call _getImage here because createLocalImageConfiguration() needs to
    ///     // be called again if the dependencies changed, in case the changes relate
    ///     // to the DefaultAssetBundle, MediaQuery, etc, which that method uses.
    ///     _getImage();
    ///   }
    ///
    ///   @override
    ///   void didUpdateWidget(MyImage oldWidget) {
    ///     super.didUpdateWidget(oldWidget);
    ///     if (widget.imageProvider != oldWidget.imageProvider)
    ///       _getImage();
    ///   }
    ///
    ///   void _getImage() {
    ///     final ImageStream oldImageStream = _imageStream;
    ///     _imageStream = widget.imageProvider.resolve(createLocalImageConfiguration(context));
    ///     if (_imageStream.key != oldImageStream?.key) {
    ///       // If the keys are the same, then we got the same image back, and so we don't
    ///       // need to update the listeners. If the key changed, though, we must make sure
    ///       // to switch our listeners to the new image stream.
    ///       final ImageStreamListener listener = ImageStreamListener(_updateImage);
    ///       oldImageStream?.removeListener(listener);
    ///       _imageStream.addListener(listener);
    ///     }
    ///   }
    ///
    ///   void _updateImage(ImageInfo imageInfo, bool synchronousCall) {
    ///     setState(() {
    ///       // Trigger a build whenever the image changes.
    ///       _imageInfo = imageInfo;
    ///     });
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _imageStream.removeListener(ImageStreamListener(_updateImage));
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return RawImage(
    ///       image: _imageInfo?.image, // this is a dart:ui Image object
    ///       scale: _imageInfo?.scale ?? 1.0,
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class ImageProvider<T>
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public ImageProvider()
        {

        }

        /// <Summary>
        /// Resolves this image provider using the given `configuration`, returning
        /// an [ImageStream].
        ///
        /// This is the public entry-point of the [ImageProvider] class hierarchy.
        ///
        /// Subclasses should implement [obtainKey] and [load], which are used by this
        /// method. If they need to change the implementation of [ImageStream] used,
        /// they should override [createStream]. If they need to manage the actual
        /// resolution of the image, they should override [resolveStreamForKey].
        ///
        /// See the Lifecycle documentation on [ImageProvider] for more information.
        /// </Summary>
        public virtual FlutterSDK.Painting.Imagestream.ImageStream Resolve(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {

            ImageStream stream = CreateStream(configuration);
            _CreateErrorHandlerAndKey(configuration, (T key, ImageErrorListener errorHandler) =>
            {
                ResolveStreamForKey(configuration, stream, key, errorHandler);
            }
            , async (T key, object exception, StackTrace stack) =>
            {
                await null;
                _ErrorImageCompleter imageCompleter = new _ErrorImageCompleter();
                stream.SetCompleter(imageCompleter);
                InformationCollector collector = default(InformationCollector);

                imageCompleter.SetError(exception: exception, stack: stack, context: new ErrorDescription("while resolving an image"), silent: true, informationCollector: collector);
            }
            );
            return stream;
        }




        /// <Summary>
        /// Called by [resolve] to create the [ImageStream] it returns.
        ///
        /// Subclasses should override this instead of [resolve] if they need to
        /// return some subclass of [ImageStream]. The stream created here will be
        /// passed to [resolveStreamForKey].
        /// </Summary>
        public virtual FlutterSDK.Painting.Imagestream.ImageStream CreateStream(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {
            return new ImageStream();
        }




        /// <Summary>
        /// Returns the cache location for the key that this [ImageProvider] creates.
        ///
        /// The location may be [ImageCacheStatus.untracked], indicating that this
        /// image provider's key is not available in the [ImageCache].
        ///
        /// The `cache` and `configuration` parameters must not be null. If the
        /// `handleError` parameter is null, errors will be reported to
        /// [FlutterError.onError], and the method will return null.
        ///
        /// A completed return value of null indicates that an error has occurred.
        /// </Summary>
        public virtual Future<FlutterSDK.Painting.Imagecache.ImageCacheStatus> ObtainCacheStatus(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Painting.Imagestream.ImageErrorListener handleError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener))
        {

            Completer<ImageCacheStatus> completer = Completer.CreateNew<ImageCacheStatus>();
            _CreateErrorHandlerAndKey(configuration, (T key, ImageErrorListener innerHandleError) =>
            {
                completer.Complete(BindingDefaultClass.PaintingBinding.Instance.ImageCache.StatusForKey(key));
            }
            , async (T key, object exception, StackTrace stack) =>
            {
                if (handleError != null)
                {
                    handleError(exception, stack);
                }
                else
                {
                    InformationCollector collector = default(InformationCollector);

                    AssertionsDefaultClass.FlutterError.OnError(new FlutterErrorDetails(context: new ErrorDescription("while checking the cache location of an image"), informationCollector: collector, exception: exception, stack: stack));
                    completer.Complete(null);
                }

            }
            );
            return completer.Future;
        }




        /// <Summary>
        /// This method is used by both [resolve] and [obtainCacheStatus] to ensure
        /// that errors thrown during key creation are handled whether synchronous or
        /// asynchronous.
        /// </Summary>
        private void _CreateErrorHandlerAndKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imageprovider._KeyAndErrorHandlerCallback<T> successCallback, FlutterSDK.Painting.Imageprovider._AsyncKeyErrorHandler<T> errorCallback)
        {
            T obtainedKey = default(T);
            bool didError = false;
            async Future<void> HandleError(object exception, StackTrace stack)
            {
                if (didError)
                {
                    return;
                }

                if (!didError)
                {
                    errorCallback(obtainedKey, exception, stack);
                }

                didError = true;
            }

            Zone dangerZone = Dart.AsyncDefaultClass.Zone.Current.Fork(specification: ZoneSpecification.CreateNew(handleUncaughtError: (Zone zone, ZoneDelegate delegate, Zone parent, object error, StackTrace stackTrace) => {
                HandleError(error, stackTrace);
            }
));
            dangerZone.RunGuarded(() =>
            {
            Future<T> key = default(Future<T>);
            try
            {
                key = ObtainKey(configuration);
            }
            catch (error,stackTrace){
                HandleError(error, stackTrace);
                return;
            }

            key.Then((T key) =>
            {
            obtainedKey = key;
            try
            {
                successCallback(key, HandleError);
            }
            catch (error,stackTrace){
                HandleError(error, stackTrace);
            }

        }
).CatchError(HandleError);
    }
);
}




/// <Summary>
/// Called by [resolve] with the key returned by [obtainKey].
///
/// Subclasses should override this method rather than calling [obtainKey] if
/// they need to use a key directly. The [resolve] method installs appropriate
/// error handling guards so that errors will bubble up to the right places in
/// the framework, and passes those guards along to this method via the
/// [handleError] parameter.
///
/// It is safe for the implementation of this method to call [handleError]
/// multiple times if multiple errors occur, or if an error is thrown both
/// synchronously into the current part of the stack and thrown into the
/// enclosing [Zone].
///
/// The default implementation uses the key to interact with the [ImageCache],
/// calling [ImageCache.putIfAbsent] and notifying listeners of the [stream].
/// Implementers that do not call super are expected to correctly use the
/// [ImageCache].
/// </Summary>
public virtual void ResolveStreamForKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration, FlutterSDK.Painting.Imagestream.ImageStream stream, T key, FlutterSDK.Painting.Imagestream.ImageErrorListener handleError)
{
    if (stream.Completer != null)
    {
        ImageStreamCompleter completer = BindingDefaultClass.PaintingBinding.Instance.ImageCache.PutIfAbsent(key, () => =>stream.Completer, onError: handleError);

        return;
    }

    ImageStreamCompleter completer = BindingDefaultClass.PaintingBinding.Instance.ImageCache.PutIfAbsent(key, () => =>Load(key, BindingDefaultClass.PaintingBinding.Instance.InstantiateImageCodec), onError: handleError);
    if (completer != null)
    {
        stream.SetCompleter(completer);
    }

}




/// <Summary>
/// Evicts an entry from the image cache.
///
/// Returns a [Future] which indicates whether the value was successfully
/// removed.
///
/// The [ImageProvider] used does not need to be the same instance that was
/// passed to an [Image] widget, but it does need to create a key which is
/// equal to one.
///
/// The [cache] is optional and defaults to the global image cache.
///
/// The [configuration] is optional and defaults to
/// [ImageConfiguration.empty].
///
/// {@tool snippet}
///
/// The following sample code shows how an image loaded using the [Image]
/// widget can be evicted using a [NetworkImage] with a matching URL.
///
/// ```dart
/// class MyWidget extends StatelessWidget {
///   final String url = '...';
///
///   @override
///   Widget build(BuildContext context) {
///     return Image.network(url);
///   }
///
///   void evictImage() {
///     final NetworkImage provider = NetworkImage(url);
///     provider.evict().then<void>((bool success) {
///       if (success)
///         debugPrint('removed image!');
///     });
///   }
/// }
/// ```
/// {@end-tool}
/// </Summary>
public virtual async Future<bool> Evict(FlutterSDK.Painting.Imagecache.ImageCache cache = default(FlutterSDK.Painting.Imagecache.ImageCache), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration))
{
    cache = (cache == null ? BindingDefaultClass.ImageCache : cache);
    T key = await ObtainKey(configuration);
    return cache.Evict(key);
}




/// <Summary>
/// Converts an ImageProvider's settings plus an ImageConfiguration to a key
/// that describes the precise image to load.
///
/// The type of the key is determined by the subclass. It is a value that
/// unambiguously identifies the image (_including its scale_) that the [load]
/// method will fetch. Different [ImageProvider]s given the same constructor
/// arguments and [ImageConfiguration] objects should return keys that are
/// '==' to each other (possibly by using a class for the key that itself
/// implements [==]).
/// </Summary>
public virtual Future<T> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
{
    return default(Future<T>);
}


/// <Summary>
/// Converts a key into an [ImageStreamCompleter], and begins fetching the
/// image.
///
/// The [decode] callback provides the logic to obtain the codec for the
/// image.
///
/// See also:
///
///  * [ResizeImage], for modifying the key to account for cache dimensions.
/// </Summary>
public virtual FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(T key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
{
    return default(ImageStreamCompleter);
}


}


/// <Summary>
/// Key for the image obtained by an [AssetImage] or [ExactAssetImage].
///
/// This is used to identify the precise resource in the [imageCache].
/// </Summary>
public class AssetBundleImageKey
{
    /// <Summary>
    /// Creates the key for an [AssetImage] or [AssetBundleImageProvider].
    ///
    /// The arguments must not be null.
    /// </Summary>
    public AssetBundleImageKey(FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), string name = default(string), double scale = default(double))
    : base()
    {
        this.Bundle = bundle;
        this.Name = name;
        this.Scale = scale;
    }
    /// <Summary>
    /// The bundle from which the image will be obtained.
    ///
    /// The image is obtained by calling [AssetBundle.load] on the given [bundle]
    /// using the key given by [name].
    /// </Summary>
    public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
    /// <Summary>
    /// The key to use to obtain the resource from the [bundle]. This is the
    /// argument passed to [AssetBundle.load].
    /// </Summary>
    public virtual string Name { get; set; }
    /// <Summary>
    /// The scale to place in the [ImageInfo] object of the image.
    /// </Summary>
    public virtual double Scale { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is AssetBundleImageKey && other.Bundle == Bundle && other.Name == Name && other.Scale == Scale;
    }




}


/// <Summary>
/// A subclass of [ImageProvider] that knows about [AssetBundle]s.
///
/// This factors out the common logic of [AssetBundle]-based [ImageProvider]
/// classes, simplifying what subclasses must implement to just [obtainKey].
/// </Summary>
public class AssetBundleImageProvider : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.AssetBundleImageKey>
{
    /// <Summary>
    /// Abstract const constructor. This constructor enables subclasses to provide
    /// const constructors so that they can be used in const expressions.
    /// </Summary>
    public AssetBundleImageProvider()
    {

    }

    /// <Summary>
    /// Converts a key into an [ImageStreamCompleter], and begins fetching the
    /// image using [loadAsync].
    /// </Summary>
    public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        InformationCollector collector = default(InformationCollector);

        return new MultiFrameImageStreamCompleter(codec: _LoadAsync(key, decode), scale: key.Scale, informationCollector: collector);
    }




    /// <Summary>
    /// Fetches the image from the asset bundle, decodes it, and returns a
    /// corresponding [ImageInfo] object.
    ///
    /// This function is used by [load].
    /// </Summary>
    private async Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.AssetBundleImageKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        ByteData data = default(ByteData);
        try
        {
            data = await key.Bundle.Load(key.Name);
        }
on FlutterError{
            BindingDefaultClass.PaintingBinding.Instance.ImageCache.Evict(key);
            throw;
        }

        if (data == null)
        {
            BindingDefaultClass.PaintingBinding.Instance.ImageCache.Evict(key);
            throw new StateError("Unable to read data");
        }

        return await decode(data.Buffer.AsUint8List());
    }



}


public class _SizeAwareCacheKey
{
    public _SizeAwareCacheKey(@Object providerCacheKey, int width, int height)
    {
        this.ProviderCacheKey = providerCacheKey;
        this.Width = width;
        this.Height = height;
    }
    public virtual @Object ProviderCacheKey { get; set; }
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is _SizeAwareCacheKey && other.ProviderCacheKey == ProviderCacheKey && other.Width == Width && other.Height == Height;
    }



}


/// <Summary>
/// Instructs Flutter to decode the image at the specified dimensions
/// instead of at its native size.
///
/// This allows finer control of the size of the image in [ImageCache] and is
/// generally used to reduce the memory footprint of [ImageCache].
///
/// The decoded image may still be displayed at sizes other than the
/// cached size provided here.
/// </Summary>
public class ResizeImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey>
{
    /// <Summary>
    /// Creates an ImageProvider that decodes the image to the specified size.
    ///
    /// The cached image will be directly decoded and stored at the resolution
    /// defined by `width` and `height`. The image will lose detail and
    /// use less memory if resized to a size smaller than the native size.
    /// </Summary>
    public ResizeImage(FlutterSDK.Painting.Imageprovider.ImageProvider<object> imageProvider, int width = default(int), int height = default(int))
    : base()
    {
        this.ImageProvider = imageProvider;
        this.Width = width;
        this.Height = height;
    }
    /// <Summary>
    /// The [ImageProvider] that this class wraps.
    /// </Summary>
    public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ImageProvider { get; set; }
    /// <Summary>
    /// The width the image should decode to and cache.
    /// </Summary>
    public virtual int Width { get; set; }
    /// <Summary>
    /// The height the image should decode to and cache.
    /// </Summary>
    public virtual int Height { get; set; }

    /// <Summary>
    /// Composes the `provider` in a [ResizeImage] only when `cacheWidth` and
    /// `cacheHeight` are not both null.
    ///
    /// When `cacheWidth` and `cacheHeight` are both null, this will return the
    /// `provider` directly.
    /// </Summary>
    public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ResizeIfNeeded(int cacheWidth, int cacheHeight, FlutterSDK.Painting.Imageprovider.ImageProvider<object> provider)
    {
        if (cacheWidth != null || cacheHeight != null)
        {
            return new ResizeImage(provider, width: cacheWidth, height: cacheHeight);
        }

        return provider;
    }




    public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        DecoderCallback decodeResize = (Uint8List bytes, {
            int cacheWidthint cacheHeigh) => {

                return decode(bytes, cacheWidth: Width, cacheHeight: Height);
            }
        ;
            return ImageProvider.Load(key.ProviderCacheKey, decodeResize);
        }




public new Future<FlutterSDK.Painting.Imageprovider._SizeAwareCacheKey> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
    {
        Completer<_SizeAwareCacheKey> completer = default(Completer<_SizeAwareCacheKey>);
        SynchronousFuture<_SizeAwareCacheKey> result = default(SynchronousFuture<_SizeAwareCacheKey>);
        ImageProvider.ObtainKey(configuration).Then((object key) =>
        {
            if (completer == null)
            {
                result = new SynchronousFuture<_SizeAwareCacheKey>(new _SizeAwareCacheKey(key, Width, Height));
            }
            else
            {
                completer.Complete(new _SizeAwareCacheKey(key, Width, Height));
            }

        }
        );
        if (result != null)
        {
            return result;
        }

        completer = Completer.CreateNew<_SizeAwareCacheKey>();
        return completer.Future;
    }



}


/// <Summary>
/// Fetches the given URL from the network, associating it with the given scale.
///
/// The image will be cached regardless of cache headers from the server.
///
/// When a network image is used on the Web platform, the [cacheWidth] and
/// [cacheHeight] parameters of the [DecoderCallback] are ignored as the Web
/// engine delegates image decoding of network images to the Web, which does
/// not support custom decode sizes.
///
/// See also:
///
///  * [Image.network] for a shorthand of an [Image] widget backed by [NetworkImage].
/// </Summary>
public class NetworkImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.NetworkImage>
{
    /// <Summary>
    /// Creates an object that fetches the image at the given URL.
    ///
    /// The arguments [url] and [scale] must not be null.
    /// </Summary>
    public static NetworkImage CreateNew(string url, double scale = default(double), Dictionary<string, string> headers = default(Dictionary<string, string>))
    {

    }
    public virtual string Url { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double Scale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual Dictionary<string, string> Headers { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.NetworkImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        return default(ImageStreamCompleter);
    }

}


/// <Summary>
/// Decodes the given [File] object as an image, associating it with the given
/// scale.
///
/// See also:
///
///  * [Image.file] for a shorthand of an [Image] widget backed by [FileImage].
/// </Summary>
public class FileImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.FileImage>
{
    /// <Summary>
    /// Creates an object that decodes a [File] as an image.
    ///
    /// The arguments must not be null.
    /// </Summary>
    public FileImage(File file, double scale = 1.0)
    : base()
    {
        this.File = file;
        this.Scale = scale;
    }
    /// <Summary>
    /// The file to decode into an image.
    /// </Summary>
    public virtual File File { get; set; }
    /// <Summary>
    /// The scale to place in the [ImageInfo] object of the image.
    /// </Summary>
    public virtual double Scale { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new Future<FlutterSDK.Painting.Imageprovider.FileImage> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
    {
        return new SynchronousFuture<FileImage>(this);
    }




    public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.FileImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        return new MultiFrameImageStreamCompleter(codec: _LoadAsync(key, decode), scale: key.Scale, informationCollector: () =>
        {
            yield return new ErrorDescription($"'Path: {File?.Path}'");
        }
        );
    }




    private async Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.FileImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {

        Uint8List bytes = await File.ReadAsBytes();
        if (bytes.LengthInBytes == 0)
        {
            BindingDefaultClass.PaintingBinding.Instance.ImageCache.Evict(key);
            throw new StateError($"'{File} is empty and cannot be loaded as an image.'");
        }

        return await decode(bytes);
    }




    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is FileImage && other.File?.Path == File?.Path && other.Scale == Scale;
    }




}


/// <Summary>
/// Decodes the given [Uint8List] buffer as an image, associating it with the
/// given scale.
///
/// The provided [bytes] buffer should not be changed after it is provided
/// to a [MemoryImage]. To provide an [ImageStream] that represents an image
/// that changes over time, consider creating a new subclass of [ImageProvider]
/// whose [load] method returns a subclass of [ImageStreamCompleter] that can
/// handle providing multiple images.
///
/// See also:
///
///  * [Image.memory] for a shorthand of an [Image] widget backed by [MemoryImage].
/// </Summary>
public class MemoryImage : FlutterSDK.Painting.Imageprovider.ImageProvider<FlutterSDK.Painting.Imageprovider.MemoryImage>
{
    /// <Summary>
    /// Creates an object that decodes a [Uint8List] buffer as an image.
    ///
    /// The arguments must not be null.
    /// </Summary>
    public MemoryImage(Uint8List bytes, double scale = 1.0)
    : base()
    {
        this.Bytes = bytes;
        this.Scale = scale;
    }
    /// <Summary>
    /// The bytes to decode into an image.
    /// </Summary>
    public virtual Uint8List Bytes { get; set; }
    /// <Summary>
    /// The scale to place in the [ImageInfo] object of the image.
    /// </Summary>
    public virtual double Scale { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new Future<FlutterSDK.Painting.Imageprovider.MemoryImage> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
    {
        return new SynchronousFuture<MemoryImage>(this);
    }




    public new FlutterSDK.Painting.Imagestream.ImageStreamCompleter Load(FlutterSDK.Painting.Imageprovider.MemoryImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {
        return new MultiFrameImageStreamCompleter(codec: _LoadAsync(key, decode), scale: key.Scale);
    }




    private Future<SKCodec> _LoadAsync(FlutterSDK.Painting.Imageprovider.MemoryImage key, FlutterSDK.Painting.Imageprovider.DecoderCallback decode)
    {

        return decode(Bytes);
    }




    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is MemoryImage && other.Bytes == Bytes && other.Scale == Scale;
    }




}


/// <Summary>
/// Fetches an image from an [AssetBundle], associating it with the given scale.
///
/// This implementation requires an explicit final [assetName] and [scale] on
/// construction, and ignores the device pixel ratio and size in the
/// configuration passed into [resolve]. For a resolution-aware variant that
/// uses the configuration to pick an appropriate image based on the device
/// pixel ratio and size, see [AssetImage].
///
/// ## Fetching assets
///
/// When fetching an image provided by the app itself, use the [assetName]
/// argument to name the asset to choose. For instance, consider a directory
/// `icons` with an image `heart.png`. First, the [pubspec.yaml] of the project
/// should specify its assets in the `flutter` section:
///
/// ```yaml
/// flutter:
///   assets:
///     - icons/heart.png
/// ```
///
/// Then, to fetch the image and associate it with scale `1.5`, use
///
/// ```dart
/// AssetImage('icons/heart.png', scale: 1.5)
/// ```
///
/// ## Assets in packages
///
/// To fetch an asset from a package, the [package] argument must be provided.
/// For instance, suppose the structure above is inside a package called
/// `my_icons`. Then to fetch the image, use:
///
/// ```dart
/// AssetImage('icons/heart.png', scale: 1.5, package: 'my_icons')
/// ```
///
/// Assets used by the package itself should also be fetched using the [package]
/// argument as above.
///
/// If the desired asset is specified in the `pubspec.yaml` of the package, it
/// is bundled automatically with the app. In particular, assets used by the
/// package itself must be specified in its `pubspec.yaml`.
///
/// A package can also choose to have assets in its 'lib/' folder that are not
/// specified in its `pubspec.yaml`. In this case for those images to be
/// bundled, the app has to specify which ones to include. For instance a
/// package named `fancy_backgrounds` could have:
///
/// ```
/// lib/backgrounds/background1.png
/// lib/backgrounds/background2.png
/// lib/backgrounds/background3.png
/// ```
///
/// To include, say the first image, the `pubspec.yaml` of the app should specify
/// it in the `assets` section:
///
/// ```yaml
///   assets:
///     - packages/fancy_backgrounds/backgrounds/background1.png
/// ```
///
/// The `lib/` is implied, so it should not be included in the asset path.
///
/// See also:
///
///  * [Image.asset] for a shorthand of an [Image] widget backed by
///    [ExactAssetImage] when using a scale.
/// </Summary>
public class ExactAssetImage : FlutterSDK.Painting.Imageprovider.AssetBundleImageProvider
{
    /// <Summary>
    /// Creates an object that fetches the given image from an asset bundle.
    ///
    /// The [assetName] and [scale] arguments must not be null. The [scale] arguments
    /// defaults to 1.0. The [bundle] argument may be null, in which case the
    /// bundle provided in the [ImageConfiguration] passed to the [resolve] call
    /// will be used instead.
    ///
    /// The [package] argument must be non-null when fetching an asset that is
    /// included in a package. See the documentation for the [ExactAssetImage] class
    /// itself for details.
    /// </Summary>
    public ExactAssetImage(string assetName, double scale = 1.0, FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), string package = default(string))
    : base()
    {
        this.AssetName = assetName;
        this.Scale = scale;
        this.Bundle = bundle;
        this.Package = package;
    }
    /// <Summary>
    /// The name of the asset.
    /// </Summary>
    public virtual string AssetName { get; set; }
    /// <Summary>
    /// The scale to place in the [ImageInfo] object of the image.
    /// </Summary>
    public virtual double Scale { get; set; }
    /// <Summary>
    /// The bundle from which the image will be obtained.
    ///
    /// If the provided [bundle] is null, the bundle provided in the
    /// [ImageConfiguration] passed to the [resolve] call will be used instead. If
    /// that is also null, the [rootBundle] is used.
    ///
    /// The image is obtained by calling [AssetBundle.load] on the given [bundle]
    /// using the key given by [keyName].
    /// </Summary>
    public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
    /// <Summary>
    /// The name of the package from which the image is included. See the
    /// documentation for the [ExactAssetImage] class itself for details.
    /// </Summary>
    public virtual string Package { get; set; }
    public virtual string KeyName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new Future<FlutterSDK.Painting.Imageprovider.AssetBundleImageKey> ObtainKey(FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
    {
        return new SynchronousFuture<AssetBundleImageKey>(new AssetBundleImageKey(bundle: Bundle ?? configuration.Bundle ?? AssetbundleDefaultClass.RootBundle, name: KeyName, scale: Scale));
    }




    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is ExactAssetImage && other.KeyName == KeyName && other.Scale == Scale && other.Bundle == Bundle;
    }




}


public class _ErrorImageCompleter : FlutterSDK.Painting.Imagestream.ImageStreamCompleter
{
    public _ErrorImageCompleter()
    {

    }

    public virtual void SetError(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), object exception = default(object), StackTrace stack = default(StackTrace), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
    {
        ReportError(context: context, exception: exception, stack: stack, informationCollector: informationCollector, silent: silent);
    }



}


/// <Summary>
/// The exception thrown when the HTTP request to load a network image fails.
/// </Summary>
public class NetworkImageLoadException : IException
{
    /// <Summary>
    /// Creates a [NetworkImageLoadException] with the specified http status
    /// [code] and the [uri]
    /// </Summary>
    public NetworkImageLoadException(int statusCode = default(int), Uri uri = default(Uri))
    : base()
    {
        this.StatusCode = statusCode;
        this.Uri = uri;
    }
    /// <Summary>
    /// The HTTP status code from the server.
    /// </Summary>
    public virtual int StatusCode { get; set; }
    /// <Summary>
    /// A human-readable error message.
    /// </Summary>
    internal virtual string _Message { get; set; }
    /// <Summary>
    /// Resolved URL of the requested image.
    /// </Summary>
    public virtual Uri Uri { get; set; }

}

}
