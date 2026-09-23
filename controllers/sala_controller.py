from models.sala import Sala, SalaRepository
from views.sala_view import SalaView


class SalaController:
    def __init__(self):
        self.repository = SalaRepository()
        self.view = SalaView()

    def iniciar(self):
        self.repository.agregar(Sala("Sala principal", 20))
        self.view.mostrar_salas(self.repository.listar())
