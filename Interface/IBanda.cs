﻿namespace SoundTrack.Interface;

public interface IBanda
{
    void ExibirDetalhes();

    void AddNota(int nota);

    int CalcularMedia(List<int> nota);
}