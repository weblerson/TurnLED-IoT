import 'package:firebase_database/firebase_database.dart';
import 'data.dart';

class LedController {
  String path = "ESP32/Valor";
  static var instance = LedController();

  void turnOn() async {
    FirebaseDatabase db = FirebaseDatabase.instance;
    DatabaseReference ref = db.ref(path);

    await ref.update(LEDState(StateJSON.toJSON(true)).data);
  }

  void turnOff() async {
    FirebaseDatabase db = FirebaseDatabase.instance;
    DatabaseReference ref = db.ref(path);

    await ref.update(LEDState(StateJSON.toJSON(false)).data);
  }
}