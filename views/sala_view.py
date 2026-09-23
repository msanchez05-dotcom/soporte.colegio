class SalaView:
    def mostrar_salas(self, salas):
        if not salas:
            print("No hay salas registradas.")
            return

        for sala in salas:
            print(f"- {sala.nombre} ({sala.capacidad} personas)")
