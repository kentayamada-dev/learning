FROM mcr.microsoft.com/devcontainers/java:1-17-bookworm

ENV TZ=Asia/Tokyo \
    SHELL=/bin/zsh

ARG WORKSPACE_PATH="/workspaces/JAVA"
ARG HOME="/home/vscode"
ARG CLONE="git clone --depth 1 --"
ARG APT="apt-get"
ARG UPDATE="${APT} update"
ARG INSTALL="${APT} -y install --no-install-recommends"

RUN rm $HOME/.zshrc && ln -s $WORKSPACE_PATH/.devcontainer/.zshrc $HOME/.zshrc \
  && $CLONE https://github.com/z-shell/F-Sy-H $HOME/fsh && $CLONE https://github.com/olets/zsh-abbr $HOME/abbr \
  && $UPDATE && $INSTALL exa fd-find fzf bat

RUN su vscode -c "umask 0002 && . /usr/local/sdkman/bin/sdkman-init.sh && sdk install gradle 8.2.1"
