import 'package:analyzer/dart/ast/ast.dart';
import 'implementation.dart';

class Literals {
  static String processNullLiteral(NullLiteral literal) {
    var csharp = "";
    for (var entity in literal.childEntities) {
      csharp += Implementation.processEntity(entity);
    }
    return csharp;
  }

  static String processDoubleLiteral(DoubleLiteral literal) {
    var csharp = "";
    for (var entity in literal.childEntities) {
      csharp += Implementation.processEntity(entity);
    }
    return csharp;
  }

  static String processBooleanLiteral(BooleanLiteral literal) {
    var csharp = "";
    for (var entity in literal.childEntities) {
      csharp += Implementation.processEntity(entity);
    }
    return csharp;
  }

  static String processIntegerLiteral(IntegerLiteral literal) {
    var csharp = "";
    for (var entity in literal.childEntities) {
      csharp += Implementation.processEntity(entity);
    }
    return csharp;
  }

  static String processMapLiteral(MapLiteral literal) {
    var csharp = "new Dictionary";
    for (var entity in literal.childEntities) {
      csharp += Implementation.processEntity(entity);
    }
    return csharp;
  }

  static String processMapLiteralEntry(MapLiteralEntry entry) {
    var csharp = "";
    for (var entity in entry.childEntities) {
      if (entity.toString() == ':')
        csharp += ', ';
      else
        csharp += Implementation.processEntity(entity);
    }
    return '{' + csharp + '}';
  }

  static String processSimpleStringLiteral(SimpleStringLiteral literal) {
    var stringValue = literal.toString();

    stringValue = stringValue.substring(1, stringValue.length - 1);

    if (stringValue.length == 1 ||
        (stringValue.startsWith('\\') && stringValue.length == 2))
      return "'$stringValue'";
    else
      return '"$stringValue"';
  }

  static String processListLiteral(ListLiteral literal) {
    var csharp = 'new List';
    var args = false;
    bool commentNextEntity = false;

    for (var entity in literal.childEntities) {
      if (entity.toString() == '[')
        csharp += '{';
      else if (entity.toString() == ']') {
        var length = args == true ? 2 : 0;
        csharp = csharp.substring(0, csharp.length - length) + '}';
      } else if (entity is TypeArgumentList) {
        csharp += Implementation.processEntity(entity) + '()';
      } else if (entity.toString() != 'const') {
        String entityStr = Implementation.processEntity(entity);
        if (entityStr.length > 0) {
          if (commentNextEntity) {
            commentNextEntity = false;
            csharp += ' /* ...' + entityStr + (args ? ' */, ' : ', */ ');
          } else {
            csharp += entityStr + ', ';
            args = true;
          }
        } else {
          if (entity is SimpleIdentifier) {
            print(
                'ERROR: dart code is using a spread operator in a list initializer, but this is not yet supported');
            commentNextEntity = true;
          }
        }
      }
    }
    return csharp;
  }
}
