class Sala:
    def __init__(self, nombre, capacidad):
        self.nombre = nombre
        self.capacidad = capacidad


class SalaRepository:
    def __init__(self):
        self._salas = []

    def agregar(self, sala):
        self._salas.append(sala)

    def listar(self):
        return list(self._salas)
