## Unreleased

### Removed
- Removida a geração de PDF baseada em `NReco.PdfGenerator`; consumidores devem converter o HTML renderizado com seu mecanismo multiplataforma.

## [0.1.7] - 2026-01-12

### Added
- Atualizando o schema da NFSe para a implementação disponível no ambiente nacional no dia 16/12/25. Obrigado a @Threads-creator
- Preenchendo CPF onde poderia ser preenchido (tomador, prestador e afins). Obrigado a @Threads-creator
- Preenchendo totalizadores de impostos federais no DANFSe e demais campos não preenchidos originalmente. Obrigado a @Threads-creator
- Ajustado negrito no layout. Obrigado a @ludero

## [0.1.5] - 2026-01-08

### Bugfix
- Exibição correta para casos de NFSe Canceladas

## [0.1.4] - 2026-01-07

### Added
- Opção para imprimir a DANFE com a tarja de Cancelada
- Inserido a logo de dados de Agudos, SP. Obrigado a @ludero
- Melhora no layout da DANFE. Obrigado a @ludero
- Melhorado e complementado o readme incluindo informações de como gerar a Tarja de Cancelada e as logos dos municípios

## [0.1.0] - 2025-12-15

### Added
- Geração de DANFSe a partir de XML NFSe Nacional
- Renderização HTML desacoplada
- Geração de PDF
- Warnings padronizados
- Golden tests de HTML
