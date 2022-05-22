class LEDState {
  final Map<String, bool> data;
  LEDState(this.data);
}

class StateJSON {
  static Map<String, bool> toJSON(bool st) {
    var json = {
      "Valor": st
    };
    
    return json;
  }
}