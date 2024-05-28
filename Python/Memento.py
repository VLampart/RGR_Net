"""
Memento pattern example.
"""
class Originator:
    _state = ""

    def set(self, state: str) -> None:
        print(f"Originator: Setting state to {state}")
        self._state = state

    def save_to_memento(self) -> "Memento":
        return self.Memento(self._state)

    def restore_from_memento(self, m: "Memento") -> None:
        self._state = m.get_saved_state()
        print(f"Originator: State after restoring from Memento: {self._state}")

    class Memento:

        def __init__(self, state):
            self._state = state

        def get_saved_state(self):
            return self._state


saved_states = []
originator = Originator()
originator.set("State1")
originator.set("State2")
saved_states.append(originator.save_to_memento())

originator.set("State3")
saved_states.append(originator.save_to_memento())

originator.set("State4")
