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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Iconbutton
{
    internal static class IconbuttonDefaultClass
    {
        public static double _KMinButtonSize = default(double);
    }

    /// <Summary>
    /// A material design icon button.
    ///
    /// An icon button is a picture printed on a [Material] widget that reacts to
    /// touches by filling with color (ink).
    ///
    /// Icon buttons are commonly used in the [AppBar.actions] field, but they can
    /// be used in many other places as well.
    ///
    /// If the [onPressed] callback is null, then the button will be disabled and
    /// will not react to touch.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// The hit region of an icon button will, if possible, be at least
    /// kMinInteractiveDimension pixels in size, regardless of the actual
    /// [iconSize], to satisfy the [touch target size](https://material.io/guidelines/layout/metrics-keylines.html#metrics-keylines-touch-target-size)
    /// requirements in the Material Design specification. The [alignment] controls
    /// how the icon itself is positioned within the hit region.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// This sample shows an `IconButton` that uses the Material icon "volume_up" to
    /// increase the volume.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/icon_button.png)
    ///
    /// ```dart preamble
    /// double _volume = 0.0;
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Column(
    ///     mainAxisSize: MainAxisSize.min,
    ///     children: <Widget>[
    ///       IconButton(
    ///         icon: Icon(Icons.volume_up),
    ///         tooltip: 'Increase volume by 10',
    ///         onPressed: () {
    ///           setState(() {
    ///             _volume += 10;
    ///           });
    ///         },
    ///       ),
    ///       Text('Volume : $_volume')
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// ### Adding a filled background
    ///
    /// Icon buttons don't support specifying a background color or other
    /// background decoration because typically the icon is just displayed
    /// on top of the parent widget's background. Icon buttons that appear
    /// in [AppBar.actions] are an example of this.
    ///
    /// It's easy enough to create an icon button with a filled background
    /// using the [Ink] widget. The [Ink] widget renders a decoration on
    /// the underlying [Material] along with the splash and highlight
    /// [InkResponse] contributed by descendant widgets.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// In this sample the icon button's background color is defined with an [Ink]
    /// widget whose child is an [IconButton]. The icon button's filled background
    /// is a light shade of blue, it's a filled circle, and it's as big as the
    /// button is.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/icon_button_background.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Material(
    ///     color: Colors.white,
    ///     child: Center(
    ///       child: Ink(
    ///         decoration: const ShapeDecoration(
    ///           color: Colors.lightBlue,
    ///           shape: CircleBorder(),
    ///         ),
    ///         child: IconButton(
    ///           icon: Icon(Icons.android),
    ///           color: Colors.white,
    ///           onPressed: () {},
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Icons], a library of predefined icons.
    ///  * [BackButton], an icon button for a "back" affordance which adapts to the
    ///    current platform's conventions.
    ///  * [CloseButton], an icon button for closing pages.
    ///  * [AppBar], to show a toolbar at the top of an application.
    ///  * [RaisedButton] and [FlatButton], for buttons with text in them.
    ///  * [InkResponse] and [InkWell], for the ink splash effect itself.
    /// </Summary>
    public class IconButton : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an icon button.
        ///
        /// Icon buttons are commonly used in the [AppBar.actions] field, but they can
        /// be used in many other places as well.
        ///
        /// Requires one of its ancestors to be a [Material] widget.
        ///
        /// The [iconSize], [padding], [autofocus], and [alignment] arguments must not
        /// be null (though they each have default values).
        ///
        /// The [icon] argument must be specified, and is typically either an [Icon]
        /// or an [ImageIcon].
        /// </Summary>
        public IconButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double iconSize = 24.0, FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, string tooltip = default(string), bool enableFeedback = true, FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints))
        : base(key: key)
        {
            this.IconSize = iconSize;
            this.VisualDensity = visualDensity;
            this.Padding = padding;
            this.Alignment = alignment;
            this.Icon = icon;
            this.Color = color;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.HighlightColor = highlightColor;
            this.SplashColor = splashColor;
            this.DisabledColor = disabledColor;
            this.OnPressed = onPressed;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.Tooltip = tooltip;
            this.EnableFeedback = enableFeedback;
            this.Constraints = constraints;
        }
        /// <Summary>
        /// The size of the icon inside the button.
        ///
        /// This property must not be null. It defaults to 24.0.
        ///
        /// The size given here is passed down to the widget in the [icon] property
        /// via an [IconTheme]. Setting the size here instead of in, for example, the
        /// [Icon.size] property allows the [IconButton] to size the splash area to
        /// fit the [Icon]. If you were to set the size of the [Icon] using
        /// [Icon.size] instead, then the [IconButton] would default to 24.0 and then
        /// the [Icon] itself would likely get clipped.
        /// </Summary>
        public virtual double IconSize { get; set; }
        /// <Summary>
        /// Defines how compact the icon button's layout will be.
        ///
        /// {@macro flutter.material.themedata.visualDensity}
        ///
        /// See also:
        ///
        ///  * [ThemeData.visualDensity], which specifies the [density] for all widgets
        ///    within a [Theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        /// <Summary>
        /// The padding around the button's icon. The entire padded icon will react
        /// to input gestures.
        ///
        /// This property must not be null. It defaults to 8.0 padding on all sides.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// Defines how the icon is positioned within the IconButton.
        ///
        /// This property must not be null. It defaults to [Alignment.center].
        ///
        /// See also:
        ///
        ///  * [Alignment], a class with convenient constants typically used to
        ///    specify an [AlignmentGeometry].
        ///  * [AlignmentDirectional], like [Alignment] for specifying alignments
        ///    relative to text direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        /// <Summary>
        /// The icon to display inside the button.
        ///
        /// The [Icon.size] and [Icon.color] of the icon is configured automatically
        /// based on the [iconSize] and [color] properties of _this_ widget using an
        /// [IconTheme] and therefore should not be explicitly given in the icon
        /// widget.
        ///
        /// This property must not be null.
        ///
        /// See [Icon], [ImageIcon].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        /// <Summary>
        /// The color for the button's icon when it has the input focus.
        ///
        /// Defaults to [ThemeData.focusColor] of the ambient theme.
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The color for the button's icon when a pointer is hovering over it.
        ///
        /// Defaults to [ThemeData.hoverColor] of the ambient theme.
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// The color to use for the icon inside the button, if the icon is enabled.
        /// Defaults to leaving this up to the [icon] widget.
        ///
        /// The icon is enabled if [onPressed] is not null.
        ///
        /// ```dart
        /// IconButton(
        ///   color: Colors.blue,
        ///   onPressed: _handleTap,
        ///   icon: Icons.widgets,
        /// )
        /// ```
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The primary color of the button when the button is in the down (pressed) state.
        /// The splash is represented as a circular overlay that appears above the
        /// [highlightColor] overlay. The splash overlay has a center point that matches
        /// the hit point of the user touch event. The splash overlay will expand to
        /// fill the button area if the touch is held for long enough time. If the splash
        /// color has transparency then the highlight and button color will show through.
        ///
        /// Defaults to the Theme's splash color, [ThemeData.splashColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        /// <Summary>
        /// The secondary color of the button when the button is in the down (pressed)
        /// state. The highlight color is represented as a solid color that is overlaid over the
        /// button color (if any). If the highlight color has transparency, the button color
        /// will show through. The highlight fades in quickly as the button is held down.
        ///
        /// Defaults to the Theme's highlight color, [ThemeData.highlightColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
        /// <Summary>
        /// The color to use for the icon inside the button, if the icon is disabled.
        /// Defaults to the [ThemeData.disabledColor] of the current [Theme].
        ///
        /// The icon is disabled if [onPressed] is null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        /// <Summary>
        /// The callback that is called when the button is tapped or otherwise activated.
        ///
        /// If this is set to null, the button will be disabled.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.focusNode}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// Text that describes the action that will occur when the button is pressed.
        ///
        /// This text is displayed when the user long-presses on the button and is
        /// used for accessibility.
        /// </Summary>
        public virtual string Tooltip { get; set; }
        /// <Summary>
        /// Whether detected gestures should provide acoustic and/or haptic feedback.
        ///
        /// For example, on Android a tap will produce a clicking sound and a
        /// long-press will produce a short vibration, when feedback is enabled.
        ///
        /// See also:
        ///
        ///  * [Feedback] for providing platform-specific feedback to certain actions.
        /// </Summary>
        public virtual bool EnableFeedback { get; set; }
        /// <Summary>
        /// Optional size constraints for the button.
        ///
        /// When unspecified, defaults to:
        /// ```dart
        /// const BoxConstraints(
        ///   minWidth: kMinInteractiveDimension,
        ///   minHeight: kMinInteractiveDimension,
        /// )
        /// ```
        /// where [kMinInteractiveDimension] is 48.0, and then with visual density
        /// applied.
        ///
        /// The default constraints ensure that the button is accessible.
        /// Specifying this parameter enables creation of buttons smaller than
        /// the minimum size, but it is not recommended.
        ///
        /// The visual density uses the [visualDensity] parameter if specified,
        /// and `Theme.of(context).visualDensity` otherwise.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            Color currentColor = default(Color);
            if (OnPressed != null) currentColor = Color; else currentColor = DisabledColor ?? theme.DisabledColor;
            VisualDensity effectiveVisualDensity = VisualDensity ?? theme.VisualDensity;
            BoxConstraints unadjustedConstraints = Constraints ?? new BoxConstraints(minWidth: IconbuttonDefaultClass._KMinButtonSize, minHeight: IconbuttonDefaultClass._KMinButtonSize);
            BoxConstraints adjustedConstraints = effectiveVisualDensity.EffectiveConstraints(unadjustedConstraints);
            Widget result = new ConstrainedBox(constraints: adjustedConstraints, child: new Padding(padding: Padding, child: new SizedBox(height: IconSize, width: IconSize, child: new Align(alignment: Alignment, child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(size: IconSize, color: currentColor), child: Icon)))));
            if (Tooltip != null)
            {
                result = new Tooltip(message: Tooltip, child: result);
            }

            return new Semantics(button: true, enabled: OnPressed != null, child: new InkResponse(focusNode: FocusNode, autofocus: Autofocus, canRequestFocus: OnPressed != null, onTap: OnPressed, enableFeedback: EnableFeedback, child: result, focusColor: FocusColor ?? ThemeDefaultClass.Theme.Of(context).FocusColor, hoverColor: HoverColor ?? ThemeDefaultClass.Theme.Of(context).HoverColor, highlightColor: HighlightColor ?? ThemeDefaultClass.Theme.Of(context).HighlightColor, splashColor: SplashColor ?? ThemeDefaultClass.Theme.Of(context).SplashColor, radius: Dart.Math.MathDefaultClass.Max(MaterialDefaultClass.Material.DefaultSplashRadius, (IconSize + Dart.Math.MathDefaultClass.Min(Padding.Horizontal, Padding.Vertical)) * 0.7)));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Widget>("icon", Icon, showName: false));
            properties.Add(new StringProperty("tooltip", Tooltip, defaultValue: null, quoted: false));
            properties.Add(new ObjectFlagProperty<VoidCallback>("onPressed", OnPressed, ifNull: "disabled"));
            properties.Add(new ColorProperty("color", Color, defaultValue: null));
            properties.Add(new ColorProperty("disabledColor", DisabledColor, defaultValue: null));
            properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: null));
            properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: null));
            properties.Add(new ColorProperty("highlightColor", HighlightColor, defaultValue: null));
            properties.Add(new ColorProperty("splashColor", SplashColor, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
        }



    }

}
