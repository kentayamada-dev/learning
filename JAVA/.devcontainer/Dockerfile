FROM mcr.microsoft.com/devcontainers/java:17-bullseye

ENV TZ=Asia/Tokyo \
    SHELL=/bin/zsh

ARG WORKSPACE_PATH
ARG HOME="/home/vscode"
ARG CLONE="git clone --depth 1 --"
ARG APT="apt-get"
ARG UPDATE="${APT} update"
ARG INSTALL="${APT} -y install --no-install-recommends"

RUN rm $HOME/.zshrc && ln -s $WORKSPACE_PATH/.devcontainer/.zshrc $HOME/.zshrc \
  && $CLONE https://github.com/z-shell/F-Sy-H $HOME/fsh && $CLONE https://github.com/olets/zsh-abbr $HOME/abbr \
  && $UPDATE && $INSTALL exa fd-find fzf bat
